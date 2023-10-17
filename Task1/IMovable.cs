using System;
using System.Drawing;

// ��������� ��������� IMovable
interface IMovable
{
    void Move(int x, int y);
}

// ���� Vehicle �� ���������� Position � ������ ��������� IMovable
class Vehicle : IMovable
{
    public Point Position { get; set; } // Point ����������� � System.Drawing

    public Vehicle(int x, int y)
    {
        Position = new Point(x, y);
    }

    public void Move(int x, int y)
    {
        Position = new Point(x, y);
    }
}

// ���� Car ��������� Vehicle � ���� ������ ��� ��������� ��������
class Car : Vehicle
{
    public Car(int x, int y) : base(x, y) { }

    public void StartEngine()
    {
        Console.WriteLine("������ ��������");
    }

    public void StopEngine()
    {
        Console.WriteLine("������ ��������");
    }
}