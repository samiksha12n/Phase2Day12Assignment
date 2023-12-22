using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Assignment11MasterPage
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        private const string connectionString = "Server=SHIVAMSINGH;Database=ContentDB;Integrated Security=True;";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                RetrieveArticles();
            }
        }

        private void RetrieveArticles()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ArticleId, Title, Content, PublishDate FROM articles";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            Article.DataSource = dataTable;
                            Article.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Response.Write("Error retrieving articles: " + ex.Message);
            }
        }


    }
}