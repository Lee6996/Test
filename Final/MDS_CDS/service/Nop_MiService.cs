﻿using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_CDS.service
{
     public class Nop_MiService
    {
        public List<Nop_MiVO> GetAllNop_Mi_Master(string nop)
        {
            return new Nop_MiDAC().GetAllNop_Mi_Master(nop);
        }
    }
}
