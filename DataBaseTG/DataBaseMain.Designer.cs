namespace DataBaseTG
{
    partial class DataBaseMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvTables = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDataBases = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_mysql = new System.Windows.Forms.RadioButton();
            this.rbt_sqlserver = new System.Windows.Forms.RadioButton();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerated = new System.Windows.Forms.Button();
            this.cbDAL = new System.Windows.Forms.CheckBox();
            this.cbBLL = new System.Windows.Forms.CheckBox();
            this.cbModel = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvTables);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 713);
            this.panel1.TabIndex = 0;
            // 
            // tvTables
            // 
            this.tvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTables.Location = new System.Drawing.Point(0, 58);
            this.tvTables.Name = "tvTables";
            this.tvTables.Size = new System.Drawing.Size(253, 655);
            this.tvTables.TabIndex = 1;
            this.tvTables.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvTables_BeforeSelect);
            this.tvTables.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTables_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDataBases);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择数据库";
            // 
            // cboDataBases
            // 
            this.cboDataBases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDataBases.FormattingEnabled = true;
            this.cboDataBases.Location = new System.Drawing.Point(3, 21);
            this.cboDataBases.Name = "cboDataBases";
            this.cboDataBases.Size = new System.Drawing.Size(247, 23);
            this.cboDataBases.TabIndex = 0;
            this.cboDataBases.Text = "--请选择--";
            this.cboDataBases.SelectedIndexChanged += new System.EventHandler(this.cboDataBases_SelectedIndexChanged);
            this.cboDataBases.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboDataBases_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 713);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 591);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_mysql);
            this.groupBox2.Controls.Add(this.rbt_sqlserver);
            this.groupBox2.Controls.Add(this.btn_SelectFile);
            this.groupBox2.Controls.Add(this.txt_output);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnGenerated);
            this.groupBox2.Controls.Add(this.cbDAL);
            this.groupBox2.Controls.Add(this.cbBLL);
            this.groupBox2.Controls.Add(this.cbModel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1060, 122);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成";
            // 
            // rbt_mysql
            // 
            this.rbt_mysql.AutoSize = true;
            this.rbt_mysql.Checked = true;
            this.rbt_mysql.Location = new System.Drawing.Point(823, 36);
            this.rbt_mysql.Name = "rbt_mysql";
            this.rbt_mysql.Size = new System.Drawing.Size(68, 19);
            this.rbt_mysql.TabIndex = 8;
            this.rbt_mysql.TabStop = true;
            this.rbt_mysql.Text = "MYSQL";
            this.rbt_mysql.UseVisualStyleBackColor = true;
            // 
            // rbt_sqlserver
            // 
            this.rbt_sqlserver.AutoSize = true;
            this.rbt_sqlserver.Location = new System.Drawing.Point(694, 36);
            this.rbt_sqlserver.Name = "rbt_sqlserver";
            this.rbt_sqlserver.Size = new System.Drawing.Size(100, 19);
            this.rbt_sqlserver.TabIndex = 7;
            this.rbt_sqlserver.Text = "SQLSERVER";
            this.rbt_sqlserver.UseVisualStyleBackColor = true;
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(460, 79);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 6;
            this.btn_SelectFile.Text = "选择地址";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(90, 79);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(345, 23);
            this.txt_output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "输出源：";
            // 
            // btnGenerated
            // 
            this.btnGenerated.Location = new System.Drawing.Point(404, 36);
            this.btnGenerated.Name = "btnGenerated";
            this.btnGenerated.Size = new System.Drawing.Size(75, 23);
            this.btnGenerated.TabIndex = 3;
            this.btnGenerated.Text = "生成";
            this.btnGenerated.UseVisualStyleBackColor = true;
            this.btnGenerated.Click += new System.EventHandler(this.btnGenerated_Click);
            // 
            // cbDAL
            // 
            this.cbDAL.AutoSize = true;
            this.cbDAL.Location = new System.Drawing.Point(262, 39);
            this.cbDAL.Name = "cbDAL";
            this.cbDAL.Size = new System.Drawing.Size(104, 19);
            this.cbDAL.TabIndex = 2;
            this.cbDAL.Text = "生成数据层";
            this.cbDAL.UseVisualStyleBackColor = true;
            // 
            // cbBLL
            // 
            this.cbBLL.AutoSize = true;
            this.cbBLL.Location = new System.Drawing.Point(129, 39);
            this.cbBLL.Name = "cbBLL";
            this.cbBLL.Size = new System.Drawing.Size(104, 19);
            this.cbBLL.TabIndex = 1;
            this.cbBLL.Text = "生成逻辑层";
            this.cbBLL.UseVisualStyleBackColor = true;
            // 
            // cbModel
            // 
            this.cbModel.AutoSize = true;
            this.cbModel.Checked = true;
            this.cbModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbModel.Location = new System.Drawing.Point(18, 39);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(89, 19);
            this.cbModel.TabIndex = 0;
            this.cbModel.Text = "生成模型";
            this.cbModel.UseVisualStyleBackColor = true;
            // 
            // DataBaseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DataBaseMain";
            this.Text = "唐三三代码生成器 v1.0";
            this.Load += new System.EventHandler(this.DataBaseMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDataBases;
        private System.Windows.Forms.TreeView tvTables;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbModel;
        private System.Windows.Forms.CheckBox cbBLL;
        private System.Windows.Forms.CheckBox cbDAL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.RadioButton rbt_sqlserver;
        private System.Windows.Forms.RadioButton rbt_mysql;
    }
}

