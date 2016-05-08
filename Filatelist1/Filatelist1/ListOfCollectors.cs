using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Filatelist1
{
    [Serializable]
    class ListOfCollectors : List<Collector>
    {
        List<Collector> collectior = new List<Collector>();

        public List<Collector> Collectior { get; set; }
        
        /// <summary>
        /// Проверка на то, если ли уже данный коллекционер в списке.
        /// </summary>
        /// <param name="ic"></param>
        /// <returns></returns>
        public bool IsCopy(Collector ic)
        {
            foreach (Collector a in collectior)
            {
                if (a.Name == ic.Name)
                    return true;
            }
            return false;
        }

    }
}
