using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReductionMethods.ReductionMethods
{
    class PopularityMethod : IReductionMethod
    {
        public DirectBitmap Calculate(DirectBitmap source)
        {
            DirectBitmap dbm = new DirectBitmap(source.Width, source.Height);

            return dbm;
        }
    }
}
