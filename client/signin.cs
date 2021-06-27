using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MongoDB.Bson;
using MongoDB.Driver;
namespace client
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }



        private void button_WOC1_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://bang:bang123@cluster0.aacbw.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            IMongoDatabase db = client.GetDatabase("NT216");
            var coll = db.GetCollection<BsonDocument>("NT216_case_study");
            var filter = Builders<BsonDocument>.Filter.Eq("USERNAME", txtUsername.Text.Trim());

            var doc = coll.Find(filter).FirstOrDefault();
            if (doc == null)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không tồn tại.");
                return;
            }
            string username = doc["USERNAME"].AsString;
            string password = doc["PASSWORD"].AsString;
            if (username == txtUsername.Text.Trim() && password == txtPassword.Text.Trim())
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mật khẩu của bạn không đúng.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new signup().Show();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        Point lastpoint;
        private void signin_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void signin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
    }
}
