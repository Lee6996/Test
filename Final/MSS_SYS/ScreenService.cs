﻿using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MSS_SYS
{
    public class ScreenService
    {
        ScreenDAC dac;
        public ScreenService()
        {
            dac = new ScreenDAC();
        }
        public List<ScreenVO> ScreenSelectInfo(string screenName)
        {
            ScreenDAC dac = new ScreenDAC();
            return dac.SelectScreenInfo(screenName);
        }
        public bool UpdateScreenUseYN(ScreenVO vo)
        {
            dac = new ScreenDAC();
            return dac.UpdateScreenUseYN(vo);
        }
        public DataTable SelectScreenBinding()
        {
            return dac.SelectScreenBinding();
        }
    }
}
