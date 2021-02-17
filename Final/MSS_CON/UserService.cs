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
        //유저이름 바인딩
        public DataTable UserNameSelectBinding()
        {
            UserDAC dac = new UserDAC();
            return dac.SelectUserNameBinding();
        }
        //공정정보 바인딩
        public DataTable DefaultProcessCodeSelectBinding()
        {
            UserDAC dac = new UserDAC();
            return dac.SelectDefaultProcessCodeBinding();
        }

        //사용자등록
        public bool InsertUser(UserVO vo)
        {
            UserDAC dac = new UserDAC();
            return dac.InsertUser(vo);
        }
    }
}
