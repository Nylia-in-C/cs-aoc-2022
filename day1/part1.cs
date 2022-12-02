using System;
namespace elven_calories{

    class calorie_counter 
    {
        static void Main(string[] args){
            string[] input = File.ReadAllLines("input.txt");
            int most = 0;
            int this_elf = 0;

            foreach (string num in input){
                if (num != ""){
                    this_elf += int.Parse(num);
                    Console.WriteLine("Current elf: {0:d}", this_elf);
                }
                else {
                    if (most < this_elf){
                        most = this_elf;
                        this_elf = 0;
                        Console.WriteLine("New high score: {0:d}, current elf: {0:d}", most, this_elf);
                    }
                    else {
                        this_elf = 0;
                    }
                }
            }
            Console.WriteLine(most);
        }
    }
}

