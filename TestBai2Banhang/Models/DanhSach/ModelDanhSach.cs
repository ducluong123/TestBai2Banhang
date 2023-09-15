namespace TestBai2Banhang.Models.DanhSach
{
    public class ModelDanhSach
    {
        public string TenSanPham { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public double TamTinh { get; set; }
        public double GiamGia { get; set; }
        public double TongCong { get; set; }
        public ModelDanhSach() 
        { 
        
        }
        public ModelDanhSach(string tenSanPham, double soLuong, double gia, double giamGia)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            TamTinh = soLuong * gia;
            GiamGia = (TamTinh * giamGia) / 100;
            TongCong = TamTinh - GiamGia;
        }
          
    }
}
