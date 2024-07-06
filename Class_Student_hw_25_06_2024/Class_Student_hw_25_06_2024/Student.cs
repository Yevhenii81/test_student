using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
interface IPrint
{
    void Print();
}

namespace Class_Student_hw_25_06_2024
{
    internal class Student : IPrint
    {
        string name;
        string secondname;
        string lastname;
        DateTime birthday;
        List<ushort> homework_rates;
        List<ushort> classwork_rates;
        List<ushort> exam_rates;

        public Student() : this("Student", "Studentov") { }
        public Student(string name, string lastname) : this(name, " ", lastname, new DateTime(5534, 12, 3)) { }
        public Student(string name, string secondname, string lastname, DateTime birthday) : this(name, secondname, lastname, new DateTime(2222, 12, 12), new List<ushort>(), new List<ushort>(), new List<ushort>()) { }
        public Student(string name, string secondname, string lastname, DateTime birthday, List<ushort> homework_rates, List<ushort> classwork_rates, List<ushort> exam_rates)
        {
            SetName(name);
            SetSecondName(secondname);
            SetLastName(lastname);
            SetBirthday(birthday);
            SetHomeWorkRates(homework_rates);
            SetClassWorkRates(classwork_rates);
            SetExamRates(exam_rates);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetLastName(string lastname)
        {
            this.lastname = lastname;
        }

        public string GetLastName()
        {
            return this.lastname;
        }

        public void SetSecondName(string secondname)
        {
            this.secondname = secondname;
        }

        public string GetSecondName()
        {
            return this.secondname;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
        }

        public void SetHomeWorkRates(List<ushort> homework_rates)
        {
            this.homework_rates = homework_rates;
        }

        public List<ushort> GetHomeworkRates()
        {
            return homework_rates;
        }

        public void SetClassWorkRates(List<ushort> classwork_rates)
        {
            this.classwork_rates = classwork_rates;
        }

        public List<ushort> GetClassworkRates()
        {
            return classwork_rates;
        }

        public void SetExamRates(List<ushort> exam_rates)
        {
            this.exam_rates = exam_rates;
        }

        public List<ushort> GetExamRates()
        {
            return exam_rates;
        }

        public void Print()
        {
            Console.WriteLine(this.name + " " + this.secondname + " " + this.lastname);
            Console.WriteLine(this.birthday);

            foreach (var rate in this.homework_rates)
            {
                Console.Write(rate.ToString() + " ");
            }

            foreach (var rate in this.classwork_rates)
            {
                Console.Write(rate.ToString() + " ");
            }

            foreach (var rate in this.exam_rates)
            {
                Console.Write(rate.ToString() + " ");
            }
        }
    }
}