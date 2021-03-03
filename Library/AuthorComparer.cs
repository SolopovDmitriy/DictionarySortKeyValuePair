using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class AuthorComparerByName : IComparer<Author>
    {     

        public int Compare(Author x, Author y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}
