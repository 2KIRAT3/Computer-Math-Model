using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Computer_Math_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = "https://github.com/2KIRAT3/Witcher-Backup-Of-Saves";
            proc.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && textBox9.Text != "")
                label11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 133.3);
            if (comboBox1.SelectedIndex == 2 && textBox9.Text != "")
                label11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 133.3);
            if (comboBox1.SelectedIndex == 1 && textBox9.Text != "")
                label11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 1000000);
            if (comboBox1.SelectedIndex == 2 && textBox9.Text != "")
                label11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 98066.5);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox9.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
            if(comboBox1.SelectedIndex == 0 && textBox9.Text != "")
                label11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 133.3);
            if (comboBox1.SelectedIndex == 2 && textBox9.Text != "")
                label11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 133.3);
            if (comboBox1.SelectedIndex == 1 && textBox9.Text != "")
                label11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 1000000);
            if (comboBox1.SelectedIndex == 2 && textBox9.Text != "")
                label11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 98066.5);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = true;

            if (comboBox2.SelectedIndex == 0 && textBox10.Text != "")
                label12.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) / 1000);

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && textBox10.Text != "")
                label12.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) / 1000);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox10.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0 && textBox11.Text != "")
                label15.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) - 273);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox11.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Enabled = true;

            if (comboBox3.SelectedIndex == 0 && textBox11.Text != "")
                label15.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) - 273);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0 && textBox12.Text != "")
                label18.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) + 273);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox12.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox12.Enabled = true;

            if (comboBox4.SelectedIndex == 0 && textBox12.Text != "")
                label18.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) - 273);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 16.38);
            if (comboBox5.SelectedIndex == 1 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) - 273);
            if (comboBox5.SelectedIndex == 2 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) / 1000);
            if (comboBox5.SelectedIndex == 3 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) / 100000);
            if (comboBox5.SelectedIndex == 4 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 1000);
            if (comboBox5.SelectedIndex == 5 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 100);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox13.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox13.Enabled = true;

            if (comboBox5.SelectedIndex == 0 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 16.38);
            if (comboBox5.SelectedIndex == 1 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) / 1000);
            if (comboBox5.SelectedIndex == 2 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) / 100000);
            if (comboBox5.SelectedIndex == 3 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 1000);
            if (comboBox5.SelectedIndex == 4 && textBox13.Text != "")
                label21.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 100);
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != "")
            {
                label39.Text = Convert.ToString(1/Convert.ToDouble(textBox18.Text));
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox18.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox14.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                label24.Text = Convert.ToString(1 / Convert.ToDouble(textBox14.Text));
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {
                label28.Text = Convert.ToString((Convert.ToDouble(textBox15.Text)* Convert.ToDouble(textBox17.Text))/ Convert.ToDouble(textBox16.Text));
            }
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                label28.Text = Convert.ToString((Convert.ToDouble(textBox15.Text) * Convert.ToDouble(textBox17.Text)) / Convert.ToDouble(textBox16.Text));
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text != "")
            {
                label28.Text = Convert.ToString((Convert.ToDouble(textBox15.Text) * Convert.ToDouble(textBox17.Text)) / Convert.ToDouble(textBox16.Text));
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox15.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox16.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox17.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text != "")
            {
                label40.Text = Convert.ToString((Convert.ToDouble(textBox20.Text) * Convert.ToDouble(textBox19.Text)) / Convert.ToDouble(textBox21.Text));
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text != "")
            {
                label40.Text = Convert.ToString((Convert.ToDouble(textBox20.Text) * Convert.ToDouble(textBox19.Text)) / Convert.ToDouble(textBox21.Text));
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text != "")
            {
                label40.Text = Convert.ToString((Convert.ToDouble(textBox20.Text) * Convert.ToDouble(textBox19.Text)) / Convert.ToDouble(textBox21.Text));
            }
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox21.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox20.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox19.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text != "")
            {
                label46.Text = Convert.ToString((Convert.ToDouble(textBox24.Text) * Convert.ToDouble(textBox23.Text)) / Convert.ToDouble(textBox22.Text));
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text != "")
            {
                label46.Text = Convert.ToString((Convert.ToDouble(textBox24.Text) * Convert.ToDouble(textBox23.Text)) / Convert.ToDouble(textBox22.Text));
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text != "")
            {
                label46.Text = Convert.ToString((Convert.ToDouble(textBox24.Text) * Convert.ToDouble(textBox23.Text)) / Convert.ToDouble(textBox22.Text));
            }
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox24.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox23.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox22.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text != "")
            {
                label52.Text = Convert.ToString((Convert.ToDouble(textBox27.Text) * Convert.ToDouble(textBox25.Text)) / Convert.ToDouble(textBox26.Text));
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text != "")
            {
                label52.Text = Convert.ToString((Convert.ToDouble(textBox27.Text) * Convert.ToDouble(textBox25.Text)) / Convert.ToDouble(textBox26.Text));
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text != "")
            {
                label52.Text = Convert.ToString((Convert.ToDouble(textBox27.Text) * Convert.ToDouble(textBox25.Text)) / Convert.ToDouble(textBox26.Text));
            }
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox25.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox26.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox27.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text != "")
            {
                label56.Text = Convert.ToString(1 / Convert.ToDouble(textBox28.Text));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            button4.ForeColor = Color.OrangeRed;
            button5.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = false;

            button4.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;

            button5.ForeColor = Color.OrangeRed;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;

            panel6.Visible = true;
            button4.ForeColor = Color.Black;

            button5.ForeColor = Color.Black;

            button8.ForeColor = Color.OrangeRed;

        }
        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (textBox44.Text != "")
            {
                label90.Text = Convert.ToString(Convert.ToDouble(textBox44.Text)*(1 + Convert.ToDouble(textBox43.Text)* Convert.ToDouble(textBox42.Text)));
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (textBox43.Text != "")
            {
                label90.Text = Convert.ToString(Convert.ToDouble(textBox44.Text) * (1 + Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox42.Text)));
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (textBox42.Text != "")
            {
                label90.Text = Convert.ToString(Convert.ToDouble(textBox44.Text) * (1 + Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox42.Text)));
            }
        }

        private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox44.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox43.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox42.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            if (textBox47.Text != "")
            {
                label96.Text = Convert.ToString(Convert.ToDouble(textBox44.Text) / (1 + Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox42.Text)));
            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (textBox46.Text != "")
            {
                label96.Text = Convert.ToString(Convert.ToDouble(textBox44.Text) / (1 + Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox42.Text)));
            }
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (textBox45.Text != "")
            {
                label96.Text = Convert.ToString(Convert.ToDouble(textBox44.Text) / (1 + Convert.ToDouble(textBox43.Text) * Convert.ToDouble(textBox42.Text)));
            }
        }

        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox47.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox46.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox45.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (textBox31.Text != "")
            {
                label62.Text = Convert.ToString((Convert.ToDouble(textBox31.Text) - Convert.ToDouble(textBox29.Text)) / (Convert.ToDouble(textBox30.Text)* Convert.ToDouble(textBox29.Text)));
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (textBox30.Text != "")
            {
                label62.Text = Convert.ToString((Convert.ToDouble(textBox31.Text) - Convert.ToDouble(textBox29.Text)) / (Convert.ToDouble(textBox30.Text) * Convert.ToDouble(textBox29.Text)));
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (textBox29.Text != "")
            {
                label62.Text = Convert.ToString((Convert.ToDouble(textBox31.Text) - Convert.ToDouble(textBox29.Text)) / (Convert.ToDouble(textBox30.Text) * Convert.ToDouble(textBox29.Text)));
            }
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox31.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox30.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox29.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (textBox41.Text != "")
            {
                label67.Text = Convert.ToString(((Convert.ToDouble(textBox41.Text) / Convert.ToDouble(textBox40.Text)) * 8.31 * Convert.ToDouble(textBox39.Text))/ Convert.ToDouble(textBox32.Text));
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (textBox40.Text != "")
            {
                label67.Text = Convert.ToString(((Convert.ToDouble(textBox41.Text) / Convert.ToDouble(textBox40.Text)) * 8.31 * Convert.ToDouble(textBox39.Text)) / Convert.ToDouble(textBox32.Text));
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (textBox39.Text != "")
            {
                label67.Text = Convert.ToString(((Convert.ToDouble(textBox41.Text) / Convert.ToDouble(textBox40.Text)) * 8.31 * Convert.ToDouble(textBox39.Text)) / Convert.ToDouble(textBox32.Text));
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (textBox32.Text != "")
            {
                label67.Text = Convert.ToString(((Convert.ToDouble(textBox41.Text) / Convert.ToDouble(textBox40.Text)) * 8.31 * Convert.ToDouble(textBox39.Text)) / Convert.ToDouble(textBox32.Text));
            }
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox32.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox39.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox40.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox41.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            if (textBox51.Text != "")
            {
                label69.Text = Convert.ToString(((Convert.ToDouble(textBox51.Text) / Convert.ToDouble(textBox50.Text)) * 8.31 * Convert.ToDouble(textBox49.Text)) / Convert.ToDouble(textBox48.Text));
            }
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            if (textBox50.Text != "")
            {
                label69.Text = Convert.ToString(((Convert.ToDouble(textBox51.Text) / Convert.ToDouble(textBox50.Text)) * 8.31 * Convert.ToDouble(textBox49.Text)) / Convert.ToDouble(textBox48.Text));
            }
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            if (textBox49.Text != "")
            {
                label69.Text = Convert.ToString(((Convert.ToDouble(textBox51.Text) / Convert.ToDouble(textBox50.Text)) * 8.31 * Convert.ToDouble(textBox49.Text)) / Convert.ToDouble(textBox48.Text));
            }
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            if (textBox48.Text != "")
            {
                label69.Text = Convert.ToString(((Convert.ToDouble(textBox51.Text) / Convert.ToDouble(textBox50.Text)) * 8.31 * Convert.ToDouble(textBox49.Text)) / Convert.ToDouble(textBox48.Text));
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (textBox36.Text != "")
            {
                label70.Text = Convert.ToString(((Convert.ToDouble(textBox36.Text) * Convert.ToDouble(textBox34.Text)* 8.31)) / (Convert.ToDouble(textBox33.Text) * Convert.ToDouble(textBox35.Text)));
            }
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox36.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox35.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox34.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox33.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox51_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox51.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox50.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox49.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox48.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (textBox35.Text != "")
            {
                label70.Text = Convert.ToString(((Convert.ToDouble(textBox36.Text) * Convert.ToDouble(textBox34.Text) * 8.31)) / (Convert.ToDouble(textBox33.Text) * Convert.ToDouble(textBox35.Text)));
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (textBox34.Text != "")
            {
                label70.Text = Convert.ToString(((Convert.ToDouble(textBox36.Text) * Convert.ToDouble(textBox34.Text) * 8.31)) / (Convert.ToDouble(textBox33.Text) * Convert.ToDouble(textBox35.Text)));
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.Text != "")
            {
                label70.Text = Convert.ToString(((Convert.ToDouble(textBox36.Text) * Convert.ToDouble(textBox34.Text) * 8.31)) / (Convert.ToDouble(textBox33.Text) * Convert.ToDouble(textBox35.Text)));
            }
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            if (textBox53.Text != "")
            {
                label79.Text = Convert.ToString((Convert.ToDouble(textBox37.Text) * Convert.ToDouble(textBox52.Text) * Convert.ToDouble(textBox53.Text)) / (8.31f * Convert.ToDouble(textBox38.Text)));
            }
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            if (textBox52.Text != "")
            {
                label79.Text = Convert.ToString((Convert.ToDouble(textBox37.Text) * Convert.ToDouble(textBox52.Text) * Convert.ToDouble(textBox53.Text)) / (8.31f * Convert.ToDouble(textBox38.Text)));
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (textBox38.Text != "")
            {
                label79.Text = Convert.ToString(Convert.ToDouble(textBox37.Text) * Convert.ToDouble(textBox52.Text) * Convert.ToDouble(textBox53.Text) / (8.31f * Convert.ToDouble(textBox38.Text)));
            }
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (textBox37.Text != "")
            {
                label79.Text = Convert.ToString((Convert.ToDouble(textBox37.Text) * Convert.ToDouble(textBox52.Text) * Convert.ToDouble(textBox53.Text)) / (8.31f * Convert.ToDouble(textBox38.Text)));
            }
        }

        private void textBox53_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox53.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox52_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox52.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox38.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox37.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            if (textBox75.Text != "")
            {
                label158.Text = Convert.ToString((Convert.ToDouble(textBox75.Text) * Convert.ToDouble(textBox74.Text)) / (8.31 * Convert.ToDouble(textBox73.Text)));
            }
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            if (textBox74.Text != "")
            {
                label158.Text = Convert.ToString((Convert.ToDouble(textBox75.Text) * Convert.ToDouble(textBox74.Text)) / (8.31 * Convert.ToDouble(textBox73.Text)));
            }
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            if (textBox73.Text != "")
            {
                label158.Text = Convert.ToString((Convert.ToDouble(textBox75.Text) * Convert.ToDouble(textBox74.Text)) / (8.31 * Convert.ToDouble(textBox73.Text)));
            }
        }

        private void textBox73_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox73.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox74_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox74.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox75_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox75.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            if (textBox69.Text != "")
            {
                label148.Text = Convert.ToString(Convert.ToDouble(textBox69.Text) / Convert.ToDouble(textBox68.Text));
            }
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            if (textBox68.Text != "")
            {
                label148.Text = Convert.ToString(Convert.ToDouble(textBox69.Text) / Convert.ToDouble(textBox68.Text));
            }
        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            if (textBox78.Text != "")
            {
                label141.Text = Convert.ToString((Convert.ToDouble(textBox76.Text) * Convert.ToDouble(textBox66.Text))/(8.31* (Convert.ToDouble(textBox78.Text)/ Convert.ToDouble(textBox77.Text))));
            }
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            if (textBox77.Text != "")
            {
                label141.Text = Convert.ToString((Convert.ToDouble(textBox76.Text) * Convert.ToDouble(textBox66.Text)) / (8.31 * (Convert.ToDouble(textBox78.Text) / Convert.ToDouble(textBox77.Text))));
            }
        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            if (textBox76.Text != "")
            {
                label141.Text = Convert.ToString((Convert.ToDouble(textBox76.Text) * Convert.ToDouble(textBox66.Text)) / (8.31 * (Convert.ToDouble(textBox78.Text) / Convert.ToDouble(textBox77.Text))));
            }
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            if (textBox66.Text != "")
            {
                label141.Text = Convert.ToString((Convert.ToDouble(textBox76.Text) * Convert.ToDouble(textBox66.Text)) / (8.31 * (Convert.ToDouble(textBox78.Text) / Convert.ToDouble(textBox77.Text))));
            }
        }

        private void textBox78_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox78.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox77_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox77.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox76_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox76.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox66_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && (textBox66.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
