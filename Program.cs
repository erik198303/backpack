using System;

namespace backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            //String array, skapas utanför while loop för att kunna uppdatera och nollställa värden.
            string[] innehåll = new string[5];

			while(true) 
            {
				Console.WriteLine("Välkommen till din ryggsäck!");
				Console.WriteLine("[1] Lägg till innehåll");
				Console.WriteLine("[2] Rensa innehåll");
				Console.WriteLine("[3] Visa innehåll");
				Console.WriteLine("[4] Avsluta");
                System.Console.Write("Välj: ");

                

				string menyVal = Console.ReadLine();
				switch(menyVal)
                 {
					//Case 1, Användaren kan mata in 5st föremål via for loop, innehåll[0] = "input", innehåll[1] = "input" osv.. 
                    //Eftersom värde sparas i string(text) så kan föremål även innehålla siffror, text äpple99.
                
                
					case "1":
						System.Console.WriteLine("Nu ska du lägga till fem valfria föremål");
                        for(int i = 0; i < innehåll.Length; i++)
                        {    
                            System.Console.Write("Mata in föremål: ");
                            string input = Console.ReadLine();
                            innehåll[i] = input;
                        }
						break;
					
                    //Case 2, skriver över alla värden i array med ""/empty string.
					case "2":
						Console.WriteLine("**Ryggsäcken rensad!**");
                        for(int i = 0; i < innehåll.Length; i++)
                        {
                            System.Console.WriteLine("...");
                            innehåll[i] = "";
                        }
						break;			

                    //Case 3, visar innehåll via for loop.
					case "3":
						Console.WriteLine("Innehållet i ryggsäcken:");
                        
                        for(int i = 0; i < innehåll.Length; i++)
                        {
                            System.Console.WriteLine(innehåll[i]);                            
                        }
                       
						break;
					
					case "4":
						Console.WriteLine("Program Ryggsäcken avslutat...");
						return;   
                    default:
                    System.Console.WriteLine("**Felaktigt val!** ");
                    System.Console.WriteLine("**Välj alternativ i menyn, 1-4** ");
                    break;
                }
            }       

        }
    }
}
