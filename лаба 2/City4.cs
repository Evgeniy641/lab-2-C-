using System.Collections.Generic;
using System.Linq;

// Задание 4 - Город (расширенная версия)
public class City4
{
    public string Name { get; set; }
    public Dictionary<City4, int> ConnectedCities { get; set; }

    // Конструктор 1: ТОЛЬКО с названием 
    public City4(string name)
    {
        Name = name;
        ConnectedCities = new Dictionary<City4, int>();
    }

    // Конструктор 2: С названием и связями (для обратной совместимости)
    public City4(string name, Dictionary<City4, int> connectedCities)
    {
        Name = name;
        ConnectedCities = connectedCities ?? new Dictionary<City4, int>();
    }

    // Метод для добавления связи с городом
    public void AddConnection(City4 city, int cost)
    {
        if (city != null && !ConnectedCities.ContainsKey(city))
        {
            ConnectedCities.Add(city, cost);
        }
    }

    // Метод ToString
    public override string ToString()
    {
        if (ConnectedCities.Count == 0)
        {
            return $"{Name} (нет связей)";
        }

        var connections = string.Join(", ", ConnectedCities.Select(c => $"{c.Key.Name}:{c.Value}"));
        return $"{Name} -> {connections}";
    }

    public override bool Equals(object obj)
    {
        return obj is City4 city && Name == city.Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}