using System;

namespace GameBoxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2002, FirstName = "EREN", LastName = "YAYLACI" ,IdentityNumber=1234564897});





        }
    }
}
