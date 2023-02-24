﻿using eBilet.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Core.Utilities.Security.JWT
{
	public interface ITokenHelper
	{
		AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
	}
}
