using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class Planning
    {
        private DateTime _dateJour;
        private int _heureDebut;
        private int _heureFin;
        private string _noteProfessionnelle;

        public Planning(DateTime dateJour, int heureDebut, int heureFin, string noteProfessionnelle)
        {
            _dateJour = dateJour;
            _heureDebut = heureDebut;
            _heureFin = heureFin;
            _noteProfessionnelle = noteProfessionnelle;
        }

        public DateTime DateJour => _dateJour;

        public void AjouterCreneau()
        {
            throw new NotImplementedException();
        }

        public void VerifierDisponibilite()
        {
            throw new NotImplementedException();
        }
    }
}
