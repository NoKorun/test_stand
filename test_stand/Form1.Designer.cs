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
            this.label1 = new System.Windows.Forms.Label();
            this.stop_test_button = new System.Windows.Forms.Button();
            this.test3 = new System.Windows.Forms.Button();
            this.test2 = new System.Windows.Forms.Button();
            this.test1 = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ожидается ввод идентификатора изделия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stop_test_button
            // 
            this.stop_test_button.Location = new System.Drawing.Point(374, 219);
            this.stop_test_button.Name = "stop_test_button";
            this.stop_test_button.Size = new System.Drawing.Size(75, 23);
            this.stop_test_button.TabIndex = 8;
            this.stop_test_button.Text = "Остановка теста";
            this.stop_test_button.UseVisualStyleBackColor = true;
            this.stop_test_button.Click += new System.EventHandler(this.stop_test_button_Click);
            // 
            // test3
            // 
            this.test3.Location = new System.Drawing.Point(554, 169);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(75, 23);
            this.test3.TabIndex = 7;
            this.test3.Text = "Тест3";
            this.test3.UseVisualStyleBackColor = true;
            this.test3.Click += new System.EventHandler(this.test3_Click);
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(374, 169);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(75, 23);
            this.test2.TabIndex = 6;
            this.test2.Text = "Тест2";
            this.test2.UseVisualStyleBackColor = true;
            this.test2.Click += new System.EventHandler(this.test2_Click);
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(177, 169);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(75, 23);
            this.test1.TabIndex = 5;
            this.test1.Text = "Тест1";
            this.test1.UseVisualStyleBackColor = true;
            this.test1.Click += new System.EventHandler(this.test1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_test_button);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.pidBox);
            this.Controls.Add(this.pid_input_button);
            this.Name = "Form1";
            this.Text = "Программа тестирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pid_input_button;
        private System.Windows.Forms.TextBox pidBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop_test_button;
        private System.Windows.Forms.Button test3;
        private System.Windows.Forms.Button test2;
        private System.Windows.Forms.Button test1;
    }
}

