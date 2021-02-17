using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_CDS.service
{
    public class Def_MaService
    {
        Def_MaDAC DAC;
        
        public Def_MaService()
        {
            DAC = new Def_MaDAC();
        }
        //public List<Def_MaVO> GetAllDef_Ma_Master()
        //{
        //    return SelectDAC.GetAllDef_Ma_Master();
        //}

        public bool GetUpdateDef_Ma_Master(string groupcode, string used)
        {
            return DAC.Use_YNItem_Level_Master(groupcode, used);
        }

        public bool InsertAllDef_MaVO(Def_MaVO def)
        {
            return DAC.InsertAllDef_Master(def);
        }

        public DataTable DefBinding()
        {
            return DAC.DefBinding();
        }

        public List<Def_MaVO> GetAllDef_Ma_Master(string def)
        {
            return DAC.GetAllDef_Ma_Master(def);
        }

        public bool InsertDef_Ma(Def_MaVO vo)
        {
            return new Def_MaDAC().InsertDef_Ma(vo);
        }

        public bool UpdateDef_Ma(Def_MaVO vo)
        {
            return new Def_MaDAC().UpdateDef_Ma(vo);
        }

        public bool UpdateUseYN(Def_MaVO vo)
        {
            return new Def_MaDAC().UpdateUseYN(vo);
        }

        public bool InsertUpdateDef_MaVO(Def_MaVO additem)
        {
            return new Def_MaDAC().InsertUpdateDef_MaVO(additem);
        }

       
    }
}
