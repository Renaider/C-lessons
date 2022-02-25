
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.form2Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.forwardButon = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.form2Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 0;
            // 
            // form2Button
            // 
            this.form2Button.Location = new System.Drawing.Point(0, 0);
            this.form2Button.Name = "form2Button";
            this.form2Button.Size = new System.Drawing.Size(204, 32);
            this.form2Button.TabIndex = 1;
            this.form2Button.Text = "Form 2";
            this.form2Button.UseVisualStyleBackColor = true;
            this.form2Button.Click += new System.EventHandler(this.form2Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.forwardButon);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(733, -1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(64, 32);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 20);
            this.textBox1.TabIndex = 3;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(140, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(64, 32);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // forwardButon
            // 
            this.forwardButon.Location = new System.Drawing.Point(70, 0);
            this.forwardButon.Name = "forwardButon";
            this.forwardButon.Size = new System.Drawing.Size(64, 32);
            this.forwardButon.TabIndex = 2;
            this.forwardButon.Text = "Forward";
            this.forwardButon.UseVisualStyleBackColor = true;
            this.forwardButon.Click += new System.EventHandler(this.forwardButon_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(64, 32);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 64);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(800, 386);
            this.webBrowser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button form2Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button forwardButon;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
    }
}

