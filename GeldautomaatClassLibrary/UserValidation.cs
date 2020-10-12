using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeldautomaatClassLibrary
{
    public class UserValidation : Database
    {
        public bool validateBlock(bool blockID)
        {
            if (blockID == false)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool validateWithdrawHistory()
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `transactions` WHERE users_id = @id AND created_at = CURRENT_DATE() AND type = 'withdraw'", connection);
                cmd.Parameters.AddWithValue("@id", UserInfo.UserID);

                MySqlDataReader rdr = cmd.ExecuteReader();

                int counter = 0;
                while (rdr.Read())
                {
                    counter++;
                }
                rdr.Close();

                if (counter < 3)
                {
                    CloseConnection();
                    return true;
                } else
                {
                    CloseConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            CloseConnection();
            return false;
        }

        public double returnSaldo()
        {
            try
            {
                CloseConnection();
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", UserInfo.UserID);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    return Convert.ToDouble(rdr["balance"]);
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0.0;
        }

        public double newAmount(string amount)
        {
            return returnSaldo() - Convert.ToDouble(amount);
        }

        public bool validateAffordable(string amount)
        {
            double newBalance = newAmount(amount);
            if (newBalance < 0)
            {
                return false;
            } else
            {
                return true;
            }
        }


    }
}
