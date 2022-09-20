// See https://aka.ms/new-console-template for more information
using FigureHW;
using System;
using System.Drawing;

Console.WriteLine("Выберите фигуру: 1 - Прямоугольник, 2 - Ромб");
string answer = Console.ReadLine();
if(answer == "1")
{
    Console.WriteLine("Введите высоту и ширину: ");
    double heightRet = Convert.ToDouble(Console.ReadLine());
    double widthRet = Convert.ToDouble(Console.ReadLine());
    var MyRetangle = new Retangle { Width = widthRet, Height = heightRet };
    Console.WriteLine("Площадь прямоугольника = {0}", MyRetangle.Area());
    Console.WriteLine("Периметр прямоугольника = {0}", MyRetangle.Perimeter());
    Console.WriteLine("Сохранить результат в файл: 1 - да, 2 - нет");
    string answer2 = Console.ReadLine();
    if (answer2 == "1")
    {
        MyRetangle.ToFile();
    }
}
else if(answer == "2")
{
    Console.WriteLine("Введите длину стороны ромба, " +
        "длину основания ромба и длину высоты ромба: ");
    double sideRom = Convert.ToDouble(Console.ReadLine());
    double heightRom = Convert.ToDouble(Console.ReadLine());
    double widthRom = Convert.ToDouble(Console.ReadLine());
    var MyRhombus = new Rhombus { Side = sideRom, Width = widthRom, Height = heightRom };
    Console.WriteLine("Площадь ромба = {0}", MyRhombus.Area());
    Console.WriteLine("Периметр ромба = {0}", MyRhombus.Perimeter());
    Console.WriteLine("Сохранить результат в файл: 1 - да, 2 - нет");
    string answer3 = Console.ReadLine();
    if( answer3 == "1")
    {
        MyRhombus.ToFile();
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}
