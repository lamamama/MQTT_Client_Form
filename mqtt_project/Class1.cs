using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace mqtt_project
{
    class My_DATA_Connect
    {
        void Con_mysql()
        {
            string connecStr = "server=2001:da8:270:2018:f816:3eff:fe1d:bb01;port=3306;database=MQTT_DATA;user=root;password=lama940225";
            MySqlConnection conn = new MySqlConnection(connecStr);
            try
            {
                conn.Open();
                Console.WriteLine("连接成功！");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            Console.ReadKey();
        }
        
    }
}
