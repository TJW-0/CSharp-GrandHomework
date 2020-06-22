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
    public partial class FormLibrary : Form
    {
        FormMain formMain { get; set; }
        Client currentClient { get; set; }
        public FormLibrary(FormMain form,Client client)
        {
            InitializeComponent();
            this.formMain = form;
            this.currentClient = client;
            this.bookBindingSource.DataSource = BookShelfService.AllBooks();
        }

        private void queryButton_Click(object sender, EventArgs e)//排序
        {
            List<Book> books = new List<Book>();
            switch (queryComboBox.Text)
            {
                case "推荐数":
                    books = BookShelfService.Query(1);
                    break;
                case "书号":
                    books = BookShelfService.Query(2);
                    break;
                case "作者":
                    books = BookShelfService.Query(3);
                    break;
                case "分类":
                    books = BookShelfService.Query(4);
                    break;
                case "书架号":
                    books = BookShelfService.Query(5);
                    break;
                default:
                    MessageBox.Show("没有选择正确的排序方式！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            this.bookBindingSource.DataSource = books;
        }

        private void detailButton_Click(object sender, EventArgs e)//查看细节
        {
            Book book = bookBindingSource.Current as Book;
            if (book == null)
            {
                MessageBox.Show("请选择一本书进行操作！");
                return;
            }
            FormDetail formDetail = new FormDetail(this, book, currentClient);
            this.Hide();
            formDetail.ShowDialog();
        }

        private void finishButton_Click(object sender, EventArgs e)//完成
        {
            formMain.Show();
            formMain.resetRecommend();
            formMain.Parent = null;
            this.Close();
        }

        public void resetBooks()
        {
            List<Book> books = BookShelfService.AllBooks();
            this.bookBindingSource.DataSource = books;
        }

        private void searchPictureBox_Click(object sender, EventArgs e)//查询
        {
            List<Book> books = new List<Book>();
            if (searchTextBox.Text == null)
            {
                MessageBox.Show("没有输入用于查询的关键词！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (searchComboBox.Text)
                {
                    case "书号":
                        books = BookShelfService.Search(1, searchTextBox.Text);
                        break;
                    case "书名":
                        books = BookShelfService.Search(2, searchTextBox.Text);
                        break;
                    case "作者":
                        books = BookShelfService.Search(3, searchTextBox.Text);
                        break;
                    case "分类":
                        books = BookShelfService.Search(4, searchTextBox.Text);
                        break;
                    case "书架号":
                        books = BookShelfService.Search(5, searchTextBox.Text);
                        break;
                    default:
                        MessageBox.Show("没有选择正确的查询方式！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            this.bookBindingSource.DataSource = books;
        }
    }
}
