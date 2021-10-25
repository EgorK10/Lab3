using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFirstSystem.SelectedItem = "10";
            comboBoxSecondSystem.SelectedItem = "10";
        }

            private void radioButtonMath_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxMath.Visible = true;
            comboBoxCompare.Visible = false;
        }

        private void radioButtonCompare_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxMath.Visible = false;
            comboBoxCompare.Visible = true;
        }

        private void MathChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFirstNumber.Text) && !String.IsNullOrEmpty(textBoxSecondNumber.Text))
            {
                Number first = new(textBoxFirstNumber.Text, byte.Parse(comboBoxFirstSystem.Text));
                Number second = new(textBoxSecondNumber.Text, byte.Parse(comboBoxSecondSystem.Text));

                string answer = "";
                if (radioButtonMath.Checked)
                {
                    answer = ComboBoxMath.Text switch
                    {
                        "+" => (first + second).Num,
                        "-" => (first - second).Num,
                        "*" => (first * second).Num,
                        _ => "",
                    };
                }
                else if (radioButtonCompare.Checked)
                {
                    answer = comboBoxCompare.Text switch
                    {
                        "=" => first == second ? "Верно" : "Не верно",
                        ">" => first > second ? "Верно" : "Не верно",
                        "<" => first < second ? "Верно" : "Не верно",
                        "≠" => first != second ? "Верно" : "Не верно",
                        "≤" => first <= second ? "Верно" : "Не верно",
                        "≥" => first >= second ? "Верно" : "Не верно",
                        _ => "",
                    };
                }


                LabelAnswer.Text = answer != "" ? $"Ответ: {answer}" : "";
            }
            else
            {
                LabelAnswer.Text = "";
            }
        }

        private void comboBoxFirstSystem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxFirstNumber.Text = "";
        }

        private void comboBoxSecondSystem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxSecondNumber.Text = "";
        }

        private void textBoxFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar switch
            {
                'a' => 'A',
                'b' => 'B',
                'c' => 'C',
                'd' => 'D',
                'e' => 'E',
                'f' => 'F',
                _ => e.KeyChar,
            };
            e.Handled = comboBoxFirstSystem.Text switch
            {
                "2" => e.KeyChar == '0' || e.KeyChar == '1' || Char.IsControl(e.KeyChar) ? false : true,
                "8" => (Char.IsNumber(e.KeyChar) && e.KeyChar != '8' && e.KeyChar != '9') || Char.IsControl(e.KeyChar) ? false : true,
                "10" => Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) ? false : true,
                "16" => e.KeyChar == 'A' || e.KeyChar == 'B' ||e.KeyChar == 'C' || e.KeyChar == 'D' ||e.KeyChar == 'E' ||e.KeyChar == 'F' ||
                        Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) ? false : true,
                _ => true,
            };
        }

        private void textBoxSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar switch
            {
                'a' => 'A',
                'b' => 'B',
                'c' => 'C',
                'd' => 'D',
                'e' => 'E',
                'f' => 'F',
                _ => e.KeyChar,
            };
            e.Handled = comboBoxSecondSystem.Text switch
            {
                "2" => e.KeyChar == '0' || e.KeyChar == '1' || Char.IsControl(e.KeyChar) ? false : true,
                "8" => (Char.IsNumber(e.KeyChar) && e.KeyChar != '8' && e.KeyChar != '9') || Char.IsControl(e.KeyChar) ? false : true,
                "10" => Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) ? false : true,
                "16" => e.KeyChar == 'A' || e.KeyChar == 'B' || e.KeyChar == 'C' || e.KeyChar == 'D' || e.KeyChar == 'E' || e.KeyChar == 'F' ||
                        Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) ? false : true,
                _ => true,
            };
        }
    }    
}
