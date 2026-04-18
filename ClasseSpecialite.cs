using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class Specialite
    {
        private string _nom;
        private string _description;
        private string _code;

        public Specialite(string nom, string description, string code)
        {
            _nom = nom;
            _description = description;
            _code = code;
        }

        public string Nom => _nom;

        public void AssignerMedecin()
        {
            throw new NotImplementedException();
        }

        public void ListerMedecins()
        {
            throw new NotImplementedException();
        }
    }
}
