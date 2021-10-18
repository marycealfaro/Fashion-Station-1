using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Fashion
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "unah")
            {
                return true;
            }
            else
            {
                if (usuario == "pumas" && contrasena == "1234")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
