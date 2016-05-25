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
    class Marka
      
    {
       
        public string Country { set; get; } // страна
        public string Nominal { set; get; }  // номинальная цена
        public string Year { set; get; }  // год выпуска
        public string Tirage { set; get; }  // тираж
        public string Special { set; get; }   // особенности
        public int Id { set; get; } // Номар марки
        public Collector Coll { set; get; } // коллекционер

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="cou"></param>
        /// <param name="nomin"></param>
        /// <param name="yea"></param>
        /// <param name="tirag"></param>
        /// <param name="specia"></param>
        /// <param name="id"></param>
        /// <param name="c"></param>
        public Marka(string cou, string nomin, string yea, string tirag, string specia, int id, Collector c)
        {
            Country = cou;
            Nominal = nomin;
            Year = yea;
            Tirage = tirag;
            Special = specia;
            Id = id;
            Coll = c;
        }

       
        /// <summary>
        /// Перекрытие метода ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format(" Страна: {0}, Номинальная стоимость: {1}, Год: {2}, Тираж: {3}, Особенность: {4} ", Country, Nominal, Year, Tirage, Special);
        }


    }
}
