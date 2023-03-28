namespace LiteChat
{
    partial class Server
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IPBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RandPort = new System.Windows.Forms.Button();
            this.RanPort = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.OCLI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(44, 15);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(97, 21);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "0.0.0.0";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(44, 49);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(97, 21);
            this.PortBox.TabIndex = 1;
            this.PortBox.Text = "12345";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RandPort
            // 
            this.RandPort.Location = new System.Drawing.Point(147, 14);
            this.RandPort.Name = "RandPort";
            this.RandPort.Size = new System.Drawing.Size(109, 24);
            this.RandPort.TabIndex = 5;
            this.RandPort.Text = "Random Port";
            this.RandPort.UseVisualStyleBackColor = true;
            this.RandPort.Click += new System.EventHandler(this.button2_Click);
            // 
            // RanPort
            // 
            this.RanPort.Location = new System.Drawing.Point(147, 107);
            this.RanPort.Name = "RanPort";
            this.RanPort.Size = new System.Drawing.Size(109, 24);
            this.RanPort.TabIndex = 6;
            this.RanPort.Text = "About";
            this.RanPort.UseVisualStyleBackColor = true;
            this.RanPort.Click += new System.EventHandler(this.button3_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(191, 134);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(65, 12);
            this.Status.TabIndex = 7;
            this.Status.Text = "Waiting...";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kill Me";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // OCLI
            // 
            this.OCLI.Location = new System.Drawing.Point(9, 77);
            this.OCLI.Name = "OCLI";
            this.OCLI.Size = new System.Drawing.Size(132, 54);
            this.OCLI.TabIndex = 9;
            this.OCLI.Text = "Open Client";
            this.OCLI.UseVisualStyleBackColor = true;
            this.OCLI.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(263, 151);
            this.Controls.Add(this.OCLI);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.RanPort);
            this.Controls.Add(this.RandPort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.IPBox);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RandPort;
        private System.Windows.Forms.Button RanPort;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OCLI;
    }
}

