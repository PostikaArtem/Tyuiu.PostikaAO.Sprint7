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
        public void AddFilm(string[] values)
        {
            string pathText = $@"{Directory.GetCurrentDirectory()}\FilmsData.txt";
            string pathImage = $@"{Directory.GetCurrentDirectory()}";
            File.Copy(values[0], pathImage);
            string[] temp = values[0].Split('\\');
            string fileName = temp[temp.Length-1];
            values[0] = pathImage+@"\"+fileName;
            File.AppendAllText(pathText, String.Join("|",values)+"\n");
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
