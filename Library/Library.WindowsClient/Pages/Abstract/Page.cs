using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;

namespace Library.WindowsClient.Pages.Abstract
{
    abstract class Page
    {
        public XtraTabPage TabPage {
            get;
            protected set;
        }

        public RibbonPage RibbonPage {
            get;
            protected set;
        }

        protected Page(PageParameters parameters) {
            TabPage = parameters.TabPage;
            RibbonPage = parameters.RibbonPage;

            TabPage.Tag = this;
            RibbonPage.Tag = this;
        }

        public virtual void Activate() {
        }
    }

    class PageParameters
    {
        public RibbonPage RibbonPage {
            get;
            set;
        }

        public XtraTabPage TabPage {
            get;
            set;
        }
    }
}
