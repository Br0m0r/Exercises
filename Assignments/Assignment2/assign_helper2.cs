using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class helper
    {

        public class PhotoBook
        {
            public int numpages;
            public int x;
            public int GetNumPages()
            {
                return numpages;
            }


            public PhotoBook()
            {
                numpages = 16;

            }

            public PhotoBook(int numpages)
            {
                x = numpages;

            }


        }

        public class BigPhotoBook : PhotoBook
        {
            public BigPhotoBook()
            {
                numpages = 64;

            }
        }











    }
}
