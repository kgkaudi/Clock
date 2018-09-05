namespace Clock
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SetAlarm = new System.Windows.Forms.Button();
            this.CancelAlarm = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.worldTime = new System.Windows.Forms.Label();
            this.worldClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clock.Location = new System.Drawing.Point(712, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(102, 39);
            this.clock.TabIndex = 5;
            this.clock.Text = "00:00";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(12, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(251, 39);
            this.date.TabIndex = 6;
            this.date.Text = "1 January 2018";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(719, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 45);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // SetAlarm
            // 
            this.SetAlarm.Location = new System.Drawing.Point(26, 84);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(256, 45);
            this.SetAlarm.TabIndex = 8;
            this.SetAlarm.Text = "Set Alarm";
            this.SetAlarm.UseVisualStyleBackColor = true;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // CancelAlarm
            // 
            this.CancelAlarm.Location = new System.Drawing.Point(375, 84);
            this.CancelAlarm.Name = "CancelAlarm";
            this.CancelAlarm.Size = new System.Drawing.Size(256, 45);
            this.CancelAlarm.TabIndex = 9;
            this.CancelAlarm.Text = "Cancel/Stop Alarm";
            this.CancelAlarm.UseVisualStyleBackColor = true;
            this.CancelAlarm.Click += new System.EventHandler(this.CancelAlarm_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(368, 257);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 39);
            this.Message.TabIndex = 10;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(12, 253);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(113, 39);
            this.Status.TabIndex = 11;
            this.Status.Text = "Status";
            // 
            // cityBox
            // 
            this.cityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Los Angeles, USA",
            "New York, USA",
            "London, UK",
            "Paris, France",
            "Berlin, Germany",
            "Stockholm, Sweden",
            "Athens, Greece",
            "Moscow, Russia",
            "Tehran, Iran",
            "New Delhi, India",
            "Beijing, China",
            "Tokyo, Japan",
            "Sydney, Australia"});
            this.cityBox.Location = new System.Drawing.Point(375, 250);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(600, 46);
            this.cityBox.TabIndex = 12;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // worldTime
            // 
            this.worldTime.AutoSize = true;
            this.worldTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldTime.Location = new System.Drawing.Point(368, 310);
            this.worldTime.Name = "worldTime";
            this.worldTime.Size = new System.Drawing.Size(0, 39);
            this.worldTime.TabIndex = 14;
            // 
            // worldClock
            // 
            this.worldClock.AutoSize = true;
            this.worldClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldClock.Location = new System.Drawing.Point(368, 184);
            this.worldClock.Name = "worldClock";
            this.worldClock.Size = new System.Drawing.Size(0, 39);
            this.worldClock.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.worldClock);
            this.Controls.Add(this.worldTime);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.CancelAlarm);
            this.Controls.Add(this.SetAlarm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.clock);
            this.Name = "Form1";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SetAlarm;
        private System.Windows.Forms.Button CancelAlarm;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label worldTime;
        private System.Windows.Forms.Label worldClock;
    }
}

