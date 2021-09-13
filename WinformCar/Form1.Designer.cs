
namespace WinformCar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVmotor = new System.Windows.Forms.Label();
            this.lblMaxspeed = new System.Windows.Forms.Label();
            this.txtMaxspeed = new System.Windows.Forms.NumericUpDown();
            this.txtVMotor = new System.Windows.Forms.NumericUpDown();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.rdGasyes = new System.Windows.Forms.RadioButton();
            this.rdGasno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdAutomatyes = new System.Windows.Forms.RadioButton();
            this.rdAutomatno = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdBrands = new System.Windows.Forms.ComboBox();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(615, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 46);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(361, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(173, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(91, 428);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(173, 46);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(255, 236);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 27);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(151, 239);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 23);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name :";
            // 
            // lblVmotor
            // 
            this.lblVmotor.AutoSize = true;
            this.lblVmotor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVmotor.Location = new System.Drawing.Point(147, 294);
            this.lblVmotor.Name = "lblVmotor";
            this.lblVmotor.Size = new System.Drawing.Size(77, 23);
            this.lblVmotor.TabIndex = 7;
            this.lblVmotor.Text = "VMotor :";
            // 
            // lblMaxspeed
            // 
            this.lblMaxspeed.AutoSize = true;
            this.lblMaxspeed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxspeed.Location = new System.Drawing.Point(146, 347);
            this.lblMaxspeed.Name = "lblMaxspeed";
            this.lblMaxspeed.Size = new System.Drawing.Size(103, 23);
            this.lblMaxspeed.TabIndex = 8;
            this.lblMaxspeed.Text = "Max Speed :";
            // 
            // txtMaxspeed
            // 
            this.txtMaxspeed.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtMaxspeed.Location = new System.Drawing.Point(255, 347);
            this.txtMaxspeed.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtMaxspeed.Name = "txtMaxspeed";
            this.txtMaxspeed.Size = new System.Drawing.Size(150, 27);
            this.txtMaxspeed.TabIndex = 9;
            // 
            // txtVMotor
            // 
            this.txtVMotor.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtVMotor.Location = new System.Drawing.Point(255, 292);
            this.txtVMotor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtVMotor.Name = "txtVMotor";
            this.txtVMotor.Size = new System.Drawing.Size(150, 27);
            this.txtVMotor.TabIndex = 10;
            // 
            // dgvCar
            // 
            this.dgvCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCar.Location = new System.Drawing.Point(0, 0);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.RowHeadersWidth = 51;
            this.dgvCar.RowTemplate.Height = 29;
            this.dgvCar.Size = new System.Drawing.Size(932, 188);
            this.dgvCar.TabIndex = 11;
            this.dgvCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCar_CellContentClick);
            this.dgvCar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCar_CellFormatting);
            this.dgvCar.SelectionChanged += new System.EventHandler(this.dgvCar_SelectionChanged);
            // 
            // rdGasyes
            // 
            this.rdGasyes.AutoSize = true;
            this.rdGasyes.Location = new System.Drawing.Point(13, 30);
            this.rdGasyes.Name = "rdGasyes";
            this.rdGasyes.Size = new System.Drawing.Size(51, 24);
            this.rdGasyes.TabIndex = 12;
            this.rdGasyes.TabStop = true;
            this.rdGasyes.Text = "Yes";
            this.rdGasyes.UseVisualStyleBackColor = true;
            // 
            // rdGasno
            // 
            this.rdGasno.AutoSize = true;
            this.rdGasno.Location = new System.Drawing.Point(88, 30);
            this.rdGasno.Name = "rdGasno";
            this.rdGasno.Size = new System.Drawing.Size(50, 24);
            this.rdGasno.TabIndex = 13;
            this.rdGasno.TabStop = true;
            this.rdGasno.Text = "No";
            this.rdGasno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 15;
            // 
            // rdAutomatyes
            // 
            this.rdAutomatyes.AutoSize = true;
            this.rdAutomatyes.Location = new System.Drawing.Point(16, 31);
            this.rdAutomatyes.Name = "rdAutomatyes";
            this.rdAutomatyes.Size = new System.Drawing.Size(51, 24);
            this.rdAutomatyes.TabIndex = 17;
            this.rdAutomatyes.TabStop = true;
            this.rdAutomatyes.Text = "Yes";
            this.rdAutomatyes.UseVisualStyleBackColor = true;
            // 
            // rdAutomatno
            // 
            this.rdAutomatno.AutoSize = true;
            this.rdAutomatno.Location = new System.Drawing.Point(91, 31);
            this.rdAutomatno.Name = "rdAutomatno";
            this.rdAutomatno.Size = new System.Drawing.Size(50, 24);
            this.rdAutomatno.TabIndex = 18;
            this.rdAutomatno.TabStop = true;
            this.rdAutomatno.Text = "No";
            this.rdAutomatno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGasyes);
            this.groupBox1.Controls.Add(this.rdGasno);
            this.groupBox1.Location = new System.Drawing.Point(461, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 68);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gas :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdAutomatyes);
            this.groupBox2.Controls.Add(this.rdAutomatno);
            this.groupBox2.Location = new System.Drawing.Point(458, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 66);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automat :";
            // 
            // cmdBrands
            // 
            this.cmdBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdBrands.FormattingEnabled = true;
            this.cmdBrands.Location = new System.Drawing.Point(656, 263);
            this.cmdBrands.Name = "cmdBrands";
            this.cmdBrands.Size = new System.Drawing.Size(109, 28);
            this.cmdBrands.TabIndex = 21;
            // 
            // cmbColors
            // 
            this.cmbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Location = new System.Drawing.Point(656, 347);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(109, 28);
            this.cmbColors.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(656, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(656, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Brands :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(656, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Colors :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColors);
            this.Controls.Add(this.cmdBrands);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.txtVMotor);
            this.Controls.Add(this.txtMaxspeed);
            this.Controls.Add(this.lblMaxspeed);
            this.Controls.Add(this.lblVmotor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.Text = "Car Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVmotor;
        private System.Windows.Forms.Label lblMaxspeed;
        private System.Windows.Forms.NumericUpDown txtMaxspeed;
        private System.Windows.Forms.NumericUpDown txtVMotor;
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.RadioButton rdGasyes;
        private System.Windows.Forms.RadioButton rdGasno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdAutomatyes;
        private System.Windows.Forms.RadioButton rdAutomatno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmdBrands;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

