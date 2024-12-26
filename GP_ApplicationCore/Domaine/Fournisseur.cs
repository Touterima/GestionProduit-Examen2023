using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_ApplicationCore.Domaine
{
    public class Fournisseur
    {
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        [Key]
        public int Identifiant { get; set; }
        public bool IsApproved { get; set; }
        [MinLength(3), MaxLength(12)]
        public string Nom { get; set; }

        public virtual IList <Produit> Produits { get; set; }
    }
}
