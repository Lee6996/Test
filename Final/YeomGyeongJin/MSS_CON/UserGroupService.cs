using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.YeomGyeongJin.MSS_CON
{
    public class UserGroupService
    {
        UserGroupDAC dac;

        public UserGroupService()
        {
            dac = new UserGroupDAC();
        }

        public List<UserGroupVO> UserGroupSelectInfo(string usergoup_Name)
        {
            UserGroupDAC dac = new UserGroupDAC();
            return dac.SelectUserGroupInfo(usergoup_Name);
        }
        public List<UserGroupVO> UserGroupSelectCode_Name(string usergroup_Code, string usergroup_Name)
        {
            return dac.SelectUserGroupInfo(usergroup_Code, usergroup_Name);
        }
        public bool InsertUserGroup(UserGroupVO vo)
        {
            return dac.InsertUserGroup(vo);
        }
        public DataTable UserGroupNameSelectBinding()
        {
            return dac.SelectUserGroupNameBinding();
        }
    }
}
