using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vikoro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<String> MsgBuf = new List<String>();

        private int MAX_LINES = 256;

        private void updateLogSpam(String msg)
        {
            if (msg != null && msg.Length > 0)
            {
                MsgBuf.Add(msg);
                if (MsgBuf.Count > MAX_LINES)
                {
                    MsgBuf.RemoveAt(0);
                }

                this.textBox1.AppendText(msg);
            }
        }

        private String GetModifierText()
        {
            if (textBox2.Text == null)
            {
                return "";
            }
            else
            {
                return textBox2.Text;
            }
        }

        private void MainForm_Lord(object sender, EventArgs e)
        {
            // Supress context menu.
            textBox1.ContextMenu = new ContextMenu();
            textBox1.HideSelection = false;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String result = Libs.Roll(countSelectBox.Text,
                sideSelectBox.Text,
                operatorSelect.Text,
                GetModifierText());

            updateLogSpam(result + "\r\n");
        }

        private void countSelectBox_Validating(object sender, CancelEventArgs e)
        {
            int i;
            if (!int.TryParse(countSelectBox.Text, out i))
            {
                e.Cancel = true;
            }
        }

        private void sideSelectBox_Validating(object sender, CancelEventArgs e)
        {
            int i;
            if (!int.TryParse(sideSelectBox.Text, out i))
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.MsgBuf.Clear();
        }
    }
}
