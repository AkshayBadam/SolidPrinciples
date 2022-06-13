namespace Solid
{
   class Animal
    {
        public void makeNoise()
        {
            Console.WriteLine("i can make noise");
        }
    }
    class Dog : Animal
    {
        public void makeNoise()
        {
            Console.WriteLine("Bow Bow");
        }
    }
    class Cat : Animal
    {
        public void makeNoise()
        {
            Console.WriteLine("meow meow");
        }
    }
    class FresherStudent : Student
    {
        public void studentId()
        {
            Console.WriteLine("studentID is 0000");
        }
    }
    class Staff : Teacher
    {
        public void teacherId()
        {
            Console.WriteLine("teacher ID is 1234");
        }
    }

    class Program
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.makeNoise();
            Cat c= new Cat();
            c.makeNoise();
            FresherStudent f= new FresherStudent();
            f.studentId();  
            Staff s= new Staff();
            s.teacherId();
        }

    }
}