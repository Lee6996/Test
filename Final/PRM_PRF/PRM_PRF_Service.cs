using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    class PRM_PRF_Service
    {
        #region 001
        public List<WorkOrderVO> GetWorkOrderVOList()
        {
            return new PRM_PRF_DAC().Select_001();
        }

        public bool Correction(WorkOrderVO vo)
        {
           return new PRM_PRF_DAC().Update_001(vo);
        }
        #endregion

        #region 002

        #endregion

        #region 003
        #endregion

        #region 004
        #endregion

        #region 005
        #endregion

        #region 006
        #endregion

        #region 007
        #endregion

        #region 008
        #endregion

        #region 009
        public List<WorkHistoryVO> GetWorkHistoryVOList()
        {
           return new PRM_PRF_DAC().Select_009();
        }

        public void BindDGV_010_1(DataGridView dgv, string Start_Date, string End_Date)
        {
            dgv.DataSource = new PRM_PRF_DAC().Select_010_1(Start_Date, End_Date);
        }

        public List<AttendanceManagementVO> GetAttendanceManagementVOList()
        {
            return new PRM_PRF_DAC().Select_010_2();
        }
        #endregion
    }
}
