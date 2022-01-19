using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App24
{
    internal class clsSerial
    {
        private static string _porta = string.Empty;
        private static string _baud = string.Empty;
        private static string _sbits = string.Empty;
        private static string _dbits = string.Empty;
        private static string _parity = string.Empty;
        private static bool _cancela = false;

        public static string Porta
        {
            get { return _porta; }
            set { _porta = value; }
        }

        public static string BRate
        {
            get { return _baud; }
            set { _baud = value; }
        }

        public static string SBits
        {
            get { return _sbits; }
            set { _sbits = value; }
        }

        public static string DBits
        {
            get { return _dbits; }
            set { _dbits = value; }
        }

        public static string Paridade
        {
            get { return _parity; }
            set { _parity = value; }
        }

        public static bool Cancela
        {
            get { return _cancela; }
            set { _cancela = value; }
        }

    }
}
