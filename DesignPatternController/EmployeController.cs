using DesignPatternBusiness;
using DesignPatternBusinessContract;
using DesignPatternExercice;
using System;
using System.Collections.Generic;

namespace DesignPatternController
{
    public class EmployeController 
    {
        EmployeService eS = new EmployeService();
        public EmployeController()
        {
        }
        public void AjoutEmploye(string nom, double salaire, int id)
        {
            eS.AjoutEmploye(nom, salaire, id);
        }

        public List<Employe> GiveList()
        {
            return eS.GiveList();
        }

        public Employe FindEmployeWithID(int id)
        {
            return eS.FindEmployeWithID(id);
        }

    }
}
