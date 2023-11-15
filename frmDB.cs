using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Backup
{
    public partial class frmDB : Form
    {
        frmMain frmMain;

        public frmDB(frmMain _frmMain)
        {
            InitializeComponent();
            frmMain = _frmMain;
        }

        private void frmDB_Load(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"\json\database.json";

            string jsonFile = File.ReadAllText(filePath);

            // JSON 데이터를 객체로 역직렬화
            List<DB> jsonList = JsonConvert.DeserializeObject<List<DB>>(jsonFile);

            foreach(DB json in jsonList)
            {
                ListViewItem item = new ListViewItem(new string[] { json.DBInformation.IP, json.DBInformation.Port, json.DBInformation.ID, json.DBInformation.Password, json.DBInformation.Schema, json.Name });
                lvDBInformation.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox && control.Text == "")
                {
                    MessageBox.Show("DB 접속 정보를 모두 입력해주세요");
                    return;
                }
            }

            string ip = tbIP.Text;
            string port = tbPort.Text;
            string id = tbID.Text;
            string password = tbPassword.Text;
            string schema = tbSchema.Text;
            string name = tbName.Text;

            for (int i = 0; i < lvDBInformation.Items.Count; i++)
            {
                ListViewItem nowItem = lvDBInformation.Items[i];

                if (name == nowItem.SubItems[5].Text)
                {
                    MessageBox.Show("이미 존재하는 이름입니다");
                    return;
                }

                if(ip == nowItem.SubItems[0].Text && port == nowItem.SubItems[1].Text && id == nowItem.SubItems[2].Text && password == nowItem.SubItems[3].Text && schema == nowItem.SubItems[4].Text)
                {
                    MessageBox.Show("이미 존재하는 DB 접속 정보입니다");
                    return;
                }
            }

            string dbConnectString = string.Format("Server={0};Port={1};Uid={2};Pwd={3};Database={4};",
                    ip, port, id, password, schema);

            if (!DBConnectionTest(dbConnectString))
            {
                MessageBox.Show("접속할 수 없는 DB 정보입니다");
                return;
            }

            ListViewItem item = new ListViewItem(new string[] { ip, port, id, password, schema, name });
            lvDBInformation.Items.Add(item);
        }

        private bool DBConnectionTest(string dbConnectString)
        {
            try
            {
                using (MySqlConnection dbConnection = new MySqlConnection(dbConnectString))
                {
                    dbConnection.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<DB> jsonList = new List<DB>();

            for (int i=0; i<lvDBInformation.Items.Count; i++)
            {
                ListViewItem item = lvDBInformation.Items[i];

                DB db = new DB()
                {
                    Name = item.SubItems[5].Text,
                    DBInformation = new DBInformation()
                    {
                        IP = item.SubItems[0].Text,
                        Port = item.SubItems[1].Text,
                        ID = item.SubItems[2].Text,
                        Password = item.SubItems[3].Text,
                        Schema = item.SubItems[4].Text
                    }
                };

                jsonList.Add(db);
            }

            // JSON 배열로 직렬화
            string json = JsonConvert.SerializeObject(jsonList, Formatting.Indented);
            string filePath = Application.StartupPath + @"\json\database.json";
            File.WriteAllText(filePath, json);

            frmMain.ShowTip("저장이 완료되었습니다");
            frmMain.Log("DB 설정 저장");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvDBInformation.SelectedIndices.Count == 1)
            {
                for (int i = 0; i < lvDBInformation.SelectedIndices.Count; i++)
                    lvDBInformation.Items.RemoveAt(lvDBInformation.SelectedIndices[i]);
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

        private void lvDBInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDBInformation.SelectedIndices.Count == 1)
            {
                for (int i = 0; i < lvDBInformation.SelectedIndices.Count; i++)
                {
                    int index = lvDBInformation.SelectedIndices[i];
                    ListViewItem item = lvDBInformation.Items[index];

                    tbIP.Text = item.SubItems[0].Text;
                    tbPort.Text = item.SubItems[1].Text;
                    tbID.Text = item.SubItems[2].Text;
                    tbPassword.Text = item.SubItems[3].Text;
                    tbSchema.Text = item.SubItems[4].Text;
                    tbName.Text = item.SubItems[5].Text;
                }
            }
        }

        private void frmDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
