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
            this.travelCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.numOfPassgersTB = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.companyNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.searchResultPanel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.getTicketLbl = new Guna.UI.WinForms.GunaLinkLabel();
            this.messageLabel = new Guna.UI.WinForms.GunaLabel();
            this.datePickerValueLbl = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPassgersTB)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.searchResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // travelCB
            // 
            this.travelCB.BackColor = System.Drawing.Color.Transparent;
            this.travelCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.travelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.travelCB.FocusedColor = System.Drawing.Color.Empty;
            this.travelCB.FocusedState.Parent = this.travelCB;
            this.travelCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.travelCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.travelCB.FormattingEnabled = true;
            this.travelCB.HoverState.Parent = this.travelCB;
            this.travelCB.ItemHeight = 30;
            this.travelCB.ItemsAppearance.Parent = this.travelCB;
            this.travelCB.Location = new System.Drawing.Point(92, 69);
            this.travelCB.Name = "travelCB";
            this.travelCB.ShadowDecoration.Parent = this.travelCB;
            this.travelCB.Size = new System.Drawing.Size(287, 36);
            this.travelCB.TabIndex = 0;
            // 
            // datePicker
            // 
            this.datePicker.CheckedState.Parent = this.datePicker;
            this.datePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.HoverState.Parent = this.datePicker;
            this.datePicker.Location = new System.Drawing.Point(257, 117);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShadowDecoration.Parent = this.datePicker;
            this.datePicker.Size = new System.Drawing.Size(122, 36);
            this.datePicker.TabIndex = 1;
            this.datePicker.Value = new System.DateTime(2022, 1, 6, 14, 37, 30, 821);
            // 
            // searchBtn
            // 
            this.searchBtn.CheckedState.Parent = this.searchBtn;
            this.searchBtn.CustomImages.Parent = this.searchBtn;
            this.searchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.HoverState.Parent = this.searchBtn;
            this.searchBtn.Location = new System.Drawing.Point(92, 165);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.ShadowDecoration.Parent = this.searchBtn;
            this.searchBtn.Size = new System.Drawing.Size(287, 45);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.seachBtn_Click);
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
            this.numOfPassgersTB.Location = new System.Drawing.Point(92, 117);
            this.numOfPassgersTB.Name = "numOfPassgersTB";
            this.numOfPassgersTB.ShadowDecoration.Parent = this.numOfPassgersTB;
            this.numOfPassgersTB.Size = new System.Drawing.Size(159, 36);
            this.numOfPassgersTB.TabIndex = 5;
            this.numOfPassgersTB.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.companyNameLabel);
            this.gunaPanel1.Location = new System.Drawing.Point(70, 11);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(334, 52);
            this.gunaPanel1.TabIndex = 6;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.companyNameLabel.Location = new System.Drawing.Point(102, 15);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(121, 28);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "gunaLabel1";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchResultPanel
            // 
            this.searchResultPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchResultPanel.Controls.Add(this.getTicketLbl);
            this.searchResultPanel.Controls.Add(this.messageLabel);
            this.searchResultPanel.Controls.Add(this.datePickerValueLbl);
            this.searchResultPanel.GradientColor1 = System.Drawing.Color.White;
            this.searchResultPanel.GradientColor2 = System.Drawing.Color.White;
            this.searchResultPanel.Location = new System.Drawing.Point(0, 0);
            this.searchResultPanel.Name = "searchResultPanel";
            this.searchResultPanel.Size = new System.Drawing.Size(481, 218);
            this.searchResultPanel.TabIndex = 7;
            this.searchResultPanel.Visible = false;
            // 
            // getTicketLbl
            // 
            this.getTicketLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.getTicketLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getTicketLbl.AutoSize = true;
            this.getTicketLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.getTicketLbl.LinkColor = System.Drawing.Color.Black;
            this.getTicketLbl.Location = new System.Drawing.Point(126, 134);
            this.getTicketLbl.Name = "getTicketLbl";
            this.getTicketLbl.Size = new System.Drawing.Size(223, 28);
            this.getTicketLbl.TabIndex = 3;
            this.getTicketLbl.TabStop = true;
            this.getTicketLbl.Text = "Sign In To get a Ticket";
            this.getTicketLbl.Visible = false;
            this.getTicketLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getTicketLbl_LinkClicked);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.messageLabel.ForeColor = System.Drawing.Color.Black;
            this.messageLabel.Location = new System.Drawing.Point(130, 77);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(121, 28);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "gunaLabel1";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // datePickerValueLbl
            // 
            this.datePickerValueLbl.AutoSize = true;
            this.datePickerValueLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.datePickerValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.datePickerValueLbl.Location = new System.Drawing.Point(172, 11);
            this.datePickerValueLbl.Name = "datePickerValueLbl";
            this.datePickerValueLbl.Size = new System.Drawing.Size(121, 28);
            this.datePickerValueLbl.TabIndex = 1;
            this.datePickerValueLbl.Text = "gunaLabel1";
            this.datePickerValueLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchResultPanel);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.numOfPassgersTB);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.travelCB);
            this.Name = "mainUC";
            this.Size = new System.Drawing.Size(481, 218);
            this.Load += new System.EventHandler(this.mainUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOfPassgersTB)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.searchResultPanel.ResumeLayout(false);
            this.searchResultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox travelCB;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown numOfPassgersTB;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel companyNameLabel;
        private Guna.UI.WinForms.GunaGradient2Panel searchResultPanel;
        private Guna.UI.WinForms.GunaLabel messageLabel;
        private Guna.UI.WinForms.GunaLabel datePickerValueLbl;
        private Guna.UI.WinForms.GunaLinkLabel getTicketLbl;
    }
}
