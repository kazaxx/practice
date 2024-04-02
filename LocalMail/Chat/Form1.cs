using Newtonsoft.Json;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
namespace Chat
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public Form1()
        {
            InitializeComponent();
        }
        public class DataStore
        {
            public static string IP;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidIP(IPTextBox.Text))
            {
                MessageBox.Show("������� ���������� IP-����� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataStore.IP = IPTextBox.Text;
            Form2 form2 = new Form2();
            form2.Show();
        }
        private bool IsValidIP(string ip)
        {
            IPAddress address;
            return IPAddress.TryParse(ip, out address);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
