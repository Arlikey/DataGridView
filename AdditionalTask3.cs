using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class AdditionalTask3 : Form
    {
        public AdditionalTask3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuStrip1.Items.Add(textBox1.Text);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (textBox1.Text == item.Text)
                {
                    item.DropDownItems.Add(textBox2.Text);
                }
            }
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button1.Enabled = false;
                return;
            }
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (textBox1.Text == item.Text)
                {
                    button1.Enabled = false;
                    return;
                }
            }
            button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                button2.Enabled = false;
                return;
            }
            ToolStripMenuItem item = menuStrip1.Items.OfType<ToolStripMenuItem>().Where(e => e.Text.Equals(textBox1.Text)).FirstOrDefault();
            foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
            {
                if (textBox2.Text == dropDownItem.Text)
                {
                    button2.Enabled = false;
                    return;
                }
            }
            button2.Enabled = true;
        }
    }
}
