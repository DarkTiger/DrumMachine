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
using NAudio.Wave;
using System.Timers;
using System.Threading;
using System.Xml.Linq;


namespace WFDrumMachine
{

    public partial class frmMain : Form
    {
        Image PlayIcon = WFDrumMachine.Properties.Resources.PlayIcon;
        Image StopIcon = WFDrumMachine.Properties.Resources.StopIcon;

        List<string> lstComp1 = new List<string>();

        List<Color> tabRowsColors;

        System.Timers.Timer advanceTimer = new System.Timers.Timer(500); //Timer Avanzato
        delegate void SetTextCallback(string text);  //necessario per il threding del timer avanzato
        delegate void SetColorCallback(Color color); //necessario per il threding del timer avanzato

        int time = 0;
        int nBattuta = 0;
        int nLoops1 = 0;
        int nLoops2 = 0;

        int currentGrid = 1;
        int nGridMax = 2;
        int AddMode = 0;


        Componenti cList;
        CachedSound sndHHOpen, sndHHClose, sndRide, sndSnare, sndKick, sndTom1, sndTom2, sndCrash, sndChina;


        public frmMain()
        {
            InitializeComponent();
            menuStrip.Renderer = new MyRenderer();
            Image PlayIcon = WFDrumMachine.Properties.Resources.PlayIcon;
            Image StopIcon = WFDrumMachine.Properties.Resources.StopIcon;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnPlay.Text == "Play")
                {
                    advanceTimer.Interval = (Convert.ToInt32(1000 / (tbBPM.Value / 60)) / Convert.ToInt32(cmbBPMMultiplier.Text));
                    advanceTimer.Start();
                    btnPlay.Text = "Stop";

                    btnPlay.Image = StopIcon;
                }
                else
                {
                    StopTime();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void StopTime()
        {
            advanceTimer.Stop();
            advanceTimer.Enabled = false;
            SetLabelTime("0");
            SetLabelColor(Color.White);
            SetBtnPlayText("Play");
            btnPlay.Image = PlayIcon;

            time = 0;
            nBattuta = 0;
            nLoops1 = 0;
            nLoops2 = 0;
            currentGrid = 1;

            SetColoriRighe(dgvTab1);
            SetColoriRighe(dgvTab2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                menuStrip.ForeColor = Color.White;


                advanceTimer.Elapsed += new ElapsedEventHandler(TimerTick);
                LoadComponents();
                LoadCmbBpmMultiplier();
                LoadBtnImages();
                tbBPM.Value = 120;

                ////TEST SUONO X VERIFICARE CHE LA SCHEDA AUDIO SIA ATTIVA E CONFIGURATA
                try
                {
                    SoundEngine.Instance.PlaySound(new CachedSound(cList[3].SoundPath, 0f));
                }
                catch (Exception)
                {
                    btnPlay.Enabled = false;
                    MessageBox.Show("Errore nella riproduzione del suono.\n\nControllare che la scheda audio sia abilitata e\nconfigurata per la riproduzione di suoni a 44.100Hz - 16bit", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ///////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadBtnImages()
        {
            btnAddHHOpen1.Image = imageList_Componenti.Images[0];
            btnAddHHClose1.Image = imageList_Componenti.Images[1];
            btnAddRide1.Image = imageList_Componenti.Images[2];
            btnAddSnare1.Image = imageList_Componenti.Images[3];
            btnAddKick1.Image = imageList_Componenti.Images[4];
            btnAddTom11.Image = imageList_Componenti.Images[5];
            btnAddTom21.Image = imageList_Componenti.Images[6];
            btnAddCrash1.Image = imageList_Componenti.Images[7];
            btnAddChina1.Image = imageList_Componenti.Images[8];

            btnAddHHOpen2.Image = imageList_Componenti.Images[0];
            btnAddHHClose2.Image = imageList_Componenti.Images[1];
            btnAddRide2.Image = imageList_Componenti.Images[2];
            btnAddSnare2.Image = imageList_Componenti.Images[3];
            btnAddKick2.Image = imageList_Componenti.Images[4];
            btnAddTom12.Image = imageList_Componenti.Images[5];
            btnAddTom22.Image = imageList_Componenti.Images[6];
            btnAddCrash2.Image = imageList_Componenti.Images[7];
            btnAddChina2.Image = imageList_Componenti.Images[8];
        }

        private void LoadComponents()
        {
            cList = new Componenti();
            this.cList.Add(new Componente(Componente.Type.HiHatOpen, Color.FromArgb(153, 204, 255), Environment.CurrentDirectory + @"\Sounds\HiHatOpen.wav", 1.0f));
            this.cList.Add(new Componente(Componente.Type.HiHatClose, Color.FromArgb(153, 255, 255), Environment.CurrentDirectory + @"\Sounds\HiHatClose.wav", 1.0f));
            this.cList.Add(new Componente(Componente.Type.Ride, Color.FromArgb(255, 204, 153), Environment.CurrentDirectory + @"\Sounds\Ride.wav", 1.0f));
            this.cList.Add(new Componente(Componente.Type.Snare, Color.FromArgb(255, 255, 153), Environment.CurrentDirectory + @"\Sounds\Snare.wav", 1.0f));
            this.cList.Add(new Componente(Componente.Type.Kick, Color.FromArgb(255, 255, 153), Environment.CurrentDirectory + @"\Sounds\Kick.wav", 1.0f));
            this.cList.Add(new Componente(Componente.Type.Tom1, Color.FromArgb(255, 153, 255), Environment.CurrentDirectory + @"\Sounds\Tom1.wav", 1.0f));
            this.cList.Add(new Componente(Componente.Type.Tom2, Color.FromArgb(153, 255, 153), Environment.CurrentDirectory + @"\Sounds\Tom2.wav", 1.0f));
            this.cList.Add(new Componente(Componente.Type.Crash, Color.FromArgb(204, 255, 153), Environment.CurrentDirectory + @"\Sounds\Crash.wav", 1.0f));
            this.cList.Add(new Componente(Componente.Type.China, Color.FromArgb(153, 255, 255), Environment.CurrentDirectory + @"\Sounds\China.wav", 1.0f));


            if (File.Exists(Environment.CurrentDirectory + @"\Settings\Settings.xml"))
            {
                LoadDefaultSettings();
            }

            InizializeTab(dgvTab1);
            InizializeTab(dgvTab2);

            LoadCachedSounds();
            LoadTabRowsColor();
        }

        private void LoadDefaultSettings()
        {
            try
            {

                List<String> listDefaultPaths = new List<String>();
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\HiHatOpen.wav");
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\HiHatClose.wav");
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\Ride.wav");
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\Snare.wav");
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\Kick.wav");
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\Tom1.wav");
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\Tom2.wav");
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\Crash.wav");
                listDefaultPaths.Add(Environment.CurrentDirectory + @"\Sounds\China.wav");


                cList.Clear();

                XElement tmp = XElement.Load(Environment.CurrentDirectory + @"\Settings\Settings.xml");
                Componenti nuovi = new Componenti();

                cList.AddRange(from ElementXMLComponente in tmp.Elements("componente")
                               select new Componente(ElementXMLComponente));

                if (!File.Exists(cList[0].SoundPath))
                {
                    for (int i = 0; i < cList.Count; i++)
                    {
                        cList[i].SoundPath = listDefaultPaths[i];
                    }

                    cList.Salva(Environment.CurrentDirectory + @"\Settings\Settings.xml");

                    MessageBox.Show("I file audio non sono stati trovati nei percorsi indicati.\nSono stati ripristinati al valore di default", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadTabRowsColor();

                SetColoriRighe(dgvTab1);
                SetColoriRighe(dgvTab2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento del file 'Settings'/n" + ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCachedSounds()
        {
            sndHHOpen = new CachedSound(cList[0].SoundPath, cList[0].SoundVolume);
            sndHHClose = new CachedSound(cList[1].SoundPath, cList[1].SoundVolume);
            sndRide = new CachedSound(cList[2].SoundPath, cList[2].SoundVolume);
            sndSnare = new CachedSound(cList[3].SoundPath, cList[3].SoundVolume);
            sndKick = new CachedSound(cList[4].SoundPath, cList[4].SoundVolume);
            sndTom1 = new CachedSound(cList[5].SoundPath, cList[5].SoundVolume);
            sndTom2 = new CachedSound(cList[6].SoundPath, cList[6].SoundVolume);
            sndCrash = new CachedSound(cList[7].SoundPath, cList[7].SoundVolume);
            sndChina = new CachedSound(cList[8].SoundPath, cList[8].SoundVolume);
        }

        private void LoadTabRowsColor()
        {
            if (tabRowsColors != null)
            {
                tabRowsColors.Clear();
            }

            tabRowsColors = new List<Color>();
            for (int i = 0; i < cList.Count; i++)
            {
                Componente c = cList[i];
                tabRowsColors.Add(c.Colore);
            }
        }

        private void LoadCmbBpmMultiplier()
        {
            cmbBPMMultiplier.Items.Add("1");
            cmbBPMMultiplier.Items.Add("2");
            cmbBPMMultiplier.SelectedIndex = 0;
        }

        private void TimerTick(object source, ElapsedEventArgs e)
        {
            DataGridView grid = null;
            nBattuta += 1;

            switch (currentGrid)
            {
                case 1: grid = dgvTab1; break;
                case 2: grid = dgvTab2; break;
            }

            if (nBattuta == 40)
            {
                nBattuta = 0;

                switch (currentGrid)
                {
                    case 1: nLoops1 += 1; break;
                    case 2: nLoops2 += 1; break;
                }

                if (((currentGrid == 1) && (nLoops1 >= nudLoops1.Value)) || ((currentGrid == 2) && (nLoops2 >= nudLoops2.Value)))
                {
                    if (currentGrid < nGridMax + 1)
                    {
                        currentGrid += 1;
                        time = 0;
                        SetLabelTime("0");
                        SetLabelColor(Color.White);
                    }
                    else
                    {
                        StopTime();
                    }
                }

                grid.SuspendLayout();
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    grid.Rows[i].Cells["8/4"].Style.BackColor = grid.Rows[i].DefaultCellStyle.BackColor;
                }
                grid.ResumeLayout();
            }

            if (advanceTimer.Enabled == true && grid != null)
            {
                switch (currentGrid)
                {
                    case 1: grid = dgvTab1; break;
                    case 2: grid = dgvTab2; break;
                }

                if (grid.Columns[nBattuta].Name != "|")
                {
                    PlayDrumSounds(nBattuta, grid);
                }
                else
                {
                    nBattuta += 1;
                    PlayDrumSounds(nBattuta, grid);
                }

                if (time < 4)
                {
                    time += 1;
                }
                else
                {
                    time = 1;
                }

                grid.SuspendLayout();
                for (int i = 0; i < cList.Count; i++)
                {
                    grid.Rows[i].Cells[nBattuta - 1].Style.BackColor = tabRowsColors[i];

                    if (nBattuta == 1)
                    {
                        grid.Rows[i].Cells[40].Style.BackColor = tabRowsColors[i];
                    }

                    if (nBattuta > 2)
                    {
                        grid.Rows[i].Cells[nBattuta - 2].Style.BackColor = tabRowsColors[i];
                    }

                    for (int j = 0; j < grid.Columns.Count; j++)
                    {
                        if (grid.Columns[j].Name == "|")
                        {
                            grid.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        }
                    }
                }
                grid.ResumeLayout();

                if (time == 4)
                {
                    SetLabelColor(Color.Red);
                }
                else
                {
                    SetLabelColor(Color.White);
                }

                SetLabelTime(Convert.ToString(time));
            }
            else
            {
                if (grid == null && ckbRipetiTraccia.Checked)
                {

                    dgvTab2.SuspendLayout();
                    for (int i = 0; i < cList.Count; i++)
                    {
                        dgvTab2.Rows[i].Cells[nBattuta - 1].Style.BackColor = tabRowsColors[i];

                        if (nBattuta == 1)
                        {
                            dgvTab2.Rows[i].Cells[40].Style.BackColor = tabRowsColors[i];
                        }

                        if (nBattuta > 2)
                        {
                            dgvTab2.Rows[i].Cells[nBattuta - 2].Style.BackColor = tabRowsColors[i];
                        }

                        for (int j = 0; j < dgvTab2.Columns.Count; j++)
                        {
                            if (dgvTab2.Columns[j].Name == "|")
                            {
                                dgvTab2.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            }
                        }
                    }
                    dgvTab2.ResumeLayout();

                    SetLabelTime("0");
                    SetLabelColor(Color.White);

                    time = 0;
                    nBattuta = 0;
                    nLoops1 = 0;
                    nLoops2 = 0;
                    currentGrid = 1;
                }
                else
                {
                    StopTime();
                }
            }
        }

        private void SetLabelTime(string text)
        {
            lblTime.SuspendLayout();
            if (this.lblTime.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLabelTime);
                this.Invoke(d, new object[] { text + "/4" });
            }
            else
            {
                this.lblTime.Text = text;
            }
            lblTime.ResumeLayout();
        }

        private void SetBtnPlayText(string text)
        {
            if (this.btnPlay.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetBtnPlayText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.btnPlay.Text = text;
            }
        }

        private void SetLabelColor(Color color)
        {
            lblTime.SuspendLayout();
            if (this.lblTime.InvokeRequired)
            {
                SetColorCallback d = new SetColorCallback(SetLabelColor);
                this.Invoke(d, new object[] { color });
            }
            else
            {
                this.lblTime.ForeColor = color;
            }
            lblTime.ResumeLayout();
        }

        private void InizializeTab(DataGridView grid)
        {
            grid.SuspendLayout();
            grid.DefaultCellStyle.SelectionBackColor = Color.Transparent;

            grid.GridColor = Color.Black;
            grid.Columns.Add("|", "");

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (j == 5)
                    {
                        grid.Columns.Add("|", "");
                        DataGridViewColumn col2 = grid.Columns[i];
                        col2.Width = 0;
                    }
                    else
                    {
                        grid.Columns.Add(Convert.ToString(i) + "/" + Convert.ToString(j), Convert.ToString(i) + "/" + Convert.ToString(j));
                        DataGridViewColumn col = grid.Columns[i];
                        col.Width = 30;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 100, 100, 100);
                        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                        DataGridViewCellStyle style = grid.ColumnHeadersDefaultCellStyle;
                        grid.EnableHeadersVisualStyles = false;
                    }
                }
            }

            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);

            for (int i = 0; i < cList.Count; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Tag = cList[i];
                grid.Rows[i].DefaultCellStyle.BackColor = tabRowsColors[i];
                grid.Rows[i].HeaderCell.Value = "prova";
            }
            grid.ResumeLayout();

            SetColoriRighe(grid);
        }

        private void SetColoreBattitoAttuale(DataGridView grid)
        {
            grid.SuspendLayout();
            for (int i = 0; i < cList.Count; i++)
            {
                grid.Rows[i].Cells[nBattuta].Style.BackColor = Color.Red;
            }
            grid.ResumeLayout();
        }

        private void SetColoriRighe(DataGridView grid)
        {
            grid.SuspendLayout();
            for (int i = 0; i < cList.Count; i++)
            {
                //Componente c = (Componente)grid.Rows[i].Tag;

                for (int j = 0; j < grid.Columns.Count; j++)
                {

                    if (grid.Columns[j].Name == "|" || grid.Columns[j].Name == "Tipo")
                    {
                        //grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 100, 100, 100);
                        grid.Columns[j].HeaderCell.Style.BackColor = Color.Black;

                        grid.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        grid.Columns[j].Width = 0;
                        grid.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                        //grid.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                        grid.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                        grid.EnableHeadersVisualStyles = false;
                    }
                    else
                    {
                        grid.Columns[j].Width = 30;
                        grid.Rows[i].Cells[j].Style.BackColor = tabRowsColors[i];
                        grid.Rows[i].DefaultCellStyle.BackColor = tabRowsColors[i];
                    }
                }
            }
            grid.ClearSelection();
            grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SetLabelTime("0");
            grid.ResumeLayout();
        }

        private void dgvTab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AggiungiRimuoviColpo(sender, e.ColumnIndex, e.RowIndex);
        }

        private void AggiungiRimuoviColpo(object grid, int columnIndex, int rowIndex)
        {

            DataGridView tab = (DataGridView)grid;


            if (columnIndex >= 0 && rowIndex >= 0)
            {
                if ((tab.Columns[columnIndex].Name != "|") && (tab[columnIndex, rowIndex].Value == null))
                {
                    Componente comp = (Componente)tab.Rows[rowIndex].Tag;
                    DataGridViewImageCell cImg = new DataGridViewImageCell();
                    cImg.ImageLayout = DataGridViewImageCellLayout.Normal;

                    if (comp.Tipo == Componente.Type.HiHatOpen)
                    {
                        cImg.Value = imageList_Componenti.Images[0];
                    }
                    else if (comp.Tipo == Componente.Type.HiHatClose)
                    {
                        cImg.Value = imageList_Componenti.Images[1];
                    }
                    else if (comp.Tipo == Componente.Type.Ride)
                    {
                        cImg.Value = imageList_Componenti.Images[2];
                    }
                    else if (comp.Tipo == Componente.Type.Snare)
                    {
                        cImg.Value = imageList_Componenti.Images[3];
                    }
                    else if (comp.Tipo == Componente.Type.Kick)
                    {
                        cImg.Value = imageList_Componenti.Images[4];
                    }
                    else if (comp.Tipo == Componente.Type.Tom1)
                    {
                        cImg.Value = imageList_Componenti.Images[5];
                    }
                    else if (comp.Tipo == Componente.Type.Tom2)
                    {
                        cImg.Value = imageList_Componenti.Images[6];
                    }
                    else if (comp.Tipo == Componente.Type.Crash)
                    {
                        cImg.Value = imageList_Componenti.Images[7];
                    }
                    else if (comp.Tipo == Componente.Type.China)
                    {
                        cImg.Value = imageList_Componenti.Images[8];
                    }
                    else
                    {
                        cImg.Value = imageList_Componenti.Images[9];
                    }
                    tab[columnIndex, rowIndex] = cImg;
                }
                else if ((tab.Columns[columnIndex].Name != "|") && (tab[columnIndex, rowIndex].Value != null))
                {
                    tab[columnIndex, rowIndex] = new DataGridViewTextBoxCell();
                    tab[columnIndex, rowIndex].Value = null;
                    tab.ClearSelection();
                    tab.Refresh();
                }
                tab.ClearSelection();
            }
        }

        private void PlayDrumSounds(int nBattutaAttuale, DataGridView grid)
        {
            try
            {
                //0: HHOpen
                //1: HHClose
                //2: Ride
                //3: Snare
                //4: Kick
                //5: Tom1
                //6: Tom2
                //7: Crash
                //8: China

                if (grid.Rows[0].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlayHHOpen));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }
                if (grid.Rows[1].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlayHHClose));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }
                if (grid.Rows[2].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlayRide));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }
                if (grid.Rows[3].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlaySnare));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }
                if (grid.Rows[4].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlayKick));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }
                if (grid.Rows[5].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlayTom1));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }
                if (grid.Rows[6].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlayTom2));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }
                if (grid.Rows[7].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlayCrash));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }
                if (grid.Rows[8].Cells[nBattutaAttuale].Value != null)
                {
                    Thread t = new Thread(new ThreadStart(PlayChina));
                    t.Priority = ThreadPriority.Highest;
                    t.Start();
                }

                SetColoreBattitoAttuale(grid);
            }
            catch (Exception)
            {
                StopTime();
                MessageBox.Show("Errore nella riproduzione del Suono\nVerificare l'impostazione della scheda audio,\nla riproduzione deve avvenire a 44.100Hz e 16bit", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayHHOpen()
        {
            SoundEngine.Instance.PlaySound(sndHHOpen);
        }

        private void PlayHHClose()
        {
            SoundEngine.Instance.PlaySound(sndHHClose);
        }

        private void PlayRide()
        {
            SoundEngine.Instance.PlaySound(sndRide);
        }

        private void PlaySnare()
        {
            SoundEngine.Instance.PlaySound(sndSnare);
        }

        private void PlayKick()
        {
            SoundEngine.Instance.PlaySound(sndKick);
        }

        private void PlayTom1()
        {
            SoundEngine.Instance.PlaySound(sndTom1);
        }

        private void PlayTom2()
        {
            SoundEngine.Instance.PlaySound(sndTom2);
        }

        private void PlayCrash()
        {
            SoundEngine.Instance.PlaySound(sndCrash);
        }

        private void PlayChina()
        {
            SoundEngine.Instance.PlaySound(sndChina);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundEngine.Instance.Dispose();
        }

        private void dgvTab_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AggiungiRimuoviColpo(sender, e.ColumnIndex, e.RowIndex);
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            BPMChangeKeys(e);
        }

        private void BPMChangeKeys(KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Up)
            {
                if (tbBPM.Value < 240)
                {
                    tbBPM.Value += 1;
                }
            }

            if (key.KeyCode == Keys.Down)
            {
                if (tbBPM.Value > 60)
                {
                    tbBPM.Value -= 1;
                }
            }
        }

        private void dgvTab_KeyDown(object sender, KeyEventArgs e)
        {
            BPMChangeKeys(e);
        }

        private void cmbBPMMultiplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            advanceTimer.Interval = (Convert.ToInt32(1000 / (tbBPM.Value / 60)) / Convert.ToInt32(cmbBPMMultiplier.Text));
        }

        private void dgvTab2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AggiungiRimuoviColpo(sender, e.ColumnIndex, e.RowIndex);
        }

        private void dgvTab2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AggiungiRimuoviColpo(sender, e.ColumnIndex, e.RowIndex);
        }

        private void AggiungiColpiAutoMode(DataGridView grid, int rowIndex)
        {

            for (int i = 0; i < grid.Columns.Count - 1; i++)
            {
                if (grid.Columns[i].Name != "|")
                {
                    grid[i, rowIndex] = new DataGridViewTextBoxCell();
                    grid[i, rowIndex].Value = null;
                }

                if (AddMode == 0 && grid.Columns[i].Name != "|")
                {
                    DataGridViewImageCell cImg = new DataGridViewImageCell();
                    cImg.ImageLayout = DataGridViewImageCellLayout.Normal;
                    cImg.Value = imageList_Componenti.Images[rowIndex];
                    grid[i, rowIndex] = cImg;
                }

                else if (AddMode == 1)
                {
                    if (grid.Columns[i].Name.Contains("/1") || grid.Columns[i].Name.Contains("/3"))
                    {
                        DataGridViewImageCell cImg = new DataGridViewImageCell();
                        cImg.ImageLayout = DataGridViewImageCellLayout.Normal;
                        cImg.Value = imageList_Componenti.Images[rowIndex];
                        grid[i, rowIndex] = cImg;
                    }
                }

                else if (AddMode == 2)
                {
                    if (grid.Columns[i].Name.Contains("/2") || grid.Columns[i].Name.Contains("/4"))
                    {
                        DataGridViewImageCell cImg = new DataGridViewImageCell();
                        cImg.ImageLayout = DataGridViewImageCellLayout.Normal;
                        cImg.Value = imageList_Componenti.Images[rowIndex];
                        grid[i, rowIndex] = cImg;
                    }
                }

                else if (AddMode == 3)
                {
                    if (grid.Columns[i].Name.Contains("/1"))
                    {
                        DataGridViewImageCell cImg = new DataGridViewImageCell();
                        cImg.ImageLayout = DataGridViewImageCellLayout.Normal;
                        cImg.Value = imageList_Componenti.Images[rowIndex];
                        grid[i, rowIndex] = cImg;
                    }
                }

                else if (AddMode == 4)
                {
                    if (grid.Columns[i].Name.Contains("/2"))
                    {
                        DataGridViewImageCell cImg = new DataGridViewImageCell();
                        cImg.ImageLayout = DataGridViewImageCellLayout.Normal;
                        cImg.Value = imageList_Componenti.Images[rowIndex];
                        grid[i, rowIndex] = cImg;
                    }
                }

                else if (AddMode == 5)
                {
                    if (grid.Columns[i].Name.Contains("/3"))
                    {
                        DataGridViewImageCell cImg = new DataGridViewImageCell();
                        cImg.ImageLayout = DataGridViewImageCellLayout.Normal;
                        cImg.Value = imageList_Componenti.Images[rowIndex];
                        grid[i, rowIndex] = cImg;
                    }
                }

                else if (AddMode == 6)
                {
                    if (grid.Columns[i].Name.Contains("/4"))
                    {
                        DataGridViewImageCell cImg = new DataGridViewImageCell();
                        cImg.ImageLayout = DataGridViewImageCellLayout.Normal;
                        cImg.Value = imageList_Componenti.Images[rowIndex];
                        grid[i, rowIndex] = cImg;
                    }
                }
            }

            if (AddMode < 7)
            {
                AddMode += 1;
            }
            else
            {
                AddMode = 0;
            }
        }

        private void btnAddHHOpen_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 0);
        }

        private void btnAddHHClose_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 1);
        }

        private void btnAddRide_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 2);
        }

        private void btnAddSnare_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 3);
        }

        private void btnAddKick_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 4);
        }

        private void btnAddTom1_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 5);
        }

        private void btnAddTom2_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 6);
        }

        private void btnAddCrash_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 7);
        }

        private void btnAddChina_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab1, 8);
        }

        private void btnAddHHOpen2_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 0);
        }

        private void btnAddHHClose2_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 1);
        }

        private void btnAddRide2_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 2);
        }

        private void btnAddSnare2_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 3);
        }

        private void btnAddKick2_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 4);
        }

        private void btnAddTom12_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 5);
        }

        private void btnAddTom22_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 6);
        }

        private void btnAddCrash2_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 7);
        }

        private void btnAddChina2_Click(object sender, EventArgs e)
        {
            AggiungiColpiAutoMode(dgvTab2, 8);
        }

        private void ClearTab(DataGridView grid)
        {
            for (int r = 0; r < grid.Rows.Count; r++)
            {
                for (int c = 0; c < grid.Columns.Count - 1; c++)
                {
                    if (grid.Columns[c].Name != "|")
                    {
                        grid[c, r] = new DataGridViewTextBoxCell();
                        grid[c, r].Value = null;
                    }
                }
            }
        }

        private void btnClearTab1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Svuotare la tab?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                ClearTab(dgvTab1);
            }
        }

        private void btnClearTab2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Svuotare la tab?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                ClearTab(dgvTab2);
            }
        }

        private void ClearRow(DataGridView grid, int rowIndex)
        {
            for (int i = 0; i < grid.Columns.Count - 1; i++)
            {
                if (grid.Columns[i].Name != "|")
                {
                    grid[i, rowIndex] = new DataGridViewTextBoxCell();
                    grid[i, rowIndex].Value = null;
                }
            }
        }

        private void dgvTab1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ClearRow((DataGridView)sender, e.RowIndex);
            }
        }

        private void dgvTab2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ClearRow((DataGridView)sender, e.RowIndex);
            }
        }

        private void tbBPM_Scroll(object sender, EventArgs e)
        {
            advanceTimer.Interval = (Convert.ToInt32(1000 / (tbBPM.Value / 60)) / Convert.ToInt32(cmbBPMMultiplier.Text));
            txbBPMValue.Text = Convert.ToString(tbBPM.Value);
        }

        private void txbBPMValue_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (!int.TryParse(txbBPMValue.Text, out temp))
            {
                MessageBox.Show("Valido non valido!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbBPMValue.Text = "120";
                tbBPM.Value = 120;
            }
        }

        private void SalvaTab()
        {
            List<DataGridView> listaGriglie = new List<DataGridView>();
            listaGriglie.Add(dgvTab1);
            listaGriglie.Add(dgvTab2);
            GestioneSalvataggio gs = new GestioneSalvataggio(listaGriglie);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            sfd.Title = "Salva Tabs";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gs.Salva(sfd.FileName);
            }
        }

        private void ControlloSalvataggio()
        {
            List<DataGridView> tabs = new List<DataGridView>();
            tabs.Add(dgvTab1);
            tabs.Add(dgvTab2);

            bool tabVuote = true;
            for (int t = 0; t < tabs.Count; t++)
            {
                for (int i = 0; i < dgvTab1.Columns.Count; i++)
                {
                    for (int j = 0; j < dgvTab1.Rows.Count; j++)
                    {
                        if (tabs[t][i, j].Value != null)
                        {
                            tabVuote = false;
                            break;
                        }
                    }
                }
            }

            if (!tabVuote)
            {
                if (MessageBox.Show("Salvare la tab corrente?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    SalvaTab();
                }
            }
        }

        private void CaricaTab()
        {
            List<DataGridView> tabs = new List<DataGridView>();
            tabs.Add(dgvTab1);
            tabs.Add(dgvTab2);

            ControlloSalvataggio();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "file XML|*.xml";


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ApriXML(ofd.FileName);
            }
        }


        private void ApriXML(string nomeFile)
        {
            XElement tmp;

            tmp = XElement.Load(nomeFile);

            ClearTab(dgvTab1);
            ClearTab(dgvTab2);

            var tab1 = (from elemento in tmp.Elements("tab")
                        where elemento.Attribute("index").Value == "0"
                        select elemento).First();

            var tab2 = (from elemento in tmp.Elements("tab")
                        where elemento.Attribute("index").Value == "1"
                        select elemento).First();

            string battuteTab1 = tab1.Value;

            int indexBattuteTab1 = 0;

            for (int i = 0; i < dgvTab1.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTab1.Columns.Count; j++)
                {
                    if (dgvTab1.Columns[j].Name != "|")
                    {
                        if (battuteTab1[indexBattuteTab1] != '0')
                        {
                            AggiungiRimuoviColpo(dgvTab1, j, i);
                        }
                        indexBattuteTab1++;
                    }
                }
            }

            string battuteTab2 = tab2.Value;

            int indexBattuteTab2 = 0;

            for (int i = 0; i < dgvTab2.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTab2.Columns.Count; j++)
                {
                    if (dgvTab2.Columns[j].Name != "|")
                    {
                        if (battuteTab2[indexBattuteTab2] != '0')
                        {
                            AggiungiRimuoviColpo(dgvTab2, j, i);
                        }
                        indexBattuteTab2++;
                    }
                }
            }
        }

        private void salvaTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvaTab();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlloSalvataggio();

            this.Close();
        }

        private void caricaTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaricaTab();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTime();

            frmSettings frm = new frmSettings(ref cList);
            frm.ShowDialog();

            LoadTabRowsColor();

            SetColoriRighe(dgvTab1);
            SetColoriRighe(dgvTab2);
        }
    }
}
