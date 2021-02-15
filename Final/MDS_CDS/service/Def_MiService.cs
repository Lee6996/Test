using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_CDS.service
{
    public class Def_MiService
    {
        Def_MiDAC DAC;
        public Def_MiService()
        {
            DAC = new Def_MiDAC();
        }

        public List<Def_MiVO> GetAllDef_Mi_Master(string def)
        {
            return DAC.GetAllDef_Mi_Master(def);
        }

        public bool InsertDef_Mi(Def_MiVO vo)
        {
            return new Def_MiDAC().InsertDef_Mi(vo);
        }
        public bool InsertDef_Ma(Def_MaVO vo)
        {
            return new Def_MaDAC().InsertDef_Ma(vo);
        }

        public bool UpdateDef_Mi(Def_MiVO additem)
        {
            return new Def_MiDAC().UpdateDef_Ma(additem);
        }

       
    }
}
