using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Finance_management
{
    public class Class_InfoToHouse
    {
        private string _Name {  get; set; }
        private bool _isMale { get; set; }
        private bool _isFemale { get; set; }
        private short _age { get; set; }
        private short _monthlySalary { get; set; }
        private short _experience { get; set; }
        private string _job { get; set; }
        public Class_InfoToHouse(bool isMale, bool isFemale, short age, short monthlySalary, short experience, string job, string name)
        {
            _isMale = isMale;
            _isFemale = isFemale;
            _age = age;
            _monthlySalary = monthlySalary;
            _experience = experience;
            _job = job;
            _Name = name;
        }
        public bool GetIsMale() { return _isMale; }
        public bool GetIsFemale() { return _isFemale; }
        public short GetAge() { return _age; }
        public short GetMonthlySalary() { return _monthlySalary; }
        public short GetExperience() { return _experience; }
        public string GetJob() { return _job; }
        public string GetName() { return _Name; }

    }
    
}
