using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    class MenuService
    {
        public List<ScreenVO> GetScreenVOList()
        {
            return new ScreenDAC().SelectScreenInfo();
        }
    }
}
