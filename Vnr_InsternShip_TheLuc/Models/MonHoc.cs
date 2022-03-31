using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vnr_InsternShip_TheLuc.Models
{
    public class MonHoc
    {
        public int ID { get; set; }
        public string TenMonHoc { get; set; }
        public string MoTa { get; set; }
         
        public int KhoaHocID { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
    }
}
