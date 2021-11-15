using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class eleves
    {
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        private int numtel;
        private int idclasse;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Numtel { get => numtel; set => numtel = value; }
        public int Idclasse { get => idclasse; set => idclasse = value; }
    }
}
