﻿using System;
using System.Globalization;
using file01;

class Program{
    static void Main(string[] args){
        Triangulo x, y;
        x = new Triangulo();
        y = new Triangulo();
        System.Console.WriteLine("Entre com as medidas do triangulo X: ");
        x.A = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.WriteLine("Entre com as medidas do triangulo Y: ");
        y.A = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

       
        double areaX = x.Area();
        double areaY = y.Area();
        System.Console.WriteLine("Área de x= "+areaX.ToString("F4", CultureInfo.InvariantCulture));
        System.Console.WriteLine("Área de y= "+areaY.ToString("F4", CultureInfo.InvariantCulture));
        if(areaX > areaY){
            System.Console.WriteLine("Maior área é X, com: "+areaX.ToString("F4", CultureInfo.InvariantCulture));
        }
        else {
            System.Console.WriteLine("Maior área é Y, com: "+areaY.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}