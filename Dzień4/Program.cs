var name = "Ewa";
bool sex = true;
// mężczyzna - false, kobieta - true
var age = 35;
if (sex == true)
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
