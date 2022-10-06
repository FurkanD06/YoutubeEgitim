using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDemo_
{
    public abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate();


        public void Save()
        {
            Console.WriteLine("Kaydedildi");
        }
    }
}
