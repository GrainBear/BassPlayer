namespace MusicPlayer
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Title = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Min = new System.Windows.Forms.PictureBox();
            this.Button_Close = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.tableLayoutPanel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(323, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            // 
            // tableLayoutPanel_Title
            // 
            this.tableLayoutPanel_Title.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel_Title.ColumnCount = 4;
            this.tableLayoutPanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_Title.Controls.Add(this.Button_Min, 2, 0);
            this.tableLayoutPanel_Title.Controls.Add(this.Button_Close, 3, 0);
            this.tableLayoutPanel_Title.Controls.Add(this.label_Title, 1, 0);
            this.tableLayoutPanel_Title.Controls.Add(this.pictureBox_Logo, 0, 0);
            this.tableLayoutPanel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_Title.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Title.Name = "tableLayoutPanel_Title";
            this.tableLayoutPanel_Title.RowCount = 1;
            this.tableLayoutPanel_Title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Title.Size = new System.Drawing.Size(602, 25);
            this.tableLayoutPanel_Title.TabIndex = 7;
            // 
            // Button_Min
            // 
            this.Button_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Min.Image = ((System.Drawing.Image)(resources.GetObject("Button_Min.Image")));
            this.Button_Min.Location = new System.Drawing.Point(555, 3);
            this.Button_Min.Name = "Button_Min";
            this.Button_Min.Size = new System.Drawing.Size(19, 19);
            this.Button_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Min.TabIndex = 0;
            this.Button_Min.TabStop = false;
            this.Button_Min.Click += new System.EventHandler(this.Button_Min_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Close.Image = ((System.Drawing.Image)(resources.GetObject("Button_Close.Image")));
            this.Button_Close.Location = new System.Drawing.Point(580, 3);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(19, 19);
            this.Button_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Close.TabIndex = 0;
            this.Button_Close.TabStop = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(28, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(521, 25);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "GrainBear KeyGen";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseDown);
            this.label_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseMove);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Logo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(19, 19);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 2;
            this.pictureBox_Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBarControl1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 299);
            this.panel1.TabIndex = 8;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(45, 249);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(493, 10);
            this.progressBarControl1.TabIndex = 7;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tableLayoutPanel_Title.ResumeLayout(false);
            this.tableLayoutPanel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Title;
        private System.Windows.Forms.PictureBox Button_Min;
        private System.Windows.Forms.PictureBox Button_Close;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}

