using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.DAO
{
    class ReadDataSource
    {
        
        public static string layDuongDanSQl() {
            string data = null;
          
            string AppPath = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(AppPath);
          
            // di chuyen den thu muc cha 
            for (int i = 0; i < 5; i++) {
                dir = Directory.GetParent(dir.FullName); 
            }
            data = layDuLieu(dir.FullName);
           
            return data;
        }
        public static string layDuLieu(string path)
        {
            const string fileName= "DataSource.txt";
            const string fileDir = "DataSourceSQL";
            const string defaultDataSourcesSQL = @"Data Source=LAPTOP-V4KO1KOV\SQLEXPRESS;Initial Catalog=QuanLyCuaHangDienThoai;Integrated Security=True";
            string data = "";
            string duongDanFile = path + "/" + fileDir + "/" + fileName;



            if (!Directory.Exists(path + "/" + fileDir)) 
                Directory.CreateDirectory(path + "/" + fileDir);
            

            if (!File.Exists(duongDanFile))
            {
               
               // File.Create(duongDanFile);
                
                data = defaultDataSourcesSQL;
                FileStream fileStream = new FileStream(duongDanFile,FileMode.OpenOrCreate);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(data);

                streamWriter.Close();
                fileStream.Close();
                //File.WriteAllText(duongDanFile,defaultDataSourcesSQL);
                
            }
            else {
                FileStream fileStream = new FileStream(duongDanFile, FileMode.OpenOrCreate);
                StreamReader streamReader = new StreamReader(fileStream);
                data = streamReader.ReadToEnd();
                streamReader.Close();
                fileStream.Close();
            }



            return data;
        } 
    }
}
