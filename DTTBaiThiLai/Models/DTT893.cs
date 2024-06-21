using System.ComponentModel.DataAnnotations;

namespace DTTBaiThiLai.Models
{
    public class DTT893
    {
        [Key]
        public string HoTen {get;set;}
        public int ID {get;set;}
        public DateTime Ngaysinh {get;set;}
    }
}
