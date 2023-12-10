using Examen.ApplicationCore.Domaine;
using Examen.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Services;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 


 namespace Examen.Infrastructure

{
    public class ServiceFete : Service<Fete>, IServiceFete
    {
        public ServiceFete(ApplicationCore.Interfaces.IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
       
    }
}
