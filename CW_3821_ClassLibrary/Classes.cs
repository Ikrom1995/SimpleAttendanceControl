using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3821_ClassLibrary
{
    public class Classes
    {
        //properties for the Classess class
        public int Id { get; set; }

        public string ClassName { get; set; }

        //Constructor
        public Classes(string cName) {
            ClassName = cName;
        }

        //overriding ToString method, so it returns ClassName to the 
        //gridview when Classess used as a parameter of another class
        public override string ToString()
        {
            return ClassName;//base.ToString();
        }
    }
}
