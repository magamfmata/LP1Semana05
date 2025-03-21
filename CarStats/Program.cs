using System;
using Spectre.Console;
using Bogus;
using System.Reflection.Emit;
using System.ComponentModel;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
           Randomizer.Seed = new Random(int.Parse(args[0]));
           Faker faker = new Faker();
           BarChart bc = new BarChart();
           bc.AddItem("Ferrari", 14, faker.Random.Number(1, 20));
           bc.AddItem("Lamborghini", 4, faker.Random.Number(1, 20));
           bc.AddItem("Smart", 4, faker.Random.Number(1, 20));

        }
    }
}
