using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureHW
{
    public abstract class Figure
    {
        //Площадь
        public abstract double Area();
        //Периметр
        public abstract double Perimeter();
        public abstract void ToFile();
    }

    public class Retangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        public override void ToFile()
        {
            string _path = "resultRetangle.txt";
            var sw = new StreamWriter(_path, true);
            sw.WriteLine("Площадь прямоугольника = {0}", this.Area());
            sw.WriteLine("Периметр прямоугольника = {0}", this.Perimeter());
            sw.Close();
        }
    }

    public class Rhombus : Figure
    {
        public double Side { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
        public override void ToFile()
        {
            string _path = "resultRhombus.txt";
            var sw = new StreamWriter(_path, true);
            sw.WriteLine("Площадь ромба = {0}", this.Area());
            sw.WriteLine("Периметр ромба = {0}", this.Perimeter());
            sw.Close();
        }
    }
}
