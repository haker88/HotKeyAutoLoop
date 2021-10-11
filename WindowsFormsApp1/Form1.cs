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
        public Form1()
        {
            InitializeComponent();
            InputSimulator sim = new InputSimulator();
            textBox5.Text = "60";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
            int scenes = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            InputSimulator sim = new InputSimulator();
            while (true)
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
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
            while (true)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                switcher();
            }
            else
            {
                switcher2();
            }
        }
    }
}
