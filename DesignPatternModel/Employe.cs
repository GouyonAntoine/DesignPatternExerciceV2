using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExercice
{
    public class Employe
    {
        public int Id { get; set; }
        public double Salaire { get; set; }
        public string Nom { get; set; }

        public Employe(int id, string nom, double salaire)
        {
            Id = id;
            Nom = nom;
            Salaire = salaire;
        }
    }
}
