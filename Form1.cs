using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KirbyBlowoutBlastSaveEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("Before editing your savefile, be sure to back it up just in case!", "Warning!");
            InitializeComponent();
            dlg.Filter = "Blowout Blast savefile (*.dat)|*.dat";
            button2.Click += new System.EventHandler(ClickedSaveButton);

            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            label13.Enabled = false;
            label14.Enabled = false;
            label15.Enabled = false;
            label16.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;
            label20.Enabled = false;
            label21.Enabled = false;
            label22.Enabled = false;
            label23.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;
            radioButton13.Enabled = false;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            radioButton16.Enabled = false;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
            radioButton19.Enabled = false;
            radioButton20.Enabled = false;
            radioButton21.Enabled = false;
            radioButton22.Enabled = false;
            radioButton23.Enabled = false;
            radioButton24.Enabled = false;
            radioButton25.Enabled = false;
            radioButton26.Enabled = false;
            radioButton27.Enabled = false;
            radioButton28.Enabled = false;
            radioButton29.Enabled = false;
            radioButton30.Enabled = false;
            radioButton31.Enabled = false;
            radioButton32.Enabled = false;
            radioButton33.Enabled = false;
            radioButton34.Enabled = false;
            radioButton35.Enabled = false;
            radioButton36.Enabled = false;
            radioButton37.Enabled = false;
            radioButton38.Enabled = false;
            radioButton39.Enabled = false;
            radioButton40.Enabled = false;
            radioButton41.Enabled = false;
            radioButton42.Enabled = false;
            radioButton43.Enabled = false;
            radioButton44.Enabled = false;
            radioButton45.Enabled = false;
            radioButton46.Enabled = false;
            radioButton47.Enabled = false;
            radioButton48.Enabled = false;
            radioButton49.Enabled = false;
            radioButton50.Enabled = false;
            radioButton51.Enabled = false;
        }

        public void UncheckTrophies()
        {
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
        }

        OpenFileDialog dlg = new OpenFileDialog();

        private void ClickedSaveButton(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x28;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }

                bnw.BaseStream.Position = 0x2C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x30;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x34;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x34;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x34;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x34;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }

            if (radioButton2.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x44;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }

                bnw.BaseStream.Position = 0x48;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x4C;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x50;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x50;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x50;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x50;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }

            if (radioButton3.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x60;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x64;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x68;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x6C;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x6C;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x6C;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x6C;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }

            if (radioButton4.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x7C;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x80;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x84;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x88;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x88;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x88;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x88;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }

            if (radioButton5.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0xC4;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0xC8;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0xCC;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0xD0;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0xD0;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0xD0;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0xD0;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }

            if (radioButton6.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0xE0;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0xE4;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0xE8;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0xEC;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0xEC;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0xEC;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0xEC;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }

            if (radioButton7.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0xFC;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x100;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x104;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x108;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x108;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x108;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x108;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }

            if (radioButton8.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x118;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x11C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x120;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x124;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x124;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x124;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x124;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton9.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x160;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x164;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x168;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x16C;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x16C;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x16C;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x16C;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton10.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x17C;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x180;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x184;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x188;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x188;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x188;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x188;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton11.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x198;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x19C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x1A0;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x1A4;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x1A4;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x1A4;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x1A4;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton12.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x1B4;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x1B8;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x1BC;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x1C0;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x1C0;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x1C0;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x1C0;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton13.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x1D0;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x1D4;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x1D8;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x1DC;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x1DC;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x1DC;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x1DC;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton14.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x1FC;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x200;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x204;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x208;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x208;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x208;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x208;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton15.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x218;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x21C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x220;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x224;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x224;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x224;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x224;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton16.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x234;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x238;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x23C;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x240;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x240;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x240;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x240;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton17.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x250;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x254;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x258;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x25C;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x25C;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x25C;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x25C;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton18.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x26C;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x270;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x274;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x278;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x278;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x278;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x278;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton23.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x298;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x29C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x2A0;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x2A4;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x2A4;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x2A4;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x2A4;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton24.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x2B4;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x2B8;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x2BC;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x2C0;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x2C0;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x2C0;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x2C0;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton25.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x2D0;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x2D4;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x2D8;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x2DC;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x2DC;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x2DC;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x2DC;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton26.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x2EC;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x2F0;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x2F4;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x2F8;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x2F8;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x2F8;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x2F8;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton27.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x308;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x30C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x310;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x314;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x314;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x314;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x314;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton28.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x334;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x338;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x33C;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x340;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x340;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x340;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x340;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton29.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x350;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x354;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x358;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x35C;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x35C;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x35C;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x35C;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton30.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x36C;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x370;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x374;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x378;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x378;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x378;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x378;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton31.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x388;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x38C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x390;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x394;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x394;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x394;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x394;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton35.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x3D0;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x3D4;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x3D8;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x3DC;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x3DC;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x3DC;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x3DC;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton34.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x3EC;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x3F0;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x3F4;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x3F8;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x3F8;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x3F8;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x3F8;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton33.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x408;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x40C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x410;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x414;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x414;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x414;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x414;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton32.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x424;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x428;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x42C;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x430;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x430;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x430;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x430;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton40.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x46C;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x470;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x474;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x478;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x478;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x478;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x478;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton39.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x488;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x48C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x490;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x494;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x494;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x494;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x494;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton38.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x4A4;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x4A8;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x4AC;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x4B0;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x4B0;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x4B0;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x4B0;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton37.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x4C0;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x4C4;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x4C8;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x4CC;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x4CC;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x4CC;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x4CC;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton36.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x4DC;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x4E0;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x4E4;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x4E8;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x4E8;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x4E8;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x4E8;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton45.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x508;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x50C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x510;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x514;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x514;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x514;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x514;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton44.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x524;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x528;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x52C;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x530;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x530;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x530;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x530;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton43.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x540;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x544;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x548;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x54C;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x54C;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x54C;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x54C;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton42.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x55C;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x560;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x564;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x568;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x568;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x568;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x568;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton41.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x578;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x57C;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x580;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x584;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x584;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x584;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x584;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton50.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x5A4;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x5A8;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x5AC;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x5B0;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x5B0;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x5B0;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x5B0;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton49.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x5C0;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x5C4;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x5C8;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x5CC;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x5CC;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x5CC;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x5CC;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton48.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x5DC;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x5E0;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x5E4;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x5E8;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x5E8;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x5E8;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x5E8;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton47.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x5F8;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x5FC;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x600;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x604;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x604;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x604;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x604;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton46.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x614;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x618;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x61C;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x620;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x620;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x620;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x620;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
            if (radioButton51.Checked)
            {
                BinaryWriter bnw = new BinaryWriter(File.OpenWrite(dlg.FileName));

                bnw.BaseStream.Position = 0x634;
                int FirstScore = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Input a higher value than 0 for the first score!", "Error!");
                }
                else
                {
                    bnw.Write(FirstScore);
                    label3.Text = Convert.ToString(FirstScore);
                }


                bnw.BaseStream.Position = 0x638;
                int SecondScore = Convert.ToInt32(numericUpDown2.Value);
                bnw.Write(SecondScore);
                label6.Text = Convert.ToString(SecondScore);

                bnw.BaseStream.Position = 0x63C;
                int ThirdScore = Convert.ToInt32(numericUpDown3.Value);
                bnw.Write(ThirdScore);
                label8.Text = Convert.ToString(ThirdScore);

                if (radioButton19.Checked)
                {
                    bnw.BaseStream.Position = 0x640;
                    bnw.Write(3);
                    label10.Text = "Bronze";
                }
                if (radioButton20.Checked)
                {
                    bnw.BaseStream.Position = 0x640;
                    bnw.Write(2);
                    label10.Text = "Silver";
                }
                if (radioButton21.Checked)
                {
                    bnw.BaseStream.Position = 0x640;
                    bnw.Write(1);
                    label10.Text = "Gold";
                }
                if (radioButton22.Checked)
                {
                    bnw.BaseStream.Position = 0x640;
                    bnw.Write(0);
                    label10.Text = "Platinum";
                }
                bnw.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x28;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x30;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x34;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x34;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x34;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x34;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();

            label24.Text = Path.GetFileName(dlg.FileName).ToString();
            label25.Text = Path.GetFileName(dlg.FileName).ToString();

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            radioButton9.Enabled = true;
            radioButton10.Enabled = true;
            radioButton11.Enabled = true;
            radioButton12.Enabled = true;
            radioButton13.Enabled = true;
            radioButton14.Enabled = true;
            radioButton15.Enabled = true;
            radioButton16.Enabled = true;
            radioButton17.Enabled = true;
            radioButton18.Enabled = true;
            radioButton23.Enabled = true;
            radioButton24.Enabled = true;
            radioButton25.Enabled = true;
            radioButton26.Enabled = true;
            radioButton27.Enabled = true;
            radioButton28.Enabled = true;
            radioButton29.Enabled = true;
            radioButton30.Enabled = true;
            radioButton31.Enabled = true;
            radioButton32.Enabled = true;
            radioButton33.Enabled = true;
            radioButton34.Enabled = true;
            radioButton35.Enabled = true;
            radioButton36.Enabled = true;
            radioButton37.Enabled = true;
            radioButton38.Enabled = true;
            radioButton39.Enabled = true;
            radioButton40.Enabled = true;
            radioButton41.Enabled = true;
            radioButton42.Enabled = true;
            radioButton43.Enabled = true;
            radioButton44.Enabled = true;
            radioButton45.Enabled = true;
            radioButton46.Enabled = true;
            radioButton47.Enabled = true;
            radioButton48.Enabled = true;
            radioButton49.Enabled = true;
            radioButton50.Enabled = true;
            radioButton51.Enabled = true;
            label1.Enabled = true;
            label4.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;
            label14.Enabled = true;
            label15.Enabled = true;
            label16.Enabled = true;
            label17.Enabled = true;
            label18.Enabled = true;
            label19.Enabled = true;
            label20.Enabled = true;
            label21.Enabled = true;
            label22.Enabled = true;
            label23.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x07;
            if (bnr.ReadByte() == (0))
            {
                label19.Text = "Locked";
            }
            else
            {
                checkBox1.Checked = true;
                label19.Text = "Unlocked";
            }

            bnr.BaseStream.Position = 0x09;
            if (bnr.ReadByte() == (0))
            {
                label20.Text = "Locked";
            }
            else
            {
                checkBox2.Checked = true;
                label20.Text = "Unlocked";
            }

            bnr.BaseStream.Position = 0x0B;
            if (bnr.ReadByte() == (0))
            {
                label21.Text = "Locked";
            }
            else
            {
                checkBox3.Checked = true;
                label21.Text = "Unlocked";
            }

            bnr.BaseStream.Position = 0x0D;
            if (bnr.ReadByte() == (0))
            {
                label22.Text = "Locked";
            }
            else
            {
                checkBox4.Checked = true;
                label22.Text = "Unlocked";
            }

            bnr.BaseStream.Position = 0x0F;
            if (bnr.ReadByte() == (0))
            {
                label23.Text = "Locked";
            }
            else
            {
                checkBox5.Checked = true;
                label23.Text = "Unlocked";
            }

            bnr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();

            label24.Text = Path.GetFileName(dlg.FileName).ToString();
            label25.Text = Path.GetFileName(dlg.FileName).ToString();

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            radioButton9.Enabled = true;
            radioButton10.Enabled = true;
            radioButton11.Enabled = true;
            radioButton12.Enabled = true;
            radioButton13.Enabled = true;
            radioButton14.Enabled = true;
            radioButton15.Enabled = true;
            radioButton16.Enabled = true;
            radioButton17.Enabled = true;
            radioButton18.Enabled = true;
            radioButton23.Enabled = true;
            radioButton24.Enabled = true;
            radioButton25.Enabled = true;
            radioButton26.Enabled = true;
            radioButton27.Enabled = true;
            radioButton28.Enabled = true;
            radioButton29.Enabled = true;
            radioButton30.Enabled = true;
            radioButton31.Enabled = true;
            radioButton32.Enabled = true;
            radioButton33.Enabled = true;
            radioButton34.Enabled = true;
            radioButton35.Enabled = true;
            radioButton36.Enabled = true;
            radioButton37.Enabled = true;
            radioButton38.Enabled = true;
            radioButton39.Enabled = true;
            radioButton40.Enabled = true;
            radioButton41.Enabled = true;
            radioButton42.Enabled = true;
            radioButton43.Enabled = true;
            radioButton44.Enabled = true;
            radioButton45.Enabled = true;
            radioButton46.Enabled = true;
            radioButton47.Enabled = true;
            radioButton48.Enabled = true;
            radioButton49.Enabled = true;
            radioButton50.Enabled = true;
            radioButton51.Enabled = true;
            label1.Enabled = true;
            label4.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;
            label14.Enabled = true;
            label15.Enabled = true;
            label16.Enabled = true;
            label17.Enabled = true;
            label18.Enabled = true;
            label19.Enabled = true;
            label20.Enabled = true;
            label21.Enabled = true;
            label22.Enabled = true;
            label23.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button2.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x07;
            if (bnr.ReadByte() == (0))
            {
                label19.Text = "Locked";
            }
            else
            {
                checkBox1.Checked = true;
                label19.Text = "Unlocked";
            }

            bnr.BaseStream.Position = 0x09;
            if (bnr.ReadByte() == (0))
            {
                label20.Text = "Locked";
            }
            else
            {
                checkBox2.Checked = true;
                label20.Text = "Unlocked";
            }

            bnr.BaseStream.Position = 0x0B;
            if (bnr.ReadByte() == (0))
            {
                label21.Text = "Locked";
            }
            else
            {
                checkBox3.Checked = true;
                label21.Text = "Unlocked";
            }

            bnr.BaseStream.Position = 0x0D;
            if (bnr.ReadByte() == (0))
            {
                label22.Text = "Locked";
            }
            else
            {
                checkBox4.Checked = true;
                label22.Text = "Unlocked";
            }

            bnr.BaseStream.Position = 0x0F;
            if (bnr.ReadByte() == (0))
            {
                label23.Text = "Locked";
            }
            else
            {
                checkBox5.Checked = true;
                label23.Text = "Unlocked";
            }

            bnr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();
            
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x44;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x48;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4C;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x50;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x50;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x50;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x50;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x60;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x64;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x68;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x6C;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x6C;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x6C;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x6C;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x7C;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x80;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x84;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x88;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x88;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x88;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x88;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0xC4;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0xC8;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0xCC;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0xD0;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0xD0;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0xD0;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0xD0;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0xE0;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0xE4;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0xE8;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0xEC;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0xEC;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0xEC;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0xEC;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0xFC;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x100;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x104;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x108;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x108;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x108;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x108;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x118;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x11C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x120;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x124;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x124;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x124;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x124;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x160;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x164;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x168;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x16C;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x16C;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x16C;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x16C;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x17C;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x180;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x184;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x188;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x188;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x188;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x188;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x198;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x19C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x1A0;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x1A4;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x1A4;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x1A4;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x1A4;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x1B4;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x1B8;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x1BC;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x1C0;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x1C0;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x1C0;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x1C0;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x1D0;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x1D4;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x1D8;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x1DC;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x1DC;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x1DC;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x1DC;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x1FC;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x200;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x204;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x208;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x208;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x208;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x208;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x218;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x21C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x220;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x224;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x224;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x224;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x224;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x234;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x238;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x23C;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x240;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x240;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x240;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x240;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x250;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x254;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x258;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x25C;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x25C;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x25C;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x25C;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x26C;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x270;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x274;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x278;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x278;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x278;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x278;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x298;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x29C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2A0;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2A4;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x2A4;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x2A4;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x2A4;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x2B4;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2B8;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2BC;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2C0;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x2C0;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x2C0;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x2C0;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x2D0;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2D4;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2D8;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2DC;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x2DC;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x2DC;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x2DC;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x2EC;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2F0;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2F4;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x2F8;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x2F8;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x2F8;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x2F8;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x308;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x30C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x310;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x314;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x314;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x314;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x314;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x334;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x338;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x33C;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x340;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x340;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x340;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x340;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x350;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x354;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x358;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x35C;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x35C;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x35C;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x35C;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x36C;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x370;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x374;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x378;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x378;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x378;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x378;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x388;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x38C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x390;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x394;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x394;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x394;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x394;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x3D0;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x3D4;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x3D8;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x3DC;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x3DC;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x3DC;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x3DC;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x3EC;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x3F0;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x3F4;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x3F8;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x3F8;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x3F8;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x3F8;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x408;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x40C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x410;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x414;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x414;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x414;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x414;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x424;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x428;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x42C;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x430;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x430;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x430;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x430;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x46C;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x470;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x474;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x478;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x478;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x478;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x478;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x488;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x48C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x490;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x494;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x494;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x494;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x494;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x4A4;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4A8;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4AC;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4B0;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x4B0;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x4B0;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x4B0;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x4C0;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4C4;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4C8;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4CC;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x4CC;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x4CC;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x4CC;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x4DC;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4E0;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4E4;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x4E8;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x4E8;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x4E8;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x4E8;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x508;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x50C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x510;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x514;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x514;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x514;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x514;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x524;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x528;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x52C;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x530;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x530;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x530;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x530;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x540;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x544;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x548;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x54C;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x54C;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x54C;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x54C;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x55C;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x560;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x564;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x568;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x568;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x568;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x568;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x578;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x57C;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x580;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x584;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x584;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x584;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x584;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x5A4;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5A8;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5AC;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5B0;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x5B0;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x5B0;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x5B0;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x5C0;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5C4;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5C8;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5CC;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x5CC;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x5CC;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x5CC;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x5DC;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5E0;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5E4;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5E8;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x5E8;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x5E8;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x5E8;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x5F8;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x5FC;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x600;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x604;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x604;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x604;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x604;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x614;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x618;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x61C;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x620;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x620;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x620;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x620;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            UncheckTrophies();

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            button2.Enabled = true;

            BinaryReader bnr = new BinaryReader(File.OpenRead(dlg.FileName));

            bnr.BaseStream.Position = 0x634;
            label3.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x638;
            label6.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x63C;
            label8.Text = bnr.ReadInt32().ToString();

            bnr.BaseStream.Position = 0x640;
            if (bnr.ReadByte() == (0))
            {
                label10.Text = "Platinum";
            }

            bnr.BaseStream.Position = 0x340;
            if (bnr.ReadByte() == (1))
            {
                label10.Text = "Gold";
            }

            bnr.BaseStream.Position = 0x640;
            if (bnr.ReadByte() == (2))
            {
                label10.Text = "Silver";
            }

            bnr.BaseStream.Position = 0x640;
            if (bnr.ReadByte() == (3))
            {
                label10.Text = "Bronze";
            }

            bnr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryWriter bnr = new BinaryWriter(File.OpenWrite(dlg.FileName));

            if (checkBox1.Checked)
            {
                bnr.BaseStream.Position = 0x07;
                int writeValue = Convert.ToByte(1);
                bnr.Write(writeValue);
                label19.Text = "Unlocked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x08;
                    bnr.Write(writeValue);
                }
            }

            else if (checkBox1.Checked == false)
            {
                bnr.BaseStream.Position = 0x07;
                int writeValue = Convert.ToByte(0);
                bnr.Write(writeValue);
                label19.Text = "Locked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x08;
                    bnr.Write(writeValue);
                }
            }


            if (checkBox2.Checked)
            {
                bnr.BaseStream.Position = 0x09;
                int writeValue = Convert.ToByte(1);
                bnr.Write(writeValue);
                label20.Text = "Unlocked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x0A;
                    bnr.Write(writeValue);
                }
            }

            else if (checkBox2.Checked == false)
            {
                bnr.BaseStream.Position = 0x09;
                int writeValue = Convert.ToByte(0);
                bnr.Write(writeValue);
                label20.Text = "Locked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x0A;
                    bnr.Write(writeValue);
                }
            }

            if (checkBox3.Checked)
            {
                bnr.BaseStream.Position = 0x0B;
                int writeValue = Convert.ToByte(1);
                bnr.Write(writeValue);
                label21.Text = "Unlocked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x0C;
                    bnr.Write(writeValue);
                }
            }

            else if (checkBox3.Checked == false)
            {
                bnr.BaseStream.Position = 0x0B;
                int writeValue = Convert.ToByte(0);
                bnr.Write(writeValue);
                label21.Text = "Locked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x0C;
                    bnr.Write(writeValue);
                }
            }

            if (checkBox4.Checked)
            {
                bnr.BaseStream.Position = 0x0D;
                int writeValue = Convert.ToByte(1);
                bnr.Write(writeValue);
                label22.Text = "Unlocked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x0E;
                    bnr.Write(writeValue);
                }
            }

            else if (checkBox4.Checked == false)
            {
                bnr.BaseStream.Position = 0x0D;
                int writeValue = Convert.ToByte(0);
                bnr.Write(writeValue);
                label22.Text = "Locked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x0E;
                    bnr.Write(writeValue);
                }
            }

            if (checkBox5.Checked)
            {
                bnr.BaseStream.Position = 0x0F;
                int writeValue = Convert.ToByte(1);
                bnr.Write(writeValue);
                label23.Text = "Unlocked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x10;
                    bnr.Write(writeValue);
                }
            }

            if (checkBox5.Checked == false)
            {
                bnr.BaseStream.Position = 0x0F;
                int writeValue = Convert.ToByte(0);
                bnr.Write(writeValue);
                label23.Text = "Locked";
                if (checkBox6.Checked)
                {
                    bnr.BaseStream.Position = 0x10;
                    bnr.Write(writeValue);
                }
            }


            bnr.Close();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
        }


    }
}
