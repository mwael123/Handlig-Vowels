namespace Handlig_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            
                try
                {
                   
                    Console.WriteLine("please Enter a string:");
                    string input = Console.ReadLine();

                   
                    CheckForVowels(input);

                  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            
            static void CheckForVowels(string input)
            {
                
                input = input.ToLower();

                
                bool hasVowel = false;

                for (int i = 0; i < input.Length; i++)
                {
                    char c = input[i];

                    
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        hasVowel = true;
                        Console.WriteLine(" string contains vowels.");
                        break;
                       
                }
                }

               
                if (!hasVowel)
                {
                    throw new Exception(" not contain any vowels.");
                }
            }
        }
    }
    

