namespace AdoNetWinFormHW3.Forms
{
    partial class AddOrEditCountry
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
            this.labelCountry = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.PartOfWorldCombobox = new System.Windows.Forms.ComboBox();
            this.CapitalCombobox = new System.Windows.Forms.ComboBox();
            this.numericArea = new System.Windows.Forms.NumericUpDown();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorArea = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPartOfWorld = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartOfWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название страны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Площадь страны";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Часть света";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 127);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(54, 15);
            this.labelCountry.TabIndex = 0;
            this.labelCountry.Text = "Столица";
            this.labelCountry.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // PartOfWorldCombobox
            // 
            this.PartOfWorldCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartOfWorldCombobox.FormattingEnabled = true;
            this.PartOfWorldCombobox.Location = new System.Drawing.Point(137, 90);
            this.PartOfWorldCombobox.Name = "PartOfWorldCombobox";
            this.PartOfWorldCombobox.Size = new System.Drawing.Size(212, 23);
            this.PartOfWorldCombobox.TabIndex = 2;
            this.PartOfWorldCombobox.Validating += new System.ComponentModel.CancelEventHandler(this.PartOfWorldCombobox_Validating);
            // 
            // CapitalCombobox
            // 
            this.CapitalCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CapitalCombobox.FormattingEnabled = true;
            this.CapitalCombobox.Location = new System.Drawing.Point(137, 124);
            this.CapitalCombobox.Name = "CapitalCombobox";
            this.CapitalCombobox.Size = new System.Drawing.Size(212, 23);
            this.CapitalCombobox.TabIndex = 2;
            this.CapitalCombobox.Visible = false;
            // 
            // numericArea
            // 
            this.numericArea.DecimalPlaces = 2;
            this.numericArea.Location = new System.Drawing.Point(137, 55);
            this.numericArea.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericArea.Name = "numericArea";
            this.numericArea.Size = new System.Drawing.Size(212, 23);
            this.numericArea.TabIndex = 3;
            this.numericArea.Validating += new System.ComponentModel.CancelEventHandler(this.numericArea_Validating);
            // 
            // errorName
            // 
            this.errorName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorName.ContainerControl = this;
            // 
            // errorArea
            // 
            this.errorArea.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorArea.ContainerControl = this;
            // 
            // errorPartOfWorld
            // 
            this.errorPartOfWorld.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPartOfWorld.ContainerControl = this;
            // 
            // btnCansel
            // 
            this.btnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCansel.Location = new System.Drawing.Point(274, 163);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 4;
            this.btnCansel.Text = "Отмена";
            this.btnCansel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(193, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddOrEditCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(364, 198);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.numericArea);
            this.Controls.Add(this.CapitalCombobox);
            this.Controls.Add(this.PartOfWorldCombobox);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditCountry";
            this.Text = "Добавить страну";
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartOfWorld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelCountry;
        private TextBox txtName;
        private ComboBox PartOfWorldCombobox;
        private ComboBox CapitalCombobox;
        private NumericUpDown numericArea;
        private ErrorProvider errorName;
        private ErrorProvider errorArea;
        private ErrorProvider errorPartOfWorld;
        private Button btnOK;
        private Button btnCansel;
    }
}