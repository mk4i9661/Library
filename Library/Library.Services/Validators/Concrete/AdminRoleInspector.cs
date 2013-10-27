using Library.DataContracts.Concrete;
using Library.Services.Validators.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Validators.Concrete
{
    public class AdminRoleInspector : RoleInspector
    {
        protected override bool ValidateRole(Role role) {
            return (role.Id & RoleId.Admin) != 0;
        }
    }
}
