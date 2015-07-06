namespace Click_Paster_WinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.recordButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.eventBox = new System.Windows.Forms.TextBox();
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.loopBox = new System.Windows.Forms.CheckBox();
            this.looptimesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recordButton
            // 
            this.recordButton.BackColor = System.Drawing.Color.Red;
            this.recordButton.Location = new System.Drawing.Point(13, 13);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(75, 23);
            this.recordButton.TabIndex = 0;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = false;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playButton.Location = new System.Drawing.Point(13, 43);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Black;
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(13, 73);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // eventBox
            // 
            this.eventBox.Location = new System.Drawing.Point(106, 13);
            this.eventBox.Multiline = true;
            this.eventBox.Name = "eventBox";
            this.eventBox.ReadOnly = true;
            this.eventBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventBox.Size = new System.Drawing.Size(223, 160);
            this.eventBox.TabIndex = 3;
            this.eventBox.Text = "EVENTS:";
            // 
            // playTimer
            // 
            this.playTimer.Interval = 200;
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(13, 102);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(75, 20);
            this.intervalBox.TabIndex = 4;
            // 
            // loopBox
            // 
            this.loopBox.AutoSize = true;
            this.loopBox.Location = new System.Drawing.Point(13, 131);
            this.loopBox.Name = "loopBox";
            this.loopBox.Size = new System.Drawing.Size(50, 17);
            this.loopBox.TabIndex = 5;
            this.loopBox.Text = "Loop";
            this.loopBox.UseVisualStyleBackColor = true;
            // 
            // looptimesBox
            // 
            this.looptimesBox.Location = new System.Drawing.Point(13, 153);
            this.looptimesBox.Name = "looptimesBox";
            this.looptimesBox.Size = new System.Drawing.Size(75, 20);
            this.looptimesBox.TabIndex = 6;
            this.looptimesBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(341, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.looptimesBox);
            this.Controls.Add(this.loopBox);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.recordButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mouse Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox eventBox;
        private System.Windows.Forms.Timer playTimer;
        private System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.CheckBox loopBox;
        private System.Windows.Forms.TextBox looptimesBox;
        private System.Windows.Forms.Label label1;
    }
}

