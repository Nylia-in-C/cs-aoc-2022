using System;
namespace rps{

    class rps_game
    // Opponent A:Rock, B: Paper, C: Scissors
    // Self     X:Rock, Y: Paper, Z: Scissors
    {
        static void Main(string[] args){
            string[] input = File.ReadAllLines("input.txt");
            int total = 0, curr = 0;

            foreach (string round in input){
                string[] hands = round.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(hands);
                //if (round != ""){
                    
                //}
                }
            }
        }
}

