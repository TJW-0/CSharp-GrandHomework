using LibrarySystem_Final.LibraryForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem_Final
{
    public partial class FormMain : Form
    {
        public Client currentClient { get; set; }
        public Client administrator = new Client("管理员", "admin");
        public Client user1 = new Client("涂珈玮", "TJW");
        public Client user2 = new Client("康盛尧", "KSY");
        public Client user3 = new Client("李梦凡", "LMF");
        public List<Book> recommendBooks { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public FormMain()
        {
            InitializeComponent();
            administrator.Id = "1";
            user1.Id = "2";
            user2.Id = "3";
            user3.Id = "4";
            if (currentClient == null)
            {
                this.signOutButton.Visible = false;
                this.signOutButton.Enabled = false;
            }
            if (ClientService.AllClients().Count == 0)
            {
                ClientService.AddAdministrator(administrator);
                ClientService.AddAdministrator(user1);
                ClientService.AddAdministrator(user2);
                ClientService.AddAdministrator(user3);
            }
            this.managePictureBox.Visible = false;
            this.accountButton.Visible = false;
            this.libraryButton.Visible = false;
            //this.managePictureBox.Enabled = false;
            if (BookShelfService.AllBooks().Count == 0)//设置初始值
            {
                Test.Test1();
                Test.Test2();
            }
            //MessageBox.Show("1");
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            String time = DateTime.Now.ToLongDateString().ToString();
            int m = time.IndexOf("月");
            int d = time.IndexOf("日");
            Day = DateTime.Now.Day;
            BookShelfService.Check(Year, Month, Day);
            recommendBooks = BookShelfService.getRecommend();
            recommendBindingSource.DataSource = recommendBooks;
        }

        private void signInButton_Click(object sender, EventArgs e)//登录
        {
            FormRegisterAndSignIn formRegisterAndSignin = new FormRegisterAndSignIn(1);
            if (formRegisterAndSignin.ShowDialog() == DialogResult.OK)
            {
                currentClient = formRegisterAndSignin.currentClient;
                if (currentClient != null)
                {
                    nameTextBox.ReadOnly = false;
                    nameTextBox.Text = currentClient.Name;
                    nameTextBox.ReadOnly = true;
                    this.signOutButton.Visible = true;
                    this.signOutButton.Enabled = true;
                    this.signInButton.Visible = false;
                    this.signInButton.Enabled = false;
                    this.registerButton.Visible = false;
                    this.registerButton.Enabled = false;
                    this.accountButton.Visible = true;
                    this.libraryButton.Visible = true;
                    if (currentClient.Name == "管理员")
                    {
                        this.managePictureBox.Visible = true;
                        this.managePictureBox.Enabled = true;
                    }
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)//注册
        {
            FormRegisterAndSignIn formRegisterandSignin = new FormRegisterAndSignIn(2);
            formRegisterandSignin.ShowDialog();
        }

        private void signOutButton_Click(object sender, EventArgs e)//退出登录
        {
            currentClient = null;
            nameTextBox.ReadOnly = false;
            nameTextBox.Text = null;
            nameTextBox.ReadOnly = true;
            this.signOutButton.Visible = false;
            this.signOutButton.Enabled = false;
            this.signInButton.Visible = true;
            this.signInButton.Enabled = true;
            this.registerButton.Visible = true;
            this.registerButton.Enabled = true;
            this.managePictureBox.Visible = false;
            this.managePictureBox.Enabled = false;
            this.accountButton.Visible = false;
            this.libraryButton.Visible = false;
        }

        private void accountButton_Click(object sender, EventArgs e)//进入账号界面
        {
            FormAccount formAccount = new FormAccount(this, currentClient);
            this.Hide();
            formAccount.ShowDialog();
        }

        private void libraryButton_Click(object sender, EventArgs e)//查阅馆内藏书
        {
            FormLibrary formLibrary = new FormLibrary(this, currentClient);
            this.Hide();
            formLibrary.ShowDialog();
        }

        private void managePictureBox_Click(object sender, EventArgs e)//进行图书管理
        {
            FormManage formManage = new FormManage(this, currentClient);
            this.Hide();
            formManage.ShowDialog();
        }

        public void resetRecommend()
        {
            this.recommendBindingSource.DataSource = BookShelfService.getRecommend();
        }
    }
}
