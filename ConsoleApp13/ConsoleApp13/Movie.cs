using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Movie
    {
        public int Id { get; set; } // Movie's Id
        public string Title { get; set; } // Movie's title
        public float Rating { get; set; } // Movie's rating
        public double Receipts { get; set; } // Movie's receipts
        public string Actors { get; set; } // Movie's actors
        public string Reviews { get; set; } // Movie's list of reviews

        internal static void Sort(object cLASS_FOR_COMPARER)
        {
            throw new NotImplementedException();
        }
    }
}
