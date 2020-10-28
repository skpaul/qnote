namespace QNote
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.chkAlwayOnTop = new System.Windows.Forms.CheckBox();
            this.OpacityValueScrollBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPasteCSV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDontChangeOpacity = new System.Windows.Forms.CheckBox();
            this.lblClipboardStatus = new System.Windows.Forms.Label();
            this.lblCreateCsv = new System.Windows.Forms.LinkLabel();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityValueScrollBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ctrl+Arrow";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(1, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Topmost-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(3, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Opacity-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alt+Arrow";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.Color.White;
            this.txtNote.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.Chocolate;
            this.txtNote.Location = new System.Drawing.Point(0, 28);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(223, 158);
            this.txtNote.TabIndex = 7;
            this.txtNote.DoubleClick += new System.EventHandler(this.txtNote_DoubleClick);
            // 
            // chkAlwayOnTop
            // 
            this.chkAlwayOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAlwayOnTop.AutoSize = true;
            this.chkAlwayOnTop.Checked = true;
            this.chkAlwayOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwayOnTop.Location = new System.Drawing.Point(33, 244);
            this.chkAlwayOnTop.Name = "chkAlwayOnTop";
            this.chkAlwayOnTop.Size = new System.Drawing.Size(15, 14);
            this.chkAlwayOnTop.TabIndex = 6;
            this.chkAlwayOnTop.UseVisualStyleBackColor = true;
            this.chkAlwayOnTop.CheckedChanged += new System.EventHandler(this.chkAlwayOnTop_CheckedChanged);
            // 
            // OpacityValueScrollBar
            // 
            this.OpacityValueScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpacityValueScrollBar.Location = new System.Drawing.Point(40, 2);
            this.OpacityValueScrollBar.Maximum = 100;
            this.OpacityValueScrollBar.Minimum = 10;
            this.OpacityValueScrollBar.Name = "OpacityValueScrollBar";
            this.OpacityValueScrollBar.Size = new System.Drawing.Size(183, 45);
            this.OpacityValueScrollBar.TabIndex = 5;
            this.OpacityValueScrollBar.TickFrequency = 10;
            this.OpacityValueScrollBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.OpacityValueScrollBar.Value = 55;
            this.OpacityValueScrollBar.Scroll += new System.EventHandler(this.OpacityValueScrollBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Opacity";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Top";
            // 
            // btnPasteCSV
            // 
            this.btnPasteCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasteCSV.Location = new System.Drawing.Point(136, 212);
            this.btnPasteCSV.Name = "btnPasteCSV";
            this.btnPasteCSV.Size = new System.Drawing.Size(80, 23);
            this.btnPasteCSV.TabIndex = 14;
            this.btnPasteCSV.Text = "&Paste CSV";
            this.btnPasteCSV.UseVisualStyleBackColor = true;
            this.btnPasteCSV.Click += new System.EventHandler(this.btnPasteCSV_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Don\'t Change Opacity";
            // 
            // chkDontChangeOpacity
            // 
            this.chkDontChangeOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDontChangeOpacity.AutoSize = true;
            this.chkDontChangeOpacity.Location = new System.Drawing.Point(206, 243);
            this.chkDontChangeOpacity.Name = "chkDontChangeOpacity";
            this.chkDontChangeOpacity.Size = new System.Drawing.Size(15, 14);
            this.chkDontChangeOpacity.TabIndex = 15;
            this.chkDontChangeOpacity.UseVisualStyleBackColor = true;
            // 
            // lblClipboardStatus
            // 
            this.lblClipboardStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClipboardStatus.AutoSize = true;
            this.lblClipboardStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipboardStatus.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblClipboardStatus.Location = new System.Drawing.Point(50, 187);
            this.lblClipboardStatus.Name = "lblClipboardStatus";
            this.lblClipboardStatus.Size = new System.Drawing.Size(26, 15);
            this.lblClipboardStatus.TabIndex = 17;
            this.lblClipboardStatus.Text = "text";
            // 
            // lblCreateCsv
            // 
            this.lblCreateCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreateCsv.AutoSize = true;
            this.lblCreateCsv.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblCreateCsv.Location = new System.Drawing.Point(156, 189);
            this.lblCreateCsv.Name = "lblCreateCsv";
            this.lblCreateCsv.Size = new System.Drawing.Size(62, 13);
            this.lblCreateCsv.TabIndex = 18;
            this.lblCreateCsv.TabStop = true;
            this.lblCreateCsv.Text = "Create CSV";
            this.myToolTip.SetToolTip(this.lblCreateCsv, "Create CSV with all the text.");
            this.lblCreateCsv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreateCsv_LinkClicked);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Orchid;
            this.label8.Location = new System.Drawing.Point(1, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Clipboard:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 259);
            this.Controls.Add(this.lblClipboardStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCreateCsv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkDontChangeOpacity);
            this.Controls.Add(this.btnPasteCSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.chkAlwayOnTop);
            this.Controls.Add(this.OpacityValueScrollBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QNote";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Deactivate += new System.EventHandler(this.frmMain_Deactivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.OpacityValueScrollBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.CheckBox chkAlwayOnTop;
        private System.Windows.Forms.TrackBar OpacityValueScrollBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPasteCSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDontChangeOpacity;
        private System.Windows.Forms.Label lblClipboardStatus;
        private System.Windows.Forms.LinkLabel lblCreateCsv;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Label label8;
    }
}

