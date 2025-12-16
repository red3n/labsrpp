using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.BeginUpdate();

            comboBox1.Items.Add("гора");
            comboBox1.Items.Add("река");
            comboBox1.Items.Add("пустыня");
            comboBox1.Items.Add("страна");
            comboBox1.Items.Add("океан");

            comboBox1.EndUpdate();

            comboBox1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            // Прилагательное
            string adjective = "";

            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    adjective = rb.Text;
                    break;
                }
            }

            // Существительное
            string noun = comboBox1.SelectedItem.ToString();

            // Глагол
            string verb = listBox1.SelectedItem.ToString();

            // Результат
            string result = adjective + " " + noun + " " + verb;

            if (checkBox1.Checked)
            {
                result += "!";
            }

            label2.Text = result;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxVerb.Text.Trim() == "")
                return;

            listBox1.Items.Add(textBoxVerb.Text);
            textBoxVerb.Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;

            listBox1.Items[listBox1.SelectedIndex] = textBoxVerb.Text;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                textBoxVerb.Text = listBox1.SelectedItem.ToString();
        }
        private void btnAddRadio_Click(object sender, EventArgs e)
        {
            if (textBoxAdj.Text.Trim() == "")
                return;

            RadioButton rb = new RadioButton();
            rb.Text = textBoxAdj.Text;
            rb.AutoSize = true;

            int count = groupBox1.Controls.OfType<RadioButton>().Count();

            rb.Location = new Point(10, 20 + count * 25);

            groupBox1.Controls.Add(rb);

            textBoxAdj.Clear();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    comboBox1.Items.Add(comboBox1.Text);
                    comboBox1.Text = "";
                }
            }

            // Shift + U
            if (e.Shift && e.KeyCode == Keys.U)
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    comboBox1.Items[comboBox1.SelectedIndex] = comboBox1.Text;
                }
            }

            // Delete
            if (e.KeyCode == Keys.Delete)
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    comboBox1.Text = "";
                }
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            MessageBox.Show("Список существительных открыт");
        }
    }
}
