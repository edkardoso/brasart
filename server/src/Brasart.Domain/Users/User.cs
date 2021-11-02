using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brasart.Domain.Common.Entities;

namespace Brasart.Domain.Users
{
    public class User: AuditableBaseEntity
    {
        protected User(){}

        public string Name { get;  }
        public string Email { get;  }
        public string Password { get;  }

    }
}
