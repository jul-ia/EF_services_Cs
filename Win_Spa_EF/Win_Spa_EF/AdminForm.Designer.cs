namespace Win_Spa_EF
{
    partial class AdminForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxServ = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteS = new System.Windows.Forms.Button();
            this.buttonEditS = new System.Windows.Forms.Button();
            this.buttonAddS = new System.Windows.Forms.Button();
            this.groupBoxCat = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonDeleteCat = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonEditCat = new System.Windows.Forms.Button();
            this.buttonAddCat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxServ.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.groupBoxCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(81, -41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "All purchases:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "All purchases:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(25, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(634, 198);
            this.dataGridView1.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(347, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Services";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(25, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Categories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxServ
            // 
            this.groupBoxServ.Controls.Add(this.comboBox3);
            this.groupBoxServ.Controls.Add(this.groupBoxService);
            this.groupBoxServ.Controls.Add(this.buttonDeleteS);
            this.groupBoxServ.Controls.Add(this.buttonEditS);
            this.groupBoxServ.Controls.Add(this.buttonAddS);
            this.groupBoxServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxServ.Location = new System.Drawing.Point(305, 302);
            this.groupBoxServ.Name = "groupBoxServ";
            this.groupBoxServ.Size = new System.Drawing.Size(383, 253);
            this.groupBoxServ.TabIndex = 23;
            this.groupBoxServ.TabStop = false;
            this.groupBoxServ.Text = "Services operations:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(121, 35);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(247, 24);
            this.comboBox3.TabIndex = 18;
            // 
            // groupBoxService
            // 
            this.groupBoxService.Controls.Add(this.buttonOk);
            this.groupBoxService.Controls.Add(this.textBox5);
            this.groupBoxService.Controls.Add(this.label4);
            this.groupBoxService.Controls.Add(this.textBox4);
            this.groupBoxService.Controls.Add(this.textBox3);
            this.groupBoxService.Controls.Add(this.label3);
            this.groupBoxService.Controls.Add(this.label2);
            this.groupBoxService.Location = new System.Drawing.Point(121, 68);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.Size = new System.Drawing.Size(247, 176);
            this.groupBoxService.TabIndex = 11;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "Add service";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(79, 134);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 17;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 106);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(131, 22);
            this.textBox5.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 22);
            this.textBox3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // buttonDeleteS
            // 
            this.buttonDeleteS.Location = new System.Drawing.Point(21, 93);
            this.buttonDeleteS.Name = "buttonDeleteS";
            this.buttonDeleteS.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteS.TabIndex = 10;
            this.buttonDeleteS.Text = "Delete";
            this.buttonDeleteS.UseVisualStyleBackColor = true;
            this.buttonDeleteS.Click += new System.EventHandler(this.buttonDeleteS_Click);
            // 
            // buttonEditS
            // 
            this.buttonEditS.Location = new System.Drawing.Point(21, 151);
            this.buttonEditS.Name = "buttonEditS";
            this.buttonEditS.Size = new System.Drawing.Size(75, 23);
            this.buttonEditS.TabIndex = 8;
            this.buttonEditS.Text = "Edit";
            this.buttonEditS.UseVisualStyleBackColor = true;
            this.buttonEditS.Click += new System.EventHandler(this.buttonEditS_Click);
            // 
            // buttonAddS
            // 
            this.buttonAddS.Location = new System.Drawing.Point(21, 37);
            this.buttonAddS.Name = "buttonAddS";
            this.buttonAddS.Size = new System.Drawing.Size(75, 23);
            this.buttonAddS.TabIndex = 7;
            this.buttonAddS.Text = "Add";
            this.buttonAddS.UseVisualStyleBackColor = true;
            this.buttonAddS.Click += new System.EventHandler(this.buttonAddS_Click);
            // 
            // groupBoxCat
            // 
            this.groupBoxCat.Controls.Add(this.textBox2);
            this.groupBoxCat.Controls.Add(this.buttonDeleteCat);
            this.groupBoxCat.Controls.Add(this.comboBox1);
            this.groupBoxCat.Controls.Add(this.buttonEditCat);
            this.groupBoxCat.Controls.Add(this.buttonAddCat);
            this.groupBoxCat.Controls.Add(this.textBox1);
            this.groupBoxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCat.Location = new System.Drawing.Point(25, 302);
            this.groupBoxCat.Name = "groupBoxCat";
            this.groupBoxCat.Size = new System.Drawing.Size(274, 253);
            this.groupBoxCat.TabIndex = 22;
            this.groupBoxCat.TabStop = false;
            this.groupBoxCat.Text = "Category operations:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 22);
            this.textBox2.TabIndex = 5;
            // 
            // buttonDeleteCat
            // 
            this.buttonDeleteCat.Location = new System.Drawing.Point(187, 110);
            this.buttonDeleteCat.Name = "buttonDeleteCat";
            this.buttonDeleteCat.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCat.TabIndex = 4;
            this.buttonDeleteCat.Text = "Delete";
            this.buttonDeleteCat.UseVisualStyleBackColor = true;
            this.buttonDeleteCat.Click += new System.EventHandler(this.buttonDeleteCat_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonEditCat
            // 
            this.buttonEditCat.Location = new System.Drawing.Point(187, 199);
            this.buttonEditCat.Name = "buttonEditCat";
            this.buttonEditCat.Size = new System.Drawing.Size(75, 23);
            this.buttonEditCat.TabIndex = 2;
            this.buttonEditCat.Text = "Edit";
            this.buttonEditCat.UseVisualStyleBackColor = true;
            this.buttonEditCat.Click += new System.EventHandler(this.buttonEditCat_Click);
            // 
            // buttonAddCat
            // 
            this.buttonAddCat.Location = new System.Drawing.Point(187, 37);
            this.buttonAddCat.Name = "buttonAddCat";
            this.buttonAddCat.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCat.TabIndex = 1;
            this.buttonAddCat.Text = "Add";
            this.buttonAddCat.UseVisualStyleBackColor = true;
            this.buttonAddCat.Click += new System.EventHandler(this.buttonAddCat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(528, 258);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Choose category:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxServ);
            this.Controls.Add(this.groupBoxCat);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxServ.ResumeLayout(false);
            this.groupBoxService.ResumeLayout(false);
            this.groupBoxService.PerformLayout();
            this.groupBoxCat.ResumeLayout(false);
            this.groupBoxCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxServ;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteS;
        private System.Windows.Forms.Button buttonEditS;
        private System.Windows.Forms.Button buttonAddS;
        private System.Windows.Forms.GroupBox groupBoxCat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonDeleteCat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonEditCat;
        private System.Windows.Forms.Button buttonAddCat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
    }
}