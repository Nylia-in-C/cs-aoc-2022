using System;
using System.Linq;
namespace signals{

    class Marker
    {
        static void Main(string[] args){
            string[] input = File.ReadAllLines("input.txt");
            signal_checker(input[0], 4);
            signal_checker(input[0], 14);
        }

        static void signal_checker(string input, int num){
            char[] arr = input.Substring(0, num).ToCharArray();
            int count = num;

            foreach (char letter in input.Substring(num)){ //read characters from file
                if ((arr.Count() != arr.Distinct().Count())) { //check if every character in array is unique
                        arr[count % num] = letter;
                        count++;
                }

                else {
                    Console.WriteLine("Characters until marker with {0:d} unique chars: {1:d}", num, count);
                    return;
                }
            }
        }
    }
}
