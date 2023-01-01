using System.Data.SQLite;
using System.Diagnostics;
using Dapper;
// using Microsoft.Data.Sqlite;
// using NetTopologySuite;
// using NetTopologySuite.Geometries;

namespace ExtensionsSample
{
    static class Program
    {
        static void Main()
        {
            // var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
            // var currentLocation = geometryFactory.CreatePoint(new Coordinate(-69.938951, 18.481188));

            // using var context = new SportsGroundContext();
            // context.Database.EnsureCreated();
            // var list = new List<SportsGround>()
            //     {
            //         new SportsGround()
            //         {
            //             Name = "Sports Complex",
            //             Location = geometryFactory.CreatePoint(new Coordinate(-69.9388777, 18.4839233)),
            //         },

            //         new SportsGround()
            //         {
            //             Name = "Gaddafi Stadium",
            //             Location = geometryFactory.CreatePoint(new Coordinate(-69.9118804, 18.4826214)),
            //         },

            //         new SportsGround()
            //         {
            //             Name = "Internation Sports Stadium",
            //             Location = geometryFactory.CreatePoint(new Coordinate(-69.9334673, 18.4718075)),
            //         }
            //     };

            // context.SportsGround.AddRange(list);
            // context.SaveChanges();


            // var grounds = context.SportsGround
            //     .OrderBy(x => x.Location.Distance(currentLocation))
            //     .Where(x => x.Location.IsWithinDistance(currentLocation, 2000))
            //     .Select(x => new { x.Name, Distance = x.Location.Distance(currentLocation) })
            //     .ToList();

            // foreach (var ground in grounds)
            // {
            //     Console.WriteLine($"{ground.Name} ({ground.Distance:N0} meters away)");
            // }

            SqlMapper.

            // SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_dynamic_cdecl());

            var connection = new SQLiteConnection("Data Source=:memory:");
            connection.Open();

            // Load the SpatiaLite extension
            // connection.EnableExtensions();
            connection.LoadExtension("mod_spatialite");

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT spatialite_version()
            ";
            var version = (string)command.ExecuteScalar();

            Debug.WriteLine($"Using SpatiaLite {version}");
        }
    }
}