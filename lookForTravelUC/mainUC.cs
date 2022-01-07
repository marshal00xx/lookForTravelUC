using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace lookForTravelUC
{
    public partial class mainUC: UserControl
    {
        private static String _companyId;
        private static String _companyName;
        public String companyId { set { _companyId = value; } }
        public String companyName { set { _companyName = value; } }
        public static String connectionString = "Data source = .; initial catalog = transportMangment; integrated security = true";
        DataTable table = new DataTable();
        public mainUC()
        {
            InitializeComponent();
        }
        private void mainUC_Load(object sender, EventArgs e) {
            /*_companyId = "COMP1000";
            setDataSources();*/
            numOfPassgersTB.Minimum = 1;
            datePicker.MinDate = DateTime.Now;
        }
        private void seachBtn_Click(object sender, EventArgs e) {
            try {
                if(table.Rows.Count > 0) {
                    datePickerValueLbl.Text = datePicker.Value.ToShortDateString();
                    if (table.Rows[travelCB.SelectedIndex].Field<String>(4).Equals("1")) {
                        messageLabel.Text = $"{table.Rows[travelCB.SelectedIndex].Field<TimeSpan>(2)} -- {table.Rows[travelCB.SelectedIndex].Field<TimeSpan>(3)}";
                        getTicketLbl.Text = "Sign In To get a Ticket";
                        Point point = new Point(126, 134);
                        getTicketLbl.Location = point;
                        getTicketLbl.Visible = true;
                        searchResultPanel.Visible = true;
                    }
                    else {
                        // Sign In To get a Ticket
                        //No travels left for today
                        messageLabel.Text = "No travels left for today";
                        Point point = new Point(53, 134);
                        getTicketLbl.Location = point;
                        getTicketLbl.Text = "Try changing the dates of your search.";
                        searchResultPanel.Visible = true;
                        getTicketLbl.Visible = true;
                    }
                }
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        public void setDataSources() {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "usp_getOriginToDestination";
                        command.Parameters.AddWithValue("@companyId", _companyId);
                        using (SqlDataReader reader = command.ExecuteReader()){
                            table.Clear();
                            table.Load(reader);
                            travelCB.DataSource = table;
                            travelCB.DisplayMember = "travel";
                        }
                        companyNameLabel.Text = _companyName;
                    }
                }           
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void getTicketLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (!getTicketLbl.Text.Equals(" Sign In To get a Ticket"))
                searchResultPanel.Visible = false;
            else {
                // todo logic to run when the user wanna signin
            }
        }
    }
}
