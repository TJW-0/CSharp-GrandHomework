using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem_Final.LibraryForm
{
    public partial class FormDetail : Form
    {
        public FormAccount formAccount { get; set; }
        public FormLibrary formLibrary { get; set; }
        public FormManage formManage { get; set; }
        public int Flag = 0;
        public static String resPath { get; set; }//封面文件存放的路径
        public String path { get; set; }//当前图片的路径
        public Book currentBook { get; set; }
        public Client currentClient { get; set; }
        public BookShelf currentShelf { get; set; }

        public FormDetail(FormAccount form1, Book book, Client client)//从我的账号界面进入
        {
            InitializeComponent();
            this.Flag = 1;
            resPath = BookShelfService.findPath();
            this.currentBook = book;
            this.currentClient = client;
            this.formAccount = form1;
            this.nameTextBox.Text = book.Name;
            this.nameTextBox.ReadOnly = true;
            this.authorTextBox.Text = book.Author;
            this.authorTextBox.ReadOnly = true;
            this.sortTextBox.Text = book.Sort;
            this.sortTextBox.ReadOnly = true;
            this.shelfIdTextBox.Text = book.BookShelfId;
            this.shelfIdTextBox.ReadOnly = true;
            this.introductionTextBox.Text = book.Description;
            this.introductionTextBox.ReadOnly = true;
            if (book.imagePath != null)
            {
                if (File.Exists(book.imagePath))
                {
                    FileStream fs = File.Open(book.imagePath, FileMode.Open);
                    this.discoverPictureBox.Image = Image.FromStream(fs);
                    fs.Close();
                    //this.discoverPictureBox.Image = Image.FromFile(book.imagePath);
                }
            }
            this.appointButton.Visible = false;
            this.lendButton.Visible = false;
            this.recommendButton.Visible = false;
            this.choosePictureButton.Visible = false;
            this.addButton.Visible = false;
        }
        public FormDetail(FormLibrary form2, Book book, Client client)//从馆内藏书界面进入
        {
            InitializeComponent();
            this.Flag = 2;
            resPath = BookShelfService.findPath();
            this.currentBook = book;
            this.currentClient = client;
            this.formLibrary = form2;
            this.nameTextBox.Text = book.Name;
            this.nameTextBox.ReadOnly = true;
            this.authorTextBox.Text = book.Author;
            this.authorTextBox.ReadOnly = true;
            this.sortTextBox.Text = book.Sort;
            this.sortTextBox.ReadOnly = true;
            this.shelfIdTextBox.Text = book.BookShelfId;
            this.shelfIdTextBox.ReadOnly = true;
            this.introductionTextBox.Text = book.Description;
            this.introductionTextBox.ReadOnly = true;
            if (book.imagePath != null)
            {
                if (File.Exists(book.imagePath))
                {
                    FileStream fs = File.Open(book.imagePath, FileMode.Open);
                    this.discoverPictureBox.Image = Image.FromStream(fs);
                    fs.Close();
                    //this.discoverPictureBox.Image = Image.FromFile(book.imagePath);
                }
            }
            this.choosePictureButton.Visible = false;
            this.addButton.Visible = false;
        }
        public FormDetail(FormManage form3, BookShelf shelf, Client client)//从图书管理界面的添加书籍进入
        {
            InitializeComponent();
            this.Flag = 3;
            resPath = BookShelfService.findPath();
            this.currentShelf = shelf;
            this.currentClient = client;
            this.formManage = form3;
            this.shelfIdTextBox.Text = shelf.BookShelfId;
            this.shelfIdTextBox.ReadOnly = true;
            this.appointButton.Visible = false;
            this.lendButton.Visible = false;
            this.recommendButton.Visible = false;
        }
        public FormDetail(FormManage form3, Book book,Client client)//从图书管理界面的修改细节进入
        {
            InitializeComponent();
            this.Flag = 4;
            resPath = BookShelfService.findPath();
            this.currentBook = book;
            this.currentClient = client;
            this.formManage = form3;
            this.nameTextBox.Text = book.Name;
            this.authorTextBox.Text = book.Author;
            this.sortTextBox.Text = book.Sort;
            this.shelfIdTextBox.Text = book.BookShelfId;
            this.shelfIdTextBox.ReadOnly = true;
            this.introductionTextBox.Text = book.Description;
            if (book.imagePath != null)
            {
                if (File.Exists(book.imagePath))
                {
                    FileStream fs = File.Open(book.imagePath, FileMode.Open);
                    this.discoverPictureBox.Image = Image.FromStream(fs);
                    fs.Close();
                    //this.discoverPictureBox.Image = Image.FromFile(book.imagePath);
                }
            }
            this.appointButton.Visible = false;
            this.lendButton.Visible = false;
            this.recommendButton.Visible = false;
            this.addButton.Visible = false;
        }
        private void appointButton_Click(object sender, EventArgs e)//预约
        {
            BookShelfService.AppointBook(currentBook, currentClient);
            this.appointButton.Enabled = false;
            this.appointButton.Visible = false;
        }

        private void lendButton_Click(object sender, EventArgs e)//借阅
        {
            BookShelfService.LendBook(currentBook, currentClient);
        }

        private void recommendButton_Click(object sender, EventArgs e)//推荐
        {
            currentBook.Recommend = currentBook.Recommend + 1;
            BookShelfService.UpdateBook(currentBook);
            this.recommendButton.Enabled = false;
            this.recommendButton.Visible = false;
        }

        private void choosePictureButton_Click(object sender, EventArgs e)//选择封面
        {
            this.openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            if (path.Contains(".jpg") || path.Contains(".png") || path.Contains(".gif") || path.Contains(".bmp"))
            {
                FileStream fd = File.Open(path, FileMode.Open);
                this.discoverPictureBox.Image = Image.FromStream(fd);
                fd.Close();
                //discoverPictureBox.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("请选择图片文件！");
            }
        }

        private void addButton_Click(object sender, EventArgs e)//加入书架
        {
            if (nameTextBox.Text != null && authorTextBox.Text != null && sortTextBox.Text != null && introductionTextBox.Text != null)
            {
                int k = Convert.ToInt32(BookShelfService.AllBooks().Max(i => i.BookId)) + 1;
                string bookId = k + "";
                string name = this.nameTextBox.Text;
                string author = this.authorTextBox.Text;
                string bookShelfId = currentShelf.BookShelfId;
                string lendTime = null;
                string clientName = null;
                string sort = this.sortTextBox.Text;
                string appointers = "";
                string description = this.introductionTextBox.Text;
                Book newBook = new Book(bookId, name, bookShelfId, author, description, lendTime, clientName, sort, appointers) { State = "可正常使用" };
                if (path != null)
                {
                    FileStream fr = File.Open(path, FileMode.Open);
                    FileStream fw = File.Open(resPath + @"\" + newBook.Name + ".jpg", FileMode.Create);
                    Image newImage = Image.FromStream(fr);
                    newImage.Save(fw, System.Drawing.Imaging.ImageFormat.Jpeg);
                    newBook.imagePath = resPath + @"\" + newBook.Name + ".jpg";
                    fr.Close();
                    fw.Close();
                }
                currentShelf.AddBook(newBook);
                BookShelfService.UpdateShelf(currentShelf);
                MessageBox.Show("已添加新书！");
                this.addButton.Enabled = false;
                this.addButton.Visible = false;
            }
            else
            {
                MessageBox.Show("没有输入完整的信息！");
            }
        }

        private void finishButton_Click(object sender, EventArgs e)//完成
        {
            switch (Flag)
            {
                case 1:
                    formAccount.Show();
                    formAccount.resetAppointAndLend();
                    formAccount.Parent = null;
                    this.Close();
                    break;
                case 2:
                    formLibrary.Show();
                    formLibrary.resetBooks();
                    formLibrary.Parent = null;
                    this.Close();
                    break;
                case 3:
                    formManage.Show();
                    formManage.resetLibrary();
                    formManage.Parent = null;
                    this.Close();
                    break;
                case 4:
                    currentBook.Name = this.nameTextBox.Text;
                    currentBook.Author = this.authorTextBox.Text;
                    currentBook.Sort = this.sortTextBox.Text;
                    currentBook.Description = this.introductionTextBox.Text;
                    BookShelfService.UpdateBook(currentBook);
                    if (path != null)
                    {
                        if(File.Exists(resPath + @"\" + currentBook.Name + ".jpg"))
                        {
                            File.Delete(resPath + @"\" + currentBook.Name + ".jpg");
                        }
                        FileStream fr = File.Open(path, FileMode.Open);
                        FileStream fw = File.Open(resPath + @"\" + currentBook.Name + ".jpg", FileMode.Create);
                        Image newImage = Image.FromStream(fr);
                        newImage.Save(fw, System.Drawing.Imaging.ImageFormat.Jpeg);
                        currentBook.imagePath = resPath + @"\" + currentBook.Name + ".jpg";
                        fr.Close();
                        fw.Close();
                    }
                    formManage.Show();
                    formManage.resetLibrary();
                    formManage.Parent = null;
                    this.Close();
                    break;
                default:
                    break;
            }
        }

    }
}
