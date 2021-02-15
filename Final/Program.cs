using System;
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
            //폴더 명 앞에 붙여서 위쪽에 유징문 안 생기게 해주세요. 이 부분에서 오류나는 경우 계속 생기네요
            //안 쓰는 유징문 다 지워두겠습니다. -민주
            Application.Run(new PPS_SCH.frm_PPS_SCH_003());
        }
    }
}
