﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_01_20_HomeworkExam_FileManager
{
    public partial class MainForm : Form
    {
        private Size currentThisClientSize;
        private string CurrentClientWidthGetLargerOrSmaller;
        private string CurrentClientHeightGetLargerOrSmaller;
        public MainForm()
        {
            InitializeComponent();
            InitializeSomeControls();
        }
        private void InitializeSomeControls()
        {
            currentThisClientSize = new Size(this.ClientRectangle.Width, this.ClientRectangle.Height);

            tbcTabControl.Width = this.ClientRectangle.Width;
            tbcTabControl.Height = this.ClientRectangle.Height;
            tbcTabControl.Location = new System.Drawing.Point(0, 0);
            this.ClientSizeChanged += (object sender, EventArgs e) => 
            {               
                if (this.ClientRectangle.Width > currentThisClientSize.Width) { lblShowInfo.Location = new Point(lblShowInfo.Location.X + 1, lblShowInfo.Location.Y); CurrentClientWidthGetLargerOrSmaller = "Width get larger"; }
                if (this.ClientRectangle.Width < currentThisClientSize.Width) { lblShowInfo.Location = new Point(lblShowInfo.Location.X - 1, lblShowInfo.Location.Y); CurrentClientWidthGetLargerOrSmaller = "Width get smaller"; }
                if (this.ClientRectangle.Height > currentThisClientSize.Height) { lblShowInfo.Location = new Point(lblShowInfo.Location.X, lblShowInfo.Location.Y + 1); CurrentClientHeightGetLargerOrSmaller = "Height get larger"; }
                if (this.ClientRectangle.Height < currentThisClientSize.Height) { lblShowInfo.Location = new Point(lblShowInfo.Location.X, lblShowInfo.Location.Y - 1); CurrentClientHeightGetLargerOrSmaller = "Height get smaller"; }

                tbcTabControl.Width = this.ClientRectangle.Width;
                tbcTabControl.Height = this.ClientRectangle.Height;
                lblShowInfo.Text = $"{this.ClientRectangle.Width}\n\n{this.ClientRectangle.Height}\n\n {CurrentClientWidthGetLargerOrSmaller}, {CurrentClientHeightGetLargerOrSmaller}";

                currentThisClientSize = this.ClientRectangle.Size;
            };
        }
            
    }
}
