using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp20.model
{
    public class File
    {
        // ham ghi file
        public static bool GhiFile(List<SanPham> ds, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ds);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // ham doc file
        public static List<SanPham> DocFile(string path)
        {
            List<SanPham> ds = new List<SanPham>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                ds = data as List<SanPham>;
                fs.Close ();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
