using Library.Services.Validators.Abstract;
using Library.Services.Validators.Concrete;
using Library.Services.Validators.InspectorFactories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Validators.InspectorFactories.Concrete
{
    public class BibliographerInspectorFactory : IRoleInspectorFactory
    {
        public RoleInspector Create() {
            return new BibliographerRoleInspector();
        }
    }
}
