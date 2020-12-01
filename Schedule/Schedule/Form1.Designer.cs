
namespace Schedule
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Base = new System.Windows.Forms.DataGridView();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AT = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.BT = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.WT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ta = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.TextBox();
            this.Single = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Sing = new System.Windows.Forms.RadioButton();
            this.Multi = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Base)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.Ext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Ext
            // 
            this.Ext.BackColor = System.Drawing.Color.Red;
            this.Ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ext.Location = new System.Drawing.Point(600, 9);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(28, 23);
            this.Ext.TabIndex = 1;
            this.Ext.Text = "X";
            this.Ext.UseVisualStyleBackColor = false;
            this.Ext.Click += new System.EventHandler(this.Ext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scheduling";
            // 
            // Base
            // 
            this.Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Base.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P,
            this.A,
            this.B});
            this.Base.GridColor = System.Drawing.Color.Black;
            this.Base.Location = new System.Drawing.Point(238, 61);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(343, 235);
            this.Base.TabIndex = 2;
            this.Base.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Base_CellContentClick);
            // 
            // P
            // 
            this.P.HeaderText = "Process";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            // 
            // A
            // 
            this.A.HeaderText = "ArrivalTime";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // B
            // 
            this.B.HeaderText = "BurstTime";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Process :";
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(24, 111);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(144, 20);
            this.Process.TabIndex = 4;
            this.Process.TextChanged += new System.EventHandler(this.Process_TextChanged);
            this.Process.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Process_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arrival Time :";
            // 
            // AT
            // 
            this.AT.Location = new System.Drawing.Point(24, 181);
            this.AT.Name = "AT";
            this.AT.Size = new System.Drawing.Size(144, 20);
            this.AT.TabIndex = 6;
            this.AT.TextChanged += new System.EventHandler(this.AT_TextChanged);
            this.AT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AT_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(21, 217);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 15);
            this.label.TabIndex = 7;
            this.label.Text = "Burst Time :";
            // 
            // BT
            // 
            this.BT.Location = new System.Drawing.Point(24, 245);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(144, 20);
            this.BT.TabIndex = 8;
            this.BT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BT_KeyPress);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(13, 284);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(122, 284);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Clear";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // WT
            // 
            this.WT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WT.Location = new System.Drawing.Point(248, 321);
            this.WT.Name = "WT";
            this.WT.ReadOnly = true;
            this.WT.Size = new System.Drawing.Size(124, 20);
            this.WT.TabIndex = 11;
            this.WT.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Waiting Time";
            // 
            // Ta
            // 
            this.Ta.AutoSize = true;
            this.Ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ta.Location = new System.Drawing.Point(401, 302);
            this.Ta.Name = "Ta";
            this.Ta.Size = new System.Drawing.Size(122, 15);
            this.Ta.TabIndex = 13;
            this.Ta.Text = "Turn-around Time";
            // 
            // TT
            // 
            this.TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TT.Location = new System.Drawing.Point(404, 321);
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            this.TT.Size = new System.Drawing.Size(124, 20);
            this.TT.TabIndex = 14;
            this.TT.Text = "0";
            // 
            // Single
            // 
            this.Single.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Single.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Single.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Single.Location = new System.Drawing.Point(64, 319);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(77, 23);
            this.Single.TabIndex = 15;
            this.Single.Text = "Compute";
            this.Single.UseVisualStyleBackColor = false;
            this.Single.Click += new System.EventHandler(this.Compute_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(581, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(587, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(587, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(587, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(587, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(587, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(581, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(593, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(587, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(587, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(587, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(587, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(587, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(587, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(587, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "label20";
            // 
            // Sing
            // 
            this.Sing.AutoSize = true;
            this.Sing.Checked = true;
            this.Sing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sing.Location = new System.Drawing.Point(548, 302);
            this.Sing.Name = "Sing";
            this.Sing.Size = new System.Drawing.Size(60, 17);
            this.Sing.TabIndex = 33;
            this.Sing.TabStop = true;
            this.Sing.Text = "Single";
            this.Sing.UseVisualStyleBackColor = true;
            this.Sing.CheckedChanged += new System.EventHandler(this.Sing_CheckedChanged);
            // 
            // Multi
            // 
            this.Multi.AutoSize = true;
            this.Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi.Location = new System.Drawing.Point(548, 327);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(69, 17);
            this.Multi.TabIndex = 34;
            this.Multi.TabStop = true;
            this.Multi.Text = "Multiple";
            this.Multi.UseVisualStyleBackColor = true;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 378);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Sing);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Single);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.Ta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WT);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.BT);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Base)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Base;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Process;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AT;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox BT;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox WT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Ta;
        private System.Windows.Forms.TextBox TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.Button Single;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton Sing;
        private System.Windows.Forms.RadioButton Multi;
    }
}

