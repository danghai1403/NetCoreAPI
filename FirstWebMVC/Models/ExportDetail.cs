using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class ExportDetail // chi tiết xuất
    {
        public int Id { get; set; } // khóa chính

        public int ExportId { get; set; } // FK phiếu xuất
        public Export? Export { get; set; }

        public int DeviceId { get; set; } // FK thiết bị
        public Device? Device { get; set; }

        public int Quantity { get; set; } // số lượng xuất

        public decimal Price { get; set; } // đơn giá xuất

        public decimal Total => Quantity * Price; 
        // thành tiền
    }
}