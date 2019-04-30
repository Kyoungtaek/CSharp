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
        public static bool Save(Passport passport)
        {
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

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

                if(passport.Picture == null)
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
    }
}
