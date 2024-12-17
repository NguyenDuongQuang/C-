using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Goll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            testEntities.Data
        }

        public List<nhan_vien> getAll()
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44345/api/")
            };
            var resqonse = client.GetAsync("NhanVien").Result;
            return resqonse.IsSuccessStatusCode ? resqonse.Content.Re : null;
        }
    }
}
