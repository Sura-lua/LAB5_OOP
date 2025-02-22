using System;
using System.Linq;

namespace LAB5_OOP
{
    public class PersonName
    {
        // --- Fields ---
        private string _fullName, _title, _fName, _lName;

        // --- Properties ---
        public string fullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                SplitName(); // เรียก Method แยกชื่อเมื่อกำหนดค่า
            }
        }

        public string title
        {
            get { return _title; }
        }

        public string firstName
        {
            get { return _fName; }
        }

        public string lastName
        {
            get { return _lName; }
        }

        // --- Constructor (Overload) ---
        public PersonName(string name)
        {
            _fullName = name;
            SplitName();
        }

        public PersonName()
        {
            _fullName = "";
            _title = "";
            _fName = "";
            _lName = "";
        }

        // --- Method แยกชื่อ ---
        private void SplitName()
        {
            string[] titles = { "นาย", "นาง", "นางสาว", "เด็กชาย", "เด็กหญิง",
                                "ด.ช.", "ด.ญ.", "น.ส.", "ด.ต.", "พ.ต.ต.", "ร.ต.ต.", "ดร.", "มรว.", "ผศ.", "ศ." };

            string[] parts = _fullName.Trim().Split(' ');

            if (parts.Length >= 2)
            {
                if (titles.Contains(parts[0]))
                {
                    _title = parts[0];
                    _fName = parts[1];
                    _lName = string.Join(" ", parts.Skip(2));
                }
                else
                {
                    _title = "";
                    _fName = parts[0];
                    _lName = string.Join(" ", parts.Skip(1));
                }
            }
            else
            {
                _title = "";
                _fName = _fullName;
                _lName = "ไม่พบข้อมูลนามสกุล";
            }
        }
    }
}
