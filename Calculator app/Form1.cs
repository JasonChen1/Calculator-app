using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //use to turn off the calculator
        public void disable()
        {
            //disable all the button when this method is called
            textBox1.Enabled = false;
            onButton.Show();//when off button is clicked onButton will show
            offButton.Hide(); //then hide offButton
            deleteButton.Enabled = false;
            clearButton.Enabled = false;
            multiplyButton.Enabled = false;
            numButton7.Enabled = false;
            numButton8.Enabled = false;
            numButton9.Enabled = false;
            minusButton.Enabled = false;
            plusButton.Enabled = false;
            numButton6.Enabled = false;
            numButton5.Enabled = false;
            numButton4.Enabled = false;
            divideButton.Enabled = false;
            numButton3.Enabled = false;
            numButton2.Enabled = false;
            numButton1.Enabled = false;
            equalButton.Enabled = false;
            dotButton.Enabled = false;
            numButton0.Enabled = false;
        }

        //turn on calculator
        public void enable()
        {
            //enable all the button when this method is called
            textBox1.Enabled = true;
            offButton.Show();//when on button is clicked offButton will show
            onButton.Hide();//then hide onButton
            deleteButton.Enabled = true;
            clearButton.Enabled = true;
            multiplyButton.Enabled = true;
            numButton7.Enabled = true;
            numButton8.Enabled = true;
            numButton9.Enabled = true;
            minusButton.Enabled = true;
            plusButton.Enabled = true;
            numButton6.Enabled = true;
            numButton5.Enabled = true;
            numButton4.Enabled = true;
            divideButton.Enabled = true;
            numButton3.Enabled = true;
            numButton2.Enabled = true;
            numButton1.Enabled = true;
            equalButton.Enabled = true;
            dotButton.Enabled = true;
            numButton0.Enabled = true;
        }

        //on button 
        private void button1_Click(object sender, EventArgs e)
        {
            enable();//turn on calculator
        }

        //dot button
        private void button20_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + '.';
            textBox1.ForeColor = Color.Red;
        }

        //button 0
        private void button21_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Red;
        }

        //button 1
        private void button17_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }


        //button 2
        private void button16_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }

        //button 3
        private void button15_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        //button 4
        private void button13_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        //button 5
        private void button12_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        //button 6
        private void button11_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        //button 7
        private void button6_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }

        //button 8
        private void button7_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }

        //button 9
        private void button8_Click(object sender, EventArgs e)
        {
            //Display text in textbox when button is pressed changed color to red
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }

        //off button
        private void button2_Click(object sender, EventArgs e)
        {
            disable();//calling disable function to turn off calculator
        }


        float num, ans;
        int count;

        public void compute()
        {
            //compute answers
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        //displaying text for *
        private void button5_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
            
        }

        //displaying text for +
        private void button10_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        //displaying text for -
        private void button9_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        //displaying text for /
        private void button14_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        //equal button
        private void button18_Click(object sender, EventArgs e)
        {
            compute();//compute result 
            label1.Text = "";//clear label
        }

        //clear button
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++ )
            {
                textBox1.Text = textBox1.Text + text[i];                 
            }

        }


    }
}
