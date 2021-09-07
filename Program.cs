using System;

namespace PermanentDrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada

            {
                Console.WriteLine("Mis aastal sa oled sündinud?");
                int YearOfBirth = Int32.Parse(Console.ReadLine());
                int Age = 2021 - YearOfBirth;

                if( Age < 18)
                {
                    Console.WriteLine("Sa oled piisavalt vana ,et juhiluba saada");

                }
                  else if(Age > 18 )          
                {
                    Console.WriteLine("Oled liiga noor ,et juhiluba saada");

                }
                  else
                {
                    Console.WriteLine("Oled 18 siis saad juhiloa");
                }
                
                
            
            
            
            
            
            
             }

        }
    }
}
