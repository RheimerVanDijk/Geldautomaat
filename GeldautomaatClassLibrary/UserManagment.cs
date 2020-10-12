using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GeldautomaatClassLibrary
{
    public class UserManagment : Database
    {
        PasswordConvert passwordConvert = new PasswordConvert();
        public bool adminLogin(string username, string pincode)
        {
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE email = @email AND pincode = @pincode AND role = 1", connection);
                cmd.Parameters.AddWithValue("@email", username);
                cmd.Parameters.AddWithValue("@pincode", pincode);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    CloseConnection();

                    return true;
                }
                rdr.Close();

                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            CloseConnection();
            return false;
        }
        
        public bool createUser(string email, string sex, System.DateTime birthday, int bsn, string firstName, string lastName, string address, string postcode, string plaats)
        {
            try
            {
                OpenConnection();
                Random RandNum = new Random();

                int accountNumber = RandNum.Next(10000000, 99999999);

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE account_number = @accountNumber", connection);
                cmd.Parameters.AddWithValue("@accountNumber", accountNumber);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    rdr.Close();
                    createUser(email, sex, birthday, bsn, firstName, lastName, address, postcode, plaats);
                }else
                {
                    rdr.Close();
                    string pinCode = passwordConvert.randomPincode();
                    cmd = new MySqlCommand("INSERT INTO users (email, sex, birthday, bsn_number, first_name, last_name, address, zipcode, town, pincode, account_number) VALUES(@email, @sex, @birthday, @bsn_number, @first_name, @last_name, @address, @zipcode, @town, @pincode, @account_number)", connection);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@birthday", birthday);
                    cmd.Parameters.AddWithValue("@bsn_number", bsn);
                    cmd.Parameters.AddWithValue("@first_name", firstName);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@zipcode", postcode);
                    cmd.Parameters.AddWithValue("@town", plaats);
                    cmd.Parameters.AddWithValue("@pincode", pinCode);
                    cmd.Parameters.AddWithValue("@account_number", accountNumber);

                    cmd.ExecuteNonQuery();

                    CloseConnection();

                    Console.WriteLine("SUCCESSS");
                    return true;
                }
                rdr.Close();

                CloseConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        public void GetAllUsers(DataGridView dgvUsers)
        {
            dgvUsers.Rows.Clear();
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE role = 0", connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dgvUsers.Rows.Add(rdr["id"], rdr["first_name"], rdr["last_name"], rdr["account_number"], "edit user");
                }
                rdr.Close();

                CloseConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void FillEditUser(string id, TextBox email, TextBox sex, DateTimePicker birthday, TextBox bsn, TextBox firstName, TextBox lastName, TextBox address, TextBox postcode, TextBox plaats)
        {
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        DateTime value = DateTime.Parse(rdr["birthday"].ToString());
                        email.Text = rdr["email"].ToString();
                        sex.Text = rdr["sex"].ToString();
                        birthday.Value = DateTime.Parse(value.ToString("yyyy/MM/dd"));
                        bsn.Text = rdr["bsn_number"].ToString();
                        firstName.Text = rdr["first_name"].ToString();
                        lastName.Text = rdr["last_name"].ToString();
                        address.Text = rdr["address"].ToString();
                        postcode.Text = rdr["zipcode"].ToString();
                        plaats.Text = rdr["town"].ToString();
                    }

                    rdr.Close();
                }

                CloseConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void updateUser(string email, string sex, System.DateTime birthday, int bsn, string firstName, string lastName, string address, string postcode, string plaats, string id)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET email = @email, sex = @sex, birthday = @birthday, bsn_number = @bsn_number, first_name = @first_name, last_name = @last_name, address = @address, zipcode = @zipcode, town = @town WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@bsn_number", bsn);
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@zipcode", postcode);
                cmd.Parameters.AddWithValue("@town", plaats);
                cmd.Parameters.AddWithValue("@id", id);


                cmd.ExecuteNonQuery();

                CloseConnection();

                Console.WriteLine("SUCCESSS");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void resetPin(string id)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET pincode = @pincode WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@pincode", passwordConvert.randomPincode());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                CloseConnection();

                Console.WriteLine("SUCCESSS");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void setUserBlock(string id, string value)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET blocked = @blockedValue WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@blockedValue", value);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                CloseConnection();

                Console.WriteLine("Updated block state");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public bool removeUser(string id)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `users` WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteReader();
                CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        public void searchUser(string name, string accountNumber, DataGridView dgvUsers)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE role = 0 AND CONCAT(first_name , ' ' , last_name) = @search OR role = 0 AND first_name = @search OR role = 0 AND last_name = @search OR role = 0 AND account_number = @num", connection);
                cmd.Parameters.AddWithValue("@search", name);
                cmd.Parameters.AddWithValue("@num", accountNumber);

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    dgvUsers.Rows.Clear();
                    while (rdr.Read())
                    {
                        dgvUsers.Rows.Add(rdr["id"], rdr["first_name"], rdr["last_name"], rdr["account_number"], "edit user");
                    }

                    rdr.Close();
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }


}
