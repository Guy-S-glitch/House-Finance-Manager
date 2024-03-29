﻿using System.Drawing.Imaging;
using static Common.Structs.Gender;
namespace Common
{ 
    public class InfoToHouse
    {
        public string _houseNumber { get; set; }
        private Image _picture { get; set; }
        private string _picturePath { get; set; }
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
         
        public InfoToHouse(Member.MemberInformation memberInformation)
        {
            _isMale = memberInformation.IsMale;
            _age = memberInformation.Age;
            _monthlySalary = memberInformation.MonthlySalary;
            _experience = memberInformation.Experience;
            _job = memberInformation.Job;
            _Name = memberInformation.Name;
            _expenses = memberInformation.Expenses;
            _phone = memberInformation.Phone;
            _email = memberInformation.Email;
            _city = memberInformation.City;
            _picture = memberInformation.Picture;
            _picturePath = memberInformation.PicturePath;
            _houseNumber = memberInformation.HouseNumber;
        }

        public bool GetIsMale() { return _isMale; }
        private Structs.Gender gender = new Structs.Gender();
        public string GetGender() { return _isMale ? gender.Male : gender.Female; }

        public DateTime GetDate() { return _age; }

        public float GetAge()
        {
            float fullAge = (float)(DateTime.Today.Year - _age.Year + ((DateTime.Today.Month - _age.Month) / 12.0));

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
        public string GetPicturePath() { return _picturePath; }
        public string GetHouseNumber() { return _houseNumber; }
 
    }

    public class Member
    {
        public struct MemberInformation
        {
            public string HouseNumber { get; set; }
            public Image Picture { get; set; }
            public string PicturePath { get; set; }
            public string City { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Name { get; set; }
            public bool IsMale { get; set; }
            public DateTime Age { get; set; }
            public short MonthlySalary { get; set; }
            public short Experience { get; set; }
            public string Job { get; set; }
            public NumericUpDown[] Expenses { get; set; }
        } 
    }
}