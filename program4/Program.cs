Console.WriteLine("Привет, как тебя зовут");
string name = Console.ReadLine();
if(name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");

}
else
{
    Console.Write("Привет,");
    Console.WriteLine(name);
}