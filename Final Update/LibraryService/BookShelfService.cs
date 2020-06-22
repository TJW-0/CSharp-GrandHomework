using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LibrarySystem_Final
{
    public class BookShelfService
    {
        public BookShelfService()
        {

        }

       public static IQueryable<BookShelf> AllShelves(BookShelfContext db)
        {
            return db.BookShelves.Include(o => o.Books)
                ;
        }

        public static List<BookShelf> GetAllShelfs()//取得数据库内全部的书架
        {
            using (var db = new BookShelfContext())
            {
                var query = AllShelves(db).ToList();
                foreach(var shelf in query)
                {
                    shelf.SetNum();
                }
                return query;
            }
        }
        
        public static BookShelf GetBookShelfById(string id)//按Id取得特定的书架
        {
            using (var db = new BookShelfContext())
            {
                return AllShelves(db).FirstOrDefault(o => o.BookShelfId == id);
            }
        }

        
        public static BookShelf AddBookShelf(BookShelf shelf)//添加新的书架
        {
            try
            {
                using (var db = new BookShelfContext())
                {
                    db.BookShelves.Add(shelf);
                    db.SaveChanges();
                    MessageBox.Show("已成功添加书架！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return shelf;
            }
            catch (Exception e)
            {
                MessageBox.Show("添加书架错误！"+e.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new ApplicationException($"添加书架错误: {e.Message}");
            }
        }

        public static void RemoveBookShelf(string id)//删除书架
        {
            try
            {
                using (var db = new BookShelfContext())
                {
                    var shelf = db.BookShelves.Include("Books").Where(o => o.BookShelfId == id).FirstOrDefault();
                    db.BookShelves.Remove(shelf);
                    db.SaveChanges();
                    ClearBooks();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("删除书架错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new ApplicationException($"删除书架错误!");
            }
        }

        private static void ClearBooks()//配合上一个方法，删除与被删除的书架相关联的书
        {
            try
            {
                using (var db = new BookShelfContext())
                {
                    var oldBooks = db.Books.Where(book => book.BookShelfId == null);
                    db.Books.RemoveRange(oldBooks);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("删除书架错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new ApplicationException($"删除书架错误!");
            }
        }

        public static List<Book> AllBooks()//取得所有的书
        {
            using (var db = new BookShelfContext())
            {
                return db.Books.ToList();
            }
        }
        

        private static void RemoveBooksFromShelf(string bookShelfId)//删除书籍(对整个书架进行操作)，可能无用
        {
            using (var db = new BookShelfContext())
            {
                var oldBooks = db.Books.Where(book => book.BookShelfId == bookShelfId);
                db.Books.RemoveRange(oldBooks);
                db.SaveChanges();
            }
        }

        public static void RemoveBooks(string bookId)//删除书籍(对单本书进行操作)
        {
            using (var db = new BookShelfContext())
            {
                var oldBooks = db.Books.Where(book => book.BookId == bookId);
                foreach (var book in oldBooks)
                {
                    if (book.imagePath != null)
                    {
                        if (File.Exists(book.imagePath))
                        {
                            File.Delete(book.imagePath);
                        }
                    }
                }
                db.Books.RemoveRange(oldBooks);
                db.SaveChanges();
            }
        }

        public static void UpdateShelf(BookShelf newBookShelf)//更新数据库内的书架
        {
            RemoveBooksFromShelf(newBookShelf.BookShelfId);
            using (var db = new BookShelfContext())
            {
                db.Entry(newBookShelf).State = EntityState.Modified;
                db.Books.AddRange(newBookShelf.Books);
                db.SaveChanges();
            }
        }

        public static void UpdateBook(Book newBook)//更新数据库内的书籍
        {
            RemoveBooks(newBook.BookId);
            using (var db = new BookShelfContext())
            {
                db.Entry(newBook).State = EntityState.Modified;
                db.Books.Add(newBook);
                db.SaveChanges();
            }
        }

        public static void SetBookState(Book book, string state, Client client)//设置书籍的当前状态，包括“可正常使用”、“已被借阅”
        {
            if (state == "可正常使用")
            {
                book.ClientName = "";
            }
            else
            {
                book.ClientName = client.Name;
            }
            book.State = state;
            UpdateBook(book);
        }

        public static List<Book> GetAllLentBooks(Client client)//取得所有已借阅的书
        {
            using (var db = new BookShelfContext())
            {
                return db.Books.Where(o => o.State == "已被借阅").Where(p => p.ClientName == client.Name).ToList();
            }
        }

        public static List<Book> GetAllAppointedBooks(Client client)//取得所有预约的书
        {
            using (var db = new BookShelfContext())
            {
                List<Book> appointed = new List<Book>();
                foreach(var b in db.Books.Where(o => o.State == "已被借阅").ToList())
                {
                    if (b.Appointers.Contains(client.Name))
                    {
                                appointed.Add(b);
                    }
                }
                return appointed;
            }
        }

        public static void ReNewLending(Book book, Client client)//续借新书
        {
            string oldTime = book.LendTime;
            int y = book.LendTime.IndexOf("年");
            int m = book.LendTime.IndexOf("月");
            int d = book.LendTime.IndexOf("日");
            int Year = Convert.ToInt32(book.LendTime.Substring(0, y));
            int Month = Convert.ToInt32(book.LendTime.Substring(y + 1, m - y - 1));
            int Day = Convert.ToInt32(book.LendTime.Substring(m + 1, d - m - 1));
            string newTime;
            if (Month == 12)
            {
                Year = Year + 1;
                Month = 1;
            }
            else
            {
                Month++;
                if (Day > DateTime.DaysInMonth(Year, Month))
                {
                    Day = DateTime.DaysInMonth(Year, Month);
                }
            }
            newTime = Year + "年" + Month + "月" + Day + "日";
            book.LendTime = newTime;
            book.reNewNum++;
            SetBookState(book, "已被借阅", client);
            MessageBox.Show("已成功续借！");
        }
        
        public static void ReturnBooks(Book book, Client client)//还书
        {
            book.reNewNum = 0;
            if(book.Appointers == "" || book.Appointers == null)
            {
                book.LendTime = null;
                SetBookState(book, "可正常使用", client);
            }
            else
            {
                int i = book.Appointers.IndexOf(" ");
                string c = book.Appointers.Substring(0, i);
                book.Appointers = book.Appointers.Replace(c + " ", "");
                Client newClient = ClientService.AllClients().FirstOrDefault(o => o.Name == c);
                int Year = DateTime.Now.Year;
                int Month = DateTime.Now.Month+1;
                int Day = DateTime.Now.Day;
                book.LendTime = Year + "年" + Month + "月" + Day + "日";
                SetBookState(book, "已被借阅", newClient);
            }
        }

        public static void CancellAppoint(Book book, Client client)//取消预约
        {
            book.Appointers = book.Appointers.Replace(client.Name+" ", "");
            UpdateBook(book);
            MessageBox.Show("成功取消预约！");
        }

        public static void AppointBook(Book book, Client client)//预约
        {
            if(book.State == "可正常使用")
            {
                MessageBox.Show("该书可正常使用，可以直接借阅！");
                return;
            }
            if (book.Appointers.Contains(client.Name))
            {
                MessageBox.Show("您已经预约过了！");
                return;
            }
            if (book.ClientName == client.Name)
            {
                MessageBox.Show("您已经借阅了这本书！");
                return;
            }
            if (book.Appointers.Length != 0)
            {
                book.Appointers = book.Appointers+" "+client.Name+" ";
            }
            else if(book.Appointers.Length == 0)
            {
                book.Appointers = client.Name+" ";
            }
            UpdateBook(book);
            MessageBox.Show("成功预约！");
        }
        
        public static void LendBook(Book book, Client client)//借阅
        {
            if(book.State == "已被借阅")
            {
                MessageBox.Show("该书已被借阅，请进行预约！");
                return;
            }
            int Year = DateTime.Now.Year;
            int Month = DateTime.Now.Month;
            int Day = DateTime.Now.Day;
            if (Month == 12)
            {
                Year = Year + 1;
                Month = 1;
            }
            else
            {
                Month++;
                if (Day > DateTime.DaysInMonth(Year, Month))
                {
                    Day = DateTime.DaysInMonth(Year, Month);
                }
            }
            book.LendTime = Year + "年" + Month + "月" + Day + "日";
            SetBookState(book, "已被借阅", client);
            MessageBox.Show("已成功借阅！");
        }

        public static void Check(int year,int month, int day)
        {
            using (var db = new BookShelfContext())
            {
                List<Book> allLentBooks = db.Books.Where(o => o.State == "已被借阅").ToList();
                foreach(var b in allLentBooks)
                {
                    String time = b.LendTime;
                    int y = time.IndexOf("年");
                    int m = time.IndexOf("月");
                    int d = time.IndexOf("日");
                    String bookYear = time.Substring(0, y);
                    String bookMonth = time.Substring(y + 1, m - y - 1);
                    String bookDay = time.Substring(m + 1, d - m - 1);
                    Client user = ClientService.AllClients().FirstOrDefault(o => o.Name == b.ClientName);
                    if (Convert.ToInt32(bookYear) == year)
                    {
                        if(Convert.ToInt32(bookMonth) == month)
                        {
                            if(Convert.ToInt32(bookDay) <= day)
                            {
                                ReturnBooks(b, user);
                            }
                        }
                        else if(Convert.ToInt32(bookMonth) < month)
                        {
                            ReturnBooks(b, user);
                        }
                    }
                    else if(Convert.ToInt32(bookYear) < year)
                    {
                        ReturnBooks(b, user);
                    }
                }
            }
        }

        public static List<Book> Query(int i)//排序方法，i表示具体的排序规则，完成
        {
            List<Book> queryBooks = new List<Book>();
            using (var db = new BookShelfContext())
            {
                switch (i)
                {
                    case 1://默认的按推荐数排序
                        var query1 = BookShelfService.AllBooks();
                        var list1 = from t in query1 orderby t.Recommend descending select t;
                        queryBooks = list1.ToList();
                        break;
                    case 2://书号
                        var query2 = BookShelfService.AllBooks();
                        var list2 = from t in query2 orderby t.BookId ascending select t;
                        queryBooks = list2.ToList();
                        break;
                    case 3://作者
                        var query3 = BookShelfService.AllBooks();
                        var list3 = from t in query3 orderby t.Author ascending select t;
                        queryBooks = list3.ToList();
                        break;
                    case 4://分类
                        var query4 = BookShelfService.AllBooks();
                        var list4 = from t in query4 orderby t.Sort ascending select t;
                        queryBooks = list4.ToList();
                        break;
                    case 5://书架号
                        var query5 = BookShelfService.AllBooks();
                        var list5 = from t in query5 orderby t.BookId ascending select t;
                        queryBooks = list5.ToList();
                        break;
                }
            }
            return queryBooks;
        }

        public static List<Book> Search(int i, string key)//查询方法，i表示具体的排序规则，完成
        {
            List<Book> searchBooks = new List<Book>();
            using (var db = new BookShelfContext())
            {
                switch (i)
                {
                    case 1://按书号查询
                        foreach (var book in BookShelfService.AllBooks().Where(o => o.BookId.Contains(key) == true))
                        {
                            searchBooks.Add(book);
                        }
                        break;
                    case 2://书名
                        foreach (var book in BookShelfService.AllBooks().Where(o => o.Name.Contains(key) == true))
                        {
                            searchBooks.Add(book);
                        }
                        break;
                    case 3://作者
                        foreach (var book in BookShelfService.AllBooks().Where(o => o.Author.Contains(key) == true))
                        {
                            searchBooks.Add(book);
                        }
                        break;
                    case 4://分类
                        foreach (var book in BookShelfService.AllBooks().Where(o => o.Sort == key))
                        {
                            searchBooks.Add(book);
                        }
                        break;
                    case 5://书架号
                        foreach (var book in BookShelfService.AllBooks().Where(o => o.BookShelfId == key))
                        {
                            searchBooks.Add(book);
                        }
                        break;
                }
            }
            return searchBooks;
        }

        public static List<Book> getRecommend()
        {
            List<Book> books = new List<Book>();
            using (var db = new BookShelfContext())
            {
                books = db.Books.OrderByDescending(i=>i.Recommend).ToList();
            }
            if (books.Count >= 3)
            {
                List<Book> recommend = new List<Book> { books[0], books[1], books[2] };
                return recommend;
            }
            else
            {
                return books;
            }
        }

        public static string findPath()
        {
            string basePath = Directory.GetCurrentDirectory();
            return basePath.Replace(@"\bin\Debug", @"\discovers");
        }
    }
}
