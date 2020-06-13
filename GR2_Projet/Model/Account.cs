using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Model
{
    class Account
    {
        public int id { get { return id; } set { id = value; } }
        public string name { get { return name; } set { name = value; } }
        public int budget { get { return budget; } set { budget = value; } }

        public Account() { }
    }
}
