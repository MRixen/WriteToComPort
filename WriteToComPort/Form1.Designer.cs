namespace WriteToComPort
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_motorAngle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox_PortName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox_repetitions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_motorSpeed = new System.Windows.Forms.TextBox();
            this.textBox_information = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Turn motor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_TurnMotor_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 53);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Open port";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_OpenPort_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(232, 53);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Close port";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_ClosePort_Click);
            // 
            // textBox_motorAngle
            // 
            this.textBox_motorAngle.Location = new System.Drawing.Point(125, 117);
            this.textBox_motorAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_motorAngle.Name = "textBox_motorAngle";
            this.textBox_motorAngle.Size = new System.Drawing.Size(99, 22);
            this.textBox_motorAngle.TabIndex = 4;
            this.textBox_motorAngle.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 185);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Turn right";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_TurnRight_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 185);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "Turn left";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_TurnLeft_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 185);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 7;
            this.button6.Text = "Turn middle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_TurnMiddle_Click);
            // 
            // textBox_PortName
            // 
            this.textBox_PortName.Location = new System.Drawing.Point(124, 21);
            this.textBox_PortName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PortName.Name = "textBox_PortName";
            this.textBox_PortName.Size = new System.Drawing.Size(99, 22);
            this.textBox_PortName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Motor angle:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 221);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 11;
            this.button7.Text = "Start Test";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_StartTest_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(123, 221);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 28);
            this.button8.TabIndex = 12;
            this.button8.Text = "Stopp Test";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox_repetitions
            // 
            this.textBox_repetitions.Location = new System.Drawing.Point(123, 259);
            this.textBox_repetitions.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_repetitions.Name = "textBox_repetitions";
            this.textBox_repetitions.Size = new System.Drawing.Size(100, 22);
            this.textBox_repetitions.TabIndex = 13;
            this.textBox_repetitions.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Repetitions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Motor speed:";
            // 
            // textBox_motorSpeed
            // 
            this.textBox_motorSpeed.Location = new System.Drawing.Point(125, 143);
            this.textBox_motorSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_motorSpeed.Name = "textBox_motorSpeed";
            this.textBox_motorSpeed.Size = new System.Drawing.Size(99, 22);
            this.textBox_motorSpeed.TabIndex = 15;
            this.textBox_motorSpeed.Text = "100";
            // 
            // textBox_information
            // 
            this.textBox_information.Location = new System.Drawing.Point(13, 297);
            this.textBox_information.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_information.Multiline = true;
            this.textBox_information.Name = "textBox_information";
            this.textBox_information.Size = new System.Drawing.Size(396, 124);
            this.textBox_information.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 434);
            this.Controls.Add(this.textBox_information);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_motorSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_repetitions);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PortName);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_motorAngle);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_motorAngle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox_PortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox_repetitions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_motorSpeed;
        private System.Windows.Forms.TextBox textBox_information;
    }
}

