using System;

namespace CSDemosSwitch {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a two letter state code to learn its capital.");
            string state = Console.ReadLine();
            state = state.ToUpper();

            // Solution with ELSE...

            string capital = "";

            //if (state == "IN") {
            //    capital = "Indianapolis";
            //} else if (state == "KY") {
            //    capital = "Frankfort";
            //} else if (state == "OH") {
            //    capital = "Columbus";
            //} else if (state == "PA") {
            //    capital = "Harrisburg";
            //} else {
            //    capital = "I don't know!";
            //}

            Console.WriteLine("The capital of {0} is {1}.", state, capital);
            Console.ReadLine();
        }
    }
}
