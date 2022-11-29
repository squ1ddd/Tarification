using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alternance.Modeles;
using Alternance.VueModeles;
using ENCHERE_SIO.VuesModeles;

namespace Alternance.VueModeles
{
    public class CalculVueModele : BaseVueModele
    {
        #region Attributes
        private double _montantTotal;
        private Dictionnaire _unDictio;
        private ObservableCollection<string> _lesAdresses;
        private ObservableCollection<Dictionnaire> _test;
        #endregion

        #region Constructor
        public CalculVueModele()
        {
            getLesTarifs();
            remplirLesAdresses();
        }
        #endregion

        #region Getters/Setters
        public Dictionnaire UnDictio
        {
            get { return _unDictio; }
            set { _unDictio = value; }
        }
        public ObservableCollection<Dictionnaire> Test
        {
            get { return _test; }
            set { SetProperty(ref _test, value); }
        }
        public ObservableCollection<string> LesAdresses
        {
            get { return _lesAdresses; }
            set { SetProperty(ref _lesAdresses, value); }
        }
        public double MontantTotal
        {
            get { return _montantTotal; }
            set { SetProperty(ref _montantTotal, value); }
        }
        #endregion

        #region Methods

        public void getLesTarifs()
        {
            UnDictio = new Dictionnaire();
            Test = new ObservableCollection<Dictionnaire>();
            Test.Add(UnDictio);
            foreach (List<double> lesTarifs in UnDictio.DicoValeur.Values)
            {
                foreach (double le in lesTarifs)
                {
                    foreach(Dictionnaire unDic in Test)
                    {
                        unDic.Valeur.Add(le);
                    }
                }
            }
        }
        public double getLePrix(int nbAdresses,string nom)
        {
            UnDictio = new Dictionnaire();
            return UnDictio.total(nbAdresses, nom);
        }

        public void remplirLesAdresses()
        {
            LesAdresses = new ObservableCollection<string>();
            foreach(int i in UnDictio.DicoAdresse.Keys)
            {
                string list = UnDictio.DicoAdresse[i];
                LesAdresses.Add("De " + i.ToString() + " à" + list + " Adr.");
            }
        }
        #endregion
    }
}
