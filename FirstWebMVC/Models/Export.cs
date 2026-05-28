using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace FirstWebMVC.Models
{
    public class Export // phiếu xuất
{
    public int Id { get; set; }

    public DateTime ExportDate { get; set; }

    public ICollection<ExportDetail>? ExportDetails { get; set; }
}
}