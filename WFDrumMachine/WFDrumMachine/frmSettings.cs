using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


namespace WFDrumMachine
{
    public partial class frmSettings : Form
    {

        ColorDialog cd = new ColorDialog();
        OpenFileDialog ofd = new OpenFileDialog();
        Componenti cList;


        public frmSettings(ref Componenti cList)
        {
            InitializeComponent();

            this.cList = cList;
            ofd.Filter = "File Audio|*.wav";
            
            //0: HHOpen
            //1: HHClose
            //2: Ride
            //3: Snare
            //4: Kick
            //5: Tom1
            //6: Tom2
            //7: Crash
            //8: China

            ImpostaSettaggi();
        }

        private void ImpostaSettaggi()
        {
            trackBarHHOpenGain.Value = Convert.ToInt32(cList[0].SoundVolume * 10);
            trackBarHHCloseGain.Value = Convert.ToInt32(cList[1].SoundVolume * 10);
            trackBarRideGain.Value = Convert.ToInt32(cList[2].SoundVolume * 10);
            trackBarSnareGain.Value = Convert.ToInt32(cList[3].SoundVolume * 10);
            trackBarKickGain.Value = Convert.ToInt32(cList[4].SoundVolume * 10);
            trackBarTom1Gain.Value = Convert.ToInt32(cList[5].SoundVolume * 10);
            trackBarTom2Gain.Value = Convert.ToInt32(cList[6].SoundVolume * 10);
            trackBarCrashGain.Value = Convert.ToInt32(cList[7].SoundVolume * 10);
            trackBarChinaGain.Value = Convert.ToInt32(cList[8].SoundVolume * 10);

            lblHHOpenColor.BackColor = cList[0].Colore;
            lblHHOpenColor.ForeColor = cList[0].Colore;
            lblHHCloseColor.BackColor = cList[1].Colore;
            lblHHCloseColor.ForeColor = cList[1].Colore;
            lblRideColor.BackColor = cList[2].Colore;
            lblRideColor.ForeColor = cList[2].Colore;
            lblSnareColor.BackColor = cList[3].Colore;
            lblSnareColor.ForeColor = cList[3].Colore;
            lblKickColor.BackColor = cList[4].Colore;
            lblKickColor.ForeColor = cList[4].Colore;
            lblTom1Color.BackColor = cList[5].Colore;
            lblTom1Color.ForeColor = cList[5].Colore;
            lblTom2Color.BackColor = cList[6].Colore;
            lblTom2Color.ForeColor = cList[6].Colore;
            lblCrashColor.BackColor = cList[7].Colore;
            lblCrashColor.ForeColor = cList[7].Colore;
            lblChinaColor.BackColor = cList[8].Colore;
            lblChinaColor.ForeColor = cList[8].Colore;

            txbHHOpPath.Text = cList[0].SoundPath;
            txbHHClPath.Text = cList[1].SoundPath;
            txbRidePath.Text = cList[2].SoundPath;
            txbSnarePath.Text = cList[3].SoundPath;
            txbKickPath.Text = cList[4].SoundPath;
            txbTom1Path.Text = cList[5].SoundPath;
            txbTom2Path.Text = cList[6].SoundPath;
            txbCrashPath.Text = cList[7].SoundPath;
            txbChinaPath.Text = cList[8].SoundPath;
        }


        private void SetColor(object sender)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = cd.Color;
            lbl.ForeColor = cd.Color;
        }

