using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class Prof
    {
        int id;
        string nom;
        string prenom;
        string adresse;
        string tel;
        string mail;
        string dateembauche;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Dateembauche { get => dateembauche; set => dateembauche = value; }
    }
}
