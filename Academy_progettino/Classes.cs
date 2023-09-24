using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_progettino
{
    internal class Classes : Schools
    {
        string school;

        public string ClassName { get; set; }

        public Classes() 
        {
            school = string.Empty;
        }
        public Classes(string schoolName)
        { 
            school = schoolName;
        }


        //Recupera la scuola di riferimento
        public string GetSchool() { return school; }
    }
}
