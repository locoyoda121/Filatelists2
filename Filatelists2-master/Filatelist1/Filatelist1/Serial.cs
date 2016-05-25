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
    [Serializable]
    class Serial
    {
        public static ListOfMarks marksList = new ListOfMarks();

        public static ListOfCollectors collectorsList = new ListOfCollectors();

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
