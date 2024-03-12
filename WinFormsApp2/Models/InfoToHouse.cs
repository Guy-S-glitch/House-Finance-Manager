using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Finance_management
{
    public class InfoToHouse
    {
        private Image _picture { get; set; }
        private string _city { get; set; }
        private string _email { get; set; }
        private string _phone { get; set; }
        private string _Name { get; set; }
        private bool _isMale { get; set; } 
        private DateTime _age { get; set; }
        private short _monthlySalary { get; set; }
        private short _experience { get; set; }
        private string _job { get; set; }
        private NumericUpDown[] _expenses { get; set; }

        public DataSentHandler DataSentHandler
        {
            get => default;
            set
            {
            }
        }

        public List<object> List
        {
            get => default;
            set
            {
            }
        }

        public InfoToHouse(bool isMale, DateTime age, short monthlySalary, short experience
            , string job, string name, NumericUpDown[] expenses, string phone, string email, string city, Image picture)
        {
            _isMale = isMale; _age = age; _monthlySalary = monthlySalary; _experience = experience;
            _job = job; _Name = name; _expenses = expenses; _phone = phone; _email = email; _city = city; _picture = picture;
        }
        public bool GetIsMale() { return _isMale; } 
        public string GetGender() { return _isMale ? "Male" : "Female"; }
        public DateTime GetDate() { return _age; }
        public float GetAge()
        {
            float fullAge = (float)(((DateTime.Today.Year - _age.Year) + ((DateTime.Today.Month - _age.Month) / 12.0)));
            int removeAfter2Dig = (int)(fullAge * 10);
            return (float)(removeAfter2Dig / 10.0);
        }
        public short GetMonthlySalary() { return _monthlySalary; }
        public short GetExperience() { return _experience; }
        public string GetJob() { return _job; }
        public string GetName() { return _Name; }
        public NumericUpDown[] GetExpenses() { return _expenses; }
        public string GetPhone() { return _phone; }
        public string GetEmail() { return _email; }
        public string GetCity() { return _city; }
        public Image GetPicture() { return _picture; }

        public byte[] ImageToByteArray()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                _picture.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }
    }

}
