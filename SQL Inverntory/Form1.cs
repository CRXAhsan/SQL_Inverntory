using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Step 1 call DB link Libraries

using System.Data.SqlClient;
using System.Data;


namespace SQL_Inverntory
{
    public partial class Form1 : Form
    {
        //--------------------------step: 2 set connection string--------------------------
        
           
        SqlConnection con = new SqlConnection("Data Source=MJDT-0268;Initial Catalog=mobileProduct;Integrated Security=True");

        // --------------------------------------------------------------------------------
       
        public Form1()
        {
            InitializeComponent();
        }

        // -------------------wrong function-----------------------
        private void ProductId_Click(object sender, EventArgs e)
        {

        }
        // --------------------------------------------------------

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Fill the Data Grid with Table Data
            //Call the Bind Function
            BindGrid();
        }

        public void BindGrid()
        {
            // Step 03: Call SQL Data Adapter for run the query and call the data.
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from product", con);

            
            // Step 04: Create Data Set for store the data
            DataSet ds = new DataSet();
            
            
            //Step 05: Fill Data Set with Data Adapter Calling Data
            //Adapter is calling the data and then saved in ds object
            adapter.Fill(ds);


            //Step 06: Show Data into the Grid View
            // table 0 is used due to we can show only one table&#39;s data in the data grid so we have call first table by table 0
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void Txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void Btn_insert_Click(object sender, EventArgs e)
        {
            //Step 07: Make a string variable for insert Query in insert button.
            // string QRY =  "Insert into Person(PersonID, PersonName)Values(3,Fahad)";

            string QRY = "Insert into product(productID, productName)Values('" + txt_id.Text +"','" + txt_name.Text + "')";

            //Step 08: Create object for sql command to execute the insert query and connect the connection string 
            SqlCommand obj = new SqlCommand(QRY, con);
            //open the connection
            con.Open();
            //Execute the query
            obj.ExecuteNonQuery();
            //close the connection
            con.Close();


            BindGrid(); //Refresh the Grid and show the inserted data

            MessageBox.Show("Product Inserted\n ID: " + txt_id.Text + "\nName: " + txt_name.Text, "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            //Step 09: Create object for sql command to execute the Update query and connect the connection string

            SqlCommand cmd = new SqlCommand("UPDATE product SET productName = '" + txt_name.Text+ "' WHERE productID = " + txt_id.Text, con);

            //open the connection

            con.Open();

            //Execute the query

            cmd.ExecuteNonQuery();

            //close the connection

            con.Close();

            BindGrid(); //Refresh the Grid and show the inserted data

            MessageBox.Show("Product Updated\n ID: " + txt_id.Text + "\nName: " + txt_name.Text, "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            //Step 10: Create object for sql command to execute the Delete query and connect the connection string
            SqlCommand cmd = new SqlCommand(" Delete from product WHERE productID = " + txt_id.Text, con);
            //open the connection
            con.Open();
            //Execute the query
            cmd.ExecuteNonQuery();
            //close the connection
            con.Close();
            BindGrid(); //Refresh the Grid and show the inserted data

            MessageBox.Show("Product Deleted\n ID: " + txt_id.Text + "\nName: " + txt_name.Text, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from product WHERE productID like '%" + txt_search.Text + "%' OR    productName = '" + txt_search.Text + "'",  con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            BindGrid();
            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}




//============================================================================================================================================


