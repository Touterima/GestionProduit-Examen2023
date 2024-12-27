using GP_ApplicationCore.Domaine;
using GP_ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_ApplicationCore.Services
{
    public class CategorieService : Service<Categorie>, ICategorieService
    {
        public CategorieService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
