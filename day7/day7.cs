using System;
using System.Linq;
namespace signals{

    class Tree
    {
        private Tree root = new Tree();
        private Tree parent = null;
        private Tree curdir = null;
        private int size = 0;

        static void Main(string[] args){
            string[] input = File.ReadAllLines("input.txt");
            }

        static void build_tree(string input){       
                foreach (string line in input) {
                    if (line.Contains("$ cd ")) {
                        curdir = 
                    }
                }
                }
    }
}
