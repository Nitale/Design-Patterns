using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.getInstance();
            Singleton.m_singleton.Name = "Jean-Paul";

            FactoryHydrogene fabH = new FactoryHydrogene();
            var bateau = fabH.CreerPaquebot();
        }
    }
}
