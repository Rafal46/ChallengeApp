

string name = "Ania";
string sex = "Kobieta";
int age = 20;


Console.WriteLine(name);
Console.WriteLine(sex);
Console.WriteLine(age);

if (sex == "Kobieta")
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
        if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }

    else
    {
        Console.WriteLine("Kobieta 30 lat lub starsza");
    }

else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }

    else
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}












