using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.WindowsClient
{
    partial class MainForm
    {
        private void InitializeComponent() {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rpReaders = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpCards = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpBooks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpReaders,
            this.rpCards,
            this.rpBooks});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1029, 142);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // rpReaders
            // 
            this.rpReaders.Name = "rpReaders";
            this.rpReaders.Text = "Читатели";
            // 
            // rpCards
            // 
            this.rpCards.Name = "rpCards";
            this.rpCards.Text = "Читательские карты";
            // 
            // rpBooks
            // 
            this.rpBooks.Name = "rpBooks";
            this.rpBooks.Text = "Книги";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1029, 485);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Text = "Система \"Библиотека\"";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraBars.Ribbon.RibbonPage rpReaders;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCards;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBooks;
    }
}
