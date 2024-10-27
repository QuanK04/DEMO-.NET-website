namespace DemoWebsite.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; } // Thêm thuộc tính hình ảnh nếu cần
        public string Content { get; set; } // Thêm thuộc tính nội dung nếu cần
    }
}
