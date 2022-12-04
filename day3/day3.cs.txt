using System;
using System.Linq;
namespace rucksack{

    class reorg
    {
        static void Main(string[] args){
            string[] input = File.ReadAllLines("input.txt");
            part1(input);
            part2(input);
        }

        static void part1(string[] input){
            int psum = 0;
            foreach (string contents in input){ //read lines from file, split in halves
                int hsize = (contents.Length/2);
                string half1 = contents.Substring(0,(hsize));
                string half2 = contents.Substring(((hsize)));

                for (int i = 0; i < (hsize); i++){ //check for common character

                    if (half2.Contains(half1.Substring(i,1))){ //char found
                        char in_both = char.Parse(half1.Substring(i,1)); //convert

                        if (Char.IsLower(in_both)){
                            psum += (in_both - 96); // lower, 1-26
                        }
                        else {
                            psum += (in_both - 38); // upper, 27-52
                        }
                    break;
                    }
                }
            }
        Console.WriteLine("Solution to part1: {0:d}", psum);
        }

         static void part2(string[] input){
            int psum = 0;
            for (int j = 0; j < input.Count(); j+=3){ 
                string elf1 = input[j];
                string elf2 = input[j+1];
                string elf3 = input[j+2];
                int size = elf1.Length;

                for (int i = 0; i < size; i++){ //check for common character

                    if (elf2.Contains(elf1.Substring(i,1)) && elf3.Contains(elf1.Substring(i,1))){ //char found
                        char in_all = char.Parse(elf1.Substring(i,1)); //convert

                        if (Char.IsLower(in_all)){
                            psum += (in_all - 96); // lower, 1-26
                        }
                        else {
                            psum += (in_all - 38); // upper, 27-52
                        }
                    break;
                    }
                }
            }
        Console.WriteLine("Solution to part2: {0:d}", psum);
        }
    }
}