using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    
    class Singleton
    {
        public string Name { get; set; } 
        public static Singleton m_singleton = null;
        public static Singleton getInstance()
        {
            if (m_singleton == null)
                m_singleton = new Singleton();
            return m_singleton;
        }
        private Singleton()
        {
        }
    }
}
