using System;
using System.Collections.Generic;

namespace belt1.Models
{
    public class Display
    {
        public int DisplayID {get;set;}

        public int UserID {get;set;}

        public string UserName {get;set;}

        public string NameUser {get;set;}

        public string Alias {get;set;}

         public string Email {get;set;}

        public string ActivityMessage {get;set;}
       

        public List<User> Guests {get;set;}

        public User Creator {get;set;}


        public bool IsHosting {get;set;}
        public bool IsAttending {get;set;}
        

    }
}