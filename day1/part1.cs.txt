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
                }
                else {
                    if (most < this_elf){
                        most = this_elf;
                        this_elf = 0;
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

