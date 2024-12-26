using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_ApplicationCore.Domaine
{
    public class Produit
    {
        [DataType(DataType.Date,ErrorMessage="Invalide")]
        public DateTime DateProd { get; set; }
        public string MyPDestinationroperty { get; set; }
        public string Nom { get; set; }
        public float Price { get; set; }
        public int ProductId { get; set; }

        public virtual IList <Fournisseur> Fournisseurs { get; set; }

        public int CategorieFk { get; set; } ///en utilisant l'annotation
        [ForeignKey("CategorieFk")]
        public virtual Categorie Categorie { get; set; }

    }
}
