using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class Contrat
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private double _salaire;
        private string _typeContrat;

        public Contrat(DateTime dateDebut, DateTime dateFin, double salaire, string typeContrat)
        {
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _salaire = salaire;
            _typeContrat = typeContrat;
        }

        public DateTime DateDebut => _dateDebut;

        public void CalculerSalaire()
        {
            throw new NotImplementedException();
        }

        public void EstActif()
        {
            throw new NotImplementedException();
        }
    }
}
