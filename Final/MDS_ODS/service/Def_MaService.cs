using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_SDS.service
{
    public class Def_MaService
    {
        Def_MaDAC DAC;
        
        public Def_MaService()
        {
            DAC = new Def_MaDAC();
        }
        public List<Def_MaVO> GetAllDef_Ma_Master()
        {
            return SelectDAC.GetAllDef_Ma_Master();
        }

        public bool GetUpdateDef_Ma_Master(string groupcode, string used)
        {
            return DAC.Use_YNItem_Level_Master(groupcode, used);
        }

        public bool InsertAllDef_MaVO(Def_MaVO def)
        {
            return DAC.InsertAllDef_Master(def);
        }
    }
}
