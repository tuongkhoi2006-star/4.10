using System;

namespace WinFormsApp4._10_
{
    public class CheckoutRecord
    {
        public string Id { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string Equipment { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public string Status
        {
            get
            {
                if (ReturnDate != null)
                    return "Đã trả";
                if (DueDate < DateTime.Now.Date)
                    return "Quá hạn";
                return "Đang mượn";
            }
        }
    }
}
