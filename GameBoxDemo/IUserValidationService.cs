using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoxDemo
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
