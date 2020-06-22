using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem_Final.LibraryForm
{
    public partial class FormAccount : Form
    {
        FormMain formMain { get; set; }
        Client currentClient { get; set; }
        List<Book> appointBooks { get; set; }
        List<Book> lendBooks { get; set; }
        public FormAccount(FormMain form1, Client client)
        {
            InitializeComponent();
            formMain = form1;
            currentClient = client;
            this.resetAppointAndLend();
        }

        private void finishButton_Click(object sender, EventArgs e)//完成
        {
            formMain.Show();
            formMain.resetRecommend();
            formMain.Parent = null;
            this.Close();
        }

        private void cancellButton_Click(object sender, EventArgs e)//取消预约
        {
            Book book = appointBindingSource.Current as Book;
            if (book == null)
            {
                MessageBox.Show("请选择一本书进行操作！");
                return;
            }
            BookShelfService.CancellAppoint(book, currentClient);
            appointBooks = new List<Book>();
            appointBindingSource.DataSource = appointBooks;
            appointBooks = BookShelfService.GetAllAppointedBooks(currentClient);
            appointBindingSource.ResetBindings(false);
            appointBindingSource.DataSource = appointBooks;
        }

        private void detailButton1_Click(object sender, EventArgs e)//预约的查看细节
        {
            Book book = appointBindingSource.Current as Book;
            if (book == null)
            {
                MessageBox.Show("请选择一本书进行操作！");
                return;
            }
            FormDetail formDetail = new FormDetail(this, book, currentClient);
            this.Hide();
            formDetail.ShowDialog();
        }

        private void newButton_Click(object sender, EventArgs e)//续借
        {
            Book book = lendBindingSource.Current as Book;
            if (book == null)
            {
                MessageBox.Show("请选择一本书进行操作！");
                return;
            }
            if (book.reNewNum < 3)
            {
                BookShelfService.ReNewLending(book, currentClient);
            }
            else
            {
                MessageBox.Show("该书续借次数太多，不允许继续续借！");
            }
            lendBooks = new List<Book>();
            lendBindingSource.DataSource = lendBooks;
            lendBooks = BookShelfService.GetAllLentBooks(currentClient);
            lendBindingSource.ResetBindings(false);
            lendBindingSource.DataSource = lendBooks;
        }

        private void returnButton_Click(object sender, EventArgs e)//还书
        {
            Book book = lendBindingSource.Current as Book;
            if (book == null)
            {
                MessageBox.Show("请选择一本书进行操作！");
                return;
            }
            BookShelfService.ReturnBooks(book, currentClient);
            lendBooks = new List<Book>();
            lendBindingSource.DataSource = lendBooks;
            lendBooks = BookShelfService.GetAllLentBooks(currentClient);
            lendBindingSource.ResetBindings(false);
            lendBindingSource.DataSource = lendBooks;
        }

        private void detailButton2_Click(object sender, EventArgs e)//借阅的查看细节
        {
            Book book = lendBindingSource.Current as Book;
            if (book == null)
            {
                MessageBox.Show("请选择一本书进行操作！");
                return;
            }
            FormDetail formDetail = new FormDetail(this, book, currentClient);
            this.Hide();
            formDetail.ShowDialog();
        }

        public void resetAppointAndLend()
        {
            appointBooks = BookShelfService.GetAllAppointedBooks(currentClient);
            this.appointBindingSource.DataSource = appointBooks;
            lendBooks = BookShelfService.GetAllLentBooks(currentClient);
            this.lendBindingSource.DataSource = lendBooks;
            this.nameTextBox.Text = currentClient.Name;
        }
    }
}
