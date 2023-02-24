using eBilet.Core.DataAccess.Concrete.EntityFramework;
using eBilet.DataAccess.Abstract;
using eBilet.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.Concrete.Repository
{
	public class CustomerRepository : BaseEntityRepository<Customer>, ICustomerRepository
	{
		public CustomerRepository(DbContext context) : base(context)
		{
		}
	}
}
