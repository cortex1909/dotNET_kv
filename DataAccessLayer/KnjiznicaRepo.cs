using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using MySql.Data;


namespace DataAccessLayer
{
    public class KnjiznicaRepo
    {
        public List<Knjige> knjige = new List<Knjige>();
        public List<Korisnici> korisnici = new List<Korisnici>();
        public List<Posudba> posudba = new List<Posudba>();
        public List<string> spremi = new List<string>();
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        public void PousdiKnjigu(Posudba oUser)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Dakovic_Posudba (NazivKnjige, NazivKorisnika, DatumPosudjivanja, DatumVracanja) VALUES  ('" + oUser.NazivKnjige + "','" + oUser.NazivKorisnika + "','" + oUser.DatumPosudjivanja + "','" + oUser.DatumVracanja + "');";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void RazduziKnjigu(Posudba oUser)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Dakovic_Posudba WHERE Id ='" + oUser.IDPosudba + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public List<Posudba> DohvatiPosudbe()
        {
            posudba = new List<Posudba>();
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM Dakovic_Posudba";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        posudba.Add(new Posudba()
                        {
                            IDPosudba = (int)oReader["Id"],
                            NazivKnjige = (string)oReader["NazivKnjige"],
                            NazivKorisnika = (string)oReader["NazivKorisnika"],
                            DatumPosudjivanja = (string)oReader["DatumPosudjivanja"],
                            DatumVracanja = (string)oReader["DatumVracanja"]
                        }) ;
                    }
                }
            }
            return posudba;
        }
        public void SpremiKnjigeTXT()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        return;
                    }
                    string selectCommandText = "SELECT * FROM Dakovic_Posudba";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, connection))
                    {
                        using (DataTable table = new DataTable("Dakovic_Posudba"))
                        {
                            adapter.Fill(table);
                            StringBuilder commaDelimitedText = new StringBuilder();
                            commaDelimitedText.AppendLine("   ***ID POSUDBE***   ***NAZIV KNJIGE***   ***NAZIV KORISNIKA***   ***DATUM POSUDBE***   ***DATUM VRACANJA***"); 
                            foreach (DataRow row in table.Rows)
                            {
                                string value = string.Format("=> {0} | {1} | {2} | {3} | {4} <=", row[0], row[1], row[2], row[3], row[4]);
                                commaDelimitedText.AppendLine(value);
                            }
                            File.WriteAllText(@"C:/Users/Hrvoje/Desktop/DotNETKV/Knjiznica/Knjiznica/Resources/ListaPosudenihKnjiga.txt", commaDelimitedText.ToString());




                        }
                    }
                }
            }


        public List<Knjige>DohvatiKnjige(string title)
        {
            knjige = new List<Knjige>();
                    string url = "https://api.itbook.store/1.0/search/" + title;
                    string json = CallRestMethod(url);
                    var o = JObject.Parse(json);
                    foreach (JObject item in o.GetValue("books"))
                    {
                    knjige.Add(new Knjige
                        {
                            NazivKnjige = (string)item.GetValue("title"),
                            Podnaziv = (string)item.GetValue("subtitle"),
                            ISBN13 = (string)item.GetValue("isbn13"),
                            Cijena = (string)item.GetValue("price")
                        });
                    }
            return knjige;
        }

        public List<Korisnici> DohvatiKorisnike()
        {
            korisnici = new List<Korisnici>();
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM Dakovic_Korisnici";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        korisnici.Add(new Korisnici()
                        {
                            IDKorisnika = (int)oReader["Id"],
                            ImeKorisnika = (string)oReader["ImeKorisnika"],
                            PrezimeKorisnika = (string)oReader["PrezimeKorisnika"]
                        });
                    }
                }
            }
            return korisnici;
        }
        public List<string> DohvatiKorisnikeCombo()
        {
            var comboKorisnici = posudba.Select(x => x.NazivKorisnika).Distinct().ToList();
            comboKorisnici.Insert(0, "*** SVI ***");
            return comboKorisnici;
        }
        public List<Posudba> ComboFilter(string ime)
        {
            var comboKorisnici = posudba.Where(x => true);
            if (ime != "*** SVI ***")
            {
                comboKorisnici = comboKorisnici.Where(x => x.NazivKorisnika == ime);
            }
            return comboKorisnici.ToList();
        }
        public void DodajKorisnika(Korisnici oUser)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Dakovic_Korisnici (ImeKorisnika, PrezimeKorisnika) VALUES  ('" + oUser.ImeKorisnika + "','" + oUser.PrezimeKorisnika + "');";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void UpdateUsers(Korisnici oUser)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Dakovic_Korisnici SET ImeKorisnika = '" + oUser.ImeKorisnika + "', PrezimeKorisnika = '" + oUser.PrezimeKorisnika + "' WHERE Id = " + oUser.IDKorisnika;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteUsers(Korisnici oUser)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Dakovic_Korisnici WHERE Id ='" + oUser.IDKorisnika + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }


        public List<Knjige> Filter(string title)
        {
            var knjiznica = knjige.Where(x => true);
            if (!string.IsNullOrEmpty(title))
            {
                knjiznica = knjiznica.Where(x => x.NazivKnjige == title);
            }
            return knjiznica.ToList();

        }

    }
}