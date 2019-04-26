using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class Bateau
    {

    }

    public class ZodiaqueHydrogene : Bateau
    {
        public ZodiaqueHydrogene()
        {
            Console.WriteLine("ZODIAQUE HYDROGENE");
        }

    }

    public class PaquebotHydrogene : Bateau
    {
       
    }



    public class ZodiaquePetrol : Bateau
    {

    }

    public class PaquebotPetrol : Bateau
    {

    }
}