        private void lblHHOpenColor_Click(object sender, EventArgs e)
        {
            cd.Color = cList[0].Colore;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(sender);
                cList[0].Colore = cd.Color;
            }
        }

        private void lblHHCloseColor_Click(object sender, EventArgs e)
        {
           cd.Color = cList[1].Colore;

           if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
               SetColor(sender);
               cList[1].Colore = cd.Color;
           }
        }
        private void lblRideColor_Click(object sender, EventArgs e)
        {
            cd.Color = cList[2].Colore;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(sender);
                cList[2].Colore = cd.Color;
            }
        }

        private void lblSnareColor_Click(object sender, EventArgs e)
        {
            cd.Color = cList[3].Colore;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(sender);
                cList[3].Colore = cd.Color;
            }
        }

        private void lblKickColor_Click(object sender, EventArgs e)
        {
            cd.Color = cList[4].Colore;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(sender);
                cList[4].Colore = cd.Color;
            }
        }

        private void lblTom1Color_Click(object sender, EventArgs e)
        {
            cd.Color = cList[5].Colore;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(sender);
                cList[5].Colore = cd.Color;
            }
        }

        private void lblTom2Color_Click(object sender, EventArgs e)
        {
            cd.Color = cList[6].Colore;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(sender);
                cList[6].Colore = cd.Color;
            }
        }

        private void lblCrashColor_Click(object sender, EventArgs e)
        {
            cd.Color = cList[7].Colore;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(sender);
                cList[7].Colore = cd.Color; 
            }
        }
        private void lblChinaColor_Click(object sender, EventArgs e)
        {
            cd.Color = cList[8].Colore;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(sender);
                cList[8].Colore = cd.Color;
            }
        }

        private void btnHHOpLoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbHHOpPath.Text = ofd.FileName;
                cList[0].SoundPath = txbHHOpPath.Text;
            }
        }

        private void btnHHCLLoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbHHClPath.Text = ofd.FileName;
                cList[1].SoundPath = txbHHClPath.Text;
            }
        }

        private void btnRideLoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbRidePath.Text = ofd.FileName;
                cList[2].SoundPath = txbRidePath.Text;
            }
        }

        private void btnSnareLoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbSnarePath.Text = ofd.FileName;
                cList[3].SoundPath = txbSnarePath.Text;
            }
        }

        private void btnKickLoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbKickPath.Text = ofd.FileName;
                cList[4].SoundPath = txbKickPath.Text;
            }
        }

        private void btnTom1LoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbTom1Path.Text = ofd.FileName;
                cList[5].SoundPath = txbTom2Path.Text;
            }
        }

        private void btnTom2LoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbTom2Path.Text = ofd.FileName;
                cList[6].SoundPath = txbTom2Path.Text;
            }
        }

        private void btnCrashLoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbCrashPath.Text = ofd.FileName;
                cList[7].SoundPath = txbCrashPath.Text;
            }
        }

        private void btnChinaLoadSound_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbChinaPath.Text = ofd.FileName;
                cList[8].SoundPath = txbChinaPath.Text;
            }
        }


        private void trackBarHHOpenGain_Scroll(object sender, EventArgs e)
        {
            cList[0].SoundVolume = (float)trackBarHHOpenGain.Value / 10;
        }

        private void trackBarHHCloseGain_Scroll(object sender, EventArgs e)
        {
            cList[1].SoundVolume = (float)trackBarHHCloseGain.Value / 10;
        }

        private void trackBarRideGain_Scroll(object sender, EventArgs e)
        {
            cList[2].SoundVolume = (float)trackBarRideGain.Value / 10;
        }

        private void trackBarSnareGain_Scroll(object sender, EventArgs e)
        {
            cList[3].SoundVolume = (float)trackBarSnareGain.Value / 10;
        }

        private void trackBarKickGain_Scroll(object sender, EventArgs e)
        {
            cList[4].SoundVolume = (float)trackBarKickGain.Value / 10;
        }
        
        private void trackBarTom1Gain_Scroll(object sender, EventArgs e)
        {
            cList[5].SoundVolume = (float)trackBarTom1Gain.Value / 10;
        }

        private void trackBarTom2Gain_Scroll(object sender, EventArgs e)
        {
            cList[6].SoundVolume = (float)trackBarTom2Gain.Value / 10;
        }

        private void trackBarCrashGain_Scroll(object sender, EventArgs e)
        {
            cList[7].SoundVolume = (float)trackBarCrashGain.Value / 10;
        }

        private void trackBarChinaGain_Scroll(object sender, EventArgs e)
        {
            cList[8].SoundVolume = (float)trackBarChinaGain.Value / 10;
        }


        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "file XML|*.xml";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cList.OpenXMLFile(ofd.FileName);

                ImpostaSettaggi();
            }
        }

        private void salvaConNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Settaggio XML|*.xml";


            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cList.Salva(sfd.FileName);
            }
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            menuStrip.Renderer = new MyRenderer();
        }
    }
}
