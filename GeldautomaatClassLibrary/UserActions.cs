using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

namespace GeldautomaatClassLibrary
{
    public class UserActions : Database
    {
        PasswordConvert passwordConvert = new PasswordConvert();
        UserValidation userValidation = new UserValidation();
        public bool userLogin(string account_number, string pincode)
        {
            pincode = passwordConvert.ComputeSha256Hash(pincode);
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE account_number = @accNUM AND pincode = @pin AND role = 0", connection);
                cmd.Parameters.AddWithValue("@accNUM", account_number);
                cmd.Parameters.AddWithValue("@pin", pincode);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    if (userValidation.validateBlock(Convert.ToBoolean(rdr["blocked"])))
                    {
                        string fullName = rdr["first_name"].ToString() + " " + rdr["last_name"].ToString();
                        UserInfo.userName = fullName;
                        UserInfo.UserID = rdr["id"].ToString();

                        CloseConnection();
                        return true;
                    }
                    else
                    {
                        CloseConnection();
                        return false;

                    }

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        } 

        public string welcomeMessage()
        {
            return "Welkom " + UserInfo.userName + ", kies een van de opties";
        }

        public string returnSaldo()
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", UserInfo.UserID);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
  
                    return rdr["balance"].ToString();
                }
                rdr.Close();
                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return "";
        }

        public bool deposit(string amount)
        {
            try
            {
                string currentBalance = returnSaldo();
                double newBalance = Convert.ToDouble(amount) + Convert.ToDouble(currentBalance);
                CloseConnection();
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `transactions` (`amount`, `type`, `created_at`, `users_id`) VALUES (@amount, @type, CURRENT_DATE(), @user_id)", connection);
                MySqlCommand cmd2 = new MySqlCommand("UPDATE `users` SET balance = @balance WHERE id = @id", connection);

                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@type", UserInfo.Deposit);
                cmd.Parameters.AddWithValue("@user_id", UserInfo.UserID);

                cmd2.Parameters.AddWithValue("@balance", newBalance);
                cmd2.Parameters.AddWithValue("@id", UserInfo.UserID);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                CloseConnection();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        public void transactionHistory(DataGridView table)
        {
            try
            {
                table.Rows.Clear();
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `transactions` WHERE users_id = @id ORDER BY id DESC LIMIT 3", connection);
                cmd.Parameters.AddWithValue("@id", UserInfo.UserID);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    string type = "";
                    if (rdr["type"].ToString() == "deposit")
                    {
                        type = "+";
                    } else
                    {
                        type = "-";
                    }

                    table.Rows.Add(rdr["created_at"], rdr["type"], type + "$" + rdr["amount"]);
                    
                }
                rdr.Close();
                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string userWithdraw(string amount)
        {
            try
            {
                if (userValidation.validateWithdrawHistory())
                {
                    Console.WriteLine("LESS");
                    if (userValidation.validateAffordable(amount))
                    {
                        double newBalance = userValidation.newAmount(amount);
                        CloseConnection();
                        OpenConnection();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO `transactions` (`amount`, `type`, `created_at`, `users_id`) VALUES (@amount, @type, CURRENT_DATE(), @user_id)", connection);
                        MySqlCommand cmd2 = new MySqlCommand("UPDATE `users` SET balance = @balance WHERE id = @id", connection);

                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@type", UserInfo.Withdraw);
                        cmd.Parameters.AddWithValue("@user_id", UserInfo.UserID);

                        cmd2.Parameters.AddWithValue("@balance", newBalance);
                        cmd2.Parameters.AddWithValue("@id", UserInfo.UserID);

                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        CloseConnection();
                        CloseConnection();

                        Console.WriteLine("HET WERKT BICTHES");
                        return "bill";
                    } else
                    {
                        Console.WriteLine("NOOO :(");
                        return "noMoney";
                    }
                } else
                {
                    Console.WriteLine("MORE");
                    return "toMany";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return "error";
        }

        public string withdrawMsg()
        {
            return UserInfo.formMessage;
        }

        public void setWithdrawMsg(string msg)
        {
            UserInfo.formMessage = msg;
        }
    }
}
