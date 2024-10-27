using DemoWebsite.Models; // Đảm bảo rằng bạn đã thêm dòng này
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DemoWebsite.Pages
{
    public class BookListModel : PageModel
    {
        public List<Book> Books { get; set; }

        public void OnGet()
        {
            Books = new List<Book>
            {
                new Book { Id = 1, Title = "Bùa mê", ImageUrl = "/images/book1.jpg", Content = "Nội dung cuốn sách 1." },
                new Book { Id = 2, Title = "Trăng bản Nắng", ImageUrl = "/images/book2.jpg", Content = "Nội dung cuốn sách 2." },
                new Book { Id = 3, Title = "Giọt mồ hôi trong xanh", ImageUrl = "/images/book3.jpg", Content = "Nội dung cuốn sách 3." },
                new Book { Id = 4, Title = "Dây cháy chậm", ImageUrl = "/images/book4.jpg", Content = "Nội dung cuốn sách 4." },
                new Book { Id = 5, Title = "Thầy", ImageUrl = "/images/book5.jpg", Content = "Nội dung cuốn sách 5." },
                new Book { Id = 6, Title = "Quyền lựa chọn", ImageUrl = "/images/book6.jpg", Content = "Nội dung cuốn sách 6." },
            };
        }
    }
}
