using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public partial class Restaurant
    {
        public double AverageRating()
        {
            return Reviews.ToList().Sum(x => x.rating) / ((double)Reviews.Count);
        }


    }
}
