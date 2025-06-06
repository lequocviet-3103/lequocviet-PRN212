using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        #region Nhóm các thuộc tính của employee
        private int _id;
        private string _id_card;
        private string _name;
        private string _email;
        private string _phone;
        #endregion
        #region Nhóm các constructor của employee
        public Employee()
        {
            this._id = 0;
            this._id_card = "000";
            this._name = "OBAMA";
            this._email = "obama@gmail.com";
            this._phone = "12343";

        }

        public Employee(int _id, string _id_card, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._id_card = _id_card;
            this._name = _name;
            this._email = _email;
            this._phone = _phone;
                    }
        public int Id { get { return _id; }
            set { _id = value; } }
        public string IdCard{
            get { return _id_card; }
            set { _id_card = value; }
                }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        #endregion
        #region 
        public void PrintInfor()
        {
            string msg = $"{Id}\t{IdCard}\t{Name}\t{Email}\t{Phone}\t";
            Console.WriteLine(msg);
        }

        public override string ToString()
        {
            string msg = $"{Id}\t{IdCard}\t{Name}\t{Email}\t{Phone}\t";
            return (msg);
        }
        #endregion
    }
}
