using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACS1AV
{
   public class DSTaiKhoan
    {
        private static DSTaiKhoan instance;
        public static DSTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DSTaiKhoan();
                return instance;
            }
            set => instance = value;
        }
        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }


        DSTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("anhvu123", "160603"));
            listTaiKhoan.Add(new TaiKhoan("messi08", "240687"));
            listTaiKhoan.Add(new TaiKhoan("elpulga", "240687"));
            listTaiKhoan.Add(new TaiKhoan("admin", "160603"));
        }
    }
}
