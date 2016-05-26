using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Filatelist1
{
    /// <summary>
    /// Класс для сериализации списков марок и коллекционеров
    /// </summary>

    [Serializable]
    class Serial
    {

        public static ListOfMarks marksList = new ListOfMarks();                      //общий список марок
        public static ListOfCollectors collectorsList = new ListOfCollectors();       //общий список коллекционеров


        /// <summary>
        /// Сохранение изменений в общем списке коллекционеров.
        /// </summary>
        public static void SaveCollector()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("Collectors.dat", FileMode.OpenOrCreate))
                {
                    binFormat.Serialize(fStream, collectorsList);
                }
            }
            catch { }
        }

        /// <summary>
        /// Сооздание или открытие общего списка коллекционеров.
        /// </summary>
        public static void OpenCollector()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("Collectors.dat", FileMode.Open))
                {
                    collectorsList = (ListOfCollectors)binFormat.Deserialize(fStream);
                }
            }
            catch { }
        }

        /// <summary>
        /// Сооздание или открытие общего списка марок.
        /// </summary>
        public static void OpenMark()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("Marks.dat", FileMode.Open))
                {
                    marksList = (ListOfMarks)binFormat.Deserialize(fStream);
                }
            }
            catch { }
        }

        /// <summary>
        /// Сохранение изменений в общем списке марок.
        /// </summary>
        public static void SaveMark()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("Marks.dat", FileMode.OpenOrCreate))
                {
                    binFormat.Serialize(fStream, marksList);
                }
            }
            catch { }
        }

    }
}
