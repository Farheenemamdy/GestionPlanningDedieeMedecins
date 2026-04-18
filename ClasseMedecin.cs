using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class Medecin : Personne
    {
        private string _specialite;
        private string _grade;
        private string _statut;
        private string[] _services;

        public Medecin(string nom, string prenom, string numRegistreNational, string telephone, string email,
                       string specialite, string grade, string statut, string[] services)
            : base(nom, prenom, numRegistreNational, telephone, email)
        {
            _specialite = specialite;
            _grade = grade;
            _statut = statut;
            _services = services;
        }

        public string Specialite => _specialite;
        public string Grade => _grade;
        public string Statut => _statut;
        public string[] Services => _services;

        public void ConsulterPlanning()
        {
            throw new NotImplementedException();
        }

        public void EffectuerConsultation()
        {
            throw new NotImplementedException();
        }
    }
}
