public class Animal
{
    private string name;
    public Animal(string name)
    {
        this.name = name;
    }
    public void naming()
    {
        Console.WriteLine($"Имя: {name}");
    }
}
static void Main()
{
    Animal cat = new Animal('Луна')
    cat.naming
}