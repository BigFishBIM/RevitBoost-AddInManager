using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInManager
{
    public partial class FormAbout : System.Windows.Forms.Form
    {
        public FormAbout()
        {
            InitializeComponent();
            LinkLabel.Link llStantec = new LinkLabel.Link();
            llStantec.LinkData ="https://www.autodesk.com/products/revit/overview?term=1-YEAR&tab=subscription/";
            linkLabelStantec.Links.Add(llStantec);

            LinkLabel.Link llBoost = new LinkLabel.Link();
            llBoost.LinkData ="https://github.com/BigFishBIM/RevitBoost-AddInManager/";
            linkLabelBoost.Links.Add(llBoost);
        }

        private void linkLabelBoost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabelStantec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
