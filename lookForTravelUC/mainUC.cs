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
        SqlConnection connection = new SqlConnection(connectionString);
        public mainUC()
        {
            InitializeComponent();
        }
        private void mainUC_Load(object sender, EventArgs e) {
            datePicker.MinDate = DateTime.Now;
        }
        private void seachBtn_Click(object sender, EventArgs e) {
             
        }
        public void setDataSources() {
            try {
                connection.Open();
                using (SqlCommand command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "usp_getOriginToDestination";
                    command.Parameters.AddWithValue("@companyId", _companyId);
                    using(SqlDataReader reader = command.ExecuteReader()) {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        travelCB.DataSource = table;
                        travelCB.DisplayMember = "travel";
                    }
                    connection.Dispose();
                    companyNameLabel.Text = _companyName;
                }
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        
    }
}
