using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameOfLifePOC
{
    public partial class Display : Form
    {
        GOL _gol = null;

        Timer _timer = null;
        bool _timerStarted = false;
        
        #region Constructor

        public Display()
        {
            InitializeComponent();
        }

        #endregion

        #region Form opening and closing events

        private void Display_Load(object sender, EventArgs e)
        {
            _gol = new GOL(Convert.ToInt32(this.nup_gridSize.Value), Convert.ToInt32(this.nup_cellSize.Value));
            this._gol.DeadGrid();
            this.pictureBox1.Image = _gol.GenerateBitmap();
            this.pictureBox1.Refresh();
        }

        private void Display_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._timer != null)
            {
                StopTimer();
                this._timer.Dispose();
            }
        }

        #endregion

        #region Timer Related

        private void bt_startTimer_Click(object sender, EventArgs e)
        {
            if (this._gol != null)
            {
                if (this._timerStarted)
                {
                    StopTimer();
                }
                else
                {
                    StartTimer();
                }
            }
        }

        private void StartTimer()
        {
            this._timer = new Timer();
            this._timer.Interval = this.trackBar1.Value;
            this._timer.Tick += _timer_Tick;
            this._timer.Start();

            this._timerStarted = true;
            this.bt_startTimer.Text = "Stop Timer";
        }

        private void StopTimer()
        {
            this._timer.Stop();
            this._timerStarted = false ;
            this.bt_startTimer.Text = "Start Timer";
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            this._gol.ProcessNextStep();
            this.pictureBox1.Image = _gol.GenerateBitmap();
            this.lbl_generations.Text = string.Format("Generations: {0}", this._gol.Generations);
        }

        #endregion

        #region UI Events

        private void bt_Seed_Click(object sender, EventArgs e)
        {
            _gol = new GOL(Convert.ToInt32(this.nup_gridSize.Value), Convert.ToInt32(this.nup_cellSize.Value));
            _gol.RandomizeGrid();
            this.pictureBox1.Image = _gol.GenerateBitmap();
            this.pictureBox1.Refresh();
        }

        private void bt_blank_Click(object sender, EventArgs e)
        {
            _gol = new GOL(Convert.ToInt32(this.nup_gridSize.Value), Convert.ToInt32(this.nup_cellSize.Value));
            this._gol.DeadGrid();
            this.pictureBox1.Image = _gol.GenerateBitmap();
            this.pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this._gol != null)
            {
                this._gol.FlipValueAtCord(e.X, e.Y);
                if (!this._timerStarted)
                {
                    this.pictureBox1.Image = _gol.GenerateBitmap();
                    this.pictureBox1.Refresh();
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (this._timer != null)
            {
                this._timer.Interval = this.trackBar1.Value;
            }
        }

        #endregion

    }
}
