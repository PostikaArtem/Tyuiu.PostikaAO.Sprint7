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

            //FileInfo fileInfo = new FileInfo(copyTo);
            //bool fileExists = fileInfo.Exists;

            //if (fileExists)
            //{
            //    File.Delete(pathData);
            //}

            string finalLine = string.Join(";", values);
            Encoding ru = Encoding.GetEncoding(1251);
            if (isFirst)
            {
                File.AppendAllText(pathData, finalLine, Encoding.Unicode);
            }
            else
            {
                File.AppendAllText(pathData, Environment.NewLine + finalLine, Encoding.Unicode);
            }
        }

        public int GetFilmCount()
        {
            int result = 0;
            if (File.Exists(pathData))
            {
                using (StreamReader rd = new StreamReader(pathData))
                {
                    while (rd.ReadLine() != null)
                    {
                        result++;
                    }
                }
                return result;
            }
            return result;
        }

        public string[] GetFilmInfo(int lineNum)
        {
            string line = File.ReadLines(pathData).Skip(lineNum).First();
            string[] result = line.Split(';');

            return result;
        }

        public string[] GetAllFilmsNames()
        {
            string[] lines = File.ReadAllLines(pathData);
            string[] result = new string[lines.Length];

            for (int i = 0; i < result.Length; i++)
            {
                string filmName = lines[i].Split(';')[1];
                result[i] = filmName;
            }

            return result;
        }

        public string[] GetAllFilmsImages()
        {
            string[] lines = File.ReadAllLines(pathData);
            string[] result = new string[lines.Length];

            for (int i = 0; i < result.Length; i++)
            {
                string pathImage = lines[i].Split(';')[0];
                result[i] = pathImage;
            }

            return result;
        }


        public void DeleteFilm(int deletedLine)
        {
            string fileContent = File.ReadAllText(pathData);
            fileContent = fileContent.Replace('\n', '\r');
            string[] lines = fileContent.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


            string[] resultLines = new string[lines.Length - 1];
            for (int i = 0; i < lines.Length; i++)
            {
                if (i == deletedLine) continue;
                if (i < deletedLine)
                {
                    resultLines[i] = lines[i];
                }
                else
                {
                    resultLines[i - 1] = lines[i];
                }
            }


            File.Delete(pathData);
            if (resultLines.Length == 0) return;

            if (resultLines.Length == 1)
            {
                File.AppendAllText(pathData, resultLines[0]);
            }
            else
            {
                File.AppendAllText(pathData, string.Join(Environment.NewLine, resultLines));
            }
        }

    }
}
