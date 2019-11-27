using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangePath
{
    public partial class Form1 : Form
    {
        public string txtDownload { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            string workingDirectory = Environment.CurrentDirectory;
            //string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            //string fullPath = Path.Combine(projectDirectory, "AutoSource",  "Example.java");
            string peerDirectory = Directory.GetDirectoryRoot(workingDirectory);
            string fullPath = Path.Combine(peerDirectory, @"EZMS_Automation\src\TestLab", "Share_query.java");

            // create new .java file
            CreateFile(fullPath, txtPath.Text);

            // run bat file
            //fullPath = Path.Combine(projectDirectory, "AutoSource", "run.bat");
            fullPath = Path.Combine(peerDirectory, @"EZMS_Automation", "Download_Attachment_VSTS.bat");
            int returnCode = ExecuteCommand(fullPath);
            if (returnCode > -1)
                MessageBox.Show("Run successfully!!!!");

            Application.Exit();
        }

        private void CreateFile(string fullPath, string newPath)
        {
            try
            {
                List<string> lineToWrite = new List<string>();
                string line = null;
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine().ToString();
                        if (line.Contains("Common_Action_Chrome.DonwloadAttachmentVSTS("))
                            line = "\t\tCommon_Action_Chrome.DonwloadAttachmentVSTS(\"" + newPath.Replace(@"\", @"\\") + "\", \"null\");";
                        lineToWrite.Add(line);
                    }
                }
                if (lineToWrite == null)
                    throw new InvalidDataException("Line does not exist in " + fullPath);

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
                //Create a new file
                File.WriteAllLines(fullPath, lineToWrite);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private int ExecuteCommand(string command)
        {
            int ExitCode;
            Process Process;
            Process = Process.Start(command);
            Process.StartInfo.CreateNoWindow = true;
            Process.WaitForExit();
            ExitCode = Process.ExitCode;
            
            Process.Close();

            return ExitCode;
        }
    }
}
