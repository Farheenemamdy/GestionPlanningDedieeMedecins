using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_hospitalière_médecin___EMAMDY_NOOR_E_AYN
{
    public class Service
    {
        private string _nomService;
        private int _etage;
        private string _batiment;

        public Service(string nomService, int etage, string batiment)
        {
            _nomService = nomService;
            _etage = etage;
            _batiment = batiment;
        }

        public string NomService => _nomService;

        public void AjouterMedecin()
        {
            throw new NotImplementedException();
        }

        public void ListerMedecins()
        {
            throw new NotImplementedException();
        }
    }
}
