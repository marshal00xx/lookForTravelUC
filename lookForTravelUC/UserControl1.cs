using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lookForTravelUC
{
    public partial class mainUC: UserControl
    {
        private DataTable _origineCities = new DataTable();
        private DataTable _destinationCities = new DataTable();

        public DataTable origineCities { set { _origineCities = value; } }
        public DataTable destinationCities { set { _destinationCities = value; } }
        public mainUC()
        {
            InitializeComponent();
        }
        private void mainUC_Load(object sender, EventArgs e) {
            origineCityCB.DataSource = _origineCities;
            origineCityCB.Text = string.Empty;
            destCityCB.DataSource = _destinationCities;
            destCityCB.Text = string.Empty;
            datePicker.MinDate = DateTime.Now;
        }
        private void seachBtn_Click(object sender, EventArgs e) {
             
        }

        
    }
}
