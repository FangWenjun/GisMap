using System;
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

            GisSet.GisSetControl m_GisSetControl = new GisSet.GisSetControl();
        }
    }
}
