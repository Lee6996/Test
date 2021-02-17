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
    public class Nop_MaService
    {
        public DataTable NopBinding()
        {
            return new Nop_MaDAC().NopBinding();
        }

        public List<Nop_MaVO> GetAllNop_Ma_Master(string nop)
        {
            return new Nop_MaDAC().GetAllNop_Ma_Master(nop);
        }

        public bool InsertNop_Ma(Nop_MaVO vo)
        {
            return new Nop_MaDAC().InsertNop_Ma(vo);
        }

        public bool UpdateNop_Ma(Nop_MaVO vo)
        {
            return new Nop_MaDAC().UpdateNop_Ma(vo);
        }

        public bool InsertUpdateNop_MaVO(Nop_MaVO vo)
        {
            return new Nop_MaDAC().InsertUpdateNop_MaVO(vo);
        }

        public bool UpdateUseYN(Nop_MaVO vo)
        {
            return new Nop_MaDAC().UpdateUseYN(vo) ;
        }
    }
}
