namespace ReflectClass
{

    interface I
    {
            void M1();
            void M2();
    }
    interface I2
    {
        void M3();
    }
    interface I3
    {
        void M4();
    }
    public class Class1 : I, I2, I3
    {
        void I.M1()
        {
            Console.WriteLine("This is Method 1");
        }
        void I.M2()
        {
            Console.WriteLine("This is Method 2");
        }

        void I2.M3()
        {
            Console.WriteLine("this is Method 3");
        }

        void I3.M4()
        {
            Console.WriteLine("this is Method 4");
        }

        public class B : Class1
        {
           public void BM5()
            {
                Console.WriteLine("this is method 5");
            }
        }
    }
}
