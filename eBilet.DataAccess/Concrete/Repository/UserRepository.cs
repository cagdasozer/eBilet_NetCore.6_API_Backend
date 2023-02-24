using eBilet.Core.DataAccess.Concrete.EntityFramework;
using eBilet.Core.Entities.Concrete;
using eBilet.DataAccess.Abstract;
using eBilet.DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.Concrete.Repository
{
	public class UserRepository : BaseEntityRepository<User>, IUserRepository
	{
		public UserRepository(DbContext context) : base(context)
		{
		}

		public async Task<List<OperationClaim>> GetClaims(User user)
		{
			using (var context = new eBiletContext())
			{
				var result = from operationClaim in context.OperationClaims
							 join userOperationClaim in context.UserOperationClaims
								 on operationClaim.Id equals userOperationClaim.OperationClaimId
							 where userOperationClaim.UserId == user.Id
							 select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
				return result.ToList();

			}
		}
	}
}
