using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vnr_InsternShip_TheLuc.Models
{
    public class KhoaHoc
    {
        public int ID { get; set; }
        public string TenKhoaHoc { get; set; }
        
        [ForeignKey("KhoaHocId")]
        public List<MonHoc> MonHoc { get; set; }
        
    }
}
