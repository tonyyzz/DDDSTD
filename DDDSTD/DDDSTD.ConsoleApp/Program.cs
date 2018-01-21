using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSTD.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Article article = new Article
			{
				Title = "漫谈实体、对象、DTO及AutoMapper的使用",
				Content = "实体（Entity）、对象（Object）、DTO（Data Transfer Object）数据传输对象，老生常谈话题，简单的概念，换个角度你会发现更多的东西。个人拙见，勿喜请喷。",
				Author = "xishuai",
				PostTime = DateTime.Now,
				Remark = "文章备注"
			};
			//配置AutoMapper 
			AutoMapper.Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<Article, ArticleDTO>()//创建映射
			   .ForMember(dest => dest.ArticleID, opt => opt.MapFrom(src => src.Id))//指定映射规则
			   .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Content.Substring(0, 10)))//指定映射规则
			   .ForMember(dest => dest.PostYear, opt => opt.MapFrom(src => src.PostTime.Year))//指定映射规则
			   .ForMember(dest => dest.Remark, opt => opt.Ignore());//指定映射规则 忽视没有的属性
			 });

			//调用映射
			ArticleDTO form = AutoMapper.Mapper.Map<Article, ArticleDTO>(article);
		}
	}
}
