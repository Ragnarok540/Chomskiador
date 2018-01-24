using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chomskiador {

    public class Program {

        public static void Main(string[] args) {

            Console.Out.WriteLine("=== Forma Normal De Chomsky ===");
            Grammar gram = new Grammar();
            gram.Productions.UnionWith(Production.Parse("B->C|BDC|DC"));
            gram.Productions.UnionWith(Production.Parse("C->E|CFE"));
            gram.Productions.UnionWith(Production.Parse("E->G|EaG"));
            gram.Productions.UnionWith(Production.Parse("G->H|bBc|I"));
            gram.Productions.UnionWith(Production.Parse("D->d|e"));
            gram.Productions.UnionWith(Production.Parse("F->f|g"));
            gram.Compile();

            gram.Start();

            Console.Out.WriteLine(gram.ToString());
            Console.Out.WriteLine("\n" + gram.ConcatTerminals());
            Console.Out.WriteLine("\n" + gram.ConcatVariables());

            gram.Term1();

            Console.Out.WriteLine(gram.ToString());
            Console.Out.WriteLine("\n" + gram.ConcatTerminals());
            Console.Out.WriteLine("\n" + gram.ConcatVariables());

            gram.Term2();

            Console.Out.WriteLine(gram.ToString());
            Console.Out.WriteLine("\n" + gram.ConcatTerminals());
            Console.Out.WriteLine("\n" + gram.ConcatVariables());

            gram.Bin();

            Console.Out.WriteLine(gram.ToString());
            Console.Out.WriteLine("\n" + gram.ConcatTerminals());
            Console.Out.WriteLine("\n" + gram.ConcatVariables());

            gram.Unit();

            Console.Out.WriteLine(gram.ToString());
            Console.Out.WriteLine("\n" + gram.ConcatTerminals());
            Console.Out.WriteLine("\n" + gram.ConcatVariables());

            Console.ReadLine();

            Console.Out.WriteLine(Utils.IsTerminal('a'));
            Console.Out.WriteLine(Utils.IsTerminal('A'));
            Console.Out.WriteLine(Utils.IsVariable('a'));
            Console.Out.WriteLine(Utils.IsVariable('A'));

            Test(8);

            Console.ReadLine();

        }

        public static void Test(int num) {
            SortedSet<String> lis = Utils.Binaries(num);
            foreach (String s in lis) Console.Out.WriteLine(s);
        }

    }

}
