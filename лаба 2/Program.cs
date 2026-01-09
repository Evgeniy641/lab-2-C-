using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ЛАБОРАТОРНАЯ РАБОТА №2 ===");

        // Задание 1.2 - Человек
        Console.WriteLine("ЗАДАНИЕ 1.2 - ЧЕЛОВЕК");
        Person person1 = new Person("Клеопатра", 152);
        Person person2 = new Person("Пушкин", 167);
        Person person3 = new Person("Владимир", 189);

        Console.WriteLine(person1);
        Console.WriteLine(person2);
        Console.WriteLine(person3);
        Console.WriteLine();

        // Задание 1.3 - Имя
        Console.WriteLine("ЗАДАНИЕ 1.3 - ИМЯ");
        Name name1 = new Name("Клеопатра");
        Name name2 = new Name("Пушкин", "Александр", "Сергеевич");
        Name name3 = new Name("Маяковский", "Владимир");

        Console.WriteLine(name1);
        Console.WriteLine(name2);
        Console.WriteLine(name3);
        Console.WriteLine();

        // Задание 2 - Человек с именем
        Console.WriteLine("ЗАДАНИЕ 2 - ЧЕЛОВЕК С ИМЕНЕМ");
        PersonWithName personWithName1 = new PersonWithName(name1, 152);
        PersonWithName personWithName2 = new PersonWithName(name2, 167);
        PersonWithName personWithName3 = new PersonWithName(name3, 189);

        Console.WriteLine(personWithName1);
        Console.WriteLine(personWithName2);
        Console.WriteLine(personWithName3);
        Console.WriteLine();

        // Задание 3 - Города
        Console.WriteLine("ЗАДАНИЕ 3 - ГОРОДА");

        // Создаем города с помощью словаря связей
        var moscowConnections = new Dictionary<City3, int>();
        var spbConnections = new Dictionary<City3, int>();
        var kazanConnections = new Dictionary<City3, int>();
        var sochiConnections = new Dictionary<City3, int>();
        var vladivostokConnections = new Dictionary<City3, int>();

        // Создаем города с пустыми связями сначала
        City3 moscow = new City3("Москва", moscowConnections);
        City3 spb = new City3("Санкт-Петербург", spbConnections);
        City3 kazan = new City3("Казань", kazanConnections);
        City3 sochi = new City3("Сочи", sochiConnections);
        City3 vladivostok = new City3("Владивосток", vladivostokConnections);

        // Добавляем связи
        moscow.AddConnection(spb, 500);
        moscow.AddConnection(kazan, 700);

        spb.AddConnection(moscow, 500);
        spb.AddConnection(sochi, 1000);

        kazan.AddConnection(moscow, 700);
        kazan.AddConnection(vladivostok, 3000);

        sochi.AddConnection(spb, 1000);
        sochi.AddConnection(vladivostok, 2500);

        vladivostok.AddConnection(kazan, 3000);
        vladivostok.AddConnection(sochi, 2500);

        // Выводим информацию о городах
        City3[] cities3 = { moscow, spb, kazan, sochi, vladivostok };
        foreach (var city in cities3)
        {
            Console.WriteLine(city);
        }
        Console.WriteLine();

        // Задание 4 - Города (расширенная версия)
        Console.WriteLine("ЗАДАНИЕ 4 - ГОРОДА (РАСШИРЕННАЯ ВЕРСИЯ)");

        // Создаем города - теперь можно создавать только с именем
        City4 moscow4 = new City4("Москва");
        City4 spb4 = new City4("Санкт-Петербург");
        City4 kazan4 = new City4("Казань");
        City4 sochi4 = new City4("Сочи");
        City4 vladivostok4 = new City4("Владивосток");

        // Создаем связи между городами 
        moscow4.AddConnection(spb4, 500);
        moscow4.AddConnection(kazan4, 700);

        spb4.AddConnection(moscow4, 500);
        spb4.AddConnection(sochi4, 1000);

        kazan4.AddConnection(moscow4, 700);
        kazan4.AddConnection(vladivostok4, 3000);

        sochi4.AddConnection(spb4, 1000);
        sochi4.AddConnection(vladivostok4, 2500);

        vladivostok4.AddConnection(kazan4, 3000);
        vladivostok4.AddConnection(sochi4, 2500);

        // Выводим информацию о городах
        City4[] cities4 = { moscow4, spb4, kazan4, sochi4, vladivostok4 };
        foreach (var city in cities4)
        {
            Console.WriteLine(city);
        }
        Console.WriteLine();

        // Задание 5 - Дроби
        Console.WriteLine("ЗАДАНИЕ 5 - ДРОБИ");

        // Создаем дроби
        Fraction f1 = new Fraction(1, 3);
        Fraction f2 = new Fraction(2, 3);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(5, 6);

        Console.WriteLine("Созданные дроби:");
        Console.WriteLine($"f1 = {f1}");
        Console.WriteLine($"f2 = {f2}");
        Console.WriteLine($"f3 = {f3}");
        Console.WriteLine($"f4 = {f4}");
        Console.WriteLine();

        // Примеры операций
        Console.WriteLine("Примеры операций:");

        // Сложение
        Fraction resultAdd = f1.Add(f2);
        Console.WriteLine($"{f1} + {f2} = {resultAdd}");

        // Вычитание
        Fraction resultSubtract = f3.Subtract(f4);
        Console.WriteLine($"{f3} - {f4} = {resultSubtract}");

        // Умножение
        Fraction resultMultiply = f1.Multiply(f2);
        Console.WriteLine($"{f1} * {f2} = {resultMultiply}");

        // Деление
        Fraction resultDivide = f3.Divide(f4);
        Console.WriteLine($"{f3} / {f4} = {resultDivide}");

        // Операции с целыми числами
        Console.WriteLine("\nОперации с целыми числами:");
        Console.WriteLine($"{f1} + 2 = {f1.Add(2)}");
        Console.WriteLine($"{f2} * 3 = {f2.Multiply(3)}");
        Console.WriteLine($"{f3} - 1 = {f3.Subtract(1)}");
        Console.WriteLine($"{f4} / 2 = {f4.Divide(2)}");

        // Цепочка операций как в задании
        Console.WriteLine("\nЦепочка операций: f1.Sum(f2).Div(f3).Minus(5)");
        Fraction chainResult = f1.Sum(f2).Div(f3).Minus(5);
        Console.WriteLine($"{f1}.Sum({f2}).Div({f3}).Minus(5) = {chainResult}");

        Console.ReadLine();
    }
}