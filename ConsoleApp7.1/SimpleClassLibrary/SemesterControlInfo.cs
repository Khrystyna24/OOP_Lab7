using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    public class SemesterControlInfo
    {
        public string ControlForm;
        public string Scale;
        public DateTime ExaminationDate;
        public DateTime ResultsFillingDate;
        public int Hours;
        public SemesterControlInfo()
        {
            ControlForm = "Екзамен";
            Scale = "5-бальна";
            ExaminationDate = DateTime.Now;
            ResultsFillingDate = DateTime.Now;
            Hours = 2;
        }
        public SemesterControlInfo(string controlForm, string scale, DateTime examinationDate, DateTime resultsFillingDate, int hours)
        {
            ControlForm = controlForm;
            Scale = scale;
            ExaminationDate = examinationDate;
            ResultsFillingDate = resultsFillingDate;
            Hours = hours;
        }
        private string controlForm
        {
            get
            {
                return ControlForm;
            }
            set
            {
                ControlForm = value;
            }
        }
        private string scale
        {
            get
            {
                return Scale;
            }
            set
            {
                Scale = value;
            }
        }
        private DateTime examinationDate
        {
            get
            {
                return ExaminationDate;
            }
            set
            {
                ExaminationDate = value;
            }
        }
        private DateTime resultsFillingDate
        {
            get
            {
                return ResultsFillingDate;
            }
            set
            {
                ResultsFillingDate = value;
            }
        }
        private int hours
        {
            get
            {
                return Hours;
            }
            set
            {
                Hours = value;
            }
        }
        public int GetTotalTime(int studentCount)
        {
            return studentCount * Hours;
        }

        public bool IsHappeningToday()
        {
            return ExaminationDate == ResultsFillingDate;
        }
        public SemesterControlInfo(SemesterControlInfo other)
        {
            ControlForm = other.ControlForm;
            Scale = other.Scale;
            ExaminationDate = other.ExaminationDate;
            ResultsFillingDate = other.ResultsFillingDate;
            Hours = other.Hours;
        }
        public override string ToString()
        {
            return $"Вид контролю: {ControlForm}, Шкала оцінювання: {Scale}, Дата проведення іспиту:{ExaminationDate}, Дата заповнення відомості: {ResultsFillingDate}, Кількість годин: {Hours}";
        }
    }
}
