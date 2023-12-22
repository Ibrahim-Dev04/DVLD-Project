using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Project
{
    public class clsFilepath
    {
        static public bool isExist(string FilePath)
        {
           return  File.Exists(FilePath) ;
        }
    }
}
