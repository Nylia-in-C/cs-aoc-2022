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

                if (round != ""){
                    Console.WriteLine("{0:s}, {1:s}", hands[0], hands[1]);
                    switch(hands[0]){
                        case "A": //opponent rock
                            switch(hands[1]){
                                case "X": //self rock
                                    curr = 1 + 3;
                                    total += curr;
                                    break;
                                case "Y": //self paper
                                    curr = 2 + 6;
                                    total += curr;
                                    break;
                                case "Z": //self scissors
                                    curr = 3 + 0;
                                    total += curr;
                                    break;
                            }
                            break;

                        case "B": //opponent paper
                            switch(hands[1]){
                                case "X": //self rock
                                    curr = 1 + 0;
                                    total += curr;
                                    break;
                                case "Y": //self paper
                                    curr = 2 + 3;
                                    total += curr;
                                    break;
                                case "Z": //self scissors
                                    curr = 3 + 6;
                                    total += curr;
                                    break;
                            }
                            break;

                        case "C": //opponent scissors
                            switch(hands[1]){
                                case "X": //self rock
                                    curr = 1 + 6;
                                    total += curr;
                                    break;
                                case "Y": //self paper
                                    curr = 2 + 0;
                                    total += curr;
                                    break;
                                case "Z": //self scissors
                                    curr = 3 + 3;
                                    total += curr;
                                    break;
                            }
                            break;
                    }
                }
                }
                Console.WriteLine(total);
            }
        }
}

