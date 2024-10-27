using DemoWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DemoWebsite.Pages
{
    public class ReadBookModel : PageModel
    {
        public Book Book { get; set; }

        public void OnGet(int id)
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Bùa mê", ImageUrl = "/images/book1.jpg"},
                new Book { Id = 2, Title = "Trăng bản Nắng", ImageUrl = "/images/book2.jpg"},
                new Book { Id = 3, Title = "Giọt mồ hôi trong xanh", ImageUrl = "/images/book3.jpg"},
                new Book { Id = 4, Title = "Dây cháy chậm", ImageUrl = "/images/book4.jpg"},
                new Book { Id = 5, Title = "Thầy", ImageUrl = "/images/book5.jpg"},
                new Book { Id = 6, Title = "Quyền lựa chọn", ImageUrl = "/images/book6.jpg"},
            };

            // Tìm sách theo ID
            Book = books.FirstOrDefault(b => b.Id == id);
            if (Book != null)
            {
                string content = System.IO.File.ReadAllText(Path.Combine("BookContents", $"Book{id}.txt"));
                Book.Content = content.Replace("\n", "<br/>");
            }
        }
    }
}
