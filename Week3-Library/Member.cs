using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Library
{
    class Member
    {
        private int memberID;
        private string name;
        private string address;
        private int phone;

        public int MemberID
        {
            get { return memberID; }
            private set 
            { 
                if(value > 0)
                {
                    MemberID = value;
                }
            else
                {
                    Console.WriteLine("Error: Member ID must be greater than " +
                        "zero.");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set 
            {
            if(!value.Any(char.IsDigit) && value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or" +
                        "contain numbers.");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set {  address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Member(int memberID, string name, string address, int 
            phone)
        {
            this.MemberID = memberID;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone number: {Phone}");
            Console.WriteLine();
        }
    }
}