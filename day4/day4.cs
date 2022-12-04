using System;
namespace cleanup{

    class overlap
    {
        static void Main(string[] args){
            string[] input = File.ReadAllLines("input.txt");
            part1(input);
            part2(input);
        }

        static void part1(string[] input){
            int count = 0;
            foreach (string areas in input){ //read lines from file

                //splits and conversions
                string[] each_elf = areas.Split(',');
                string[] elf1 = each_elf[0].Split('-'); string[] elf2 = each_elf[1].Split('-');
                int elf1_i = Int32.Parse(elf1[0]); int elf1_f = Int32.Parse(elf1[1]);
                int elf2_i = Int32.Parse(elf2[0]); int elf2_f = Int32.Parse(elf2[1]);

                //check if one range is encapsulated by the other
                if (((elf1_i <= elf2_i) && (elf1_f >= elf2_f))  ||
                    ((elf1_i >= elf2_i) && (elf1_f <= elf2_f))  ) {
                    
                    count+=1;
                }
            }
            Console.WriteLine("Solution to part 1: {0:d}", count);
        }
        
         static void part2(string[] input){
            int count = 0;
            foreach (string areas in input){ //read lines from file

                //splits and conversions
                string[] each_elf = areas.Split(',');
                string[] elf1 = each_elf[0].Split('-'); string[] elf2 = each_elf[1].Split('-');
                int elf1_i = Int32.Parse(elf1[0]); int elf1_f = Int32.Parse(elf1[1]);
                int elf2_i = Int32.Parse(elf2[0]); int elf2_f = Int32.Parse(elf2[1]);

                //check if one range overlaps the other
                if (((elf1_i <= elf2_i) && (elf1_f >= elf2_i))  ||
                    ((elf2_i <= elf1_i) && (elf2_f >= elf1_i))  ) {
                    
                    count+=1;
                }
            }
            Console.WriteLine("Solution to part 2: {0:d}", count);
        }
    }
}
