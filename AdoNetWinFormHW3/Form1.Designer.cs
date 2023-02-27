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
            this.btnCapital5K = new System.Windows.Forms.Button();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnEditCountry = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.CountryGrid = new System.Windows.Forms.DataGridView();
            this.CitiesTab = new System.Windows.Forms.TabPage();
            this.btnUpdateCitiesGrid = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEditCity = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.CountryCombobox = new System.Windows.Forms.ComboBox();
            this.CitiesGrid = new System.Windows.Forms.DataGridView();
            this.btnCountryName = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            this.tabCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).BeginInit();
            this.CitiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesGrid)).BeginInit();
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
            this.tabCountry.Controls.Add(this.btnCountryName);
            this.tabCountry.Controls.Add(this.btnCapital5K);
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
            // btnCapital5K
            // 
            this.btnCapital5K.Location = new System.Drawing.Point(853, 171);
            this.btnCapital5K.Name = "btnCapital5K";
            this.btnCapital5K.Size = new System.Drawing.Size(128, 64);
            this.btnCapital5K.TabIndex = 2;
            this.btnCapital5K.Text = "Столицы где больше 5к население";
            this.btnCapital5K.UseVisualStyleBackColor = true;
            this.btnCapital5K.Click += new System.EventHandler(this.btnCapital5K_Click);
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
            this.CitiesTab.Controls.Add(this.btnUpdateCitiesGrid);
            this.CitiesTab.Controls.Add(this.btnRemove);
            this.CitiesTab.Controls.Add(this.btnEditCity);
            this.CitiesTab.Controls.Add(this.btnAddCity);
            this.CitiesTab.Controls.Add(this.CountryCombobox);
            this.CitiesTab.Controls.Add(this.CitiesGrid);
            this.CitiesTab.Location = new System.Drawing.Point(4, 24);
            this.CitiesTab.Name = "CitiesTab";
            this.CitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.CitiesTab.Size = new System.Drawing.Size(989, 488);
            this.CitiesTab.TabIndex = 1;
            this.CitiesTab.Text = "Города";
            this.CitiesTab.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCitiesGrid
            // 
            this.btnUpdateCitiesGrid.Location = new System.Drawing.Point(211, 7);
            this.btnUpdateCitiesGrid.Name = "btnUpdateCitiesGrid";
            this.btnUpdateCitiesGrid.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCitiesGrid.TabIndex = 8;
            this.btnUpdateCitiesGrid.Text = "Обновить";
            this.btnUpdateCitiesGrid.UseVisualStyleBackColor = true;
            this.btnUpdateCitiesGrid.Click += new System.EventHandler(this.btnUpdateCitiesGrid_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(828, 64);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEditCity
            // 
            this.btnEditCity.Location = new System.Drawing.Point(906, 35);
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Size = new System.Drawing.Size(75, 23);
            this.btnEditCity.TabIndex = 6;
            this.btnEditCity.Text = "Изменить";
            this.btnEditCity.UseVisualStyleBackColor = true;
            this.btnEditCity.Click += new System.EventHandler(this.btnEditCity_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(828, 35);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(75, 23);
            this.btnAddCity.TabIndex = 5;
            this.btnAddCity.Text = "Добавить";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // CountryCombobox
            // 
            this.CountryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryCombobox.FormattingEnabled = true;
            this.CountryCombobox.Location = new System.Drawing.Point(6, 7);
            this.CountryCombobox.Name = "CountryCombobox";
            this.CountryCombobox.Size = new System.Drawing.Size(199, 23);
            this.CountryCombobox.TabIndex = 4;
            this.CountryCombobox.SelectedIndexChanged += new System.EventHandler(this.CountryCombobox_SelectedIndexChanged);
            // 
            // CitiesGrid
            // 
            this.CitiesGrid.AllowUserToAddRows = false;
            this.CitiesGrid.AllowUserToDeleteRows = false;
            this.CitiesGrid.AllowUserToResizeRows = false;
            this.CitiesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CitiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitiesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CitiesGrid.Location = new System.Drawing.Point(6, 35);
            this.CitiesGrid.Name = "CitiesGrid";
            this.CitiesGrid.RowHeadersVisible = false;
            this.CitiesGrid.RowTemplate.Height = 25;
            this.CitiesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CitiesGrid.Size = new System.Drawing.Size(816, 447);
            this.CitiesGrid.TabIndex = 3;
            // 
            // btnCountryName
            // 
            this.btnCountryName.Location = new System.Drawing.Point(853, 241);
            this.btnCountryName.Name = "btnCountryName";
            this.btnCountryName.Size = new System.Drawing.Size(128, 30);
            this.btnCountryName.TabIndex = 3;
            this.btnCountryName.Text = "Название стран";
            this.btnCountryName.UseVisualStyleBackColor = true;
            this.btnCountryName.Click += new System.EventHandler(this.btnCountryName_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.CitiesGrid)).EndInit();
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
        private DataGridView CitiesGrid;
        private ComboBox CountryCombobox;
        private Button btnAddCity;
        private Button btnEditCity;
        private Button btnRemove;
        private Button btnUpdateCitiesGrid;
        private Button btnCapital5K;
        private Button btnCountryName;
    }
}