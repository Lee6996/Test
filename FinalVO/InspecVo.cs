﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class InspecVo
    {
        public string Workorderno { get; set; }
        public string Prd_Date { get; set; }
        public string Process_name { get; set; }
        public string Wc_Name { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Inspect_name { get; set; }
        public decimal USL { get; set; }
        public decimal SL { get; set; }
        public decimal LSL { get; set; }
        public string Inspect_datetime { get; set; }
        public string Item_code { get; set; }
        public string Inspect_measure_seq { get; set; }
        public decimal Inspect_val { get; set; }
    }
}
