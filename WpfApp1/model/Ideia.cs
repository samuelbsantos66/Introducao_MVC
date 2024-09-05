using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.persistência;

namespace WpfApp1.model
{
    internal class Ideia
    {
        public string area { get; set; } = "";
        public string ideia { get; set; } = "";

        public float Custo { get; set; } = 0;

        public Boolean cadastrarIdeia(Ideia i)
        {
            BD.salvarBD(i);
            return true;
        }
    }
}
