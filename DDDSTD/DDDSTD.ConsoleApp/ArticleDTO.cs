using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSTD.ConsoleApp
{
	/// <summary>
	/// 文章DTO
	/// </summary>
	/// ArticleDTO中可以看到多了两个属性：Summary（文章摘要）和PostYear（文章发表年份），
	/// 这就是我们在特定的业务场景中需要的，并不会影响到领域模型，
	public class ArticleDTO
	{
		/// <summary>
		/// 文章唯一编码
		/// </summary>
		public string ArticleID { get; set; }
		/// <summary>
		/// 文章标题
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// 文章摘要
		/// </summary>
		public string Summary { get; set; }
		/// <summary>
		/// 文章内容
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// 文章作者
		/// </summary>
		public string Author { get; set; }
		/// <summary>
		/// 文章发表日期
		/// </summary>
		public DateTime PostTime { get; set; }
		/// <summary>
		/// 文章发表年份
		/// </summary>
		public int PostYear { get; set; }
		/// <summary>
		/// 文章备注
		/// </summary>
		public string Remark { get; set; }
	}
}
