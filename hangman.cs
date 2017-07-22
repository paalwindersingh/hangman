using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hangman
{
   class Hangman
   {
        static void Main(string[] args)
        {
            string word = ChooseWord();
            List <string> lettersGuessed = new List<string>();
            int chance = 5;
            CheckLetterInWord(word,lettersGuessed);
           
            while (chance > 0 ) 
            {
                string input = AskLetter();
                lettersGuessed.Add(input);
                    if (IsWord(word,lettersGuessed)) 
                    {
                        Console.WriteLine(word);
                        Console.WriteLine("Congratulations! you have found the word");
                        break;
                    } 
                    else if (word.Contains(input))
                    {
                        Console.WriteLine("Correct!");
                        string letters = CheckLetterInWord(word, lettersGuessed);
                        Console.Write(letters);

                    }
                    else 
                    {
                        Console.WriteLine("Wrong guess! try again");
                        chance-=1;
                

                    if(chance==0){
			            Console.WriteLine("__________   ");
			            Console.WriteLine("|         |  ");
			            Console.WriteLine("|         0 ");
			            Console.WriteLine("|        /|\\ ");
			            Console.WriteLine("|        / \\ ");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
                    }
                    else if(chance==1){
			            Console.WriteLine("__________   ");
			            Console.WriteLine("|         |  ");
			            Console.WriteLine("|         0  ");
			            Console.WriteLine("|        /|\\ ");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
                    }else if(chance == 2){
			            Console.WriteLine("__________   ");
			            Console.WriteLine("|         |  ");
			            Console.WriteLine("|         0  ");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
                    }else if(chance == 3){
                    	Console.WriteLine("__________   ");
			            Console.WriteLine("|         |  ");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
			            Console.WriteLine("|");
			            Console.WriteLine("| ");
		            }else if(chance == 4){
		            	Console.WriteLine("__________   ");
		                Console.WriteLine("|");
		                Console.WriteLine("|");
		                Console.WriteLine("|");
		                Console.WriteLine("|");
		                Console.WriteLine("|");
		                Console.WriteLine("|");
		            }
		        }
            }
            Console.ReadKey();
    }
    
    static string ChooseWord(){
      return "apple";
    }
        static bool IsWord(string word, List<string> letterGuessed) 
            {
                bool wordFound = false;
                for (int i = 0; i < word.Length; i++) 
                {
                    string letter = Convert.ToString(word[i]);
                    if (letterGuessed.Contains(letter))
                    {
                        wordFound = true;
                    }
                    else 
                    {
                        return false;
                    }

                }
                return wordFound;
            }
            static string AskLetter(){
              Console.WriteLine("Enter a letter");
                string input = Console.ReadLine();
                 return input;
            }
         static string CheckLetterInWord(string word, List<string> letterGuessed) 
            {
                string correctletters = "";
                for (int i =0 ; i < word.Length; i++)
                {
                    string c =Convert.ToString( word[i]);
                    if (letterGuessed.Contains(c))
                    {
                        correctletters += c;
                    }
                    else
                    {
                        correctletters += " _ ";
                    }

                }
                return correctletters;

            }
        }
   }
