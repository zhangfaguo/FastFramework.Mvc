using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core.Models
{
    public class PageModel
    {
        /// <summary>
        /// 页面索引
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 分页总数
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总计录数
        /// </summary>

        public int RecordCount { get; set; }
    }
}
