using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Filatelist1
{
    /// <summary>
    /// Класс, с помощью которого совершается управление списком коллекционеров.
    /// </summary>

    [Serializable]
    class ListOfCollectors : List<Collector>
    {
        /// <summary>
        /// Проверка на то, если ли уже данный коллекционер в списке.
        /// </summary>
        /// <param name="ic"></param>
        /// <returns></returns>
        public bool IsCopy(Collector ic)
        {
            foreach (Collector a in Serial.collectorsList)
            {
                if (a.Phone == ic.Phone)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
