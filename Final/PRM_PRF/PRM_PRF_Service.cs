using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    class PRM_PRF_Service
    {
        #region 001
        public List<WorkOrderVO> GetWorkOrderVOList(string dtpFrom, string dtpTo, string processCode = null, string wcCode = null)
        {
            return new SelectDAC().SelectWorkOrder(dtpFrom, dtpTo, processCode, wcCode);
        }

        public bool Correction(WorkOrderVO vo)
        {
            return new PRM_PRF_DAC().Update_001(vo);
        }
        #endregion

        #region 002

        public List<GoodsInHistoryVO> GetGoodsInHistoryVOList(string workorderno)
        {
            return new SelectDAC().SelectGoodsInHistory(workorderno);
        }

        public bool Update002_WO(string workorderno)
        {
            return new PRM_PRF_DAC().UpdateWorkorderStatus(workorderno);
        }

        public bool Update002_Pallet(string palletno)
        {
            return new PRM_PRF_DAC().UpdatePalletStatus(palletno);
        }
        #endregion

        #region 003
        public List<ReceivingListVO> GetSelectReceivingListVOList(string dtpFrom, string dtpTo, string itemCode = null)
        {
            return new SelectDAC().SelectReceivingListVO(dtpFrom, dtpTo, itemCode);
        }
        #endregion

        #region 005

        public List<GVStatusVO> GetGVVOList(string GV_Group = null, string Item_Code = null)
        {
            return new SelectDAC().SelectGVStatus(GV_Group, Item_Code);
        }
        #endregion

        #region 006
        public List<GVHistoryVO> GetGVHistoryVOList(string dtpFrom, string dtpTo, string GV_Code, string Item_Code)
        {
            return new SelectDAC().SelectGVHistory(dtpFrom, dtpTo, GV_Code, Item_Code);
        }
        #endregion

        #region 007
        public List<GV> GetGV(string checkExist = null)
        {
            return new SelectDAC().SelectForPopup<GV>("GV", checkExist);
        }
        #endregion

        #region 008
        public object GetNOPVOList(string dtpFrom, string dtpTo, string WC_Code)
        {
            return new SelectDAC().SelectNOP(dtpFrom, dtpTo, WC_Code);
        }

        public void BindCboWithNopVO(ComboBox cbo)
        {
            cbo.DisplayMember = "Nop_Mi_Name";
            cbo.ValueMember = "Nop_Mi_Code";
            cbo.DataSource = new SelectDAC().SelectForPopup<Nop_Mi>("Nop_Mi");
        }

        internal void BindCboWithWorkCenterVO(ComboBox cbo)
        {
            cbo.DisplayMember = "WC_Name";
            cbo.ValueMember = "WC_Code";
            cbo.DataSource = new SelectDAC().SelectForPopup<WC>("WC");
        }

        internal bool Insert008(NOPVO vo)
        {
            return new PRM_PRF_DAC().InsertNop_History(vo);
        }
        #endregion

        #region 009
        public List<WorkHistoryVO> GetWorkHistoryVOList(string dtpFrom, string dtpTo, string Wc_Name)
        {
            return new SelectDAC().SelectWorkHistory(dtpFrom, dtpTo, Wc_Name);
        }
        #endregion

        #region 010
        public List<AttendanceManagementVO> GetAttendanceManagementVOList(string dtpFrom, string dtpTo, string user_ID)
        {
            return new SelectDAC().SelectAttendanceManagement(dtpFrom, dtpTo, user_ID);
        }

        public DataTable SelectWorkHistoryPivot(string dtpFrom, string dtpTo, string User_ID)
        {
            return new PRM_PRF_DAC().SelectWorkHistoryPivot(dtpFrom, dtpTo, User_ID);
        }
        #endregion
    }
}
