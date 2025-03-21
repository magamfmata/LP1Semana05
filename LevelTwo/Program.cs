﻿using System;
using SixLabors.ImageSharp;
using Spectre.Console;
using SoGoodLib;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SoGoodClass.SoGoodMethod());
            if (args.Length == 0)
            {
                CanvasImage image = new CanvasImage("tux.jpg");
                image.MaxWidth(24);
                AnsiConsole.Write(image);
            }
            else
            {
                string inputImage = args[0];
                string inputWidthStr = args[1];
                CanvasImage image = new CanvasImage(inputImage);
                int inputW = int.Parse(inputWidthStr);
                image.MaxWidth(inputW);
                AnsiConsole.Write(image);
            }
        }
    }
}
