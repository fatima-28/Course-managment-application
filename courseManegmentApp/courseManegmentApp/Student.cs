using System;
namespace courseManegmentApp
{
    public class Student
    {
        
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public bool Type { get; set; }

        public Student(string fullname,bool type)
        {
            FullName = fullname;
            Type = type;
            
        }
    }
}
