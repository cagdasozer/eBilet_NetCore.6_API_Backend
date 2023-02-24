using eBilet.Core.DataAccess.Abstract;
using eBilet.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.Abstract
{
	public interface IUserRepository : IEntityRepository<User>
	{
		Task<List<OperationClaim>> GetClaims(User user);
	}
}
