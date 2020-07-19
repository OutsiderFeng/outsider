using System;

namespace property_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Age = 16};
            Console.WriteLine(stu.CanWork);
        }
    }
    class Student
    {

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value;
                this.caculatorCanWork();
            }
        }

        private bool canWork;

        public bool CanWork
        {
            get { return canWork; }
        }

        private void caculatorCanWork()
        {
            if (this.age>=16)
            {
                this.canWork = true;
            }
            else
            {
                this.canWork = false;
            }
        }
    }
}
