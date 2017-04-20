using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Columns;
using System.Drawing;
using DevExpress.Xpo.DB;
using DevExpress.XtraGrid.Views.Grid;

namespace Life
{
    [DBAttribute(Caption = "Прибыль", IconFile = "DatebookProfitCollection.png")]
    public partial class DatebookProfitCollectionView : DBViewInterface
    {
        public DatebookProfitCollectionView()
        {
            InitializeComponent();
        }

        private void tableGridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
