using DesignPatternController;
using System;
using System.Collections.Generic;

namespace DesignPatternExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans mon Application sur la découverte du DesignPatern et de l'Architecture !");
            AffichageConsole();
            var choix = GetInt("Choissiez un fonctionnalité à utilisez (0 pour quitter) ");
            Console.WriteLine("");
            var employeControler = new EmployeController();

            while (choix != 0)
            {
                switch (choix)
                {
                    case 1:
                        FindWithID(employeControler.FindEmployeWithID(GetInt("Entrez un ID a chercher")));
                        break;
                    case 2:
                        AffichageListe(employeControler.GiveList());
                        break;
                    case 3:
                        employeControler.AjoutEmploye(GetString("Entrez le nom de l'employé à ajouter "), GetInt("Entrez le salaire de l'employé à ajouter "), GetInt("Entrez l'ID de l'employé à ajouter "));
                        break;
                    default:
                        break;
                }

                AffichageConsole();
                choix = GetInt("Choissiez un fonctionnalité à utilisez (0 pour quitter) ");
                Console.WriteLine("");
            }
        }

        public static void AffichageListe(List<Employe> liste)
        {
            Console.WriteLine("Affichage de la liste des Employés de la base de donnée : ");

            foreach(var employe in liste)
            {
                Console.WriteLine(" Employé avec l'id " + employe.Id + " => Son prénom est " + employe.Nom + " et son salaire est de " + employe.Salaire);
            }
            Console.WriteLine("");
        }

        public static void AffichageConsole()
        {
            Console.WriteLine("1°) Trouver un employé grâce à son ID ");
            Console.WriteLine("2°) Afficher la liste de tous les employés de la base de données ");
            Console.WriteLine("3°) Ajouter un employé à la base de données ");
        }

        public static void FindWithID(Employe e)
        {
            if(e.Nom == "NULL")
            {
                Console.WriteLine("Aucun employé avec cet ID existe dans la BDD !");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("L'employé avec l'ID " + e.Id + " est " + e.Nom);
                Console.WriteLine("");
            }
        }

        public static string GetString(string Label = "Entrez quelque chose")
        {
            Console.WriteLine(Label);
            var input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Entrée incorrecte, veuilllez réessayer");
                input = Console.ReadLine();
            }

            return input;
        }

        public static int GetInt(string Label = "Entré une valeur au pif")
        {
            int inputNumber;
            var input = GetString(Label);

            while (!int.TryParse(input, out inputNumber))
            {
                Console.WriteLine("Entrée incorrecte, veuilllez réessayer");
                input = Console.ReadLine();
            }

            return inputNumber;
        }
    }
}
