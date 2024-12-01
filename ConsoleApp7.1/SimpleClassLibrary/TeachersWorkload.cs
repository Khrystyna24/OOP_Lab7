using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    public class TeachersWorkload
    {
        public string SubjectName;
        public int Semester;
        public int StudentCount;
        public SemesterControlInfo SemesterControl;
        public int SemesterWeeks;
        public double AcademicHours;
        public int AuditoryClasses;

        public TeachersWorkload()
        {
            SubjectName = "Програмування";
            Semester = 1;
            StudentCount = 10;
            SemesterControl = new SemesterControlInfo();
        }

        public TeachersWorkload(string subjectName, int semester, int studentCount, SemesterControlInfo semesterControl)
        {
            SubjectName = subjectName;
            Semester = semester;
            StudentCount = studentCount;
            SemesterControl = semesterControl;
        }

        public TeachersWorkload(TeachersWorkload other)
        {
            SubjectName = other.SubjectName;
            Semester = other.Semester;
            StudentCount = other.StudentCount;
            SemesterControl = new SemesterControlInfo(other.SemesterControl);
        }

        public string subjectName
        {
            get
            {
                return SubjectName;
            }
            set
            {
                SubjectName = value;
            }
        }

        public int semester
        {
            get
            {
                return Semester;
            }
            set
            {
                Semester = value;
            }
        }

        public int studentCount
        {
            get
            {
                return StudentCount;
            }
            set
            {
                StudentCount = value;
            }
        }

        public SemesterControlInfo semesterControl
        {
            get
            {
                return SemesterControl;
            }
            set
            {
                SemesterControl = value;
            }
        }

        public int semesterWeeks
        {
            get
            {
                return SemesterWeeks;
            }
            set
            {
                SemesterWeeks = value;
            }
        }

        public double academicHours
        {
            get
            {
                return AcademicHours;
            }
            set
            {
                AcademicHours = value;
            }
        }

        public int auditoryClasses
        {
            get
            {
                return AuditoryClasses;
            }
            set
            {
                AuditoryClasses = value;
            }
        }

        public void InputSemesterDuration()
        {
            Console.WriteLine("Виберіть одиницю вимірювання тривалості семестру:");
            Console.WriteLine("1. Тижні\n2. Академічні години\n3. Аудиторні заняття");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення тривалості:");
            int value = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    semesterWeeks = value;
                    auditoryClasses = value * 4;
                    academicHours = auditoryClasses * 1.5;
                    break;
                case 2:
                    academicHours = value;
                    auditoryClasses = (int)(value / 1.5);
                    semesterWeeks = auditoryClasses / 4;
                    break;
                case 3:
                    auditoryClasses = value;
                    academicHours = value * 1.5;
                    semesterWeeks = value / 4;
                    break;
                default:
                    Console.WriteLine("Невірний вибір!");
                    break;
            }
        }

        public void DisplaySemesterDuration()
        {
            Console.WriteLine($"Тривалість семестру: {semesterWeeks} тижнів, {academicHours:F1} академічних годин, {auditoryClasses} аудиторних занять.");
        }

        public override string ToString()
        {
            return $"Назва предмета: {SubjectName}, Семестр: {Semester}, Кількість студентів: {StudentCount}, {SemesterControl}";
        }
    }
}
