using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Employee
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;

            }
            set
            {

                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsLetter(value[i]))
                    {
                        if (Char.IsUpper(value[0]))
                        {
                            _name = value;

                        }
                        else
                        {
                            Console.WriteLine("Adin ilk herfi boyuk olmalidir!");
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Herflerden bashqa simvol olmamalidir!");
                        break;
                    }


                }

            }
        }



        public string _surname;
        public string Surname
        {
            get
            {
                return _surname;

            }
            set
            {

                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsLetter(value[i]))
                    {
                        if (Char.IsUpper(value[0]))
                        {
                            _surname = value;
                           
                        }
                        else
                        {
                            Console.WriteLine("Adin ilk herfi boyuk olmalidir!");
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Herflerden bashqa simvol olmamalidir!");
                        break;
                    }
                    
                       
                }

            }
        }


        public int _salary;
        public int Salary
        {
            get
            {
                return _salary;

            }
            set
            {
                if (value>=250)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Maash 250 den ashagi ola bilmez!");
                }
                
            }
        }

    }
}
