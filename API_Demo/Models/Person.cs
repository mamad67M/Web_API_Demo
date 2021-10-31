using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Demo.Models
{
    public class Person
    {
        public int id { get; set; } = 0;
        public string nom { get; set; } = "";
        public string prenom { get; set; } = "";

        public Person(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Person()
        {

        }

    }
}