using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Contact_List
{
    public class Contact
    {
        // 1      2       3        4    5
        //Id|FirstName|LastName|Email|Photo

        public int ID{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email{get;set;}
        public string Photo{ get; set; }


        public Contact(string line)
        {
            var pieces = line.Split('|');

            ID = Convert.ToInt32(pieces[1]);
            FirstName = pieces[2];
            LastName = pieces[3];
            Email = pieces[4];
            Photo = pieces[5];
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }

    }
    
}
