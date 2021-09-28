using System;

Console.WriteLine("Vilktet land har störst landyta? a) Ryssland b) Kanada c) Kina");

string fråga1 = Console.ReadLine();

fråga1 = fråga1.ToLower();

int points =0;

if (fråga1 == "a")
{
    points = points +1;
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar!");
}

Console.WriteLine("Vilken är den längsta floden? a) Kongofloden b) Nilen c) Amazonfloden");

string fråga2 = Console.ReadLine();

fråga2 = fråga2.ToLower();

if (fråga2 == "c") 
{
    points = points +1;
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar!");
}

Console.WriteLine("Vilken är den största sjön i Sverige? a) Vättern b) Vänern c) Mälaren");

string fråga3 = Console.ReadLine();

fråga3 = fråga3.ToLower();

if (fråga3 == "b") 
{
    points = points +1;
    Console.WriteLine("Rätt svar! Du fick " + points + " poäng");
}
else
{
    Console.WriteLine("Fel svar! Du fick " + points + " poäng");
}

Console.ReadLine();