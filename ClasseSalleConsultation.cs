using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class SalleConsultation
    {
        private int _numSalle;
        private int _etage;
        private string _batiment;

        public SalleConsultation(int numSalle, int etage, string batiment)
        {
            _numSalle = numSalle;
            _etage = etage;
            _batiment = batiment;
        }

        public int NumSalle => _numSalle;

        public void EstDisponible()
        {
            throw new NotImplementedException();
        }

        public void AffecterMedecin()
        {
            throw new NotImplementedException();
        }
    }
}
