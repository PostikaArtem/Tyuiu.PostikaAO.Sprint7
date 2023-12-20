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
        public void AddNewPosition()
        {
            int num=0;
            string path = $@"{Directory.GetCurrentDirectory()}\DataFilm{num}.txt";

            string template = "История пакетика 2\n2023\nДетектив\nЮрий Быков\nЮрий Быков\nАндрей Шаров, Тимур Христианов, Данил Бомжиков\nРоссия\nШароБарсоЛук\nЖизни 800 человек общежития висят буквально на волоске из-за безразличия местных властей. В любую секунду здание может рухнуть. И кто бы мог подумать, что судьбы людей окажутся в руках простого сантехника. Но удастся ли ему что-то изменить и предотвратить катастрофу?";

            File.AppendAllText(path, template);
        }
        public string[] OpenFile()
        {
            int num = 0;
            string path = $@"{Directory.GetCurrentDirectory()}\DataFilm{num}.txt";

            string[] result = new string[9];
            using (StreamReader reader = new StreamReader(path))
            {
                for(int i =0; i<9; i++)
                {
                    string line = reader.ReadLine();
                    result[i] = line;
                }
            }

            return result;
        }
    }
}
