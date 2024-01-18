using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        {
            Console.WriteLine("~Pounds to Kilograms Converter~");
            Console.Write("Weight in Pounds(lbs): ");
            int pounds = Convert.ToInt32(Console.ReadLine());
            double kilograms = pounds * 0.453592;
            Console.WriteLine("Weight converted to Kilograms(kg): " + kilograms);
        }
        {
            Console.WriteLine("\n~Miles to Kilometers~");
            Console.Write("Length in Miles(mi): ");
            int miles = Convert.ToInt32(Console.ReadLine());
            double kilometers = miles * 1.609344;
            Console.WriteLine("Length in Kilometers(km): " + kilometers);
        }
        {
            Console.WriteLine("\n~Fahrenheit to Celsius~");
            Console.Write("Temperature in Fahrenheit(°F): ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius(°C): " + celsius);
        }
        {
            Console.WriteLine("\n~Average~");
            int s0 = 19;
            int s1 = 21;
            int s2 = 20;
            int s3 = 18;
            int s4 = 18;
            int s5 = 17;
            int s6 = 22;
            int s7 = 20;
            int s8 = 18;
            int s9 = 21;
            double x = (s0 + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9) / 10.0;

            Console.WriteLine("Age of student 1: " + s0);
            Console.WriteLine("Age of student 2: " + s1);
            Console.WriteLine("Age of student 3: " + s2);
            Console.WriteLine("Age of student 4: " + s3);
            Console.WriteLine("Age of student 5: " + s4);
            Console.WriteLine("Age of student 6: " + s5);
            Console.WriteLine("Age of student 7: " + s6);
            Console.WriteLine("Age of student 8: " + s7);
            Console.WriteLine("Age of student 9: " + s8);
            Console.WriteLine("Age of student 10: " + s9);
            Console.WriteLine("Average age of students: " + x);
        }
        {
            Console.WriteLine("\n~Story~");
            string p0 = "~Beirina~";
            string p1 = "~Shadowheart~";
            string p2 = "~Lae'zel~";
            string p3 = "~Gale~";
            string p4 = "~Astarion~";
            string p5 = "~Wyll~";
            string p6 = "~Karlach~";
            string loc0 = "<Faerun>";
            string loc1 = "<Sword Coast>";
            string loc2 = "<Baldur's Gate>";
            string en0 = "~Mind Flayers~";
            string en1 = "~Lord Enver Gortash~";
            string en2 = "~Orin the Red~";
            string w0 = "<Dragon Greatsword>";
            string sk0 = "<Eldritch Blast>";
            string sk1 = "<Finger of Death>";
            string eq0 = "<Adamantine Armor>";

            Console.WriteLine($"Along the famous region of {loc1} in the world of {loc0}, there lies the crown jewel city of");
            Console.WriteLine($"{loc2} where the adventurers {p0}, {p1}, {p2}, {p3}, {p4}, {p5}, {p6} would continue their journey");
            Console.WriteLine($"to eradicate the {en0} planning to conquer all of {loc0}. Following their journey, they have clues");
            Console.WriteLine($"who their mastermind is and their lair. They raided the dungeon of {en1} to defeat him and {en2} once and for all.");
            Console.WriteLine($"At the last breath of the two bosses, {p0} uses her {w0} and {p5} {sk0} to finish them off.");
            Console.WriteLine($"By the time of their victory, {en2} almost killed {p0} by her {sk1} and dies off. {p0}'s wound is incurable.");
            Console.WriteLine($"To reward their deeds, the Gods healed {p0} the hole in her {eq0}. At last, peace prevailed over {loc0} once again.");
            Console.WriteLine($"Little did they know that the {en0} were freed from the hands of their former masters. Now they have total control over");
            Console.WriteLine($"powerful nautiloids and weapons. Will the heroes defeat the another looming threat? or be defeated in the last battle over {loc0}??");
        }
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                int sum = 0;
                string pattern = "";

                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                    pattern += i;

                    if (i != n)
                    {
                        pattern += "+";
                    }
                }

                Console.WriteLine("Formula: " + pattern);
                Console.WriteLine("Output: " + sum);
            }
        }
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = n; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}