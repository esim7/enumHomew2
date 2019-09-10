using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewWorkEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Hostel hostel = new Hostel();
            Console.WriteLine("Введите количество студентов которые претендуют на жилье в общежитии");
            int studentCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentCount; i++)
            {
                Student student = new Student();
                hostel.AddRequest(student);
            }
            Array.Sort(hostel.Students);//сортируем массив студентов по убыванию среднего балла
            Array.Reverse(hostel.Students);
            hostel.ShowAllStudents();
            Console.ReadKey();
        }
    }
}
