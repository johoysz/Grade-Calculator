/* by jlb */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void maskedTextBoxUserInput_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter 0 to 100 only.", maskedTextBoxUserInput);
        }
        private void calButton_MouseEnter(object sender, EventArgs e)
        {
            calButton.BackColor = Color.White;
        }
        private void calButton_MouseHover(object sender, EventArgs e)
        {
            calButton.BackColor = Color.White;
        }
        private void calButton_MouseLeave(object sender, EventArgs e)
        {
            calButton.BackColor = Color.IndianRed;
        }
        private void calButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int calculate = Convert.ToInt32(maskedTextBoxUserInput.Text);
            if (calculate >= 90 && calculate <= 100)
            {
                gradeLabel.Text = "A";
            }
            else if (calculate >= 80 && calculate <= 89)
            {
                gradeLabel.Text = "B";
            }
            else if (calculate >= 70 && calculate <= 79)
            {
                gradeLabel.Text = "C";
            }
            else if (calculate >= 60 && calculate <= 69)
            {
                gradeLabel.Text = "D";
            }
            else if (calculate >= 0 && calculate <= 59)
            {
                gradeLabel.Text = "F";
            }
            else { gradeLabel.Text = "~"; }
        }
        private void maskedTextBoxUserInput_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxUserInput.Text == "") {
                gradeLabel.Text = string.Empty;
            }
        }
    }
}
