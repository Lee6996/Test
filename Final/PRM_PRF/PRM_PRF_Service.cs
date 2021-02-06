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
        public List<WorkOrderVO> GetWorkOrderVOList(string dtpFrom, string dtpTo)
        {
            return new SelectDAC().SelectWorkOrder(dtpFrom, dtpTo);
        }

        public bool Correction(WorkOrderVO vo, UserVO user)
        {
           return new PRM_PRF_DAC().Update_001(vo, user);
        }
        #endregion

        #region 002

        public List<GoodsInHistoryVO> GetGoodsInHistoryVOList(string workorderno)
        {
            return new SelectDAC().SelectGoodsInHistory(workorderno);
        }
        #endregion

        #region 003
        public List<ReceivingListVO> GetSelectReceivingListVOList(string dtpFrom, string dtpTo)
        {
            return new SelectDAC().SelectReceivingListVO(dtpFrom, dtpTo);
        }
        #endregion

        #region 005
        public void BindDGV_005(DataGridView dgv)
        {
            dgv.DataSource = new SelectDAC().SelectGVStatus();
        }
        #endregion

        #region 006
        public List<GVHistoryVO> GetGVHistoryVOList(string dtpFrom, string dtpTo)
        {
            return new SelectDAC().SelectGVHistory(dtpFrom, dtpTo);
        }
        #endregion

        #region 007
        #endregion

        #region 008
        #endregion

        #region 009
        public List<WorkHistoryVO> GetWorkHistoryVOList()
        {
            return new SelectDAC().SelectWorkHistory();
        }

        public void BindDGV_010_1(DataGridView dgv, string Start_Date, string End_Date)
        {
            dgv.DataSource = new PRM_PRF_DAC().Select_010_1(Start_Date, End_Date);
        }

        public List<AttendanceManagementVO> GetAttendanceManagementVOList()
        {
            return new SelectDAC().SelectAttendanceManagement();
        }
        #endregion
    }
}
