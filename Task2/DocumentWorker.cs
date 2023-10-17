using System;

class DocumentWorker
{
    public void OpenDocument()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("�������� ��������");
    }

    public void EditDocument()
    {
        Console.WriteLine("����������� ��������� �������� � ���� - ���");
    }

    public void SaveDocument()
    {
        Console.WriteLine("���������� ��������� �������� � ���� - ���");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public new void EditDocument()
    {
        Console.WriteLine("�������� ������������.");
    }

    public new void SaveDocument()
    {
        Console.WriteLine("�������� ��������� � ������� ������, ���������� � ����� �������� �������� � ���� �������");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public new void SaveDocument()
    {
        Console.WriteLine("�������� ��������� � ������ ������");
    }
}