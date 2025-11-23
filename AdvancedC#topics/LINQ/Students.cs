using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_topics.LINQ
{
    public class Students
    {
        private double _gpares;
        private int _age;
        private string _fullname = string.Empty;

        public int Id { get; private set; }
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("This fild cannot be null", nameof(value));
                }
                else
                {
                    _fullname = value;
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 18)
                {
                    _age = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The age is out of range");
                }
            }
        }
        public double GPAResult
        {
            get { return _gpares; }
            set
            {
                if (value >= 00.00 && value <= 4.00)
                {
                    _gpares = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The number is out of accepted range");
                }
            }
        }

        public bool IsEligibleForGraduation
        {
            get
            {
                return GPAResult >= 2.5;
            }
        }
        public Students(int id, string name, int age, double gpascore)
        {
            Id = id;
            Fullname = name;
            Age = age;
            GPAResult = gpascore;
        }
    }
}
