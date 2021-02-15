using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_ODS.service
{
    class ProcessService
    {
        public DataTable ProcessBindingName()
        {
            return new ProcessDAC().ProcessBindingName();
        }

        public List<ProcessVO> GetAllProcess()
        {
            return new ProcessDAC().GetAllProcess();
        }
    }
}
