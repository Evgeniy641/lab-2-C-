// Задание 2 - Человек с именем
public class PersonWithName
{
    public Name FullName { get; set; }
    public int Height { get; set; }

    // Конструкторы
    public PersonWithName()
    {
    }

    public PersonWithName(Name fullName, int height)
    {
        FullName = fullName;
        Height = height;
    }

    public PersonWithName(string firstName, int height)
    {
        FullName = new Name(firstName);
        Height = height;
    }

    public PersonWithName(string lastName, string firstName, int height)
    {
        FullName = new Name(lastName, firstName);
        Height = height;
    }

    public PersonWithName(string lastName, string firstName, string middleName, int height)
    {
        FullName = new Name(lastName, firstName, middleName);
        Height = height;
    }

    // Метод ToString
    public override string ToString()
    {
        return $"{FullName}, рост: {Height}";
    }
}