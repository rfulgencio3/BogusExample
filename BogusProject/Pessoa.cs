using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BogusProject
{
    public class Pessoa
    {
        public String CPF { get; set; }
        public String Nome { get; set; }
        public string UrlDaFoto { get; set; }
        public IPAddress IpDeAcesso { get; set; }
        public string NumeroDaConta { get; set; }
        public decimal Saldo { get; set; }
    }
}
