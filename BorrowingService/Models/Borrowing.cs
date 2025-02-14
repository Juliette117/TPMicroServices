namespace BorrowingService.Models
{
    public class Borrowing
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string UserId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}