using FinalDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    class UserService
    {
        public bool CheckLoginAble(string User_ID, string User_PW)
        {
            return new UserDAC().CheckLoginAble(User_ID, User_PW);
        }
    }
}
