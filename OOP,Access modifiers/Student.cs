using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Access_modifiers
{
    public class Student
    {
        public string name;
        private int _age;
        protected string address;
        private int _phone;

        public int Age 
        {
            get
            {
                if (_age > 18)
                {
                    return _age;
                }
                return -1;
            }


            set
            {
                _age= value;    
            }


        }
    }
}
