namespace test_stand
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
            this.pid_input_button = new System.Windows.Forms.Button();
            this.pidBox = new System.Windows.Forms.TextBox();
            this.testControl1 = new test_stand.TestControl();
            this.SuspendLayout();
            // 
            // pid_input_button
            // 
            this.pid_input_button.Location = new System.Drawing.Point(367, 337);
            this.pid_input_button.Name = "pid_input_button";
            this.pid_input_button.Size = new System.Drawing.Size(90, 38);
            this.pid_input_button.TabIndex = 1;
            this.pid_input_button.Text = "Выбор изделия";
            this.pid_input_button.UseVisualStyleBackColor = true;
            this.pid_input_button.Click += new System.EventHandler(this.pid_input_button_Click);
            // 
            // pidBox
            // 
            this.pidBox.Location = new System.Drawing.Point(357, 268);
            this.pidBox.Name = "pidBox";
            this.pidBox.Size = new System.Drawing.Size(100, 20);
            this.pidBox.TabIndex = 2;
            this.pidBox.TextChanged += new System.EventHandler(this.pidBox_TextChanged);
            // 
            // testControl1
            // 
            this.testControl1.InputText = "";
            this.testControl1.Location = new System.Drawing.Point(147, 36);
            this.testControl1.Name = "testControl1";
            this.testControl1.ProgramStatus = "AwaitingPid";
            this.testControl1.Size = new System.Drawing.Size(567, 226);
            this.testControl1.TabIndex = 0;
            this.testControl1.Load += new System.EventHandler(this.testControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pidBox);
            this.Controls.Add(this.pid_input_button);
            this.Controls.Add(this.testControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestControl testControl1;
        private System.Windows.Forms.Button pid_input_button;
        private System.Windows.Forms.TextBox pidBox;
    }
}

