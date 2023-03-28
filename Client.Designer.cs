namespace LiteChat
{
    partial class Client
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.IPB = new System.Windows.Forms.TextBox();
            this.PB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 292);
            this.listBox1.TabIndex = 0;
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(12, 368);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(314, 21);
            this.TB.TabIndex = 1;
            this.TB.Text = "Text in here";
            this.TB.TextChanged += new System.EventHandler(this.TB_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(240, 12);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(137, 49);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // IPB
            // 
            this.IPB.Location = new System.Drawing.Point(47, 12);
            this.IPB.Name = "IPB";
            this.IPB.Size = new System.Drawing.Size(187, 21);
            this.IPB.TabIndex = 4;
            this.IPB.Text = "127.0.0.1";
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(47, 39);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(187, 21);
            this.PB.TabIndex = 5;
            this.PB.Text = "12345";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.IPB);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.listBox1);
            this.Name = "Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox IPB;
        private System.Windows.Forms.TextBox PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}