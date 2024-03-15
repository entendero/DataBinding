using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataBinding1
{
    internal class Alumne
    {
        public string nom { get; set; }
        public string cognoms { get; set; }
        public string mail { get; set; }
        public string data_naixement { get; set; }
        private bool horari_mati_privat { get; set; }
        private bool horari_tarda_privat { get; set; }
        public bool horari_mati
        {
            get => horari_mati_privat;
            set
            {
                horari_mati_privat = value;
                horari_tarda_privat = !value;
            }
        }
        public bool horari_tarda
        {
            get => horari_tarda_privat;
            set
            {
                horari_tarda_privat = value;
                horari_mati_privat = !value;
            }
        }

        public bool Curset1 { get; set; }
        public bool Curset2 { get; set; }
        public bool Curset3 { get; set; }

        public Alumne(string Nom, string Cognoms, string Mail, string Data_naixement, bool Horari_mati, bool Horari_tarda)
        {
            nom = Nom;
            cognoms = Cognoms;
            mail = Mail;
            data_naixement = Data_naixement;
            horari_mati = Horari_mati;
            horari_tarda = Horari_tarda;
        }

    }
}
