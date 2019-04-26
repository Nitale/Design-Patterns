using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    interface MultiFactory
    {
        Bateau CreerZodiaque();
        Bateau CreerPaquebot();
    }

    class FactoryHydrogene : MultiFactory
    {
        public Bateau CreerZodiaque()
        {
            return new ZodiaqueHydrogene();
        }

        public Bateau CreerPaquebot()
        {
            return new PaquebotHydrogene();
        }
    }

    class FactoryPetrol : MultiFactory
    {
        public Bateau CreerZodiaque()
        {
            return new ZodiaquePetrol();
        }

        public Bateau CreerPaquebot()
        {
            return new PaquebotPetrol();
        }
    }
}
