using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoxDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2002 && gamer.FirstName == "EREN" && gamer.LastName == "YAYLACI")
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
