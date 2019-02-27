using System;
using System.Collections.Generic;
using System.Linq;
using BlogDemo.ConsoleApp.Models;
using BlogDemo.ConsoleApp.Services;
using Newtonsoft.Json.Linq;

namespace BlogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var baseUrl = new Api();
            Api swapi = new Api();

            var planet = swapi.GetPlanet("1");
            var planets = swapi.GetAllPlanets();

            var planetNames = new List<string>();
            List<string> planetNameList = planets.results.Select(p => p.name).ToList();

            for(int i = 0; i < planets.results.Count(); i++){
                planetNames.Add(planets.results[i].name);
            }

            Console.WriteLine("Hello Demo!\n");
            Console.WriteLine("Single Planet name, ID of 1:");
            Console.WriteLine(planet.name);
            Console.WriteLine("\n");
            Console.WriteLine("List of planet names by looping through paginated results: ");
            planetNames.ForEach(Console.WriteLine);
            Console.WriteLine("\n");
            Console.WriteLine("List of planet names using projection (LINQ), also paginated:");
            planetNameList.ForEach(Console.WriteLine);
            Console.WriteLine("\n");
        }
    }
}
