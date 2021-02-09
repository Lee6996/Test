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
        public List<WorkOrderVO> GetWorkOrderVOList(string dtpFrom, string dtpTo, string processCode= null, string wcCode = null)
        {
            return new SelectDAC().SelectWorkOrder(dtpFrom, dtpTo, processCode, wcCode);
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

        public bool Update002_WO(string workorderno, UserVO user)
        {
            return new PRM_PRF_DAC().UpdateWorkorderStatus(workorderno, user);
        }

        public bool Update002_Pallet(string palletno, UserVO user)
        {
            return new PRM_PRF_DAC().UpdatePalletStatus(palletno, user);
        }
        #endregion

        #region 003
        public List<ReceivingListVO> GetSelectReceivingListVOList(string dtpFrom, string dtpTo, string itemCode = null)
        {
            return new SelectDAC().SelectReceivingListVO(dtpFrom, dtpTo, itemCode);
        }
        #endregion

        #region 005

        public List<GVStatusVO> GetGVVOList(string GV_Group, string Item_Code)
        {
            return new SelectDAC().SelectGVStatus(GV_Group, Item_Code);
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
        internal object GetNOPVOList(string dtpFrom, string dtpTo)
        {
            return new SelectDAC().SelectNOP(dtpFrom, dtpTo);
        }
        #endregion

        #region 009
        public List<WorkHistoryVO> GetWorkHistoryVOList()
        {
            return new SelectDAC().SelectWorkHistory();
        }

        public List<AttendanceManagementVO> GetAttendanceManagementVOList()
        {
            return new SelectDAC().SelectAttendanceManagement();
        }

        
        #endregion
    }
}
