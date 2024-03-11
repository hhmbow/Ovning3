using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Övning3
{
  
        public class Person
        {

            private int _age;
            private string _fName;
            private string _lName;
            private double _Height;
            private double _Weight;

            public int Age
            {
            get { return _age; }
                set {
                if(value <= 0)
                throw new ArgumentException("Ålder måste vara större än 0.");
                _age = value;
            }
            }
            public string Fname
            {
            get { return _fName; }
                set {
                _fName = value;
                if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("Förnamnet måste vara mellan 2 och 10 tecken långt.");
                
            }
            }
            public string Lname
            {
                get { return _lName; }
                set {
                _lName = value;
               
                if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("Eftenamn måste vara mellan 3 och 15 tecken långt.");
            }
            }
            public double Height
            {
                get => _Height;
                set { 
                _Height = value;
            }
            }
            public double Weight
            {
                get => _Weight;
                set { 
                _Weight = value;
            }
            }
        }
    }

