using FinalDAC;
using FinalVO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    class PRM_PRF_Service
    {
        #region 001
        public void DgvDataBind(DataGridView dgv)
        {
            dgv.DataSource = new PRM_PRF_DAC().Select_001();
        }
        #endregion
    }
}
