using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_DataInput.Model
{
    public class DataManager
    {
        private static string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static bool Save(Passport passport)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Passport VALUES(@PassportNo, @LastName, @FirstName, @Nationality, @DOB, @Picture)";
                cmd.Parameters.Add(new SqlParameter("@PassportNo", SqlDbType.VarChar)).Value = passport.PassportNo;
                cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = passport.LastName;
                cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = passport.FirstName;

                if (String.IsNullOrEmpty(passport.Nationality))
                {
                    cmd.Parameters.Add(new SqlParameter("@Nationality", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Nationality", SqlDbType.NVarChar)).Value = passport.Nationality;
                }

                cmd.Parameters.AddWithValue("@DOB", passport.DOB);

                var passportImage = new SqlParameter("@Picture", SqlDbType.VarBinary, -1);

                if (passport.Picture == null)
                {
                    passportImage.Value = DBNull.Value;
                }
                else
                {
                    passportImage.Value = passport.Picture;
                }
                cmd.Parameters.Add(passportImage);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }

                return false;
            };
        }

        public static DataSet GetPassportData()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string sql = "SELECT * FROM Passport";

                conn.Open();

                var adapter = new SqlDataAdapter(sql, conn);
                var ds = new DataSet();

                adapter.Fill(ds);

                return ds;
            }
        }

        public static bool Update(Passport passport)
        {
            using(SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"UPDATE Passport " +
                                  $"SET LastName=@LastName, FirstName=@FirstName, Nationality=@Nationality, DOB=@DOB, Picture=@Picture " +
                                  $"WHERE PassportNo=@PassportNo";

                cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 10)).Value = passport.LastName;
                cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 10)).Value = passport.FirstName;

                if (String.IsNullOrEmpty(passport.Nationality))
                {
                    cmd.Parameters.AddWithValue("@Nationality", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Nationality", SqlDbType.NVarChar, 50)).Value = passport.Nationality;
                }

                cmd.Parameters.AddWithValue("@DOB", passport.DOB);

                SqlParameter passportImage = new SqlParameter("@Picture", SqlDbType.VarBinary, -1);
                if (passport.Picture != null)
                {
                    passportImage.Value = passport.Picture;
                }
                else
                {
                    passportImage.Value = DBNull.Value;
                }
                cmd.Parameters.Add(passportImage);

                // WHERE, @PassportNo
                cmd.Parameters.AddWithValue("@PassportNo", passport.PassportNo);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                return false;
            }
        }
    }
}