using System;
using System.Drawing;

// Створюємо інтерфейс IMovable
interface IMovable
{
    void Move(int x, int y);
}

// Клас Vehicle має властивість Position і реалізує інтерфейс IMovable
class Vehicle : IMovable
{
    public Point Position { get; set; } // Point знаходиться в System.Drawing

    public Vehicle(int x, int y)
    {
        Position = new Point(x, y);
    }

    public void Move(int x, int y)
    {
        Position = new Point(x, y);
    }
}

// Клас Car успадковує Vehicle і додає методи для управління двигуном
class Car : Vehicle
{
    public Car(int x, int y) : base(x, y) { }

    public void StartEngine()
    {
        Console.WriteLine("Двигун запущено");
    }

    public void StopEngine()
    {
        Console.WriteLine("Двигун зупинено");
    }
}