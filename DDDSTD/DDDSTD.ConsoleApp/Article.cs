using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSTD.ConsoleApp
{
	/// <summary>
	/// 文章领域模型
	/// </summary>
	public class Article : IEntity
	{
		public Article()
		{
			this.Id = Guid.NewGuid();
		}
		public string Title { get; set; }
		public string Content { get; set; }
		public string Author { get; set; }
		public DateTime PostTime { get; set; }
		public string Remark { get; set; }

		public Guid Id { get; set; }
	}
}
