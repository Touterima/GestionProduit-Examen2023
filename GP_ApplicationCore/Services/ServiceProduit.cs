using GP_ApplicationCore.Domaine;
using GP_ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_ApplicationCore.Services
{
    public class ServiceProduit : Service<Produit>, IServiceProduit
    {
        public ServiceProduit(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        IEnumerable<Fournisseur> GetFournisseursByC(Categorie categorie)
        {
            return Categorie.Produits.SelectMany(p => p.Fournisseurs);

            //getMany yaani getAll.Where
            //return GetMany(p=>p.Categorie)).SelectMany(p => p.Fournisseurs);
        }

        IEnumerable<Chimique> Get5Chimique()
        {
            //Heritage  ==>  OfType
            return GetAll().OfType<Chimique>().OrderByDescending(p=>p.Prix).Take(5) ;
        }

        Double MoyPrix(Categorie categorie)
        {
            /*
            return GetAll().OfType<Biologique>().whare(p=>p.Categorie.Equals(Categorie))
                .Average(p=>p.Prix);
            */
            /*return GetMany(p => p.Categorie.Equals(Categorie)).OfType<Biologique>()
                .Average(p => p.Prix);
            */
            return Categorie.Produits.OfType<Biologique>().Average(p => p.Prix);
        }
    }
}
