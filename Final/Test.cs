using FinalEnc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class Test : Final.FinalMDIParent
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AESEnc enc = new AESEnc();
            textBox2.Text = enc.AESEncrypt256(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AESEnc enc = new AESEnc();
            textBox3.Text = enc.AESDecrypt256(textBox2.Text);
        }
    }
}
