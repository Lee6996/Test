using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MSS_CON
{
    public class UserService
    {
        SelectDAC dac;
        public UserService()
        {
            dac = new SelectDAC();
        }

        public List<UserVO> SelectUserInfo(string user_name)
        {
            return dac.SelectUserInfo(user_name);
        }
        public DataTable UserNameSelectBinding()
        {
            UserDAC dac = new UserDAC();
            return dac.SelectUserNameBinding();
        }
    }
}
