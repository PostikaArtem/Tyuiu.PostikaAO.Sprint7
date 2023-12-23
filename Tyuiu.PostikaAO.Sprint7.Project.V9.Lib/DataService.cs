using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tyuiu.PostikaAO.Sprint7.Project.V9.Lib
{
    public class DataService
    { 
        string pathImg = $@"{Directory.GetCurrentDirectory()}\img\";
        string pathData = $@"{Directory.GetCurrentDirectory()}\FilmsData.csv";
        public void AddFilm(string[] values)
        {
            bool isFirst = false;
            if(!Directory.Exists(pathImg))
            {
                Directory.CreateDirectory(pathImg);
                isFirst = true;
            }
            string[] temp = values[0].Split('\\');
            string fileName = temp[temp.Length - 1];

            temp = fileName.Split('.');

            string fileFormat = '.' + temp[1];
            fileName = temp[0];

            string copyTo = pathImg + fileName + fileFormat;
            string copyFrom = values[0];

            int additionNum = 0;
            while (File.Exists(copyTo))
            {
                additionNum++;
                copyTo = pathImg + fileName + additionNum + fileFormat;
            }
            File.Copy(copyFrom, copyTo);
            values[0] = copyTo;

            FileInfo fileInfo = new FileInfo(copyTo);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathData);
            }

            string finalLine = string.Join(";", values);
            Encoding ru = Encoding.GetEncoding(1251);
            if (isFirst)
            {
                File.AppendAllText(pathData, finalLine, ru);
            }
            else
            {
                File.AppendAllText(pathData, Environment.NewLine + finalLine, ru);
            }
            
            
        }
        public string[] OpenFilm(int lineNum)
        {
            
            string path = $@"{Directory.GetCurrentDirectory()}\FilmsData.txt";
            string line = File.ReadLines(path).Skip(lineNum).First();
            string[] result = line.Split('|');
            

            return result;
        }
        
    }
}
