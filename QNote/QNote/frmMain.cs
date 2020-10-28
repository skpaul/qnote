using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QNote
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.Icon = Properties.Resources.QNoteIco;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = (screenWidth - this.Width)-30;
            lblClipboardStatus.Text = string.Empty;
        }

        private void ChangeOpacity()
        {
            int TrackBarValue = OpacityValueScrollBar.Value;
            double OpacityValue = (double)TrackBarValue / 100;
            this.Opacity = OpacityValue;
        }

        private void OpacityValueScrollBar_Scroll(object sender, EventArgs e)
        {
            ChangeOpacity();
        }

        private void chkAlwayOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkAlwayOnTop.Checked;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            int CurrentValue = OpacityValueScrollBar.Value;

            if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Control)
            {
                if (CurrentValue < OpacityValueScrollBar.Maximum)
                {
                    OpacityValueScrollBar.Value += 1;
                    ChangeOpacity();
                }
                return;
            }

            if (e.KeyCode == Keys.Left && e.Modifiers == Keys.Control)
            {
                if (OpacityValueScrollBar.Minimum < CurrentValue)
                {
                    OpacityValueScrollBar.Value -= 1;
                    ChangeOpacity();
                }
                return;
            }

            if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Alt)
            {
                chkAlwayOnTop.CheckState = CheckState.Checked;
                return;
            }

            if (e.KeyCode == Keys.Down && e.Modifiers == Keys.Alt)
            {
                chkAlwayOnTop.CheckState = CheckState.Unchecked;
                return;
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            //int CurrentValue = OpacityValueScrollBar.Value;

            //for (int i = CurrentValue; i <= 100; i++)
            //{
            if (!chkDontChangeOpacity.Checked)
            {
                OpacityValueScrollBar.Value = 100;
                double OpacityValue = (double)100 / 100;
                this.Opacity = OpacityValue;
            }

            //    System.Threading.Thread.Sleep(1);
            //}


        }

        private void frmMain_Deactivate(object sender, EventArgs e)
        {
            if (!chkDontChangeOpacity.Checked)
            {
                OpacityValueScrollBar.Value = 50;
                double OpacityValue = (double)50 / 100;
                this.Opacity = OpacityValue;
            }


            //int CurrentValue = OpacityValueScrollBar.Value;

            //if (CurrentValue > 50)
            //{
            //    for (int i = CurrentValue; i > 49; i--)
            //    {
            //        OpacityValueScrollBar.Value = i;
            //        double OpacityValue = (double)i / 100;
            //        this.Opacity = OpacityValue;
            //        System.Threading.Thread.Sleep(1);
            //    }
            //}
        }

        private void btnPasteCSV_Click(object sender, EventArgs e)
        {
            string MainText = Clipboard.GetText();
            string[] CsvText = MainText.Split(',');
            foreach (string item in CsvText)
            {
                txtNote.AppendText(item.Trim() + Environment.NewLine);
            }
        }

        //In order to copy the selected text
        private void txtNote_DoubleClick(object sender, EventArgs e)
        {
            string selectedText = txtNote.SelectedText;
            if (string.IsNullOrEmpty(selectedText)) return;
            Clipboard.SetText(selectedText);
            lblClipboardStatus.Text = selectedText;
        }

        private void lblCreateCsv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = txtNote.Text;
            string[] lines=text.Split('\n');
            string csv = string.Empty;
            string parameterizedvalue = string.Empty;
            foreach (string line in lines)
            {
                string value = line.Replace('\n', ' ');
                value = value.Replace('\r',' ');
                value = value.Replace(" ", "");
                if (!string.IsNullOrEmpty(value))
                {
                    csv += value + ", ";
                    parameterizedvalue += "@" + value + ", ";
                }

            }

            string output = csv + Environment.NewLine + parameterizedvalue;
            Clipboard.SetText(output);
        }

        //private void frmMain_MouseHover(object sender, EventArgs e)
        //{
        //    this.Opacity = 1.0;
        //    //if (!chkDontChangeOpacity.Checked)
        //    //{
        //    //    OpacityValueScrollBar.Value = 100;
        //    //    double OpacityValue = (double)100 / 100;
        //    //    this.Opacity = OpacityValue;
        //    //}
        //}

        //private void frmMain_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.Opacity = 0.5;
        //}
        
    }
}
