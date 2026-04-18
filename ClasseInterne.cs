using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class Interne : Personne
    {
        private string _universite;
        private int _anneeEtude;
        private string _tuteur;
        private string _serviceAffecte;

        public Interne(string nom, string prenom, string numRegistreNational, string telephone, string email,
                       string universite, int anneeEtude, string tuteur, string serviceAffecte)
            : base(nom, prenom, numRegistreNational, telephone, email)
        {
            _universite = universite;
            _anneeEtude = anneeEtude;
            _tuteur = tuteur;
            _serviceAffecte = serviceAffecte;
        }

        public string Universite => _universite;

        public void AssisterConsultation()
        {
            throw new NotImplementedException();
        }

        public void ConsulterFormation()
        {
            throw new NotImplementedException();
        }
    }
}
