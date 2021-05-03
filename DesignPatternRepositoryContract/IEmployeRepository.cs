using System;

namespace DesignPatternRepositoryContract
{
    public interface IEmployeRepository
    {
        public void AjoutEmploye(string nom, double salaire, int id);
    }
}
