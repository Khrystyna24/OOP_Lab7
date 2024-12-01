using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleClassLibrary;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("Введіть кількість предметів:");
                int n = int.Parse(Console.ReadLine());

                var workloads = CreateWorkloads(n);

                foreach (var workload in workloads)
                {
                    workload.InputSemesterDuration();
                }

                Console.WriteLine("\nІнформація про всі дисципліни:");
                foreach (var workload in workloads)
                {
                    Console.WriteLine(workload);
                    workload.DisplaySemesterDuration();
                }

                Console.WriteLine("Програма завершується...");
            }

            static List<TeachersWorkload> CreateWorkloads(int n)
            {
                var workloads = new List<TeachersWorkload>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\nВкажіть деталі проведення іспиту {i + 1}:");

                    Console.Write("Назва дисципліни: ");
                    string subjectName = Console.ReadLine();

                    Console.Write("Семестр: ");
                    int semester = int.Parse(Console.ReadLine());

                    Console.Write("Кількість студентів: ");
                    int studentCount = int.Parse(Console.ReadLine());

                    Console.Write("Вид контролю: ");
                    string controlForm = Console.ReadLine();

                    Console.Write("Шкала оцінювання: ");
                    string scale = Console.ReadLine();

                    Console.Write("Дата проведення іспиту (yyyy-MM-dd): ");
                    DateTime examinationDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Дата заповнення відомості (yyyy-MM-dd): ");
                    DateTime resultsFillingDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Кількість годин: ");
                    int hours = int.Parse(Console.ReadLine());

                    var semesterControl = new SemesterControlInfo(controlForm, scale, examinationDate, resultsFillingDate, hours);
                    workloads.Add(new TeachersWorkload(subjectName, semester, studentCount, semesterControl));
                }

                return workloads;
            }
        }
    }
}