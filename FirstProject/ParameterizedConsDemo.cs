using System;


namespace FirstProject
{
    class ParameterizedConsDemo
       
    {
        int x;
        public ParameterizedConsDemo(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called: " + i);
        }
        public void Display()
        {
            Console.WriteLine("VAlue of x is: "  + x);
        }
    static void Main()
        {
            ParameterizedConsDemo cd1 = new ParameterizedConsDemo(10);
            ParameterizedConsDemo cd2 = new ParameterizedConsDemo(20);
            cd1.Display();
            cd2.Display();
            Console.ReadKey();
        }

    }
}
