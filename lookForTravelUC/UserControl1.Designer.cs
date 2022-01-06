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
            this.origineCityCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.destCityCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.seachBtn = new Guna.UI2.WinForms.Guna2Button();
            this.numOfPassgersTB = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPassgersTB)).BeginInit();
            this.SuspendLayout();
            // 
            // origineCityCB
            // 
            this.origineCityCB.BackColor = System.Drawing.Color.Transparent;
            this.origineCityCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.origineCityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origineCityCB.FocusedColor = System.Drawing.Color.Empty;
            this.origineCityCB.FocusedState.Parent = this.origineCityCB;
            this.origineCityCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.origineCityCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.origineCityCB.FormattingEnabled = true;
            this.origineCityCB.HoverState.Parent = this.origineCityCB;
            this.origineCityCB.ItemHeight = 30;
            this.origineCityCB.ItemsAppearance.Parent = this.origineCityCB;
            this.origineCityCB.Location = new System.Drawing.Point(22, 21);
            this.origineCityCB.Name = "origineCityCB";
            this.origineCityCB.ShadowDecoration.Parent = this.origineCityCB;
            this.origineCityCB.Size = new System.Drawing.Size(287, 36);
            this.origineCityCB.TabIndex = 0;
            // 
            // destCityCB
            // 
            this.destCityCB.BackColor = System.Drawing.Color.Transparent;
            this.destCityCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.destCityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destCityCB.FocusedColor = System.Drawing.Color.Empty;
            this.destCityCB.FocusedState.Parent = this.destCityCB;
            this.destCityCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.destCityCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.destCityCB.FormattingEnabled = true;
            this.destCityCB.HoverState.Parent = this.destCityCB;
            this.destCityCB.ItemHeight = 30;
            this.destCityCB.ItemsAppearance.Parent = this.destCityCB;
            this.destCityCB.Location = new System.Drawing.Point(22, 69);
            this.destCityCB.Name = "destCityCB";
            this.destCityCB.ShadowDecoration.Parent = this.destCityCB;
            this.destCityCB.Size = new System.Drawing.Size(287, 36);
            this.destCityCB.TabIndex = 0;
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
            this.Controls.Add(this.destCityCB);
            this.Controls.Add(this.origineCityCB);
            this.Name = "mainUC";
            this.Size = new System.Drawing.Size(334, 218);
            this.Load += new System.EventHandler(this.mainUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOfPassgersTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox origineCityCB;
        private Guna.UI2.WinForms.Guna2ComboBox destCityCB;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2Button seachBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown numOfPassgersTB;
    }
}
