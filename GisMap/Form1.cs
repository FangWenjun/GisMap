﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxMapWinGIS;
using MapWinGIS;
using GisSet;

namespace GisMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Gis控件的动态加载
            AxMap axMap1 = new AxMap();
            ((System.ComponentModel.ISupportInitialize)(axMap1)).BeginInit();
            this.Controls.Add(axMap1);
            ((System.ComponentModel.ISupportInitialize)(axMap1)).EndInit();
            axMap1.Enabled = true;
            axMap1.Location = new System.Drawing.Point(0, 0);
            axMap1.Name = "axMap1";
            //   axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            axMap1.Size = new System.Drawing.Size(560, 413);
            //     axMap1.TabIndex = 2;
            
            //GisSet控件的动态加载
            GisSetControl m_GisSetControl = new GisSetControl();
            this.Controls.Add(m_GisSetControl);
            m_GisSetControl.Location = new System.Drawing.Point(0, 400);
            m_GisSetControl.Size = new System.Drawing.Size(560, 100);

            m_GisSetControl.MAP = axMap1;
          
        }
    }
}
