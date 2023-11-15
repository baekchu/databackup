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

namespace Backup
{
    public partial class frmSave : Form
    {
        frmMain frmMain;

        public frmSave(frmMain _frmMain)
        {
            InitializeComponent();
            frmMain = _frmMain;
        }

        private void frmSave_Load(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"\json\default.json";

            string jsonFile = File.ReadAllText(filePath);

            Default _default = JsonConvert.DeserializeObject<Default>(jsonFile);

            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(_default.Hour), int.Parse(_default.Minute), 0);

            timePicker.Value = dateTime;

            tbFolderPath.Text = _default.Path;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = tbFolderPath.Text;
            string hour = timePicker.Value.Hour.ToString();
            string minute = timePicker.Value.Minute.ToString();
            try
            {
                if (!Directory.Exists(path))
                {
                    if (MessageBox.Show("경로에 해당하는 폴더가 없습니다. 폴더를 생성하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Directory.CreateDirectory(path);
                    else
                    {
                        MessageBox.Show("백업 폴더 경로를 다시 설정해주세요");
                        return;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("해당 경로에 폴더를 생성할 수 없습니다");
                return;
            }

            Default _default = new Default()
            {
                Path = path,
                Hour = hour,
                Minute = minute
            };

            // JSON 배열로 직렬화
            string json = JsonConvert.SerializeObject(_default, Formatting.Indented);
            string filePath = Application.StartupPath + @"\json\default.json";
            File.WriteAllText(filePath, json);

            frmMain.ShowTip("저장이 완료되었습니다");
            frmMain.Log("백업 설정 저장");
        }

        public class Default
        {
            public string Path { get; set; }
            public string Hour { get; set; }
            public string Minute { get; set; }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                tbFolderPath.Text = folderBrowserDialog.SelectedPath;
        }

        private void frmSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
