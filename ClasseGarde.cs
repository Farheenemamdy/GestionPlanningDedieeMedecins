using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class Garde
    {
        private DateTime _dateGarde;
        private int _dureeGarde;
        private string _typeGarde;
        private string _noteGarde;

        public Garde(DateTime dateGarde, int dureeGarde, string typeGarde, string noteGarde)
        {
            _dateGarde = dateGarde;
            _dureeGarde = dureeGarde;
            _typeGarde = typeGarde;
            _noteGarde = noteGarde;
        }

        public DateTime DateGarde => _dateGarde;

        public void PlanifierGarde()
        {
            throw new NotImplementedException();
        }

        public void AnnulerGarde()
        {
            throw new NotImplementedException();
        }
    }
}
