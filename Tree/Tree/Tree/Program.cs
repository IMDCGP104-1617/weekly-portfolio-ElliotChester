using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool usingTextFile = false;

            Console.WriteLine("Huffman Code Program");
            Console.WriteLine("");

            Console.WriteLine("would you like to input via typing or text file?");

            string Answer = "";
            while (Answer == "")
            {
                Console.WriteLine("Typing = 1 | Text File = 2");
                Answer = Console.ReadLine();

                if (Answer == "1")
                {
                    usingTextFile = false;
                    break;
                }
                else 
                if (Answer == "2")
                {
                    usingTextFile = true;
                    break;
                }

                Answer = "";
                Console.WriteLine();
                Console.WriteLine("That's not an option");
                
            }

            string newString = "";

            if (usingTextFile == false)
            {
                Console.WriteLine();
                Console.WriteLine("Input Your Word");

                // sets a string as the text given by the user
                
                newString = Console.ReadLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("What is the path of your text file?");

                string txtFile = "";
                txtFile = Console.ReadLine();

                newString = System.IO.File.ReadAllText(@txtFile);
            }
            // creates the tree
            Tree tree = new Tree();

            //Adds each letter to the tree
            tree.Build(newString);

            BitArray encoded = tree.Encode(newString);

            Console.WriteLine();
            Console.WriteLine("Encoded: ");
            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();

            // Decode
            string decoded = tree.Decode(encoded);

            Console.WriteLine("Decoded: ");
            Console.WriteLine(decoded);

            Console.ReadKey();
        }
    }
}
