using EjemploLinqDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EjemploLinqDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            MundoDbContext db = new MundoDbContext();

            //INSERT
            //Pais nuevo = new Pais() { Iso = "WW", Nombre = "Costapobre" };

            //db.Pais.Add(nuevo);

            //db.SaveChanges();

            //foreach (Pais p in db.Pais.ToList())
            //{
            //    Console.WriteLine($"{p.Id} {p.Iso} {p.Nombre}");
            //}

            //DELETE
            //Pais nuevo = db.Pais.FirstOrDefault(x => x.Id == 241);

            //db.Pais.Remove(nuevo);

            //db.SaveChanges();

            //UPDATE
            //Pais nuevo = db.Pais.FirstOrDefault(x => x.Id == 240);

            //nuevo.Iso = "DD";

            //db.SaveChanges();

            //SELECT
            //var res = db.Pais.Where(x => x.Nombre.ToUpper().Contains("E"))
            //    .Select(x => new { Id = x.Id, Nombre = x.Nombre});

            //var res = from p in db.Pais.Where(x => x.Nombre.ToUpper().Contains("E"))
            //          //where p.Nombre.ToUpper().Contains("E")
            //          select p;

            var res = db.Pais.FromSql("SELECT id, iso, nombre FROM pais").ToList();

            foreach (var p in res)
            {
                Console.WriteLine($"{p.Id} {p.Nombre}");
            }
            
            Console.ReadKey();
        }
    }
}
