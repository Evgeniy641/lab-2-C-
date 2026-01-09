// Задание 1.2 - Человек (базовый)
public class Person
{
    public string Name { get; set; }
    public int Height { get; set; }

    // Конструкторы
    public Person()
    {
    }

    public Person(string name, int height)
    {
        Name = name;
        Height = height;
    }

    // Метод ToString
    public override string ToString()
    {
        return $"{Name}, рост: {Height}";
    }
}