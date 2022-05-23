namespace praktikumw13
{
    partial class Form1
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
            this.buttonDPrev = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.numericUpDownTNumber = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerBdate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNation = new System.Windows.Forms.ComboBox();
            this.labelAvail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDPrev
            // 
            this.buttonDPrev.Location = new System.Drawing.Point(103, 53);
            this.buttonDPrev.Name = "buttonDPrev";
            this.buttonDPrev.Size = new System.Drawing.Size(139, 74);
            this.buttonDPrev.TabIndex = 0;
            this.buttonDPrev.Text = "<<";
            this.buttonDPrev.UseVisualStyleBackColor = true;
            this.buttonDPrev.Click += new System.EventHandler(this.buttonDPrev_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(273, 53);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(139, 74);
            this.buttonPrev.TabIndex = 0;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(459, 53);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(139, 74);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonDNext
            // 
            this.buttonDNext.Location = new System.Drawing.Point(648, 53);
            this.buttonDNext.Name = "buttonDNext";
            this.buttonDNext.Size = new System.Drawing.Size(139, 74);
            this.buttonDNext.TabIndex = 0;
            this.buttonDNext.Text = ">>";
            this.buttonDNext.UseVisualStyleBackColor = true;
            this.buttonDNext.Click += new System.EventHandler(this.buttonDNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Team Number";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(273, 183);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(368, 31);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(273, 243);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(368, 31);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(175, 541);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 53);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(445, 541);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(196, 53);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(273, 406);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(368, 33);
            this.comboBoxTeam.TabIndex = 3;
            // 
            // numericUpDownTNumber
            // 
            this.numericUpDownTNumber.Location = new System.Drawing.Point(273, 457);
            this.numericUpDownTNumber.Name = "numericUpDownTNumber";
            this.numericUpDownTNumber.Size = new System.Drawing.Size(213, 31);
            this.numericUpDownTNumber.TabIndex = 4;
            this.numericUpDownTNumber.ValueChanged += new System.EventHandler(this.numericUpDownTNumber_ValueChanged);
            // 
            // dateTimePickerBdate
            // 
            this.dateTimePickerBdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBdate.Location = new System.Drawing.Point(273, 299);
            this.dateTimePickerBdate.Name = "dateTimePickerBdate";
            this.dateTimePickerBdate.Size = new System.Drawing.Size(417, 31);
            this.dateTimePickerBdate.TabIndex = 5;
            // 
            // comboBoxNation
            // 
            this.comboBoxNation.FormattingEnabled = true;
            this.comboBoxNation.Location = new System.Drawing.Point(273, 352);
            this.comboBoxNation.Name = "comboBoxNation";
            this.comboBoxNation.Size = new System.Drawing.Size(368, 33);
            this.comboBoxNation.TabIndex = 3;
            // 
            // labelAvail
            // 
            this.labelAvail.AutoSize = true;
            this.labelAvail.Location = new System.Drawing.Point(528, 459);
            this.labelAvail.Name = "labelAvail";
            this.labelAvail.Size = new System.Drawing.Size(19, 25);
            this.labelAvail.TabIndex = 6;
            this.labelAvail.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 627);
            this.Controls.Add(this.labelAvail);
            this.Controls.Add(this.dateTimePickerBdate);
            this.Controls.Add(this.numericUpDownTNumber);
            this.Controls.Add(this.comboBoxNation);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDNext);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDPrev);
            this.Name = "Form1";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDPrev;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.NumericUpDown numericUpDownTNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerBdate;
        private System.Windows.Forms.ComboBox comboBoxNation;
        private System.Windows.Forms.Label labelAvail;
    }
}

