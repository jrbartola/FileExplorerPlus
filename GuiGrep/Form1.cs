using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GuiGrep
{
    public partial class GuiGrepForm : Form
    {
        public GuiGrepForm()
        {
            InitializeComponent();
        }

        private void GuiGrepForm_Load(object sender, EventArgs e)
        {
            
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    fileBrowser.Url = new Uri(fbd.SelectedPath);
                    pathField.Text = fbd.SelectedPath;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (fileBrowser.CanGoBack)
            {
                fileBrowser.GoBack();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (fileBrowser.CanGoForward)
            {
                fileBrowser.GoForward();
            }
        }
    }
}
