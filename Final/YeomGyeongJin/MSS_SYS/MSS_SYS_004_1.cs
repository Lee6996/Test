﻿using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frm_MSS_SYS_004_1 : Form
    {
        SysNoticeVO SysNoticeVO;
        public frm_MSS_SYS_004_1()
        {
            InitializeComponent();
        }
        public frm_MSS_SYS_004_1(SysNoticeVO SysNoticeVO)
        {
            InitializeComponent();
            this.SysNoticeVO = SysNoticeVO;
        }
    }
}
