using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.International.Converters.PinYinConverter;
using System.Collections.ObjectModel;
namespace chineseChar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pin_str = "";
            if (textBox1.Text.Trim().Length == 0)
            {
                return;
            }
            char[] chars = textBox1.Text.Trim().ToCharArray();
            foreach(char one_char in chars)
            {
                int ch_int = (int)one_char;
                //string str_char_int = string.Format("{0}", ch_int);
                if (ch_int > 127)
                {
                    ChineseChar chineseChar = new ChineseChar(one_char);
                    ReadOnlyCollection<string> pinyin = chineseChar.Pinyins;
                    foreach (string pin in pinyin)
                    {
                        pin_str += pin + "\t";
                    }
                    pin_str += "\r\n";
                }
            }
            textBox1.Text = "";
            textBox2.Text = pin_str;
            label1.Text = "拼音获取";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
