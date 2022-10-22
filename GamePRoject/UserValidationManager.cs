using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DogumYılı == 1999 && gamer.Ad == "rabia" && gamer.Soyad == "demiroğ" 
                && gamer.TcNo == 123456789 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
