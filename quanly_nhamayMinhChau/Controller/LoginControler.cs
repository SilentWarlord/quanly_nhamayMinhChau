using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.Service;

namespace quanly_nhamayMinhChau.Controller
{
    internal class LoginControler
    {
        LoginService service = new LoginService();
        NhanVien nv ;

        public Boolean Login(string SDT, string password)
        {
            if (service.Login(SDT, password))
            {
                return true;
            }
            return false;
        }

        public string GetOTP()
        {
            string otp = (BetterRandom.NextInt() % 1000000).ToString("000000");
            return otp;
        }
        public static class BetterRandom
        {
            private static readonly ThreadLocal<System.Security.Cryptography.RandomNumberGenerator> crng = new ThreadLocal<System.Security.Cryptography.RandomNumberGenerator>(System.Security.Cryptography.RandomNumberGenerator.Create);
            private static readonly ThreadLocal<byte[]> bytes = new ThreadLocal<byte[]>(() => new byte[sizeof(int)]);
            public static int NextInt()
            {
                crng.Value.GetBytes(bytes.Value);
                return BitConverter.ToInt32(bytes.Value, 0) & int.MaxValue;
            }
            public static double NextDouble()
            {
                while (true)
                {
                    long x = NextInt() & 0x001FFFFF;
                    x <<= 31;
                    x |= (long)NextInt();
                    double n = x;
                    const double d = 1L << 52;
                    double q = n / d;
                    if (q != 1.0)
                        return q;
                }
            }
        }

        public void ForgotPass()
        {

        }

        public NhanVien Detail()
        {
            return service.Detail();
        }
    }
}
