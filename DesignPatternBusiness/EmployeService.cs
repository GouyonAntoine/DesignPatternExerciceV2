using System;
using DesignPatternRepositoryContract;
using DesignPatternBusinessContract;
using DesignPatternRepository;
using DesignPatternExercice;
using System.Collections.Generic;

namespace DesignPatternBusiness
{
    public class EmployeService : IEmployeService
    {
        EmployeRepository eR = new EmployeRepository();
        public EmployeService()
        {
        }

        public void AjoutEmploye(string nom, double salaire, int id)
        {
            if(salaire < 0)
            {
                throw new Exception("Salaire négatif !");
            }
           eR.AjoutEmploye(nom, salaire, id);
        }

        public List<Employe> GiveList()
        {
            return eR.GiveList();
        }

        public Employe FindEmployeWithID(int id)
        {
            return eR.FindEmployeWithID(id);
        }
    }
}
