using System;
namespace elven_calories{

    class top3 
    {
        static void Main(string[] args){
            string[] input = File.ReadAllLines("input.txt");
            int first = 0, second = 0, third = 0;
            int this_elf = 0;

            foreach (string num in input){
                if (num != ""){
                    this_elf += int.Parse(num);
                }
                else {
                    if (first < this_elf){
                        third = second;
                        second = first;
                        first = this_elf;
                    }
                    else if (second < this_elf){
                        third = second;
                        second = this_elf;
                    }
                    else if (third < this_elf){
                        third = this_elf;
                    }
                    this_elf = 0;
                }
            }
            Console.WriteLine("Top 3: {0:d}, {1:d}, {2:d}\n", first, second, third);
            Console.WriteLine("Sum: {0:d}\n", (first + second + third));
        }
    }
}

