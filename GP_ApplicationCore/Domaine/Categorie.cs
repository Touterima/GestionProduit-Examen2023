using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_ApplicationCore.Domaine
{
    public class Categorie
    {
        public int id { get; set; }
        public string nom { get; set; }


        public virtual IList <Produit> Produits { get; set; }
    }
}
