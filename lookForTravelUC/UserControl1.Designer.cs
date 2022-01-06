namespace lookForTravelUC
{
    partial class mainUC
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.origineCityTB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.destCityTB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.seachBtn = new Guna.UI2.WinForms.Guna2Button();
            this.numOfPassgersTB = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPassgersTB)).BeginInit();
            this.SuspendLayout();
            // 
            // origineCityTB
            // 
            this.origineCityTB.BackColor = System.Drawing.Color.Transparent;
            this.origineCityTB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.origineCityTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origineCityTB.FocusedColor = System.Drawing.Color.Empty;
            this.origineCityTB.FocusedState.Parent = this.origineCityTB;
            this.origineCityTB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.origineCityTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.origineCityTB.FormattingEnabled = true;
            this.origineCityTB.HoverState.Parent = this.origineCityTB;
            this.origineCityTB.ItemHeight = 30;
            this.origineCityTB.ItemsAppearance.Parent = this.origineCityTB;
            this.origineCityTB.Location = new System.Drawing.Point(22, 21);
            this.origineCityTB.Name = "origineCityTB";
            this.origineCityTB.ShadowDecoration.Parent = this.origineCityTB;
            this.origineCityTB.Size = new System.Drawing.Size(287, 36);
            this.origineCityTB.TabIndex = 0;
            // 
            // destCityTB
            // 
            this.destCityTB.BackColor = System.Drawing.Color.Transparent;
            this.destCityTB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.destCityTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destCityTB.FocusedColor = System.Drawing.Color.Empty;
            this.destCityTB.FocusedState.Parent = this.destCityTB;
            this.destCityTB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.destCityTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.destCityTB.FormattingEnabled = true;
            this.destCityTB.HoverState.Parent = this.destCityTB;
            this.destCityTB.ItemHeight = 30;
            this.destCityTB.ItemsAppearance.Parent = this.destCityTB;
            this.destCityTB.Location = new System.Drawing.Point(22, 69);
            this.destCityTB.Name = "destCityTB";
            this.destCityTB.ShadowDecoration.Parent = this.destCityTB;
            this.destCityTB.Size = new System.Drawing.Size(287, 36);
            this.destCityTB.TabIndex = 0;
            // 
            // datePicker
            // 
            this.datePicker.CheckedState.Parent = this.datePicker;
            this.datePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.HoverState.Parent = this.datePicker;
            this.datePicker.Location = new System.Drawing.Point(187, 117);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShadowDecoration.Parent = this.datePicker;
            this.datePicker.Size = new System.Drawing.Size(122, 36);
            this.datePicker.TabIndex = 1;
            this.datePicker.Value = new System.DateTime(2022, 1, 6, 14, 37, 30, 821);
            // 
            // seachBtn
            // 
            this.seachBtn.CheckedState.Parent = this.seachBtn;
            this.seachBtn.CustomImages.Parent = this.seachBtn;
            this.seachBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.seachBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.seachBtn.ForeColor = System.Drawing.Color.White;
            this.seachBtn.HoverState.Parent = this.seachBtn;
            this.seachBtn.Location = new System.Drawing.Point(22, 165);
            this.seachBtn.Name = "seachBtn";
            this.seachBtn.ShadowDecoration.Parent = this.seachBtn;
            this.seachBtn.Size = new System.Drawing.Size(287, 45);
            this.seachBtn.TabIndex = 4;
            this.seachBtn.Text = "Search";
            this.seachBtn.Click += new System.EventHandler(this.seachBtn_Click);
            // 
            // numOfPassgersTB
            // 
            this.numOfPassgersTB.BackColor = System.Drawing.Color.Transparent;
            this.numOfPassgersTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numOfPassgersTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numOfPassgersTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numOfPassgersTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numOfPassgersTB.DisabledState.Parent = this.numOfPassgersTB;
            this.numOfPassgersTB.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numOfPassgersTB.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numOfPassgersTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numOfPassgersTB.FocusedState.Parent = this.numOfPassgersTB;
            this.numOfPassgersTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPassgersTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numOfPassgersTB.Location = new System.Drawing.Point(22, 117);
            this.numOfPassgersTB.Name = "numOfPassgersTB";
            this.numOfPassgersTB.ShadowDecoration.Parent = this.numOfPassgersTB;
            this.numOfPassgersTB.Size = new System.Drawing.Size(159, 36);
            this.numOfPassgersTB.TabIndex = 5;
            this.numOfPassgersTB.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            // 
            // mainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.numOfPassgersTB);
            this.Controls.Add(this.seachBtn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.destCityTB);
            this.Controls.Add(this.origineCityTB);
            this.Name = "mainUC";
            this.Size = new System.Drawing.Size(334, 218);
            ((System.ComponentModel.ISupportInitialize)(this.numOfPassgersTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox origineCityTB;
        private Guna.UI2.WinForms.Guna2ComboBox destCityTB;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2Button seachBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown numOfPassgersTB;
    }
}
