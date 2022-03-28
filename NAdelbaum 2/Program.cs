
Console.WriteLine("               *                 ", Console.ForegroundColor = ConsoleColor.DarkGreen);
Console.WriteLine("              ***                ", Console.ForegroundColor = ConsoleColor.DarkGreen);
Console.WriteLine("             *****               ", Console.ForegroundColor = ConsoleColor.DarkGreen);


int numb = 0;

Console.Write("Höhe (Reihen) = ");
numb = int.Parse(Console.ReadLine());


Nadelbaum(numb);


static void Nadelbaum(int reihen)
{
    if (reihen < 3)
    {
        reihen = 3;
    }

    int maxStamm = reihen / 15;
    int tempStamm = 0;

    //Krone
    for (int i = 0; i <= reihen; i++)
    {
        for (int j = i; j <= reihen; j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < i; k++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }

    //Stamm
    do
    {
        for (int j = 0; j < reihen - (reihen / 3); j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= reihen / 3; k++)
        {
            Console.Write(" #");
        }
        Console.WriteLine();
        tempStamm++;

    } while (tempStamm <= maxStamm);
}