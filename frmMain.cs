using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Timer = System.Windows.Forms.Timer;

namespace Backup
{
    public partial class frmMain : Form
    {
        List<Thread> threadList = new List<Thread>();
        Timer timer = new Timer();
        frmDB frmDB;
        frmSave frmSave;
        frmLog frmLog;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            frmDB = new frmDB(this);

            frmSave = new frmSave(this);
            frmSave.Show();

            frmLog = new frmLog();

            frmSave.Visible = false;
            frmDB.Visible = false;
            frmLog.Visible = false;

            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            ShowTip("프로그램이 시스템 트레이에서 동작중입니다.");

            Log("프로그램 시작");
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"\json\default.json";

            string jsonFile = File.ReadAllText(filePath);

            Default _default = JsonConvert.DeserializeObject<Default>(jsonFile);

            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(_default.Hour), int.Parse(_default.Minute), 0);

            if (DateTime.Now > dateTime)
            {
                timer.Stop();

                ThreadStart(_default.Path);

                timer.Start();
            }
        }


        private void ThreadStart(string path)
        {
            string filePath = Application.StartupPath + @"\json\database.json";

            string jsonFile = File.ReadAllText(filePath);

            // JSON 데이터를 객체로 역직렬화
            List<DB> jsonList = JsonConvert.DeserializeObject<List<DB>>(jsonFile);

            foreach (DB json in jsonList)
            {
                DBInformation db = json.DBInformation;

                Thread thread = new Thread(() => ThreadRun(json, path));
                thread.Start();
                threadList.Add(thread);
            }
        }

        private void ThreadRun(DB json, string path)
        {
            DBInformation db = json.DBInformation;

            clsThread clsThread = new clsThread(db.IP, db.Port, db.ID, db.Password, db.Schema, json.Name, path, this);
        }

        public void Log(string message)
        {
            if (frmLog.rtb.InvokeRequired)
            {
                frmLog.rtb.Invoke(new MethodInvoker(delegate () //크로스 스레드 방지
                {
                    frmLog.rtb.AppendText($"\n{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} > {message}");
                    frmLog.rtb.ScrollToCaret();
                }));
            }
            else
            {
                frmLog.rtb.AppendText($"\n{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} > {message}");
                frmLog.rtb.ScrollToCaret();
            }
        }

        public class DB
        {
            public string Name { get; set; }
            public DBInformation DBInformation { get; set; }
        }
        public class DBInformation
        {
            public string IP { get; set; }
            public string Port { get; set; }
            public string ID { get; set; }
            public string Password { get; set; }
            public string Schema { get; set; }
        }

        public class Default
        {
            public string Path { get; set; }
            public string Hour { get; set; }
            public string Minute { get; set; }
        }

        public void RemoveThread(Thread currentThread)
        {
            if(threadList.Contains(currentThread))
                threadList.Remove(currentThread);
        }

        private void 백업설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSave.Visible = true;
            frmSave.BringToFront();
        }
        private void dB설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDB.Visible = true;
            frmDB.BringToFront();
        }
        private void 로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLog.Visible = true;
            frmLog.BringToFront();
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료합니다.", "Database Backup Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ShowTip("백업 프로그램을 종료합니다.");

                frmLog.Close();
                frmDB.Close();
                frmSave.Close();

                //스레드를 종료
                foreach (Thread thread in threadList)
                    thread.Abort();

                //스레드가 종료될 때까지 대기
                foreach (Thread thread in threadList)
                    thread.Join();

                threadList.Clear();

                this.Close();
                Application.Exit();
            }
        }

        public void ShowTip(string text)
        {
            tray.BalloonTipTitle = "Database Backup Program";
            tray.BalloonTipText = text;
            tray.ShowBalloonTip(1);
        }
    }
}
