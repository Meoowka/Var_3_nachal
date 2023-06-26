using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class WebMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetBooks_Click(object sender, EventArgs e)
        {
            BookService.BookServiceClient client = new BookService.BookServiceClient();
            BookService.Book book = client.GetBooks(Convert.ToInt32(txtID.Text));
            txtName.Text = book.Name;
            txtAuthor.Text = book.Author;
            txtData.Text = book.Day_Pr.ToShortDateString();
            lblMessage.Text = "Книга найдена";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            BookService.BookServiceClient client = new BookService.BookServiceClient();
            BookService.Book book = new BookService.Book();
            book.ID = Convert.ToInt32(txtID.Text);
            book.Name = txtName.Text;
            book.Author = txtAuthor.Text;
            book.Day_Pr = Convert.ToDateTime(txtData.Text);
            client.SaveBooks(book);
            lblMessage.Text = "Книга сохр.";
        }
    }
}