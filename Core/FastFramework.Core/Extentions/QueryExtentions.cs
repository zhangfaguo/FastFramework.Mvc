using FastFramework.Core.Models;
using System.Linq;

namespace System.Linq
{
    public static class QueryExtentions
    {
        public static IQueryable<T> Paging<T>(this IQueryable<T> query, PageModel page)
        {
            page.RecordCount = query.Count();

            if (page.PageSize == 0)
                page.PageSize = 10;

            page.PageCount = (page.RecordCount + page.PageSize - 1) / page.PageSize;

            if (page.PageIndex < 1)
                page.PageIndex = 1;

            if (page.PageIndex > page.PageCount && page.PageCount != 0)
                page.PageIndex = page.PageCount;

            var takeRecord = (page.PageIndex - 1) * page.PageSize;

            return query.Skip(takeRecord).Take(page.PageSize);
        }
    }
}
