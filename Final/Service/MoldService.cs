using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    public class MoldService
    {
        SelectDAC dac;
        MoldDAC Mdac;
        public MoldService()
        {
            dac = new SelectDAC();
            Mdac = new MoldDAC();
        }
        public List<MoldVO> SelectMold()
        {
            return dac.SelectMold();
        }
        public List<MoldVO> SelectMolds(string Mold_Code = null, string Mold_Group = null)
        {
            return dac.SelectMolds(Mold_Code, Mold_Group);
        }
        public List<MoldVO> SelectMoldGroup(string Mold_Code=null,string Mold_Group=null)
        {
            return dac.SelectMoldGroup(Mold_Code,Mold_Group);
        }
        public List<MoldVO> SelectMoldCode(string Mold_Code = null, string Mold_Group = null)
        {
            return dac.SelectMoldCode(Mold_Code, Mold_Group);
        }
        public List<MoldGroupVO> GetMoldGroup()
        {
            return dac.GetMoldGroup();
        }
        public bool InsertMold(MoldVO vo)
        {
            return Mdac.InsertMold(vo);
        }
        public bool UpdateMold(MoldVO vo)
        {
            return Mdac.UpdateMold(vo);
        }
        public List<MoldUseVO> SelectMoldUse()
        {
            return dac.SelectMoldUse();
        }
        public List<MoldUseVO> SelectMoldUses(string dtpFrom, string dtpTo, string Mold_Code = null, string Mold_Group = null)
        {
            return dac.SelectMoldUses(dtpFrom, dtpTo, Mold_Code, Mold_Group);
        }
        public List<MoldUseVO> SelectMoldUseItem(string dtpFrom, string dtpTo, string Mold_Code = null, string Mold_Group = null)
        {
            return dac.SelectMoldUseItem(dtpFrom, dtpTo, Mold_Code, Mold_Group);
        }
        public List<MoldUseVO> SelectMoldUseWc(string dtpFrom, string dtpTo, string Mold_Code = null, string Mold_Group = null)
        {
            return dac.SelectMoldUseWc(dtpFrom, dtpTo, Mold_Code, Mold_Group);
        }
    }
}
