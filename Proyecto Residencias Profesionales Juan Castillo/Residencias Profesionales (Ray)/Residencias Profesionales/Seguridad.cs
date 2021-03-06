﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias_Profesionales
{
    class Seguridad
    {
        public static string encriptar(string palabra)
        {
            string res = string.Empty;
            byte[] encripta = System.Text.Encoding.Unicode.GetBytes(palabra);
            res = Convert.ToBase64String(encripta);
            return res;
        }

        public static string desencriptar(string palabra)
        {            
            string result = string.Empty;
            byte[] desencrip = Convert.FromBase64String(palabra);
            result = System.Text.Encoding.Unicode.GetString(desencrip);
            return result;
        }
    }
}
