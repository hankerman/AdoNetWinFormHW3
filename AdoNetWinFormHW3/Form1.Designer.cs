namespace AdoNetWinFormHW3
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabCountry = new System.Windows.Forms.TabPage();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnEditCountry = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.CountryGrid = new System.Windows.Forms.DataGridView();
            this.CitiesTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MainTab.SuspendLayout();
            this.tabCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).BeginInit();
            this.CitiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabCountry);
            this.MainTab.Controls.Add(this.CitiesTab);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(997, 516);
            this.MainTab.TabIndex = 0;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            // 
            // tabCountry
            // 
            this.tabCountry.Controls.Add(this.btnDeleteCountry);
            this.tabCountry.Controls.Add(this.btnEditCountry);
            this.tabCountry.Controls.Add(this.btnAddCountry);
            this.tabCountry.Controls.Add(this.CountryGrid);
            this.tabCountry.Location = new System.Drawing.Point(4, 24);
            this.tabCountry.Name = "tabCountry";
            this.tabCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tabCountry.Size = new System.Drawing.Size(989, 488);
            this.tabCountry.TabIndex = 0;
            this.tabCountry.Text = "Страны";
            this.tabCountry.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Location = new System.Drawing.Point(855, 84);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(128, 33);
            this.btnDeleteCountry.TabIndex = 1;
            this.btnDeleteCountry.Text = "Удалить страну";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnEditCountry
            // 
            this.btnEditCountry.Location = new System.Drawing.Point(853, 45);
            this.btnEditCountry.Name = "btnEditCountry";
            this.btnEditCountry.Size = new System.Drawing.Size(128, 33);
            this.btnEditCountry.TabIndex = 1;
            this.btnEditCountry.Text = "Изменить страну";
            this.btnEditCountry.UseVisualStyleBackColor = true;
            this.btnEditCountry.Click += new System.EventHandler(this.btnEditCountry_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(853, 6);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(128, 33);
            this.btnAddCountry.TabIndex = 1;
            this.btnAddCountry.Text = "Добавить страну";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // CountryGrid
            // 
            this.CountryGrid.AllowUserToAddRows = false;
            this.CountryGrid.AllowUserToDeleteRows = false;
            this.CountryGrid.AllowUserToResizeRows = false;
            this.CountryGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountryGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CountryGrid.Location = new System.Drawing.Point(6, 6);
            this.CountryGrid.Name = "CountryGrid";
            this.CountryGrid.RowHeadersVisible = false;
            this.CountryGrid.RowTemplate.Height = 25;
            this.CountryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CountryGrid.Size = new System.Drawing.Size(841, 476);
            this.CountryGrid.TabIndex = 0;
            // 
            // CitiesTab
            // 
            this.CitiesTab.Controls.Add(this.button1);
            this.CitiesTab.Controls.Add(this.dataGridView1);
            this.CitiesTab.Controls.Add(this.comboBox1);
            this.CitiesTab.Location = new System.Drawing.Point(4, 24);
            this.CitiesTab.Name = "CitiesTab";
            this.CitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.CitiesTab.Size = new System.Drawing.Size(989, 488);
            this.CitiesTab.TabIndex = 1;
            this.CitiesTab.Text = "Города";
            this.CitiesTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(816, 445);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 516);
            this.Controls.Add(this.MainTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.tabCountry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).EndInit();
            this.CitiesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTab;
        private TabPage tabCountry;
        private DataGridView CountryGrid;
        private TabPage CitiesTab;
        private Button btnDeleteCountry;
        private Button btnEditCountry;
        private Button btnAddCountry;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}