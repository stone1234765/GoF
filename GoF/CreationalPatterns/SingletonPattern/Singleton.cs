using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.SingletonPattern
{
    class Singleton
    {
        private static Singleton instance = new Singleton();
        public static Singleton Instance { get { return instance; } }
        protected Singleton()
        {
        }
    }
}
