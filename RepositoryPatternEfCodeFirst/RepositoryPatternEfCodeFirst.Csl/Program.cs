using System;

namespace RepositoryPatternEfCodeFirst.Csl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - Add a player
            //using (var unitOfWork = new UnitOfWork(new RugbyDbContext()))
            //{

            //    var player = new RugbyPlayer()
            //    {
            //        FirstName="Sebastien",
            //        LastName="Chabal",
            //        Number=8
            //    };
            //    unitOfWork.RugbyPlayers.Add(player);
            //    unitOfWork.Complete();
            //}

            // Example 2 - Select all forwards
            //using (var unitOfWork = new UnitOfWork(new RugbyDbContext()))
            //{
            //    var forwards = unitOfWork.RugbyPlayers.GetAllForwards();
            //    foreach (var forward in forwards)
            //        Console.WriteLine($"{forward.FirstName} {forward.LastName} #{forward.Number:00}");
            //}

            // Example 3 - Select a player by its id
            //using (var unitOfWork = new UnitOfWork(new RugbyDbContext()))
            //{
            //    var player = unitOfWork.RugbyPlayers.Get(2);
            //    Console.WriteLine($"{player.FirstName} {player.LastName}");
            //}

            // Example 4 - Delete a player
            //using (var unitOfWork = new UnitOfWork(new RugbyDbContext()))
            //{
            //    var player = unitOfWork.RugbyPlayers.Get(3);
            //    unitOfWork.RugbyPlayers.Remove(player);
            //    unitOfWork.Complete();
            //    Console.WriteLine($"{player.FirstName} {player.LastName} has been removed.");
            //}

            // Example 5 - Update a player
            //using (var unitOfWork = new UnitOfWork(new RugbyDbContext()))
            //{
            //    var player = unitOfWork.RugbyPlayers.Get(1);
            //    player.LastName = "Castaignede";
            //    player.Number = 10;
            //    unitOfWork.Complete();
            //}

            //using (var unitOfWork = new UnitOfWork(new RugbyDbContext()))
            //{
            //    var player = unitOfWork.RugbyPlayers.Get(1);
            //    Console.WriteLine($"{player.FirstName} {player.LastName} #{player.Number}");
            //}

            Console.ReadKey();
        }
    }
}
