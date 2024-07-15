var name = "Ewa";
bool isWoman = false;
// mężczyzna - false, kobieta - true
var age = 17;
if (isWoman == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej lat 30");
    }
    if (name == "Ewa" && age == 30)
    {
        Console.WriteLine("Ewa lat 30");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
