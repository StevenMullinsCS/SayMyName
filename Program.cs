using System.Threading.Channels;

namespace Say_My_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Line1; 
            string Line2;
            string Line3;
            string Line4;
            string Line5;
            Console.WriteLine("[Please input the dialogue of Walter White as it]\n[appears on https://www.imdb.com/title/tt2301467/characters/nm0186505.]\n[Case does not matter, however puncuation does.]\n");
            Console.WriteLine("Who the hell are you?\n");
            Line1 = Console.ReadLine();
            Line1 = Line1.ToUpper();
            if (Line1 == "YOU KNOW. YOU ALL KNOW EXACTLY WHO I AM. SAY MY NAME.") 
            {
                Console.WriteLine("\nDo what? I don't... I don't have a damn clue who the hell you are.\n");
                Line2 = Console.ReadLine();
                Line2 = Line2.ToUpper();
                if (Line2 == "YEAH, YOU DO. I’M THE COOK. I’M THE MAN WHO KILLED GUS FRING.") ; // Line 2 does not have an else if, as anytime there would be input, the console would kill the program, even if the text was
                                                                                                // identical to what was required.
                {
                    Console.WriteLine("\nBullshit. Cartel got Fring.\n");
                    Line3 = Console.ReadLine();
                    Line3 = Line3.ToUpper();
                    if (Line3 == "ARE YOU SURE?") 
                    {
                        Console.WriteLine("\n[Declan looks at Mike and Mike shakes his head]\n");
                        Line4 = Console.ReadLine();
                        Line4 = Line4.ToUpper();
                        if (Line4 == "THAT'S RIGHT. NOW, SAY MY NAME.") 
                        {
                            Console.WriteLine("\nHeisenburg.\n");
                            Line5 = Console.ReadLine();
                            Line5 = Line5.ToUpper();
                            if (Line5 == "YOU'RE GODDAMN RIGHT.") 
                            {
                                Console.WriteLine("\n\n[Success.]");
                            }
                            else if (Line5 == default)
                            {
                                Console.WriteLine("[failure.]");
                            }
                        }
                        else if (Line4 == default)
                        { 
                            Console.WriteLine("[failure.]");
                        }
                    }
                    else if (Line3 == default)
                    { 
                        Console.WriteLine("[failure.]");
                    }
                }
                
            }
            else if (Line1 == default)
            { 
                Console.WriteLine("[failure.]");
            }

        }
        

}
}

