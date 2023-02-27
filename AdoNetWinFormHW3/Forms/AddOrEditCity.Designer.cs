namespace AdoNetWinFormHW3.Forms
{
    partial class AddOrEditCity
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCity = new System.Windows.Forms.TextBox();
            this.numericPopulationCity = new System.Windows.Forms.NumericUpDown();
            this.CountryCombobox = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPopulation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCountry = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulationCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Население";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Страна";
            // 
            // txtNameCity
            // 
            this.txtNameCity.Location = new System.Drawing.Point(108, 22);
            this.txtNameCity.Name = "txtNameCity";
            this.txtNameCity.Size = new System.Drawing.Size(197, 23);
            this.txtNameCity.TabIndex = 1;
            this.txtNameCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameCity_Validating);
            // 
            // numericPopulationCity
            // 
            this.numericPopulationCity.Location = new System.Drawing.Point(108, 59);
            this.numericPopulationCity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericPopulationCity.Name = "numericPopulationCity";
            this.numericPopulationCity.Size = new System.Drawing.Size(197, 23);
            this.numericPopulationCity.TabIndex = 2;
            this.numericPopulationCity.Validating += new System.ComponentModel.CancelEventHandler(this.numericPopulationCity_Validating);
            // 
            // CountryCombobox
            // 
            this.CountryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryCombobox.FormattingEnabled = true;
            this.CountryCombobox.Location = new System.Drawing.Point(106, 93);
            this.CountryCombobox.Name = "CountryCombobox";
            this.CountryCombobox.Size = new System.Drawing.Size(199, 23);
            this.CountryCombobox.TabIndex = 5;
            this.CountryCombobox.Validating += new System.ComponentModel.CancelEventHandler(this.CountryCombobox_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(230, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(149, 131);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorName
            // 
            this.errorName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorName.ContainerControl = this;
            // 
            // errorPopulation
            // 
            this.errorPopulation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPopulation.ContainerControl = this;
            // 
            // errorCountry
            // 
            this.errorCountry.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCountry.ContainerControl = this;
            // 
            // AddOrEditCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(322, 179);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.CountryCombobox);
            this.Controls.Add(this.numericPopulationCity);
            this.Controls.Add(this.txtNameCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditCity";
            this.Text = "AddOrEditCity";
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulationCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNameCity;
        private NumericUpDown numericPopulationCity;
        private ComboBox CountryCombobox;
        private Button btnCancel;
        private Button btnOk;
        private ErrorProvider errorName;
        private ErrorProvider errorPopulation;
        private ErrorProvider errorCountry;
    }
}