using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AcRepair.Models
{
    public class AppllicationDbContext
    {
        SqlConnection con;
        public AppllicationDbContext()
        {
       
               con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public bool UserAppoimentdata(UserModel md)
        {
            string query = "Insert Into usercurd (Name,Email,Description)values('"+md.Name+"','"+md.Email+"','"+md.Description+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (1 > 0) { return true; } 
            else
            {
                return false;
            }
        }
    }
}