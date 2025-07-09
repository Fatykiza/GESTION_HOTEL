using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GESTION_HOTEL
{
    internal class Chambre
    {
     int id;
     string numero;
	 string contact;
	 int refClasse;

        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Contact { get => contact; set => contact = value; }
        public int RefClasse { get => refClasse; set => refClasse = value; }
    }
}
