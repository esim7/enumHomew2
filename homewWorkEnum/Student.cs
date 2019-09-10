using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewWorkEnum
{
    public class Student : IComparable<Student>
    {
        public string FIO { get; set; } // ФИО
        public string GroupNumber { get; set; } // номер группы
        public int AverageMark { get; set; } // средний балл
        public int SalaryOnFamily { get; set; } //доход
        public int FamilyMembersCount { get; set; } //кол-во человек в семье
        public Gender gender { get; set; }
        public FormOfTraining formOfTraining { get; set; }

        public Student()
        {
            FIO = "";
            GroupNumber = "";
        }

        //public Student(string fio, string groupNumber, int averageMark, int salaryFamily, int familyMembersCount, Gender sex, FormOfTraining formTraining)
        //{
        //    FIO = fio;
        //    GroupNumber = groupNumber;
        //    if (averageMark >= 5)
        //    {
        //        AverageMark = 5;
        //    }
        //    else if (averageMark <= 1)
        //    {
        //        AverageMark = 1;
        //    }
        //    FamilyMembersCount = familyMembersCount;
        //    SalaryOnFamily = salaryFamily;
        //    gender = sex;
        //    formOfTraining = formTraining;
        //}

        public int CompareTo(Student obj)
        {
            return this.AverageMark.CompareTo(obj.AverageMark);
        }
    }
}
