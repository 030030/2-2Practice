using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int x = 100, ans = 0, i = 1;
            for (i = 1; i <= x; i++)
            {
                if ((i % 2) == 0)
                {
                    ans = ans + i;
                }
                if ((i % 3) == 0)
                {
                    ans = ans + i;
                }
                if ((i % 2) == 0)
                {
                    if ((i % 3) == 0)
                    {
                        ans = ans - i;
                    }
                }
            }
            Console.Write("1到" + x + "中，是2或3的倍數總額是" + ans)
        }
    }
    }
}