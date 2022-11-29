using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternance.Modeles
{
    public class Dictionnaire
    {
        #region Attributes
        private Dictionary<int, string> _dicoAdresse = new Dictionary<int, string>();
        private Dictionary<string, List<double>> _dicoValeur = new Dictionary<string,List<double>>();
        private List<double> _valeur;
        #endregion

        #region Constructor
        public Dictionnaire()
        {
            _valeur = new List<double>();
            alimenterDicoValeur();
            alimenterDicoAdresse();
        }
        #endregion

        #region Getters/Setters
        public Dictionary<int,string> DicoAdresse
        {
            get { return _dicoAdresse; }
            set { _dicoAdresse = value; }
        }
        public Dictionary<string, List<double>> DicoValeur
        {
            get { return _dicoValeur; }
            set { _dicoValeur = value; }
        }
        public List<double> Valeur { get => _valeur; set => _valeur = value; }
        #endregion

        #region Methods
        public void alimenterDicoAdresse()
        {
            DicoAdresse.Add(1, 2499.ToString());
            DicoAdresse.Add(2500, 4999.ToString());
            DicoAdresse.Add(5000, 9999.ToString());
            DicoAdresse.Add(10000, 14999.ToString());
            DicoAdresse.Add(15000, 24999.ToString());
            DicoAdresse.Add(25000, 49999.ToString());
            DicoAdresse.Add(50000, 99999.ToString());
            DicoAdresse.Add(100000, 10000000.ToString());
            //int i = 1;
            //int valeur = 1;
            //while (i < 100000)
            //{
            //    int iDepart = i;
            //    i += 2498*valeur;
            //    DicoAdresse.Add(iDepart, i.ToString());
            //    i += 1;

            //    if (i>4999 && i < 15000)
            //    {
            //        valeur = 2;
            //    }
            //    else if (i == 15000)
            //    {
            //        valeur = 4;
            //    }
            //    else if (i == 25000)
            //    {
            //        valeur = 10;
            //    }
            //    else if (i == 50000)
            //    {
            //        valeur = 20;
            //    }
            //}
        }
        public void alimenterDicoValeur()
        {
            DicoValeur.Add("Telechargement", donnerLePrixVente("Telechargement"));
            DicoValeur.Add("Etiquette", donnerLePrixVente("Etiquette"));
            DicoValeur.Add("Papier", donnerLePrixVente("Papier"));
            DicoValeur.Add("CD-ROM", donnerLePrixVente("CD-ROM"));
        }
        public List<double> donnerLePrixVente(string type)
        {
            List<double> list = new List<double>();
            if (type.Equals("Telechargement")||type.Equals("CD-ROM"))
            {
                list.Add(0.33);
                list.Add(0.30);
                list.Add(0.26);
                list.Add(0.23);
                list.Add(0.21);
                list.Add(0.19);
                list.Add(0.16);
                list.Add(0.14);
            }
            else if (type.Equals("Etiquette"))
            {
                list.Add(0.19);
                list.Add(0.17);
                list.Add(0.15);
                list.Add(0.13);
                list.Add(0.11);
                list.Add(0.10);
                list.Add(0.09);
                list.Add(0.08);
            }
            else if (type.Equals("Papier"))
            {
                list.Add(0.23);
                list.Add(0.20);
                list.Add(0.18);
                list.Add(0.16);
                list.Add(0.15);
                list.Add(0.14);
                list.Add(0.13);
                list.Add(0.12);
            }
            return list;

        }
        public double total(int nbAdresse, string nomSupport)
        {
            double tarif = 0;
            int fraisGestion = 0;
            int compteur = 0;
            foreach(int ia in DicoAdresse.Keys)
            {
                string list = DicoAdresse[ia];
                if(nbAdresse >= ia && nbAdresse <= int.Parse(list))
                {
                    break;
                }
                compteur++;
            }
            foreach(string a in DicoValeur.Keys)
            {
                if (a.Equals(nomSupport))
                {
                    List<double> uneListe = DicoValeur[a];
                    tarif = uneListe[compteur];
                    break;
                } 
            }
            if (nomSupport == "Telechargement")
            {
                fraisGestion = 5;

            }
            else
            {
                fraisGestion = 30;

            }
            return nbAdresse * tarif + fraisGestion;
        }
        #endregion
    }
}
