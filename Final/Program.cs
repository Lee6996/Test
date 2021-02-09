using Final.YeomGyeongJin.MSS_CON;
using Final.YeomGyeongJin.MSS_SYS;
﻿//using Final.LeeYounggyu;
using Final.YeomGyeongJin.MSS_CON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.PRM_PRF;

namespace Final
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_PRM_PRF_003());
        }
    }
}
