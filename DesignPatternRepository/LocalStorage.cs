using System.Collections.Generic;

namespace DesignPatternExercice
{
    public sealed class LocalStorage
    {
        private static LocalStorage instance = null;
        public List<Employe> ListeEmployes = new List<Employe> { new Employe(1, "Gouyon", 1000), new Employe(2, "Sung Jin-Woo", 7777777), new Employe(3, "Uchihua", 9999) };
        private LocalStorage() { }
        public static LocalStorage Instance
        {
            get
            {
                if (instance == null)
                    instance = new LocalStorage();
                return instance;
            }
        }
    }
}
