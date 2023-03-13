using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectTest1
{
    class Show
    {
        public string title;
        public string author;
        public double rating;
        public string synopsis;
        public double score;

        public Show(string sTitle, string sAuthor, double sRating, string sSynopsis, double sScore)
        {
            title = sTitle;
            author = sAuthor;
            rating = sRating;
            synopsis = sSynopsis;
            score = sScore;
        }

        public double GetRatingDifference()
        {
            double difference = rating - score;
            return Math.Abs(difference);
        }
    }
}
