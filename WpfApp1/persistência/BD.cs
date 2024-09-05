using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.controller;
using WpfApp1.model;
namespace WpfApp1.persistência
{
    internal class BD
    {
        public static List<BD> mybd = new List<BD>();
        public static void salvarBD(Ideia i) => mybd.Add(i);

        public static List<Ideia> retomarBD() => mybd;
    }
}
