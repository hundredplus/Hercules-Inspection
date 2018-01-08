using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hercules_Inspection
{
    public partial class HerculesInspection : Form
    {
        Dictionary<String, Product> productDetail = new Dictionary<string, Product>();
        String inspectingProduct = "";

        public HerculesInspection()
        {
            InitializeComponent();
        }

        private void HerculesInspection_Load(object sender, EventArgs e)
        {
            projectBox.Items.Clear();

            DBConnection dbConn = new DBConnection();
            DataTable table = dbConn.getAllProjectByStatus(2); //2=ONGOING

            Console.WriteLine("#ongoing project=" + table.Rows.Count);

            foreach (DataRow row in table.Rows)
            {
                projectBox.Items.Add(row["code"].ToString());
            }

        }

        private void projectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productBox.Items.Clear();
            productDetail.Clear();

            String selectedProject = (String)projectBox.SelectedItem;
            //MessageBox.Show(selectedProject);

            DBConnection dbConn = new DBConnection();
            DataTable table = dbConn.getInspectingProductDetail(selectedProject);

            Console.WriteLine("#Inspecting product=" + table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                Product aProd = new Product();
                aProd.Code = row["production_code"].ToString();
                aProd.ProcessNo = int.Parse(row["process_number"].ToString());
                aProd.Status = int.Parse(row["status"].ToString());
                aProd.ProcessName = row["process_name"].ToString();
                aProd.LocNo = int.Parse(row["location_number"].ToString());
                productDetail.Add(aProd.Code, aProd);

                productBox.Items.Add(aProd.Code);
            }
        }

        private void productBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productInfoTxt.Clear();
            inspectingProduct = (String)productBox.SelectedItem;

            Product aProd = new Product();

            if(productDetail.TryGetValue(inspectingProduct, out aProd))
            {
                productInfoTxt.AppendText("Production: \t" + aProd.Code + "\n");
                productInfoTxt.AppendText("Location: \t\t" + aProd.LocNo + "\n");
                productInfoTxt.AppendText("Process Name: \t" + aProd.ProcessName + "\n");

                passBtn.Enabled = true;
                failBtn.Enabled = true;
            }           

        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            //Update production status: WAIT_STATION OR INSPECTED
            int newStatus;
            Product aProd = new Product();
            if (productDetail.TryGetValue(inspectingProduct, out aProd))
            {
                if (aProd.Status == Product.INSPECTING_STATION)
                    newStatus = Product.WAIT_STATION;
                else
                    newStatus = Product.INSPECTED;

                //update status
                DBConnection dbConn = new DBConnection();
                dbConn.updateProduction(inspectingProduct, newStatus);

                passBtn.Enabled = false;
                failBtn.Enabled = false;
            }
        }

        private void failBtn_Click(object sender, EventArgs e)
        {
            //Update status to MANUAL
            DBConnection dbConn = new DBConnection();
            dbConn.updateProduction(inspectingProduct, Product.MANUAL);

            passBtn.Enabled = false;
            failBtn.Enabled = false;
        }
    }
}
