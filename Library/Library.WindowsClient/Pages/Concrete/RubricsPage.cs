using Library.Contracts;
using Library.DataContracts.Concrete;
using Library.WindowsClient.Pages.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.WindowsClient.Pages.Concrete
{
    class RubricsPage : Page<IBibliographer, RubricsPage.LoadNecessaryDataWrap, Rubric>
    {
        public RubricsPage(PageParameters parameters)
            : base(parameters) {
        }

        internal class LoadNecessaryDataWrap
        {

        }
    }
}
