using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace SDmakeTool
{
   
  
    public partial class formTool : Form
    {
        CheckBox[] cbmodel;
        cateinfo cinfo;
        int is_regular_ok;
        int is_srcdir_ok;
        int is_destdir_ok;
        int is_start;
        DataTable dataExcel;
        //ThreadStart threadStart;
        Thread thread;

        public formTool()
        {
            cbmodel = new CheckBox[10];
            //Control.CheckForIllegalCrossThreadCalls = false;
            //threadStart = new ThreadStart(toCopy);//通过ThreadStart委托告诉子线程执行什么方法　　
            //thread = new Thread(threadStart);
            is_regular_ok = 0;
            is_srcdir_ok = 0;
            is_destdir_ok = 0;
            is_start = 0;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
            gb_cateinfo.Visible = false;
            cb_per1.Visible = false;
            cb_per2.Visible = false;
            cb_per3.Visible = false;
            cb_per4.Visible = false;
            cb_per5.Visible = false;
            cb_per6.Visible = false;
            cb_per7.Visible = false;
            cb_per8.Visible = false;
            **/
            //MessageBox.Show("开始加载控件");
        }

        private void btn_regular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("打开文件");
            openFileDialog1.Filter = "Excel文件(.xls,.xlsx)|*.xls;*.xlsx";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_regular.Text =  openFileDialog1.FileName;

                //DataTable dataExcel = ExcelToDataTable(tb_regular.Text , "Sheet1");
                this.dataExcel = ExcelToDataTable(tb_regular.Text, "Sheet1");
                tb_info.Text = this.dataExcel.Rows[0][0].ToString();
                
                //cateinfo cinfo = GetCategoryAndCoord(dataExcel);
                
                this.cinfo = GetCategoryAndCoord(this.dataExcel); 
                /***
                this.cbmodel[0] = cb_per1;
                this.cbmodel[1] = cb_per2;
                this.cbmodel[2] = cb_per3;
                this.cbmodel[3] = cb_per4;
                this.cbmodel[4] = cb_per5;
                this.cbmodel[5] = cb_per6;
                this.cbmodel[6] = cb_per7;
                this.cbmodel[7] = cb_per8;
                ***/
                showCateinfo(this.cinfo , this.cbmodel);
                this.is_regular_ok = 1;
            }
        }

        /**
    * 定义一个保存类目位置和左边的数据结构
    * **/
        /***
        struct cateinfo
        { 
            //类目对应的行
            public int cate_line;
            //类目
            public string[] catename;
        };
        ***/
        public class cateinfo
        {
            public int cate_line;
            public string[] catename;
            public int cate_count;
            public cateinfo()
            {
                this.cate_line = 0;
                this.cate_count = 0;
                this.catename = new string[10];
            }
        }

        private void btn_srcdir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_srcdir.Text = folderBrowserDialog1.SelectedPath;
                //tb_info.Text += (Environment.NewLine + tb_srcdir.Text);
                outPutLog(tb_srcdir.Text);
                //更新状态
                this.is_srcdir_ok = 1;
                
            }
        }

        private void btn_destdir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_destdir.Text = folderBrowserDialog1.SelectedPath;
                //tb_info.Text += (Environment.NewLine + tb_destdir.Text);
                outPutLog(tb_destdir.Text);
                //更新状态
                this.is_destdir_ok = 1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void formTool_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /***
         *  func : 读取Excel数据
         *  date 2018-12-16
         *  author : qimi
         *  
         * 方法二：这里是fill进dataset，也可以返回OleDbDataReader来逐行读，数据较快
         *   注：这种方法容易把混合型的字段作为null值读取进来，解决办法是改造连接字符串
         *   strConn = "Provider=Microsoft.Jet.OLEDB.4.0;DataSource=C:\\Erp1912.xls;Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
         *   通过Imex=1来把混合型作为文本型读取，避免null值,详细请见http://www.connectionstrings.com
         *   
         * 
         * ***/

        public static DataTable ExcelToDataTable(string strExcelFileName, string strSheetName)
        {
            //源的定义
            //string strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + Server.MapPath("ExcelFiles/MyExcelFile.xls") + ";Extended Properties='Excel 8.0; HDR=Yes; IMEX=1'"; //此连接只能操作Excel2007之前(.xls)文件
            //string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + Server.MapPath("ExcelFiles/Mydata2007.xlsx") + ";Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'"; //此连接可以操作.
            //string strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + Server.MapPath("ExcelFiles/MyExcelFile.xls") + ";Extended Properties='Excel 8.0; HDR=Yes; IMEX=1'"; //此连接只能操作Excel2007之前(.xls)文件
            string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + strExcelFileName + ";Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'"; //此连接可以操作.
            //string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + strExcelFileName + ";" + "Extended Properties='Excel 8.0;HDR=NO;IMEX=1';";
 
            //Sql语句
            string sqlExcel = string.Format("select * from [{0}$]", strSheetName); //这是一种方法
            //string sqlExcel = "select * from   [sheet1$]";
 
            //定义存放的数据表
            DataSet ds = new DataSet();
 
            //连接数据源
            OleDbConnection conn = new OleDbConnection(strConn);
 
            conn.Open();
 
            //适配到数据源
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlExcel, strConn);
            adapter.Fill(ds, strSheetName);
 
            conn.Close();
 
            return ds.Tables[strSheetName];
        }

        /**
         *  func : 类目名称和坐标
         *  date : 2018-12-16
         *  author : qimi
         * 
         * **/


        public static cateinfo GetCategoryAndCoord(DataTable datatable)
        {
            cateinfo cinfo = new cateinfo();
            int ret = 0;
            for (int i = 0; i < 5; i++)
            {
                //固定为第一列 找到编号， 因为类目和编号同一行
                if (datatable.Rows[i][0].ToString() == "编号")
                { 
                    //找到类目行
                    cinfo.cate_line = i;
                    ret = 1;
                    break;
                }
            }

            if (1 == ret)
            {
                //找到类目开始搜索类目
                for (int i = 1; i <= cinfo.catename.Length; i++)
                {
                    if (datatable.Rows[cinfo.cate_line][i].ToString() != "")
                    {
                        cinfo.catename[i - 1] = datatable.Rows[cinfo.cate_line][i].ToString();
                        cinfo.cate_count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (0 == cinfo.cate_count)
                {
                    MessageBox.Show("没有从规则文件中找到类目");
                }
            }
            else
            {
                MessageBox.Show("没有从规则文件中定位到编号");
            }
            
            return cinfo;
        }

        /***
         *  func : 如果搜索到类目则将类目显示出来
         *  date : 2018-12-16
         *  author : qimi
         * 
         * ***/
        private void showCateinfo(cateinfo cinfo , CheckBox[] cbmodel)
        {
            if (cinfo.cate_count > 0)
            {
                for (int i = 0; i < cinfo.cate_count; i++)
                {
                    //tb_info.Text += (Environment.NewLine + cinfo.catename[i]);
                    outPutLog(cinfo.catename[i]);
                    cbmodel[i + 1].Visible = true;
                    cbmodel[i + 1].Text = cinfo.catename[i];
                    cbmodel[i].Checked = false;
                }

                /**
                 *  刷新列表
                 * **/
                cbmodel[0].Visible = true;
                //gb_cateinfo.Visible = true;
            
            }
            
        }

        private void formTool_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("form已经进入");
        }

        private void formTool_Shown(object sender, EventArgs e)
        {
            
            cbmodel[0] = cb_per1;
            cbmodel[1] = cb_per2;
            cbmodel[2] = cb_per3;
            cbmodel[3] = cb_per4;
            cbmodel[4] = cb_per5;
            cbmodel[5] = cb_per6;
            cbmodel[6] = cb_per7;
            cbmodel[7] = cb_per8;
            
            
            ;// MessageBox.Show("form shown");
        }

        private void cb_per5_CheckedChanged(object sender, EventArgs e)
        {

        }

        /***
         *  cb_per1 被点击
         * **/
        private void cb_per1_Click(object sender, EventArgs e)
        {
            if (this.cbmodel[0].Checked)
            {
                //MessageBox.Show("全部被选中了");
                //其他的项也要都被选中
                for (int i = 1; i <= this.cinfo.cate_count; i++)
                {
                    this.cbmodel[i].Checked = true;
                }
            }
            else
            {
                //MessageBox.Show("全部被取消了");
            }
        }


        /**
         *  func : 开始或者终止
         *  date : 2018-12-16
         *  author : qimi
         * **/
        private void btn_ctrl_Click(object sender, EventArgs e)
        {
            /**
             *  开始校验
             * **/
            if (0 == this.is_regular_ok)
            {
                MessageBox.Show("请选择规则文件...");
                return;
            }
            if (0 == this.is_srcdir_ok)
            {
                MessageBox.Show("请选择源文件夹...");
                return;
            }
            if (0 == this.is_destdir_ok)
            {
                MessageBox.Show("请选择目标文件夹...");
                return;
            }

            
            int ret = 0;
            //tb_info.Text += getNextStr("---------------------------");
            outPutLog("---------------------------");
            for (int i = 1; i <= this.cinfo.cate_count; i++)
            {
                if (this.cbmodel[i].Checked)
                {
                    tb_info.Text += getNextStr(this.cbmodel[i].Text);
                    ret++;
                }
            }
            //tb_info.Text += getNextStr("==========================");
            outPutLog("==========================");

            if (0 == ret)
            {
                MessageBox.Show("未选择类目...");
                return;
            }

            
            /**
             *  更新状态 
             ***/
            if (0 == this.is_start)
            {
                gb_dir.Enabled = false;
                gb_cateinfo.Enabled = false;
                //按钮文字更改
                btn_ctrl.Text = "终止";
                this.is_start = 1;
                timer1.Start();
                Control.CheckForIllegalCrossThreadCalls = false;
                ThreadStart threadStart = new ThreadStart(toCopy);//通过ThreadStart委托告诉子线程执行什么方法　　
                this.thread = new Thread(threadStart);
                this.thread.Start();//启动新线程
            }
            else
            {
                if (MessageBox.Show("确认要终止执行吗?", "请确认操作", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    gb_dir.Enabled = true;
                    gb_cateinfo.Enabled = true;
                    //按钮文字更改
                    btn_ctrl.Text = "开始";
                    this.is_start = 0;
                    timer1.Stop();
                    this.thread.Abort();
                    
                }
                
            }
            
        }

        /**
         *  func : 执行拷贝的方法
         *  date : 2018-12-19
         *  author : qimi 
         * 
         **/
        private void toCopy()
        {
            //分门别类的进行拷贝，要素就是 类目
            for (int i = 1; i <= this.cinfo.cate_count; i++)
            {
                if (this.cbmodel[i].Checked)
                {
                    //tb_info.Text += getNextStr(this.cbmodel[i].Text);
                    startCopy(this.cbmodel[i].Text, i);
                }
            }
            timer1.Stop();
           
            if(MessageBox.Show("拷贝完成","任务完成提示",MessageBoxButtons.OK,MessageBoxIcon.Information , MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                gb_dir.Enabled = true;
                gb_cateinfo.Enabled = true;
                //按钮文字更改
                btn_ctrl.Text = "开始";
                this.is_start = 0;
                
            }
            this.thread.Abort();
        }


        /**
         *  func : 执行拷贝
         *  date : 2018-12-20
         *  author : qimi
         * **/
        private void startCopy(string dirname , int pos)
        {
            //return (Environment.NewLine + str);
            int i = 1;
            string datastr = "";
            string aimPath = tb_destdir.Text + "\\" +dirname;
            string srcPath = tb_srcdir.Text + "\\" + dirname;
            //tb_info.Text += getNextStr("开始拷贝类目-->"+dirname);
            outPutLog("开始拷贝类目-->" + dirname);
            while(true)
            {
                datastr = this.dataExcel.Rows[i++][pos].ToString();
                if (datastr == "")
                {
                    break;
                }
                else
                {
                /***
                    //try
                    //{
                    // 检查目标目录是否以目录分割字符结束如果不是则添加
                
                    if (aimPath[aimPath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                    {
                        aimPath += System.IO.Path.DirectorySeparatorChar;
                    }
                    // 判断目标目录是否存在如果不存在则新建
                    if (!System.IO.Directory.Exists(aimPath))
                    {
                        System.IO.Directory.CreateDirectory(aimPath);
                    }
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    //if (System.IO.Directory.Exists(file))
                    //{
                    //    CopyDir(file, aimPath + System.IO.Path.GetFileName(file));
                    //}
                    // 否则直接Copy文件
                    //else
                    //{
                    //System.IO.File.Copy(file, aimPath + System.IO.Path.GetFileName(file), true);
                    System.IO.File.Copy(srcPath+datastr , aimPath + datastr, true);
                ***/
                    // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                    // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                    // string[] fileList = Directory.GetFile
                    //tb_info.Text += getNextStr(datastr +"成功");
                    outPutLog(datastr + "成功");
                }
            };
        }

         /**
         *  func : 输出日志
         *  date : 2018-12-16
         *  author : qimi
         * **/
        private void outPutLog(string log)
        {
            tb_info.AppendText(DateTime.Now.ToString("HH:mm:ss") + "  " + log + Environment.NewLine);
        }

        /**
         *  func : 在字符串开始位置插入换行
         *  date : 2018-12-16
         *  author : qimi
         * **/
        private string getNextStr(string str)
        {
            return (Environment.NewLine + str);
        }

        /**
         *  func : 定时器提供时间
         *  date : 2018-12-16
         *  author : qimi
         * 
         * ***/
        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbl_time.Text = DateTime.Now.ToString("hh:mm:ss"); // 08:05:57
            //int count = int.Parse(lbl_time.Tag);
            int count = Convert.ToInt32(lbl_time.Tag);
            count += 1;
            int mm = count / 60;
            int ss = count % 60;
            lbl_time.Tag = count;
            lbl_time.Text = string.Format("{0:D2}:{1:D2}",mm , ss);
            pgb_run.Value += 1;
            //lbl_time.Text = timer1.
        }

         
    }
}
    
