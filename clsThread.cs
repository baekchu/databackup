using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup
{
    internal class clsThread
    {
        string ip;
        string port;
        string id;
        string password;
        string schema;
        string name;
        string path;
        frmMain frmMain;

        public clsThread(string _ip, string _port, string _id, string _password, string _schema, string _name, string _path, frmMain _frmMain)
        {
            ip = _ip;
            port = _port;
            id = _id;
            password = _password;
            schema = _schema;
            name = _name;
            path = _path;
            frmMain = _frmMain;

            Dump();
        }

        private void Dump()
        {
            Thread currentThread = Thread.CurrentThread;
            if (!Directory.Exists(path))
            {
                frmMain.Log($"백업 폴더 경로 존재하지 않음");

                frmMain.RemoveThread(currentThread);
                currentThread.Abort();
            }

            string folderPath = $"{path}\\{name}";
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    frmMain.Log($"폴더 생성 : {folderPath}");
                }
            }
            catch
            {
                MessageBox.Show("해당 경로에 폴더를 생성할 수 없습니다");
                return;
            }

    DateTime now = DateTime.Now;

            string nowDate = $"{now.Year}{now.Month}{now.Day}";
            string[] fileNames = Directory.GetFiles(folderPath);
            foreach (string fileName in fileNames)
            {
                string fileDate = fileName.Replace(folderPath, "");
                fileDate = fileDate.Split('_')[0];
                fileDate = fileDate.Replace("\\", "");

                if (fileDate == nowDate)
                {
                    frmMain.RemoveThread(currentThread);
                    currentThread.Abort();
                }
            }

            

            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            processStartInfo.FileName = "cmd.exe";
            processStartInfo.CreateNoWindow = true; //true면 창 띄우지 않음
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;
            process.StartInfo = processStartInfo;
            process.Start();


            process.StandardInput.Write($"mysqldump -u{id} -p{password} -P{port} -h{ip} --routines {schema} > \"{folderPath}\\{nowDate}_{name}.sql\"" + Environment.NewLine);


            process.StandardInput.Close();
            string cmdMessage = process.StandardOutput.ReadToEnd();
            cmdMessage = cmdMessage.Split('\n')[cmdMessage.Split('\n').Length - 1].Replace(" >", "");
            if (Application.StartupPath == cmdMessage)
                Thread.Sleep(1000);

            process.Close();

            frmMain.Log($"백업 완료 : {name}");

            frmMain.RemoveThread(currentThread);
            currentThread.Abort();
        }
    }
}
