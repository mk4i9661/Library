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
    class CardPage : Page<IOperator, CardPage.LoadNecessaryDataWrap, Card>
    {
        public CardPage(PageParameters parameters)
            : base(parameters) {
        }

        protected override IEnumerable<Card> LoadDataOperation()
        {
            return GetProxy().GetCards();
        }

        protected override Card CreateDefaultRow()
        {
            return new Card();
        }

        protected override Card DeleteOperation(Card data)
        {
            //return GetProxy().DeleteCard(data);
            return null;
        }

        internal class LoadNecessaryDataWrap
        {
        }
    }
}
