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
            this.CountryGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainTab.SuspendLayout();
            this.tabCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabCountry);
            this.MainTab.Controls.Add(this.tabPage2);
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
            this.tabCountry.Controls.Add(this.CountryGrid);
            this.tabCountry.Location = new System.Drawing.Point(4, 24);
            this.tabCountry.Name = "tabCountry";
            this.tabCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tabCountry.Size = new System.Drawing.Size(989, 488);
            this.tabCountry.TabIndex = 0;
            this.tabCountry.Text = "Страны";
            this.tabCountry.UseVisualStyleBackColor = true;
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
            this.CountryGrid.RowTemplate.Height = 25;
            this.CountryGrid.Size = new System.Drawing.Size(841, 476);
            this.CountryGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(989, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTab;
        private TabPage tabCountry;
        private DataGridView CountryGrid;
        private TabPage tabPage2;
    }
}