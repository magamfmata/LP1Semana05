﻿using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main()
        {
            CanvasImage image = new CanvasImage("tux.jpg");

            image.MaxWidth(20);

            AnsiConsole.Write(image);

        }
    }
}
