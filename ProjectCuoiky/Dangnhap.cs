using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiky
{
    internal class Dangnhap
    {
        private string tendangnhap;
        private string matkhau;
        public Dangnhap()
        {
        }
    public Dangnhap(string tendangnhap, string matkhau)
        {
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
        }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
