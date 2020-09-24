using System;

namespace NewsManagementSystem
{
    class News 
    {
        public int ID {set; get;}
        public string Title {set; get;}
        public DateTime PublishDate {set; get;}
        public string Author {set; get;}
        public string Content {set; get;}
        public float AverageRate;
        public float GetAverageRate()
        {
            return AverageRate;
        }
        public virtual void Display()
        {
            Console.WriteLine("Title : " + Title );
            Console.WriteLine("Publish Date : " + PublishDate );
            Console.WriteLine("Author : " + Author );
            Console.WriteLine("Content : " + Content );
            Console.WriteLine("Average Rate : " + AverageRate );

        }

        int[] RateList = new int[3];
        public int this [int index]
        {
            get
            {
                return RateList[index];
            }
            set
            {
                RateList[index] = value;
            }
        }
        public void TinhAverageRate()
        {
            AverageRate = (float) (RateList[0] + RateList[1] + RateList[2] ) / 3;
        }
    }
}