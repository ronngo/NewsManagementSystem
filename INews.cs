using System;

namespace NewsManagementSystem
{
     interface INews
    {
        public int ID {set; get;}
        public string Title {set; get;}
        public DateTime PublishDate {set; get;}
        public string Author {set; get;}
        public string Content {set; get;}
        public float AverageRate {set; }

         void Display();
    }
}