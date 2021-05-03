using System.Collections.Generic;

namespace DesignPatternBusinessContract
{
    public interface IEmployeService
    {
        public void AjoutEmploye(string nom, double salaire, int id);
    }
}
