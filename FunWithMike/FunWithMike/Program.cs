using System;

namespace FunWithMike {
    class Program {
        static void Main(string[] args) {

            DateTime d = DateTime.Today;
            
            Console.WriteLine(d.AddDays(-d.Day+1));

            
        }
    }
    class Solution {
        static void Main(String[] args) {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
                Console.WriteLine(new String('#', i + 1).PadLeft(N, ' '));
        }
    }
}
