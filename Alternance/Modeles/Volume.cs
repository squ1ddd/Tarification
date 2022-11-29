using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternance.Modeles
{
    public class Volume
    {
        #region Attributes
        private string _libelle;
        private int _nbAdresses;
        #endregion

        #region Constructor
        public Volume(int nbAdresses, string libelle)
        {
            _libelle = libelle;
            _nbAdresses = nbAdresses;
        }
        #endregion

        #region Getters/Setters
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }
        public int NbAdresses
        {
            get { return _nbAdresses; }
            set { _nbAdresses = value; }
        }
        #endregion

        #region Methods
        #endregion
    }
}
