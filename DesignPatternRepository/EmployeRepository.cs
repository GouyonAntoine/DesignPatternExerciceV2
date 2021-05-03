using DesignPatternExercice;
using DesignPatternRepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRepository
{
    public class EmployeRepository : IEmployeRepository
    {
        public void AjoutEmploye(string nom, double salaire, int id)
        {
            LocalStorage.Instance.ListeEmployes.Add(new Employe(id, nom, salaire));
        }

        public List<Employe> GiveList()
        {
            return LocalStorage.Instance.ListeEmployes;
        }

        public Employe FindEmployeWithID(int id)
        {
            foreach (var employe in LocalStorage.Instance.ListeEmployes)
            {
                if (employe.Id == id)
                {
                    return employe;
                }
            }
            return new Employe(0, "NULL", 0);
        }
    }
}
