using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DBUpdater
{
    public partial class Form1 : Form
    {
        Stream myStream;
        OpenFileDialog ofd = new OpenFileDialog();
        DateTime date = new DateTime("MM, dd");

        public static string[] userArr;
        public static string[] passArr;
        
        public static int rowCounter;
        public static string day = DateTime.Now;
        public static string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = ofd.OpenFile()) != null)
                {
                    string filePath = ofd.FileName;
                    txtPath.Text = filePath;
                    List<string> userPassList = File.ReadAllLines(filePath).ToList();

                    Regex filter = new Regex(@"(.+?(?=:))");

                    int arrCounter = 0;
                    userArr = new string[userPassList.Count];

                    foreach(var lines in userPassList)
                    {
                        var match = filter.Match(lines);
                        userArr[arrCounter] = match.ToString();
                        arrCounter++;
                    }

                    passArr = new string[userPassList.Count];

                    filter = new Regex(@"(\:(.*))");

                    arrCounter = 0;

                    foreach (var lines in userPassList)
                    {
                        var match = filter.Match(lines);
                        passArr[arrCounter] = match.ToString().Replace(":", "");
                        arrCounter++;
                    }
                }
            }
                
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:redditor.database.windows.net,1433;Initial Catalog=Redditor1;Persist Security Info=False;User ID=lookdadon;Password=Fresc@13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            con.Open();
            
            for(int i = 0; i < userArr.Length; i++)
            {
                SqlCommand cmd = new SqlCommand("BEGIN IF NOT EXISTS(SELECT * FROM farmaccount WHERE '" + userArr[i] + "' = username) BEGIN INSERT INTO farmaccount(username, password, day)VALUES('" + userArr[i] +"','" + passArr[i] + "','" + day + "') END END", con);
                cmd.ExecuteNonQuery();

                dgv.Rows.Add();
                dgv.Rows[rowCounter].Cells[0].Value = userArr[i];
                dgv.Rows[rowCounter].Cells[1].Value = passArr[i];

                rowCounter++;
            }

            rowCounter = 0;

            con.Close();
        }

    }
}
