using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnLinkedList
{
   
       
            public class Person
        {
            public int age
            {
                get;
                set;
            }

            public string fname
            {
                get;
                set;
            }
            public string lname
            {
                get;
                set;
            }
            public string city
            {
                get;
                set;
            }
            public Person()
            {

            }
            public Person(int _age, string _fanme, string _lname, string _city)
            {
                age = _age;
                fname = _fanme;
                lname = _lname;
                city = _city;


            }
            public void Display()
            {

                Console.WriteLine("Name :{0}",fname + lname);
                Console.WriteLine("Age :{0}", age);
                Console.WriteLine("City :{0}", city);
            }
        }
        class Assignment2
        {
            static void Main()
            {
                List<Person> li = new List<Person>()
            {

                new Person(){ age=22, fname="Ishita",lname="Golchha",city="Jabalpur"},
                new Person(){ age=12, fname="Kanishka",lname="Khandelwal",city="Gwalior"},
                new Person(){ age=15, fname="Yashika",lname="Jain",city="Raipur"},
                new Person(){ age=40, fname="Anushka",lname="Arora",city="Delhi"},
                new Person(){ age=45, fname="Tanisha",lname="Roy",city="Mumbai"}

            };
                Console.WriteLine("Details of the 5 Person:");
                foreach (var p in li)
                {
                    p.Display();

                }


            Console.Read();
        }
        

        }

    }



