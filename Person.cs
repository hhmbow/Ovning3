using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
  
        public class Person
        {

            private int _Age;
            private string _FName;
            private string _LName;
            private int _Height;
            private int _Weight;

            public int age
            {
                get => _Age;
                set {
                _Age = value;
            }
            }
            public string fname
            {
                get => _FName;
                set { 
                _FName = value;
            }
            }
            public string lname
            {
                get => _LName;
                set {
                _LName = value;
            }
            }
            public int height
            {
                get => _Height;
                set { 
                _Height = value;
            }
            }
            public int weight
            {
                get => _Weight;
                set { 
                _Weight = value;
            }
            }
        }
    }

