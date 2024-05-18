using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodreadsC
{
    internal class Functions
    {
        public static void CleanB(Panel P)
        {
            foreach (TextBox TB in P.Controls.OfType<TextBox>())
            {
                TB.Clear();
            }
        }
    }
}
