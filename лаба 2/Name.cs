using System;
using System.Collections.Generic;

// Задание 1.3 - Имя
public class Name
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }

    // Конструкторы
    public Name()
    {
    }

    public Name(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }

    public Name(string firstName)
    {
        FirstName = firstName;
    }

    public Name(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    // Метод ToString
    public override string ToString()
    {
        List<string> parts = new List<string>();

        if (!string.IsNullOrEmpty(LastName))
            parts.Add(LastName);
        if (!string.IsNullOrEmpty(FirstName))
            parts.Add(FirstName);
        if (!string.IsNullOrEmpty(MiddleName))
            parts.Add(MiddleName);

        return string.Join(" ", parts);
    }
}