using FastFramework.Core.Models;
using System.Web.Mvc;

namespace FastFramework.Application.Core.Models
{
    [Bind(Exclude = "PageCount,RecordCount")]
    public class PageDTO<T> : BaseDTO<T>
         where T : PageModel, new()
    {
        /// <summary>
        /// 页面索引
        /// </summary>
        public int? Page
        {
            get
            {
                return Source.PageIndex;
            }
            set
            {
                Source.PageIndex = value ?? 1;
            }
        }
        /// <summary>
        /// 页面大小
        /// </summary>
        public int? Rows
        {
            get
            {
                return Source.PageSize;
            }
            set
            {
                Source.PageSize = value ?? 20;
            }
        }

        public int PageCount
        {
            get
            {
                return Source.PageCount;
            }
            set
            {
                Source.PageCount = value;
            }
        }

        public int RecordCount
        {
            get
            {
                return Source.RecordCount;
            }
            set
            {
                Source.RecordCount = value;
            }
        }
    }
}
