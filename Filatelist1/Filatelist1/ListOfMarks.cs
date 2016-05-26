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
    /// Класс, с помощью которого совершается управление списком марок.
    /// </summary>

    [Serializable]
    class ListOfMarks : List<Marka>
    {

    }
}
