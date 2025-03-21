using System;
using Spectre.Console;
using Bogus;
using System.ComponentModel.Design;
using Bogus.DataSets;


namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
           Randomizer.Seed = new Random(int.Parse(args[0]));
           Faker faker = new Faker();

           BarChart bc = new BarChart();

           string car = new Faker().Vehicle.Manufacturer();
           int count = new Faker().Random.Number(1, 20);

            AnsiConsole.Write(bc
            .Label("Car sales")
            .CenterLabel()
            .AddItem(car, count)
            .AddItem(faker.Vehicle.Manufacturer(), faker.Random.Number(1, 20))
            .AddItem(faker.Vehicle.Manufacturer(), faker.Random.Number(1, 20))
           );

           
        }
    }
}
