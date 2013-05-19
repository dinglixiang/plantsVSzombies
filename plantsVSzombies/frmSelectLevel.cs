﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace plantsVSzombies
{
    public partial class frmSelectLevel : Form
    {
        public frmSelectLevel()
        {
            InitializeComponent();
            //防止进度条滚动时闪屏（挺管用）
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void frmSelectLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnfirstlevel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLevelOne levelone = new frmLevelOne();
            levelone.Show();
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOptions frmo = new frmOptions();
            frmo.Show();
        }

        private void lblsecondlevel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("偶还没解锁哦！");
        }
    }
}
