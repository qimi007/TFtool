namespace SDmakeTool
{
    partial class formTool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTool));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_regular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_regular = new System.Windows.Forms.TextBox();
            this.tb_srcdir = new System.Windows.Forms.TextBox();
            this.tb_destdir = new System.Windows.Forms.TextBox();
            this.btn_srcdir = new System.Windows.Forms.Button();
            this.btn_destdir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ctrl = new System.Windows.Forms.Button();
            this.gb_dir = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.gb_cateinfo = new System.Windows.Forms.GroupBox();
            this.cb_per8 = new System.Windows.Forms.CheckBox();
            this.cb_per7 = new System.Windows.Forms.CheckBox();
            this.cb_per6 = new System.Windows.Forms.CheckBox();
            this.cb_per5 = new System.Windows.Forms.CheckBox();
            this.cb_per4 = new System.Windows.Forms.CheckBox();
            this.cb_per3 = new System.Windows.Forms.CheckBox();
            this.cb_per2 = new System.Windows.Forms.CheckBox();
            this.cb_per1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.pgb_run = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cb_per9 = new System.Windows.Forms.CheckBox();
            this.cb_per10 = new System.Windows.Forms.CheckBox();
            this.gb_dir.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_cateinfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_regular
            // 
            resources.ApplyResources(this.btn_regular, "btn_regular");
            this.btn_regular.Name = "btn_regular";
            this.toolTip1.SetToolTip(this.btn_regular, resources.GetString("btn_regular.ToolTip"));
            this.btn_regular.UseVisualStyleBackColor = true;
            this.btn_regular.Click += new System.EventHandler(this.btn_regular_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tb_regular
            // 
            resources.ApplyResources(this.tb_regular, "tb_regular");
            this.tb_regular.Name = "tb_regular";
            // 
            // tb_srcdir
            // 
            resources.ApplyResources(this.tb_srcdir, "tb_srcdir");
            this.tb_srcdir.Name = "tb_srcdir";
            // 
            // tb_destdir
            // 
            resources.ApplyResources(this.tb_destdir, "tb_destdir");
            this.tb_destdir.Name = "tb_destdir";
            // 
            // btn_srcdir
            // 
            resources.ApplyResources(this.btn_srcdir, "btn_srcdir");
            this.btn_srcdir.Name = "btn_srcdir";
            this.toolTip1.SetToolTip(this.btn_srcdir, resources.GetString("btn_srcdir.ToolTip"));
            this.btn_srcdir.UseVisualStyleBackColor = true;
            this.btn_srcdir.Click += new System.EventHandler(this.btn_srcdir_Click);
            // 
            // btn_destdir
            // 
            resources.ApplyResources(this.btn_destdir, "btn_destdir");
            this.btn_destdir.Name = "btn_destdir";
            this.toolTip1.SetToolTip(this.btn_destdir, resources.GetString("btn_destdir.ToolTip"));
            this.btn_destdir.UseVisualStyleBackColor = true;
            this.btn_destdir.Click += new System.EventHandler(this.btn_destdir_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btn_ctrl
            // 
            resources.ApplyResources(this.btn_ctrl, "btn_ctrl");
            this.btn_ctrl.Name = "btn_ctrl";
            this.toolTip1.SetToolTip(this.btn_ctrl, resources.GetString("btn_ctrl.ToolTip"));
            this.btn_ctrl.UseVisualStyleBackColor = true;
            this.btn_ctrl.Click += new System.EventHandler(this.btn_ctrl_Click);
            // 
            // gb_dir
            // 
            this.gb_dir.Controls.Add(this.tb_destdir);
            this.gb_dir.Controls.Add(this.btn_regular);
            this.gb_dir.Controls.Add(this.tb_srcdir);
            this.gb_dir.Controls.Add(this.btn_srcdir);
            this.gb_dir.Controls.Add(this.tb_regular);
            this.gb_dir.Controls.Add(this.btn_destdir);
            this.gb_dir.Controls.Add(this.label3);
            this.gb_dir.Controls.Add(this.label1);
            this.gb_dir.Controls.Add(this.label2);
            resources.ApplyResources(this.gb_dir, "gb_dir");
            this.gb_dir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_dir.Name = "gb_dir";
            this.gb_dir.TabStop = false;
            this.gb_dir.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Name = "lblTitle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_info);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tb_info
            // 
            this.tb_info.AllowDrop = true;
            resources.ApplyResources(this.tb_info, "tb_info");
            this.tb_info.Name = "tb_info";
            this.tb_info.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gb_cateinfo
            // 
            this.gb_cateinfo.Controls.Add(this.cb_per10);
            this.gb_cateinfo.Controls.Add(this.cb_per9);
            this.gb_cateinfo.Controls.Add(this.cb_per8);
            this.gb_cateinfo.Controls.Add(this.cb_per7);
            this.gb_cateinfo.Controls.Add(this.cb_per6);
            this.gb_cateinfo.Controls.Add(this.cb_per5);
            this.gb_cateinfo.Controls.Add(this.cb_per4);
            this.gb_cateinfo.Controls.Add(this.cb_per3);
            this.gb_cateinfo.Controls.Add(this.cb_per2);
            this.gb_cateinfo.Controls.Add(this.cb_per1);
            resources.ApplyResources(this.gb_cateinfo, "gb_cateinfo");
            this.gb_cateinfo.Name = "gb_cateinfo";
            this.gb_cateinfo.TabStop = false;
            // 
            // cb_per8
            // 
            resources.ApplyResources(this.cb_per8, "cb_per8");
            this.cb_per8.Name = "cb_per8";
            this.cb_per8.UseVisualStyleBackColor = true;
            // 
            // cb_per7
            // 
            resources.ApplyResources(this.cb_per7, "cb_per7");
            this.cb_per7.Name = "cb_per7";
            this.cb_per7.UseVisualStyleBackColor = true;
            // 
            // cb_per6
            // 
            resources.ApplyResources(this.cb_per6, "cb_per6");
            this.cb_per6.Name = "cb_per6";
            this.cb_per6.UseVisualStyleBackColor = true;
            // 
            // cb_per5
            // 
            resources.ApplyResources(this.cb_per5, "cb_per5");
            this.cb_per5.Name = "cb_per5";
            this.cb_per5.UseVisualStyleBackColor = true;
            this.cb_per5.CheckedChanged += new System.EventHandler(this.cb_per5_CheckedChanged);
            // 
            // cb_per4
            // 
            resources.ApplyResources(this.cb_per4, "cb_per4");
            this.cb_per4.Name = "cb_per4";
            this.cb_per4.UseVisualStyleBackColor = true;
            // 
            // cb_per3
            // 
            resources.ApplyResources(this.cb_per3, "cb_per3");
            this.cb_per3.Name = "cb_per3";
            this.cb_per3.UseVisualStyleBackColor = true;
            // 
            // cb_per2
            // 
            resources.ApplyResources(this.cb_per2, "cb_per2");
            this.cb_per2.Name = "cb_per2";
            this.cb_per2.UseVisualStyleBackColor = true;
            // 
            // cb_per1
            // 
            resources.ApplyResources(this.cb_per1, "cb_per1");
            this.cb_per1.Name = "cb_per1";
            this.cb_per1.UseVisualStyleBackColor = true;
            this.cb_per1.Click += new System.EventHandler(this.cb_per1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ctrl);
            this.panel1.Controls.Add(this.linkLabel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_time);
            this.panel2.Controls.Add(this.pgb_run);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_time
            // 
            resources.ApplyResources(this.lbl_time, "lbl_time");
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Tag = "0";
            // 
            // pgb_run
            // 
            resources.ApplyResources(this.pgb_run, "pgb_run");
            this.pgb_run.Name = "pgb_run";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cb_per9
            // 
            resources.ApplyResources(this.cb_per9, "cb_per9");
            this.cb_per9.Name = "cb_per9";
            this.cb_per9.UseVisualStyleBackColor = true;
            // 
            // cb_per10
            // 
            resources.ApplyResources(this.cb_per10, "cb_per10");
            this.cb_per10.Name = "cb_per10";
            this.cb_per10.UseVisualStyleBackColor = true;
            // 
            // formTool
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_cateinfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gb_dir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTool";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.formTool_Load);
            this.Shown += new System.EventHandler(this.formTool_Shown);
            this.Enter += new System.EventHandler(this.formTool_Enter);
            this.gb_dir.ResumeLayout(false);
            this.gb_dir.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_cateinfo.ResumeLayout(false);
            this.gb_cateinfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_regular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_regular;
        private System.Windows.Forms.TextBox tb_srcdir;
        private System.Windows.Forms.TextBox tb_destdir;
        private System.Windows.Forms.Button btn_srcdir;
        private System.Windows.Forms.Button btn_destdir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gb_dir;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.GroupBox gb_cateinfo;
        private System.Windows.Forms.CheckBox cb_per7;
        private System.Windows.Forms.CheckBox cb_per6;
        private System.Windows.Forms.CheckBox cb_per5;
        private System.Windows.Forms.CheckBox cb_per4;
        private System.Windows.Forms.CheckBox cb_per3;
        private System.Windows.Forms.CheckBox cb_per2;
        private System.Windows.Forms.CheckBox cb_per1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ctrl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pgb_run;
        private System.Windows.Forms.CheckBox cb_per8;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cb_per9;
        private System.Windows.Forms.CheckBox cb_per10;
    }
}

