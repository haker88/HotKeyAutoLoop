using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public bool Run = false;

        public Form1()
        {
            InitializeComponent();
            InputSimulator sim = new InputSimulator();
            textBox5.Text = "60";
            button3.Hide();
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.SelectedIndex =0;
            comboBox1.Refresh();          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Go to Prism Settings\r\n2.Hotkeys - programm hotkeys for each scene: Shift + 1 for scene 1, Shift + 2 for scene 2 and so on.\r\n3.Select how many scenes you have in switching program.\r\n4.Click 'Start auto switching'");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox5.Text, out int value)||(textBox5.Text.Length==0))
            {
                // Here comes the code if numeric
            }
            else
            {
                MessageBox.Show("only numbers are allowed");      }
        }


        public void switcher()
        {
            int seconds = Convert.ToInt32(textBox5.Text)*1000;
           
            InputSimulator sim = new InputSimulator();
            while (Run)
            {  sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }

        }

        public void switcher2()
        {
            int seconds = Convert.ToInt32(textBox5.Text)*1000;

            InputSimulator sim = new InputSimulator();
            while (Run)
            {

                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }

        }

        public void switcher3()
        {
            int seconds = Convert.ToInt32(textBox5.Text) * 1000;

            InputSimulator sim = new InputSimulator();
            while (Run)
            {

                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }

        }

        public void switcher4()
        {
            int seconds = Convert.ToInt32(textBox5.Text) * 1000;

            InputSimulator sim = new InputSimulator();
            while (Run)
            {

                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }

        }

        public void switcher5()
        {
            int seconds = Convert.ToInt32(textBox5.Text) * 1000;

            InputSimulator sim = new InputSimulator();
            while (Run)
            {

                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }

        }

        public void switcher6()
        {
            int seconds = Convert.ToInt32(textBox5.Text) * 1000;

            InputSimulator sim = new InputSimulator();
            while (Run)
            {

                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_7);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }

        }

        public void switcher7()
        {
            int seconds = Convert.ToInt32(textBox5.Text) * 1000;

            InputSimulator sim = new InputSimulator();
            while (Run)
            {

                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_7);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_8);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }

        }

        public void switcher8()
        {
            int seconds = Convert.ToInt32(textBox5.Text) * 1000;

            InputSimulator sim = new InputSimulator();
            while (Run)
            {

                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_7);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_8);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_9);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }

        }

        public void switcher9()
        {
            int seconds = Convert.ToInt32(textBox5.Text) * 1000;

            InputSimulator sim = new InputSimulator();
            while (Run)
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_7);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_8);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_9);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                Thread.Sleep(seconds);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Show();
            Run = true;

            switch (Convert.ToInt16(comboBox1.SelectedItem.ToString()))
            {
                case 2:
                    var thread = new Thread(switcher);
                    th2.Start();
                    break;
                case 3:
                    Thread th2 = new Thread(switcher2);
                    th2.Start();
                    break;
                case 4:
                    Thread th3 = new Thread(switcher3);
                    th3.Start();
                    break;
                case 5:
                    Thread th4 = new Thread(switcher4);
                    th4.Start();
                    break;
                case 6:
                    Thread th5 = new Thread(switcher5);
                    th5.Start();
                    break;
                case 7:
                    Thread th6 = new Thread(switcher6);
                    th6.Start();
                    break;
                case 8:
                    Thread th7 = new Thread(switcher7);
                    th7.Start();
                    break;
                case 9:
                    Thread th8 = new Thread(switcher8);
                    th8.Start();
                    break;
                case 10:
                    Thread th9 = new Thread(switcher9);
                    th9.Start();
                    break;
                default:
                    // code block
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string end = comboBox1.SelectedItem.ToString();
            button2.Text = "Start auto switching: 1-" + end;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Run = false;
            button3.Hide();
        }
    }
}
