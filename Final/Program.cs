<<<<<<< HEAD
﻿using Final.LeeYounggyu;
using Final.YeomGyeongJin.MSS_CON;
using Final.YeomGyeongJin.MSS_SYS;
=======
﻿using Final.YeomGyeongJin.MSS_CON;
using Final.YeomGyeongJin.MSS_SYS;
﻿using Final.LeeYounggyu;
using Final.YeomGyeongJin.MSS_CON;
>>>>>>> 3a7aa07683cf4215fcbab14f03e3ec439641006b
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new MSS_SYS_001());
        }
    }
}
