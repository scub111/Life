using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Menu;
using System.Drawing;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace Life
{
    [DBAttribute(Caption = "Расходы", IconFile = "DatebookCostCollection.png")]
    public partial class DatebookCostCollectionView : DBViewInterface
    {
        public DatebookCostCollectionView()
        {
            InitializeComponent();
        }

        private void tableGridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Column)
            {
                GridViewColumnMenu menu = e.Menu as GridViewColumnMenu;
                //Erasing the default menu items 
                //menu.Items.Clear();
                if (menu.Column != null)
                {
                    //Adding new items 
                    if (menu.Column.Caption == "Владелец \"Ежедневник\"")
                    {
                        menu.Items.Add(CreateCheckItem("Сортировать по возрастанию", menu.Column, Properties.Resources.Up, new EventHandler(DateAscendingSort)));
                        menu.Items.Add(CreateCheckItem("Сортировать по убыванию", menu.Column, Properties.Resources.Down, new EventHandler(DateDescendingSort)));
                    }
                }
            }
        }

        private DXMenuCheckItem CreateCheckItem(string caption, GridColumn column, Image image, EventHandler eventHandler)
        {
            DXMenuCheckItem item = new DXMenuCheckItem(caption, false, image, eventHandler);
            item.Tag = column;
            return item;
        }

        private void DateAscendingSort(object sender, EventArgs e)
        {
            baseXPCollecton1.Sorting.Clear();
            baseXPCollecton1.Sorting.Add(new SortProperty("[DatebookOwner].[Date]", SortingDirection.Ascending));
        }

        private void DateDescendingSort(object sender, EventArgs e)
        {
            baseXPCollecton1.Sorting.Clear();
            baseXPCollecton1.Sorting.Add(new SortProperty("[DatebookOwner].[Date]", SortingDirection.Descending));
        }
    }
}
