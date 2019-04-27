using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseTG.DAL;
using DataBaseTG.Model.MySQL;
using DataBaseTG.Model.SqlServer;
using Pomelo.Data.MySql;

namespace DataBaseTG
{
    public partial class DataBaseMain : Form
    {
        public static readonly string filePath =
            ConfigurationManager.AppSettings["file"];
        public DataBaseMain()
        {
            InitializeComponent();
        }

        private void DataBaseMain_Load(object sender, EventArgs e)
        {
            this.txt_output.Text = filePath;
        }

        private void Init()
        {
            try
            {
                if (rbt_sqlserver.Checked)
                {
                    //1.查询数据库
                    string sql = @"SELECT  name,dbid FROM    sysdatabases";
                    var dataBases = DapperHelper<DataBase>.Query(sql, null);
                    foreach (var itemData in dataBases)
                    {
                        this.cboDataBases.Items.Add(itemData.Name);
                    }
                }
                else if (rbt_mysql.Checked)
                {
                    //1.查询数据库
                    string sql = @"SELECT SCHEMA_NAME AS Name
                    FROM INFORMATION_SCHEMA.SCHEMATA";
                    var dataBases = DapperMysqlHelper<string>.Query(sql, null);
                    foreach (var itemData in dataBases)
                    {
                        this.cboDataBases.Items.Add(itemData);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //选择数据库，显示表名
        private void cboDataBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tvTables.Nodes.Clear();
            if (rbt_sqlserver.Checked)
            {
                string databaseName = this.cboDataBases.Text.Trim();
                string sql = $"SELECT name FROM {databaseName}.dbo.sysobjects WHERE xtype = 'U' ORDER BY name";
                List<string> dataBases = DapperHelper<string>.Query(sql, null);
                foreach (var dataBase in dataBases)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = dataBase;
                    this.tvTables.Nodes.Add(tn);
                }
            }
            else if (rbt_mysql.Checked)
            {
                string databaseName = this.cboDataBases.Text.Trim();
                string sql = $"SELECT table_name FROM information_schema.tables where table_schema = '{databaseName}'";
                List<string> dataBases = DapperMysqlHelper<string>.Query(sql, null);
                foreach (var dataBase in dataBases)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = dataBase;
                    this.tvTables.Nodes.Add(tn);
                }
            }

        }

        //选择treenode,获取列名
        private void tvTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (rbt_sqlserver.Checked)
            {
                string databaseName = this.cboDataBases.Text.Trim();
                string tableName = this.tvTables.SelectedNode.Text;
                //string sql = $"SELECT * FROM {databaseName}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='{tableName}'";
                string sql = $@"SELECT
                                A.name AS table_name,
                                B.name AS column_name,
                                C.value AS column_description,
                                d.COLUMN_NAME,d.DATA_TYPE,d.IS_NULLABLE,d.CHARACTER_MAXIMUM_LENGTH
                                FROM {databaseName}.sys.tables A
                                INNER JOIN {databaseName}.sys.columns B ON B.object_id = A.object_id
                                LEFT JOIN {databaseName}.sys.extended_properties C ON C.major_id = B.object_id AND C.minor_id = B.column_id
                                INNER JOIN {databaseName}.INFORMATION_SCHEMA.COLUMNS d ON b.name = d.COLUMN_NAME
                                WHERE A.name = '{tableName}'";
                var dataBases = DapperHelper<DataBaseColumn>.Query(sql, null);
                this.dataGridView1.DataSource = dataBases;
                Type t = typeof(DataBaseColumn);
                PropertyInfo[] propertyInfos = t.GetProperties();//属性
                this.dataGridView1.DataSource = dataBases;
                this.dataGridView1.Columns[propertyInfos.Count() - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            else if (rbt_mysql.Checked)
            {
                string databaseName = this.cboDataBases.Text.Trim();
                string tableName = this.tvTables.SelectedNode.Text;
                string sql = $"SELECT * FROM information_schema.COLUMNS where table_schema = '{databaseName}' AND table_Name = '{tableName}'";
                var dataBases = DapperMysqlHelper<DataBaseColumnMysql>.Query(sql, null);
                Type t = typeof(DataBaseColumnMysql);
                PropertyInfo[] propertyInfos = t.GetProperties();//属性
                this.dataGridView1.DataSource = dataBases;
                this.dataGridView1.Columns[propertyInfos.Count() - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }

        private void btnGenerated_Click(object sender, EventArgs e)
        {
            //生成模型
            if (cbModel.Checked)
            {
                if (this.tvTables.SelectedNode == null)
                {
                    MessageBox.Show("请选择表名!");
                    return;
                }
                CreateMode();
            }
            else
            {
                MessageBox.Show("请选择表名!");
                return;
            }
        }

        private void CreateMode()
        {
            try
            {
                if (rbt_sqlserver.Checked)
                {
                    List<DataBaseColumn> columns = this.dataGridView1.DataSource as List<DataBaseColumn>;
                    List<string> list = new List<string>();
                    list.Add("using System;");
                    list.Add($"public  class {this.tvTables.SelectedNode.Text}");
                    list.Add("{");
                    foreach (var column in columns)
                    {
                        if (!string.IsNullOrWhiteSpace(column.Column_description))
                        {
                            list.Add("\t/// <summary>");
                            list.Add("\t/// " + column.Column_description);
                            list.Add("\t/// </summary>");
                        }
                        string c_type = FileOperate.SqlServerTypeToCType(column.DATA_TYPE);
                        list.Add("\tpublic " + c_type + " " +
                            column.COLUMN_NAME.Substring(0, 1).ToUpper() + column.COLUMN_NAME.Substring(1)
                            + " { get; set; }");
                    }
                    list.Add("}");
                    string fileName = this.tvTables.SelectedNode.Text + ".cs";
                    FileOperate.FileWrite(list, this.txt_output.Text.Trim() + @"\" + fileName);
                    MessageBox.Show($"生成{fileName}成功!");
                }
                else if (rbt_mysql.Checked)
                {
                    List<DataBaseColumnMysql> columns = this.dataGridView1.DataSource as List<DataBaseColumnMysql>;
                    List<string> list = new List<string>();
                    list.Add("using System;");
                    list.Add($"public  class {this.tvTables.SelectedNode.Text}");
                    list.Add("{");
                    foreach (var column in columns)
                    {
                        if (!string.IsNullOrWhiteSpace(column.COLUMN_COMMENT))
                        {
                            list.Add("\t/// <summary>");
                            list.Add("\t/// " + column.COLUMN_COMMENT);
                            list.Add("\t/// </summary>");
                        }
                        
                        string c_type = FileOperate.SqlServerTypeToCType(column.DATA_TYPE);
                        list.Add("\tpublic " + c_type + " " +
                            column.COLUMN_NAME.Substring(0, 1).ToUpper() + column.COLUMN_NAME.Substring(1)
                            + " { get; set; }");
                    }
                    list.Add("}");
                    string fileName = this.tvTables.SelectedNode.Text + ".cs";
                    FileOperate.FileWrite(list, this.txt_output.Text.Trim() + @"\" + fileName);
                    MessageBox.Show($"生成{fileName}成功!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void cboDataBases_MouseClick(object sender, MouseEventArgs e)
        {
            this.cboDataBases.Items.Clear();
            Init();

        }

        private void tvTables_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //e.Node.ForeColor = Color.Blue;
            e.Node.BackColor = Color.Chartreuse;
            //e.Node.NodeFont = new Font("宋体", 10, FontStyle.Underline | FontStyle.Bold);
            if (tvTables.SelectedNode != null)
            {
                tvTables.SelectedNode.BackColor = Color.White;
                //tvTables.SelectedNode.ForeColor = SystemColors.WindowText;
                //tvTables.SelectedNode.NodeFont = new Font(FontFamily.GenericSerif, 10, FontStyle.Regular);
            }
        }

        //选择输出源文件地址
        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                txt_output.Text = folderBrowserDialog1.SelectedPath;

            }
        }
    }
}
