using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {        
                DogumYılı = 1999,
                Ad = "rabia",
                Soyad="demiroğ",
                TcNo=123456789,
            });
            
           

        }
        
    }
}
