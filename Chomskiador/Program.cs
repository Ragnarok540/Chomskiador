using System;

namespace Chomskiador {

    public class Program {

        public static void Main(string[] args) {

            Console.WriteLine("==Forma Normal de Chomsky==");

            Grammar gr = Utils.LoadFile("gram.txt");

            Console.WriteLine("\nG:");
            Console.WriteLine(gr.ToString());

            gr.Start();

            Console.WriteLine("\nSTART G:");
            Console.WriteLine(gr.ToString());

            gr.Term1();

            Console.WriteLine("\nTERM1 G:");
            Console.WriteLine(gr.ToString());

            gr.Term2();

            Console.WriteLine("\nTERM2 G:");
            Console.WriteLine(gr.ToString());

            gr.Bin();

            Console.WriteLine("\nBIN G:");
            Console.WriteLine(gr.ToString());

            gr.Del();

            Console.WriteLine("\nDEL G:");
            Console.WriteLine(gr.ToString());

            gr.Unit();

            Console.WriteLine("\nUNIT G:");
            Console.WriteLine(gr.ToString());
            
            Console.ReadLine();

        }

    }

}
