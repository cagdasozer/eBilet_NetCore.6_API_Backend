using Autofac;
using Autofac.Extras.DynamicProxy;
using eBilet.Business.Abstract;
using eBilet.Business.Concrete;
using Castle.DynamicProxy;
using eBilet.Core.Utilities.Interceptors;
using eBilet.DataAccess.Abstract;
using eBilet.DataAccess.Concrete.Repository;
using eBilet.DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBilet.Core.Utilities.Security.JWT;

namespace eBilet.Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<eBiletContext>().As<DbContext>().SingleInstance();

			builder.RegisterType<TicketManager>().As<ITicketService>().SingleInstance();
			builder.RegisterType<TicketRepository>().As<ITicketRepository>().SingleInstance();

			builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
			builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().SingleInstance();

			builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
			builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();

			builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
			builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

			builder.RegisterType<BusManager>().As<IBusService>().SingleInstance();
			builder.RegisterType<BusRepository>().As<IBusRepository>().SingleInstance();






			var assembly = System.Reflection.Assembly.GetExecutingAssembly();

			builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
				.EnableInterfaceInterceptors(new ProxyGenerationOptions()
				{
					Selector = new AspectInterceptorSelector()
				}).SingleInstance();
		}
	}
}
