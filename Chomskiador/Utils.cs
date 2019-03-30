using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

namespace Chomskiador {

    public class Utils {

        public static bool IsVariable(char c) {
            return (c <= 'Z') && (c >= 'A');
        }

        public static bool IsTerminal(char c) {
            return (c <= 'y') && (c >= 'a');
        }

        public static bool IsNullable(Production p) {
            if (p.Body == "z") return true; 
            return false;
        }

        public static bool IsInitial(Production p) {
            if (p.Head == 'A') return true;
            return false;
        }

        public static Grammar LoadFile(String path) {
            Grammar gram = new Grammar();
            StreamReader sr = File.OpenText(path);
            String line = "";
            while (!sr.EndOfStream) {
                line = sr.ReadLine();
                gram.Productions.UnionWith(Production.Parse(line));
            }
            sr.Close();
            gram.Compile();
            return gram;
        }

        public static SortedSet<String> Binaries(int bits) {
            SortedSet<String> list = new SortedSet<String>();
            int quantity = (int) Math.Pow(2, bits);
            for (int c = 0; c < quantity; c++) {
                list.Add(Binary(c, bits));
            }
            return list;
        }

        public static String Binary(int number, int length) {
            BitVector32 vector = new BitVector32(number);
            return vector.ToString().Substring(12, 32).Remove(0, 32 - length);
        }

    }

}
