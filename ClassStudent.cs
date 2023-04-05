using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppClassFirst
{
    internal class ClassStudent
    {
        //поля
        private string fio;
        private string group;
        private string progress;
        // свойства для доступа к полям
        public string FIO
        {
            get { return fio; }//возвращает значение поля
            set { fio = value; } //устанавливает значение поля
        }
               
        public string PROGRESS
        {
            get { return progress; }
            set { progress = value; }
        }
        public string GROUP
        {
            get { return group; }
            set { group = value; }
        }
        
        //методы 
        //конструктор без параметров задает значения полей по умолчанию
        public ClassStudent()
        {
            fio = "";
            group = "";
            progress = "";
        }
        //конструктор с параметрами
        public ClassStudent(string f, string g, string p)
        {
            fio = f;
            group = g;
            progress = p;
        }
        //метод вывода на экран
        public string PrintToScreen()
        {
           string line = $"Студент {fio}" +"\n";
           line += $"Учится в группе {group}"+"\n";
            return line;
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
            streamWriter.WriteLine("Личные данные студента");
            streamWriter.WriteLine($"ФИО: {fio}");
            streamWriter.WriteLine($"Группа: {group}");
            streamWriter.Close();
        }
   
       
    }
}
