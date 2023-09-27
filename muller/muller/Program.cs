namespace muller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            string name = "Anna";
            int age = 3;
            float height = 165.7F;
            float weight = 62;
            decimal money = 1000;

            string name1 = "Márk";
            int age1 = 17;
            float height1 = 167F;
            float weight1 = 64;
            decimal money1 = 1000000;

            string name2 = "Domi";
            int age2 = 117;
            float height2 = 1.65F;
            float weight2 = 640;
            decimal money2 = 640000000;



            //<name> nvu felasznao kora: <age>
            Console.Write(name);
            Console.Write(" nevu fehasznalo kora:");
            Console.WriteLine(age);

            Console.WriteLine(name + " nevu felhasznalo kora" + age);

            //interpolation 
            Console.WriteLine($"{name} nevu felhasznalo kora: {age}");

            //String.Format(text, variables)
            Console.WriteLine("{0} nevu felhasznalo kora: {1}", name, age);

            Console.WriteLine("/--------------------------------------------------------------\\");
            Console.WriteLine("| nev        | kor  | magassag | suly  |               zsebpenz|");
            Console.WriteLine("*--------------------------------------------------------------*");
            Console.WriteLine($"| {name,-10} | {age,4:D3} | {height,8:F1} | {weight,5} | {money,21:C2} |");
            Console.WriteLine($"| {name1,-10} | {age1,4:D3} | {height1,8:F1} | {weight1,5} | {money1,21:C2} |");
            Console.WriteLine($"| {name2,-10} | {age2,4:D3} | {height2,8:F1} | {weight2,5} | {money2,21:C2} |");

            Console.WriteLine("Formzasi mintak vege");
            Console.ReadLine();

            int x = 10;
            int y = 20;

            Console.CursorLeft = x;
            Console.CursorTop = y;

            Console.Write("X");

            Console.CursorLeft = x;
            Console.CursorTop = y+1;

            Console.Write("X");

            Console.CursorLeft = x;
            Console.CursorTop = y+2;

            Console.Write("X");

            Console.ReadLine();
            Console.WriteLine("poziciora iras vege");
            Console.ReadLine();

            while (true)
            { 
                Console.Clear();
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("X");

                Console.ReadKey();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                    case ConsoleKey.RightArrow:
                        x++;
                    case ConsoleKey.UpArrow:
                        y--;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    default:

                        break;
                }
            }
                   



        }
    }
}