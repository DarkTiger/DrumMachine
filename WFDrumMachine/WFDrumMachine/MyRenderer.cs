using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WFDrumMachine
{
    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }
    }

    public class MyColors : ProfessionalColorTable
    {
        Color c1 = Color.FromArgb(120, 120, 120);
        Color c2 = Color.FromArgb(80, 80, 80);


        public override Color MenuItemSelected
        {
            get { return c1; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return c1; }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return c2; }
        }

        public override Color ToolStripContentPanelGradientBegin
        {
            get { return c1; }
        }

        public override Color ToolStripContentPanelGradientEnd
        {
            get { return c2; }
        }

        public override Color OverflowButtonGradientBegin
        {
            get { return c1; }
        }

        public override Color OverflowButtonGradientEnd
        {
            get { return c2; }
        }

        public override Color ButtonSelectedGradientBegin
        {
            get { return c1; }
        }

        public override Color ButtonSelectedGradientEnd
        {
            get { return c2; }
        }

        public override Color MenuStripGradientBegin
        {
            get { return c1; }
        }

        public override Color MenuStripGradientEnd
        {
            get { return c2; }
        }

        public override Color ToolStripGradientBegin
        {
            get { return c1; }
        }

        public override Color ToolStripGradientEnd
        {
            get { return c2; }
        }

        public override Color StatusStripGradientEnd
        {
            get { return c2; }
        }

        public override Color MenuItemBorder
        {
            get { return c1; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return c1; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return c2; }
        }

        public override Color MenuBorder
        {
            get { return c1; }
        }
    }
}
