using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Persons174
{
    class Person
    {
        public string fname = "My";
        public string lname = "Sauce";
        
        public string Name
        {
            get
            {
                return fname;
            }
            set
            {
                lname = value;
            }
        }
    }
}
//class Person
//{
//    private string _name = "N/A";
//    private int _age = 0;

//    // Declare a Name property of type string:
//    public string Name
//    {
//        get
//        {
//            return _name;
//        }
//        set
//        {
//            _name = value;
//        }
//    }