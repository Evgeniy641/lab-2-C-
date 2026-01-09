using System.Collections.Generic;
using System.Linq;

// Задание 3 - Город
public class City3
{
    public string Name { get; set; }
    public Dictionary<City3, int> ConnectedCities { get; set; }

    // Конструктор для задания 3 - ТОЛЬКО с названием и связями
    public City3(string name, Dictionary<City3, int> connectedCities)
    {
        Name = name;
        ConnectedCities = connectedCities ?? new Dictionary<City3, int>();
    }

    // Метод для добавления связи с городом
    public void AddConnection(City3 city, int cost)
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
        return obj is City3 city && Name == city.Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}