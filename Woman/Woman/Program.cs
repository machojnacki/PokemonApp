
using System.ComponentModel.Design;

string name = "Ewa";
int age = 25;
string gender = "Woman";
string gender2 = "Male";

if (gender == "Woman" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
 else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}

else if (gender2 == "Male" && age < 18)
{
    Console.WriteLine("Niepełnoletni mezczyzna");
}
