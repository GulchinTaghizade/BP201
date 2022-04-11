using System;
using System.Collections.Generic;
using System.Text;

namespace _04._11._2022
{
    class Student
    {
        public string Fullname { get; set; }
        public string GroupNo { get; set; }
        public bool Type { get; set; }

        public Student(string fullName, string groupNo, bool type)
        {
            Fullname=fullName;
            GroupNo=groupNo;
            Type = type;
        }
        public override string ToString()
        {
            var result = Type ? "Zemanetli" : "Zemanetsiz";
            return $"Fullname: {Fullname} GroupNo:{GroupNo} Type: {result}";
        }

    }
}
