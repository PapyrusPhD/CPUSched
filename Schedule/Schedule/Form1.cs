using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class Homepage : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Homepage()
        {
            InitializeComponent();
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Process.TextLength == 0 || BT.TextLength == 0)
            {
                MessageBox.Show("Fill up the textbox!", "Error");
            }
            else
            {
                if (Sing.Checked)
                {
                    if (rows == 1)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label20.Text = Process.Text;
                        this.label19.Text = AT.Text;
                        this.label18.Text = BT.Text;

                    }
                    else if (rows == 2)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label17.Text = Process.Text;
                        this.label6.Text = label19.Text;
                        this.label7.Text = BT.Text;
                    }
                    else if (rows == 3)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label8.Text = Process.Text;
                        this.label9.Text = label19.Text;
                        this.label10.Text = BT.Text;
                    }
                    else if (rows == 4)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label11.Text = Process.Text;
                        this.label12.Text = label19.Text;
                        this.label13.Text = BT.Text;
                    }
                    else if (rows == 5)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label14.Text = Process.Text;
                        this.label15.Text = label19.Text;
                        this.label16.Text = BT.Text;
                    }
                    else
                    {
                        MessageBox.Show("Only minimum of 3 rows and maximum of 5 rows are accepted!", "Error");
                    }
                }
                else if (Multi.Checked)
                {
                    if (rows == 1)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label20.Text = Process.Text;
                        this.label19.Text = AT.Text;
                        this.label18.Text = BT.Text;

                    }
                    else if (rows == 2)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label17.Text = Process.Text;
                        this.label6.Text = AT.Text;
                        this.label7.Text = BT.Text;
                    }
                    else if (rows == 3)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label8.Text = Process.Text;
                        this.label9.Text = AT.Text;
                        this.label10.Text = BT.Text;
                    }
                    else if (rows == 4)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label11.Text = Process.Text;
                        this.label12.Text = AT.Text;
                        this.label13.Text = BT.Text;
                    }
                    else if (rows == 5)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label14.Text = Process.Text;
                        this.label15.Text = AT.Text;
                        this.label16.Text = BT.Text;
                    }
                    else
                    {
                        MessageBox.Show("Only minimum of 3 rows and maximum of 5 rows are accepted!", "Error");
                    }
                }
                
                
            }
            Process.Clear();
            AT.Clear();
            BT.Clear();
        }

        private void Process_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Process_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void AT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Base.Rows.Clear();
            Base.Refresh();
            AT.ReadOnly = false;
            Process.Clear();
            AT.Clear();
            BT.Clear();
            WT.Clear();
            TT.Clear();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
            Add.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Base_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Sing.Checked)
            {
                if (rows == 4)
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);

                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float sum = a1 + add1 + add2;
                    float div = sum / 3;
                    float ans = div - a1;
                    WT.Text = ans.ToString() + " ms";
                    // Turn Around Time
                    float add3 = add2 + b3;
                    float Tadd = add1 + add2 + add3;
                    float div2 = Tadd / 3;
                    float ans2 = div2 - a1;
                    TT.Text = ans2.ToString() + " ms";
                }
                else if (rows == 5)
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    // Row4
                    int a4 = Convert.ToInt32(label12.Text);
                    int b4 = Convert.ToInt32(label13.Text);

                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float add3 = add2 + b3;
                    float sum = a1 + add1 + add2 + add3;
                    float div = sum / 4;
                    float ans = div - a1;
                    WT.Text = ans.ToString() + " ms";
                    // Turn Around Time
                    float add4 = add3 + b4;
                    float Tadd = add1 + add2 + add3 + add4;
                    float div2 = Tadd / 4;
                    float ans2 = div2 - a1;
                    TT.Text = ans2.ToString() + " ms";
                }
                else if (rows == 6)
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    // Row4
                    int a4 = Convert.ToInt32(label12.Text);
                    int b4 = Convert.ToInt32(label13.Text);
                    // Row5
                    int a5 = Convert.ToInt32(label15.Text);
                    int b5 = Convert.ToInt32(label16.Text);

                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float add3 = add2 + b3;
                    float add4 = add3 + b4;
                    float sum = a1 + add1 + add2 + add3 + add4;
                    float div = sum / 5;
                    float ans = div - a1;
                    WT.Text = ans.ToString() + " ms";
                    // Turn Around Time
                    float add5 = add4 + b5;
                    float Tadd = add1 + add2 + add3 + add4 + add5;
                    float div2 = Tadd / 5;
                    float ans2 = div2 - a1;
                    TT.Text = ans2.ToString() + " ms";
                }
                else
                {
                    MessageBox.Show("You can only input 3-5 process!", "Error");
                }
            }
            else if (Multi.Checked)
            {
                if (rows == 4) //row 3
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);

                    var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 }};
                    for (int i = 0; i < input.GetLength(0) - 1; i++)
                    {
                        for (int j = i; j < input.GetLength(0); j++)
                        {
                            if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                            {
                                for (int k = 0; k < input.GetLength(1); k++)
                                {
                                    var temp = input[i, k];
                                    input[i, k] = input[j, k];
                                    input[j, k] = temp;
                                }
                            }
                        }
                    }
                    // finish time
                    double add1 = input[0, 0] + input[0, 1]; // 12
                    double add2 = add1 + input[1, 1]; // 20
                    double add3 = add2 + input[2, 1];
                    // waiting time
                    double wt1 = 0; // D
                    double wt2 = add1 - input[1, 0]; // A 9
                    double wt3 = add2 - input[2, 0]; // B 13
                    // average waiting time
                    double sum = wt1 + wt2 + wt3;
                    double div = sum / 3;
                    // average turn around time
                    double ta1 = add1 - input[0, 0]; // 10
                    double ta2 = add2 - input[1, 0]; // 17
                    double ta3 = add3 - input[2, 0]; // 28
                    // average turn around time
                    double sum1 = ta1 + ta2 + ta3;
                    double div1 = sum1 / 3;
                    WT.Text = div.ToString() + " ms";
                    TT.Text = div1.ToString() + " ms";
                    
                }
                else if (rows == 5) //row 4
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    // Row4
                    int a4 = Convert.ToInt32(label12.Text);
                    int b4 = Convert.ToInt32(label13.Text);

                    var input = new double[,] { { a1, b1}, { a2, b2}, { a3, b3}, { a4, b4} };
                    for (int i = 0; i < input.GetLength(0) - 1; i++)
                        {
                            for (int j = i; j < input.GetLength(0); j++)
                            {
                                if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                                {
                                    for (int k = 0; k < input.GetLength(1); k++)
                                    {
                                        var temp = input[i, k];
                                        input[i, k] = input[j, k];
                                        input[j, k] = temp;
                                    }
                                }
                            }
                        }
                    // finish time
                    double add1 = input[0,0] + input[0,1]; // 12
                    double add2 = add1 + input[1, 1]; // 20
                    double add3 = add2 + input[2, 1]; // 35
                    double add4 = add3 + input[3, 1]; // 46
                    // waiting time
                    double wt1 = 0; // D
                    double wt2 = add1 - input[1, 0]; // A 9
                    double wt3 = add2 - input[2, 0]; // B 13
                    double wt4 = add3 - input[3, 0]; // C 23
                    // average waiting time
                    double sum = wt1 + wt2 + wt3 + wt4;
                    double div = sum / 4;
                    // average turn around time
                    double ta1 = add1 - input[0, 0]; // 10
                    double ta2 = add2 - input[1, 0]; // 17
                    double ta3 = add3 - input[2, 0]; // 28
                    double ta4 = add4 - input[3, 0]; // 34
                    // average turn around time
                    double sum1 = ta1 + ta2 + ta3 + ta4;
                    double div1 = sum1 / 4;
                    WT.Text = div.ToString() + " ms";
                    TT.Text = div1.ToString() + " ms";
                }
                else if (rows == 6) //row5
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    // Row4
                    int a4 = Convert.ToInt32(label12.Text);
                    int b4 = Convert.ToInt32(label13.Text);
                    // Row5
                    int a5 = Convert.ToInt32(label15.Text);
                    int b5 = Convert.ToInt32(label16.Text);

                    var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 }, { a4, b4 }, { a5, b5 }};
                    for (int i = 0; i < input.GetLength(0) - 1; i++)
                    {
                        for (int j = i; j < input.GetLength(0); j++)
                        {
                            if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                            {
                                for (int k = 0; k < input.GetLength(1); k++)
                                {
                                    var temp = input[i, k];
                                    input[i, k] = input[j, k];
                                    input[j, k] = temp;
                                }
                            }
                        }
                    }
                    // finish time
                    double add1 = input[0, 0] + input[0, 1]; 
                    double add2 = add1 + input[1, 1]; 
                    double add3 = add2 + input[2, 1]; 
                    double add4 = add3 + input[3, 1];
                    double add5 = add4 + input[4, 1];
                    // waiting time
                    double wt1 = 0; // D
                    double wt2 = add1 - input[1, 0]; 
                    double wt3 = add2 - input[2, 0]; 
                    double wt4 = add3 - input[3, 0];
                    double wt5 = add4 - input[4, 0];
                    // average waiting time
                    double sum = wt1 + wt2 + wt3 + wt4 + wt5;
                    double div = sum / 5;
                    // average turn around time
                    double ta1 = add1 - input[0, 0]; // 10
                    double ta2 = add2 - input[1, 0]; // 17
                    double ta3 = add3 - input[2, 0]; // 28
                    double ta4 = add4 - input[3, 0]; // 34
                    double ta5 = add5 - input[4, 0];
                    // average turn around time
                    double sum1 = ta1 + ta2 + ta3 + ta4 + ta5;
                    double div1 = sum1 / 5;
                    WT.Text = div.ToString() + " ms";
                    TT.Text = div1.ToString() + " ms";
                }
            }
        }

        private void Sing_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AT_TextChanged(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Sing.Checked && rows >= 2)
            {
                AT.ReadOnly = true;
            }
        }
    }
}
