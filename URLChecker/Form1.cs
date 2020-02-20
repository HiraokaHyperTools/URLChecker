using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace URLChecker
{
    public partial class Form1 : Form
    {
        public Form1(string url)
        {
            InitializeComponent();
            urlText.Text = url;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri(urlText.Text);
                basicGrid.SelectedObject = uri;

                {
                    var collection = HttpUtility.ParseQueryString((uri.Query ?? "").TrimStart('?'));
                    var writer = new StringWriter();
                    for (int y = 0; y < collection.Count; y++)
                    {
                        writer.WriteLine($"{collection.GetKey(y)}={collection[y]}");
                    }
                    queryText.Text = writer.ToString();
                }
            }
            catch (Exception ex)
            {
                basicGrid.SelectedObject = ex;
            }
        }

        private void selectDefaultAppLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(
                Environment.ExpandEnvironmentVariables(@"%windir%\system32\control.exe"),
                @"/name Microsoft.DefaultPrograms /page pageDefaultProgram\pageAdvancedSettings"
            );
        }

        private void copyUrlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            urlText.Copy();
            MessageBox.Show("コピーしました");
        }
    }
}
