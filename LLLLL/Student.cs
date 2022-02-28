using System;
using System.Collections.Generic;
using System.Text;

namespace LLLLL
{
    internal class Student
    {
        public string Fullname;
        public int GroupNo;
        public int Age;

        public Student(string fullname,int groupNo,int age)
        {
            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
        }
        public bool static CheckGroup(string groupNo)
        {
            if (groupNo.Length == 4) ;

            bool.IsUpper == false;
            bool.IsDigit=false;

            foreach (var item in groupNo)

            {
                if (char.IsUpper(item))
                    IsUpper = true;
                continue;

            }
            else (char.IsDigit(item))
                    IsDigit = true;
            continue;

            bool result = IsUpper && IsDigit;
            return result;
        }
       
    }


}
