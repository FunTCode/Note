using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.ItcastProject.Common
{
    public static class MyPageBarHelper
    {
        public static string GetPageBar(int pageIndex, int pageCount)
        {
            int start, end;
            start = pageIndex - 5;
            if (start < 1)
            {
                start = 1;
            }
            end = start + 9;
            if (end > pageCount)
            {
                end = pageCount;
                start = end - 9 < 1 ? 1 : start;
            }
            StringBuilder sb = new StringBuilder();
            if (pageIndex > 1)
            {
                sb.AppendFormat("<a herf='?pageIndex={0}' class='MyPageBar'>上一页</a>", pageIndex - 1);
            }
            for (int i = start; i <= end; i++)
            {
                if (i != pageIndex)
                {
                    sb.AppendFormat("<a herf='?pageIndex={0}' class='MyPageBar'>{0}</a>", i);
                }
                else
                {
                    sb.AppendFormat("&nbsp{0}&nbsp",i);
                }
            }
            if (pageIndex < pageCount)
            {
                sb.AppendFormat("<a herf='?pageIndex={0}' class='MyPageBar'>下一页</a>", pageIndex + 1);
            }
            return sb.ToString();
        }
    }
}
