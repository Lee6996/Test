using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_CDS.service
{
    public class BoxingGrade_Detail_MasterService
    {
        public List<BoxingGrade_Detail_MasterVO> GetAllBox_Detail_Master(string box)
        {
            return new BoxingGrade_Detail_MasterDAC().GetAllBox_Detail_Master(box);
        }

        public bool InsertBox_Detail(BoxingGrade_Detail_MasterVO additem)
        {
            return new BoxingGrade_Detail_MasterDAC().InsertBox_Detail(additem);
        }

        public bool UpdateBox_Detail(BoxingGrade_Detail_MasterVO additem)
        {
            return new BoxingGrade_Detail_MasterDAC().UpdateBox_Detail(additem);
        }

        public List<BoxingGrade_Detail_MasterVO> GetAllBoxMa(string box)
        {
            return new BoxingGrade_Detail_MasterDAC().GetAllBoxMa(box);
        }
    }
}
