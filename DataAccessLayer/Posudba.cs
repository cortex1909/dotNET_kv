using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Posudba
    {
        public int IDPosudba { get; set; }
        public string NazivKnjige { get; set; }
        public string NazivKorisnika { get; set; }
        public string DatumPosudjivanja { get; set; }
        public string DatumVracanja { get; set; }
    }
}
