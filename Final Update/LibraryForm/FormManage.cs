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
    public partial class FormManage : Form
    {
        FormMain formMain { get; set; }
        Client currentClient { get; set; }
        bool isNormal = true;
        public FormManage(FormMain form, Client client)
        {
            InitializeComponent();
            this.formMain = form;
            this.currentClient = client;
            this.shelfBindingSource.DataSource = BookShelfService.GetAllShelfs();
        }

        private void addShelfButton_Click(object sender, EventArgs e)//添加书架
        {
            int k = Convert.ToInt32(BookShelfService.GetAllShelfs().Max(i => i.BookShelfId)) + 1;
            BookShelfService.AddBookShelf(new BookShelf() { BookShelfId = k + "" });
            shelfBindingSource.DataSource = BookShelfService.GetAllShelfs();
        }

        private void deleteShelfButton_Click(object sender, EventArgs e)//删除书架
        {
            BookShelf shelf = shelfBindingSource.Current as BookShelf;
            BookShelfService.RemoveBookShelf(shelf.BookShelfId);
            shelfBindingSource.DataSource = BookShelfService.GetAllShelfs();
        }

        private void addBookButton_Click(object sender, EventArgs e)//添加书籍
        {
            BookShelf shelf = shelfBindingSource.Current as BookShelf;
            FormDetail formDetail = new FormDetail(this,shelf,currentClient);
            this.Hide();
            formDetail.ShowDialog();
        }

        private void deleteBookButton_Click(object sender, EventArgs e)//删除书籍
        {
            Book book = bookBindingSource.Current as Book;
            if (book == null)
            {
                MessageBox.Show("请选择一本书进行操作！");
                return;
            }
            BookShelfService.RemoveBooks(book.BookId);
            shelfBindingSource.DataSource = BookShelfService.GetAllShelfs();
        }

        private void detailButton_Click(object sender, EventArgs e)//修改细节
        {
            BookShelf shelf = shelfBindingSource.Current as BookShelf;
            Book book = bookBindingSource.Current as Book;
            FormDetail formDetail = new FormDetail(this,book, currentClient);
            this.Hide();
            formDetail.ShowDialog();
        }

        private void searchPictureBox_Click(object sender, EventArgs e)//查询
        {
            if (searchTextBox.Text == null)
            {
                MessageBox.Show("没有输入用于查询的关键词！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String key = searchTextBox.Text;
                List<Book> searchBooks = new List<Book>();
                switch (searchComboBox.Text)
                {
                    case "书号":
                        if (!isNormal)
                        {
                            foreach (var book in BookShelfService.AllBooks().Where(o => o.BookId.Contains(key) == true))
                            {
                                searchBooks.Add(book);
                            }
                        }
                        else
                        {
                            BookShelf shelf = shelfBindingSource.Current as BookShelf;
                            foreach (var book in BookShelfService.AllBooks().Where(o => o.BookId.Contains(key) == true).Where(i => i.BookShelfId == shelf.BookShelfId))
                            {
                                searchBooks.Add(book);
                            }
                        }
                        break;
                    case "书名":
                        if (!isNormal)
                        {
                            foreach (var book in BookShelfService.AllBooks().Where(o => o.Name.Contains(key) == true))
                            {
                                searchBooks.Add(book);
                            }
                        }
                        else
                        {
                            BookShelf shelf = shelfBindingSource.Current as BookShelf;
                            foreach (var book in BookShelfService.AllBooks().Where(o => o.Name.Contains(key) == true).Where(i => i.BookShelfId == shelf.BookShelfId))
                            {
                                searchBooks.Add(book);
                            }
                        }
                        break;
                    case "作者":
                        if (!isNormal)
                        {
                            foreach (var book in BookShelfService.AllBooks().Where(o => o.Author.Contains(key) == true))
                            {
                                searchBooks.Add(book);
                            }
                        }
                        else
                        {
                            BookShelf shelf = shelfBindingSource.Current as BookShelf;
                            foreach (var book in BookShelfService.AllBooks().Where(o => o.Author.Contains(key) == true).Where(i => i.BookShelfId == shelf.BookShelfId))
                            {
                                searchBooks.Add(book);
                            }
                        }
                        break;
                    case "分类":
                        if (!isNormal)
                        {
                            foreach (var book in BookShelfService.AllBooks().Where(o => o.Sort.Contains(key) == true))
                            {
                                searchBooks.Add(book);
                            }
                        }
                        else
                        {
                            BookShelf shelf = shelfBindingSource.Current as BookShelf;
                            foreach (var book in BookShelfService.AllBooks().Where(o => o.Sort.Contains(key) == true).Where(i => i.BookShelfId == shelf.BookShelfId))
                            {
                                searchBooks.Add(book);
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("没有选择正确的查询方式！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                bookBindingSource.DataMember = null;
                bookBindingSource.DataSource = searchBooks;
            }
        }

        private void sortButton_Click(object sender, EventArgs e)//按分类管理
        {
            isNormal = false;
            shelfBindingSource.DataSource = BookShelfService.GetAllShelfs();
            bookBindingSource.DataMember = null;
            bookBindingSource.DataSource = BookShelfService.Query(4);
        }

        private void refreshButton_Click(object sender, EventArgs e)//刷新
        {
            isNormal = true;
            shelfBindingSource.DataSource = BookShelfService.GetAllShelfs();
            bookBindingSource.DataSource = shelfBindingSource;
            bookBindingSource.DataMember = "Books";
        }

        private void finishButton_Click(object sender, EventArgs e)//完成
        {
            formMain.Show();
            formMain.resetRecommend();
            formMain.Parent = null;
            this.Close();
        }

        public void resetLibrary()
        {
            this.shelfBindingSource.DataSource = BookShelfService.GetAllShelfs();
        }
    }
}
