using System.Globalization;
using System.Text;

namespace WinFormsApp4._10_
{
    public static class CsvExporter
    {
        public static void ExportToCsv(string path, IEnumerable<CheckoutRecord> records)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Mã phiếu, Mã sv, Họ tên, Thiết bị, Số lượng, Ngày mượn, Hạn trả, Ngày trả, Trạng thái");
            foreach (var r in records)
            {
                var line = string.Join(",",
                    Escape(r.Id), Escape(r.StudentId), Escape(r.StudentName), Escape(r.Equipment),
                    r.Quantity.ToString(), r.BorrowDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                    r.DueDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                    r.ReturnDate?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) ?? "", Escape(r.Status));
                sb.AppendLine(line);
            }
            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }

        private static string Escape(string s)
        {
            if (s == null) return "";
            if (s.Contains(',') || s.Contains('"') || s.Contains('\n'))
            {
                return '"' + s.Replace("\"", "\"\"") + '"';
            }
            return s;
        }
    }
}
