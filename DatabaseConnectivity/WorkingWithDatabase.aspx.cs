using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataBaseConnectivity
{
    public partial class WorkingWithDataBase : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RJ7FDJE\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;TrustServerCertificate=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            SqlCommand cmd = new SqlCommand("select * from student", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        public void addRecord()
        {
            string Rollno, Name, city;
            Rollno = TextBox1.Text;
            Name = TextBox2.Text;
            city = TextBox3.Text;
            int rno = Convert.ToInt32(Rollno);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values(@Rollno,@Name,@city)", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Rollno",rno);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@city", city);

            int count = cmd.ExecuteNonQuery();
            MessageBox.Show(count + " Record added successfully", "Record added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        public void DeleteData()
        {
            con.Open();
            var Rollno = Convert.ToInt32(TextBox1.Text);
            SqlCommand cmd = new SqlCommand("delete from student where  Rollno=@Rollno", con);


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Rollno", Rollno);

            int count = cmd.ExecuteNonQuery();
            MessageBox.Show(count + " Record deleted successfully", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        public void UpdateData()
        {
            string Rollno, Name, city;
            Rollno = TextBox1.Text;
            Name = TextBox2.Text;
            city = TextBox3.Text;
            var rno = Convert.ToInt32(Rollno);
            con.Open();

            SqlCommand cmd = new SqlCommand("update student set Name=@Name, city=@city where Rollno=@Rollno", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Rollno", rno);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@city", city);

            int count = cmd.ExecuteNonQuery();
            MessageBox.Show(count + " Record updated successfully", "Record updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            addRecord();
            getData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DeleteData();        
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}