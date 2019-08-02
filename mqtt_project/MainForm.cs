using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Diagnostics;
using uPLibrary.Networking.M2Mqtt;
using System.Net;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using uPLibrary.Networking.M2Mqtt.Session;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Internal;
using MySqlConnector;
using MySqlConnector.Authentication;
using MySqlConnector.Logging;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace mqtt_project
{
    public partial class MainForm : Form
    {
        

        /// <summary>
        /// MQTT代理服务器地址
        /// </summary>
        public string MQTT_Border_IPAddress = "2409:8921:5a70:70d:ad78:d234:f05b:564";
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();
        public MainForm()
        {
            InitializeComponent();
            
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
            this.textBox1.Text = System.Text.Encoding.Default.GetString(e.Message);
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

        private void SUB_BTN_Click(object sender, EventArgs e)
        {
            string topic = "/my/test";

            Mqtt_Sub_Message(topic.Split(' '));
        }

        private void Pub_BTN_Click(object sender, EventArgs e)
        {
            Mqtt_Pub_Message("/my/test", this.textBox2.Text);
        }
        private void History_BTN_Click(object sender, EventArgs e)
        {
            HistoryForm HF = new HistoryForm();
            HF.Show();
        }
    }
}
