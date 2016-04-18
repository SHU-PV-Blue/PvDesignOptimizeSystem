using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;

namespace PvDesignOptimizeSystem
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void navButton3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.navButton2.setActive(true);
            this.webBrowser1.ObjectForScripting = this;
        }

        public void getLngLat(string lng, string lat)
        {
            this.txt_lng.Text = lng.ToString();
            this.txt_lat.Text = lat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lng = this.txt_lng.Text;
            string lat = this.txt_lat.Text;
            this.webBrowser1.Document.InvokeScript("moveToPoint", new object[]{
                lng,lat
            });
        }

    }
}
