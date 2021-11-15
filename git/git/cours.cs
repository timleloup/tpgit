using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class cours
    {
        private int id;
        private int idmatiere;
        private string date;
        private string heure;
        private string duree;
        private int idprof;
        private int idsalle;
        private int idclasse;

        public int Id { get => id; set => id = value; }
        public int Idmatiere { get => idmatiere; set => idmatiere = value; }
        public string Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public string Duree { get => duree; set => duree = value; }
        public int Idprof { get => idprof; set => idprof = value; }
        public int Idsalle { get => idsalle; set => idsalle = value; }
        public int Idclasse { get => idclasse; set => idclasse = value; }
    }
}
