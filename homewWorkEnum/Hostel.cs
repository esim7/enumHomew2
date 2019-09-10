using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewWorkEnum
{
    public class Hostel
    {
        const int minWage = 42500;

        public Student[] Students;
        public int StudenCount { get; set; } = 0;
        List<Student> FinalStudentList; //здесь будет финальный список студентов зачисленных в общежитие по критериям

        public Hostel()
        {
            FinalStudentList = new List<Student>();
            Students = new Student[StudenCount];
        }
        public void AddRequest(Student obj)
        {
            Console.WriteLine("Введите ФИО студента");
            obj.FIO = Console.ReadLine();
            Console.WriteLine("Введите номер группы");
            obj.GroupNumber = Console.ReadLine();
            Console.WriteLine("Введите средний бал студента");
            obj.AverageMark = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите доход на семью");
            obj.SalaryOnFamily = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество человек в семье");
            obj.FamilyMembersCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите пол студента 1 - мужской    2 - женский");
            int gender = int.Parse(Console.ReadLine());
            if (gender == 1)
            {
                obj.gender = Gender.Man;
            }
            else if (gender == 2)
            {
                obj.gender = Gender.Woman;
            }
            Console.WriteLine("Введите форму обучения 1 - очная    2 - заочная");
            int studyForm = int.Parse(Console.ReadLine());
            if (studyForm == 1)
            {
                obj.formOfTraining = FormOfTraining.Fulltime;
            }
            else if (studyForm == 2)
            {
                obj.formOfTraining = FormOfTraining.Distance;
            }
            ++StudenCount;
            Array.Resize(ref Students, StudenCount);
            Students[StudenCount - 1] = obj;
        }
        public void ShowAllStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("Имя студена: " + Students[i].FIO);
                Console.WriteLine("Номер группы: " + Students[i].GroupNumber);
                Console.WriteLine("Средний балл: " + Students[i].AverageMark);
                Console.WriteLine("Доход на каждого члена семьи: " + Students[i].SalaryOnFamily / Students[i].FamilyMembersCount);
                Console.WriteLine("Количество человек в семье: " + Students[i].FamilyMembersCount);
                Console.WriteLine("Пол студена: " + Students[i].gender);
                Console.WriteLine("Форма обучения: " + Students[i].formOfTraining);
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }

        public void Result()
        {
            for(int i = 0; i < StudenCount; i++)
            {
                if((Students[i].SalaryOnFamily / Students[i].FamilyMembersCount) < minWage)
                {
                    FinalStudentList.Add(Students[i]);
                    Students[i].FIO = null;
                }
            }
            for (int i = 0; i < StudenCount; i++)
            {
                if (Students[i].FIO != null)
                {
                    FinalStudentList.Add(Students[i]);
                }
            }
            Console.WriteLine("Порядок очереди студентов для зачисления в общежитие:");
            foreach (Student student in FinalStudentList)
            {
                Console.WriteLine(student.FIO);
                Console.WriteLine(student.GroupNumber);
                Console.WriteLine(student.gender);
                Console.WriteLine(student.formOfTraining);
            }
        }
    }
}
