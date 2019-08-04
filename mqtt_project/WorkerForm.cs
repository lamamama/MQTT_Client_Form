using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using MySqlConnector.Authentication;
using MySqlConnector.Logging;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using uPLibrary.Networking.M2Mqtt.Session;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Internal;
using uPLibrary.Networking.M2Mqtt;
using Newtonsoft.Json;
using System.Threading;

namespace mqtt_project
{
    public partial class WorkerForm : Form
    {
        /// <summary>
        /// MQTT代理服务器地址
        /// </summary>
        public string MQTT_Border_IPAddress = "2409:8921:5a20:36fb:e8ad:b160:8081:b02c";
        DataTable room = new DataTable();
        public WorkerForm()
        {
            InitializeComponent();
            ROOMDATATABLEINIT();
            RoomComboComInit();
            
        }

        void RoomComboComInit()
        {
            ConMySQLByUserAndPwsswd();
            for (int i = 0; i < room.Rows.Count; i++)
            {
                Room_ComboBox.Items.Add(room.Rows[i]["room"]);
                Room_ComboBox.SelectedIndex = 0;
            }
            this.Name_Text_Label.Text = room.Rows[this.Room_ComboBox.SelectedIndex]["Account"].ToString();
            this.label1.Text = this.Room_ComboBox.Text;
            if(this.label1.Text=="21-2-3")
            Mqtt_Sub_Message("iot-2/evt/status/fmt/json".Split(' '));
        }
        /// <summary>
        /// 初始化DataTable
        /// </summary>
        void ROOMDATATABLEINIT()
        {
            room.Columns.Add("room");
            room.Columns.Add("Account");
            
        }
        /// <summary>
        /// 通过房间号查找数据
        /// </summary>
        /// <param name="room"></param>
        public void ConMySQLByUserAndPwsswd()
        {
            string datatable = null;
            datatable = "Patient_Login_Hospital";
            string connecStr = "Server=2001:da8:270:2018:f816:3eff:fe1d:bb01;User ID=root;Password=lama940225;Database=MQTT_DATA";
            try
            {
                using (var conn = new MySqlConnection(connecStr))
                {
                    conn.Open();
                    MySqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + datatable +";");
                        cmd.Connection = conn;
                        cmd.Transaction = trans;

                        using (var reader = cmd.ExecuteReader())
                        {


                            if (reader.HasRows)
                            {
                                //登陆成功

                                while (reader.Read())
                                {
                                    room.Rows.Add(reader["room"],reader["Account"]);
                                }
                            }
                            else
                            {
                                //登陆失败
                                MessageBox.Show("未查找到该病床");
                                this.Name_Text_Label.Text = "未设置";
                                this.label1.Text = "未设置";
                            }


                        }
                        trans.Commit();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        conn.Close();
                        MessageBox.Show(ex.ToString());
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Room_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MqttClient client = new MqttClient(MQTT_Border_IPAddress);
            client.Unsubscribe("iot-2/evt/status/fmt/json".Split(' '));
            this.Name_Text_Label.Text = room.Rows[this.Room_ComboBox.SelectedIndex]["Account"].ToString();
            this.label1.Text = this.Room_ComboBox.Text;
            if (this.label1.Text == "21-2-3")
                Mqtt_Sub_Message("iot-2/evt/status/fmt/json".Split(' '));
            else
            {
                this.Pass_Now_Value_Label.Text = "未连接";
                this.Liu_Now_Value_Label.Text = "未连接";


            }

        }

        /// <summary>
        /// 订阅某主题
        /// </summary>
        /// <param name="Topic">消息主题</param>
        /// <param name="QosLevel">消息安全等级，要和发布消息一致</param>
        public void Mqtt_Sub_Message(string[] Topic, int QosLevel = 0)
        {
            //消息等级
            byte[] qos;
            // create client instance
            MqttClient client = new MqttClient(MQTT_Border_IPAddress);

            // register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            if (QosLevel == 0)
            {
                qos = new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };

            }
            else if (QosLevel == 1)
            {
                qos = new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE };
            }
            else if (QosLevel == 2)
            {
                qos = new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
            }
            else
            {
                qos = new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
            }
            // subscribe to the topic "/home/temperature" with QoS 2
            client.Subscribe(Topic, qos);
           
        }
        /// <summary>
        /// 收到的订阅消息内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            // handle message received
            
            string a = System.Text.Encoding.Default.GetString(e.Message);
            MQTTTRecMes Msg = JsonConvert.DeserializeObject<MQTTTRecMes>(System.Text.Encoding.Default.GetString(e.Message));

            new Thread(() =>
            {

                Action action = () =>
                {
                    if (this.label1.Text == "21-2-3")
                    {
                        this.Pass_Now_Value_Label.Text = Msg.Pa_value;
                        this.Liu_Now_Value_Label.Text = Msg.Temp;
                    }

                };
                Invoke(action);

            }).Start();

        }
        /// <summary>
        /// 发布MQTT消息
        /// </summary>
        /// <param name="Topic">消息主题</param>
        /// <param name="message">消息内容</param>
        /// <param name="QosLevel">消息qos级别</param>
        public void Mqtt_Pub_Message(string Topic, string message, int QosLevel = 0)
        {
            MqttClient client = new MqttClient(MQTT_Border_IPAddress);
            string clientid = Guid.NewGuid().ToString();
            client.Connect(clientid);
            //消息qos级别
            byte qos;
            if (QosLevel == 0)
            {
                qos = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;

            }
            else if (QosLevel == 1)
            {
                qos = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
            }
            else if (QosLevel == 2)
            {
                qos = MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
            }
            else
            {
                qos = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
            }

            client.Publish(Topic, Encoding.UTF8.GetBytes(message), qos, false);
        }
        public class MQTTTRecMes
        {
            public string myName { get; set; }
            public string room { get; set; }
            public string Pa_value { get; set; }
            public string DefRoute  { get; set; }
        public string RSSI { get; set; }
        public string Temp { get; set; }
        public string VDD3 { get; set; }
        public string ALL_L { get; set; }
    }
}
}
