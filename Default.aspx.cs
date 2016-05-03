using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    BookReviewServiceReference1.SampleBookReviewServiceClient bsc = new BookReviewServiceReference1.SampleBookReviewServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillAuthorDropDown();
    }

    protected void FillAuthorDropDown()
    {
        string[] authors = bsc.GetAuthors();
        DropDownList1.DataSource = authors;
        DropDownList1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string author = DropDownList1.SelectedItem.Text;
        BookReviewServiceReference1.BookLite[] books = bsc.GetBooks(author);
        GridView1.DataSource = books;
        GridView1.DataBind();
    }
}