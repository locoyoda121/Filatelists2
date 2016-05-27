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
    /// Класс, с помощью которого будет осуществляться работа с коллекционерами.
    /// </summary>
    [Serializable]
    class Collector
    {
        public string Country { set; get; }      // Страна
        public string Name { set; get; }         // Имя
        public string Phone { set; get; }        // телефон
        public int Id { set; get; }              // Номер коллекционера.
        public ListOfMarks Listmarks;            // Колекция марок

        /// <summary>
        /// Конструктор для создания нового коллекционера.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <param name="id"></param>
        public Collector(string n, string c, string p, int id)
        {
            Name = n;
            Phone = p;
            Country = c;
            Id = id;
            Listmarks = new ListOfMarks();
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Collector()
        {

        }
    }
}
