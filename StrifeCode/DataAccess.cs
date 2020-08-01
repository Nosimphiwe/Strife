using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace StrifeCode
{
    class DataAccess
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JNTVL1MK\\SQLSERVER;Initial Catalog = Strifedb; Integrated Security = True");
        SqlDataReader rdrReader = null;


        public List<UserDetails> GetUsers()
        {

            List<UserDetails> userDetails = new List<UserDetails>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM Users";

                SqlCommand cmdRead = new SqlCommand(query, conn);

                rdrReader = cmdRead.ExecuteReader();

                while (rdrReader.Read())
                {
                    userDetails.Add(new UserDetails(Convert.ToInt16(
                        rdrReader[0]),
                        rdrReader[1].ToString(),
                        rdrReader[2].ToString(),
                        rdrReader[3].ToString(),
                        rdrReader[4].ToString(),
                        rdrReader[5].ToString(),
                        rdrReader[6].ToString(),
                        rdrReader[7].ToString(),
                        rdrReader[8].ToString(),
                        rdrReader[9].ToString(),
                        rdrReader[10].ToString(),
                        rdrReader[11].ToString(),
                        rdrReader[12].ToString()));
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            finally
            {
                if (rdrReader != null)
                {
                    rdrReader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }

            }
            return userDetails;



        }

        public void InsertUserDetails(string name, string surname, string email, string cell, string unit, string street, string suburb, string province, string country, string password, string zip, string picture)
        {
            try
            {
                conn.Open();
                string insertstring = @"Insert Into Users
                                               (Name, Surname, email, Unit, Cell, Street, Suburb, Province, ZipCode, Country, Password, Picture)
                                                Values
                                               ('" + name + "', '" + surname + "' , '" + email + "' , '" + cell + "' , '" + unit + "' , '" + street + "', '" + suburb + "' , '" + province + "' , '" + country + "' , '" + password + "' , '" + zip + "' , '" + picture + "')";
                SqlCommand cmdInsert = new SqlCommand(insertstring, conn);
                cmdInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if (rdrReader != null)
                {
                    rdrReader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }


    }
}
