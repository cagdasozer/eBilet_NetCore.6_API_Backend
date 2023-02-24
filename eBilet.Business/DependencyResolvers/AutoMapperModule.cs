using eBilet.Core.Utilities.IoC;
using eBilet.DataAccess.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.DependencyResolvers
{
	public class AutoMapperModule : ICoreModule
	{
		public void Load(IServiceCollection serviceCollection)
		{
			serviceCollection.AddAutoMapper(typeof(MapperProfile));
		}
	}
}
