using GP_ApplicationCore.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_ApplicationCore.Interfaces
{
    public interface IServiceProduit
    {

        IEnumerable<Fournisseur> GetFournisseursByC(Categorie categorie);
        IEnumerable<Chimique> Get5Chimique();

        Double MoyPrix(Categorie categorie);
    }
}
