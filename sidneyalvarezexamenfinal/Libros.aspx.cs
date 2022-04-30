using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sidneyalvarezexamenfinal
{
    public partial class Libros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }


        public void llenarGrid()
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            DataTable dt = new DataTable();

            try
            {
                using (Conn = sidneyalvarezexamenfinal.DBconn.obtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("LISTARLIBROS", Conn))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            retorno = cmd.ExecuteNonQuery();
                            cmd.Connection = Conn;
                            sda.SelectCommand = cmd;

                            using (dt = new DataTable())
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                sda.Fill(dt);
                                this.GridView1.DataSource = dt;
                                this.GridView1.DataBind();
                            }
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Bagregar_Click(object sender, EventArgs e)
        {

            if (IsValid)
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NS636SUN\\SQLEXPRESS01;Initial Catalog=BIBLIOTECA;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("AGREGARLIBROS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nombre", tlibro.Text);
                cmd.Parameters.AddWithValue("ID AUTOR", tautor.Text);
                cmd.Parameters.AddWithValue("UBICACION", tubicacion.Text);
                cmd.Parameters.AddWithValue("FECHA", tpublicacion.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw new Exception("Exception adding account. " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                llenarGrid();

            }

            llenarGrid();

        }

        protected void Beliminar_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NS636SUN\\SQLEXPRESS01;Initial Catalog=BIBLIOTECA;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("BORRARLIBROS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nombre", tlibro.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw new Exception("Exception adding account. " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                llenarGrid();

            }
        }

        protected void Bactualizar_Click(object sender, EventArgs e)
        {

            if (IsValid)
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NS636SUN\\SQLEXPRESS01;Initial Catalog=BIBLIOTECA;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("ACTUALIZALIBROS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nombre", tlibro.Text);
                cmd.Parameters.AddWithValue("ID AUTOR", tautor.Text);
                cmd.Parameters.AddWithValue("UBICACION", tubicacion.Text);
                cmd.Parameters.AddWithValue("FECHA", tpublicacion.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw new Exception("Exception adding account. " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                llenarGrid();
            }
            
        }
    }
}