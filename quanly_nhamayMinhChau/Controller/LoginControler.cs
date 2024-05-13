using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.Service;

namespace quanly_nhamayMinhChau.Controller
{
    internal class LoginControler
    {
        LoginService service = new LoginService();
        NhanVien nv;
        
        public Boolean Login(string SDT, string password)
        {
            if(service.Login(SDT, password))
            {
                return true;
            }
            return false;
        }
    }
}
