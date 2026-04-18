using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class Personne
    {
        private string _nom;
        private string _prenom;
        private string _numRegistreNational;
        private string _telephone;
        private string _email;

        public Personne(string nom, string prenom, string numRegistreNational, string telephone, string email)
        {
            _nom = nom;
            _prenom = prenom;
            _numRegistreNational = numRegistreNational;
            _telephone = telephone;
            _email = email;
        }

        public string Nom => _nom;
        public string Prenom => _prenom;

        public void SeConnecter()
        {
            throw new NotImplementedException();
        }

        public void AfficherProfil()
        {
            throw new NotImplementedException();
        }
    }
}
