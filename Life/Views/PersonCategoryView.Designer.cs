namespace Life
{
    partial class PersonCategoryView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonCategoryView));
            this._dbInterface1 = new RapidInterface.DBInterface();
            this.baseUnitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.baseXPCollecton1 = new DevExpress.Xpo.XPCollection(this.components);
            this.dockPanelMerge1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.tableDockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.tableDockContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.tableLayoutControl1 = new RapidInterface.LayoutControlEx();
            this.tableGridControl1 = new RapidInterface.GridControlEx(this.components);
            this.tableGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.tableGridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.PersonCategoryCaptionGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CommentGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.icons1 = new DevExpress.Utils.ImageCollection(this.components);
            this.tableNavigatorControl1 = new RapidInterface.DataNavigatorEx(this.components);
            this.tableLayoutGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tableNavigatorLayoutItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableGridLayoutItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.formDockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.formDockContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.formLayoutControl1 = new RapidInterface.LayoutControlEx();
            this.formNavigatorControl1 = new RapidInterface.DataNavigatorEx(this.components);
            this.PersonCategoryCaptionTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.CommentTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.formLayoutGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.formNavigatorLayoutItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.formDataLayoutGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.PersonCategoryCaptionLayoutItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CommentLayoutItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.itemString1 = new RapidInterface.DBInterfaceItemString();
            this.itemString2 = new RapidInterface.DBInterfaceItemString();
            this._dbInterface1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseUnitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseXPCollecton1)).BeginInit();
            this.dockPanelMerge1.SuspendLayout();
            this.tableDockPanel1.SuspendLayout();
            this.tableDockContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLayoutControl1)).BeginInit();
            this.tableLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icons1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLayoutGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNavigatorLayoutItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridLayoutItem1)).BeginInit();
            this.formDockPanel1.SuspendLayout();
            this.formDockContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formLayoutControl1)).BeginInit();
            this.formLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonCategoryCaptionTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLayoutGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formNavigatorLayoutItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDataLayoutGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonCategoryCaptionLayoutItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentLayoutItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dbInterface1
            // 
            this._dbInterface1.BaseUnitOfWork = this.baseUnitOfWork1;
            this._dbInterface1.BaseXPCollecton = this.baseXPCollecton1;
            this._dbInterface1.Controls.Add(this.dockPanelMerge1);
            this._dbInterface1.CountOpenDesigner = 2;
            this._dbInterface1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbInterface1.DockManager = this.dockManager1;
            this._dbInterface1.DockPanelMerge = this.dockPanelMerge1;
            this._dbInterface1.FormDataLayoutGroup = this.formDataLayoutGroup1;
            this._dbInterface1.FormDockContainer = this.formDockContainer1;
            this._dbInterface1.FormDockPanel = this.formDockPanel1;
            this._dbInterface1.FormLayoutControl = this.formLayoutControl1;
            this._dbInterface1.FormLayoutGroup = this.formLayoutGroup1;
            this._dbInterface1.FormNavigatorControl = this.formNavigatorControl1;
            this._dbInterface1.FormNavigatorLayoutItem = this.formNavigatorLayoutItem1;
            this._dbInterface1.Icons = this.icons1;
            this._dbInterface1.ImagePath = "d:\\Мои документы\\!Projects\\RapidInterface\\RapidInterface\\Life\\Life\\";
            this._dbInterface1.Items.Add(this.itemString1);
            this._dbInterface1.Items.Add(this.itemString2);
            this._dbInterface1.ItemsSeq.Add(this.itemString1);
            this._dbInterface1.ItemsSeq.Add(this.itemString2);
            this._dbInterface1.Location = new System.Drawing.Point(0, 0);
            this._dbInterface1.Name = "_dbInterface1";
            this._dbInterface1.ProgramDesign = false;
            this._dbInterface1.Size = new System.Drawing.Size(994, 631);
            this._dbInterface1.TabIndex = 0;
            this._dbInterface1.TableDockContainer = this.tableDockContainer1;
            this._dbInterface1.TableDockPanel = this.tableDockPanel1;
            this._dbInterface1.TableGridBand = this.tableGridBand1;
            this._dbInterface1.TableGridControl = this.tableGridControl1;
            this._dbInterface1.TableGridLayoutItem = this.tableGridLayoutItem1;
            this._dbInterface1.TableGridView = this.tableGridView1;
            this._dbInterface1.TableLayoutControl = this.tableLayoutControl1;
            this._dbInterface1.TableLayoutGroup = this.tableLayoutGroup1;
            this._dbInterface1.TableNavigatorControl = this.tableNavigatorControl1;
            this._dbInterface1.TableNavigatorLayoutItem = this.tableNavigatorLayoutItem1;
            this._dbInterface1.TableType = null;
            this._dbInterface1.XPCollections.Add(this.baseXPCollecton1);
            // 
            // baseUnitOfWork1
            // 
            this.baseUnitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.baseUnitOfWork1.TrackPropertiesModifications = false;
            // 
            // baseXPCollecton1
            // 
            this.baseXPCollecton1.DeleteObjectOnRemove = true;
            this.baseXPCollecton1.ObjectType = typeof(Life.PersonCategory);
            this.baseXPCollecton1.Session = this.baseUnitOfWork1;
            // 
            // dockPanelMerge1
            // 
            this.dockPanelMerge1.ActiveChild = this.tableDockPanel1;
            this.dockPanelMerge1.Controls.Add(this.formDockPanel1);
            this.dockPanelMerge1.Controls.Add(this.tableDockPanel1);
            this.dockPanelMerge1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanelMerge1.FloatVertical = true;
            this.dockPanelMerge1.ID = new System.Guid("b304dcb7-4e1b-4244-b2df-67599a2d4e60");
            this.dockPanelMerge1.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMerge1.Name = "dockPanelMerge1";
            this.dockPanelMerge1.OriginalSize = new System.Drawing.Size(501, 200);
            this.dockPanelMerge1.Size = new System.Drawing.Size(994, 631);
            this.dockPanelMerge1.Tabbed = true;
            this.dockPanelMerge1.TabsPosition = DevExpress.XtraBars.Docking.TabsPosition.Left;
            // 
            // tableDockPanel1
            // 
            this.tableDockPanel1.Controls.Add(this.tableDockContainer1);
            this.tableDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.tableDockPanel1.FloatSize = new System.Drawing.Size(600, 600);
            this.tableDockPanel1.ID = new System.Guid("dad5e80c-80ed-424e-8568-3dfe4d0366cc");
            this.tableDockPanel1.Location = new System.Drawing.Point(31, 23);
            this.tableDockPanel1.Name = "tableDockPanel1";
            this.tableDockPanel1.OriginalSize = new System.Drawing.Size(400, 400);
            this.tableDockPanel1.Size = new System.Drawing.Size(959, 604);
            this.tableDockPanel1.Text = "Таблица";
            // 
            // tableDockContainer1
            // 
            this.tableDockContainer1.Controls.Add(this.tableLayoutControl1);
            this.tableDockContainer1.Location = new System.Drawing.Point(0, 0);
            this.tableDockContainer1.Name = "tableDockContainer1";
            this.tableDockContainer1.Size = new System.Drawing.Size(959, 604);
            this.tableDockContainer1.TabIndex = 0;
            // 
            // tableLayoutControl1
            // 
            this.tableLayoutControl1.Controls.Add(this.tableGridControl1);
            this.tableLayoutControl1.Controls.Add(this.tableNavigatorControl1);
            this.tableLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutControl1.Images = this.icons1;
            this.tableLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutControl1.Name = "tableLayoutControl1";
            this.tableLayoutControl1.Root = this.tableLayoutGroup1;
            this.tableLayoutControl1.Size = new System.Drawing.Size(959, 604);
            this.tableLayoutControl1.TabIndex = 0;
            // 
            // tableGridControl1
            // 
            this.tableGridControl1.DataSource = this.baseXPCollecton1;
            this.tableGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.tableGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.tableGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.tableGridControl1.Location = new System.Drawing.Point(12, 35);
            this.tableGridControl1.MainView = this.tableGridView1;
            this.tableGridControl1.Name = "tableGridControl1";
            this.tableGridControl1.ShowOnlyPredefinedDetails = true;
            this.tableGridControl1.Size = new System.Drawing.Size(935, 557);
            this.tableGridControl1.TabIndex = 4;
            this.tableGridControl1.UseEmbeddedNavigator = true;
            this.tableGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tableGridView1});
            // 
            // tableGridView1
            // 
            this.tableGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.tableGridBand1});
            this.tableGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.PersonCategoryCaptionGridColumn1,
            this.CommentGridColumn1});
            this.tableGridView1.GridControl = this.tableGridControl1;
            this.tableGridView1.Images = this.icons1;
            this.tableGridView1.Name = "tableGridView1";
            this.tableGridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.tableGridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.tableGridView1.OptionsFind.AlwaysVisible = true;
            this.tableGridView1.OptionsView.ShowAutoFilterRow = true;
            this.tableGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tableGridBand1
            // 
            this.tableGridBand1.Caption = "Основные данные";
            this.tableGridBand1.Columns.Add(this.PersonCategoryCaptionGridColumn1);
            this.tableGridBand1.Columns.Add(this.CommentGridColumn1);
            this.tableGridBand1.Name = "tableGridBand1";
            this.tableGridBand1.VisibleIndex = 0;
            this.tableGridBand1.Width = 917;
            // 
            // PersonCategoryCaptionGridColumn1
            // 
            this.PersonCategoryCaptionGridColumn1.Caption = "Название категории лица";
            this.PersonCategoryCaptionGridColumn1.FieldName = "PersonCategoryCaption";
            this.PersonCategoryCaptionGridColumn1.Name = "PersonCategoryCaptionGridColumn1";
            this.PersonCategoryCaptionGridColumn1.Visible = true;
            this.PersonCategoryCaptionGridColumn1.Width = 458;
            // 
            // CommentGridColumn1
            // 
            this.CommentGridColumn1.Caption = "Комментарий";
            this.CommentGridColumn1.FieldName = "Comment";
            this.CommentGridColumn1.Name = "CommentGridColumn1";
            this.CommentGridColumn1.Visible = true;
            this.CommentGridColumn1.Width = 459;
            // 
            // icons1
            // 
            this.icons1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icons1.ImageStream")));
            // 
            // tableNavigatorControl1
            // 
            this.tableNavigatorControl1.DataSource = this.baseXPCollecton1;
            this.tableNavigatorControl1.Error = false;
            this.tableNavigatorControl1.Location = new System.Drawing.Point(299, 12);
            this.tableNavigatorControl1.Name = "tableNavigatorControl1";
            this.tableNavigatorControl1.ShowToolTips = true;
            this.tableNavigatorControl1.Size = new System.Drawing.Size(361, 19);
            this.tableNavigatorControl1.StyleController = this.tableLayoutControl1;
            this.tableNavigatorControl1.TabIndex = 5;
            this.tableNavigatorControl1.TableCaption = "Категория лица";
            this.tableNavigatorControl1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            // 
            // tableLayoutGroup1
            // 
            this.tableLayoutGroup1.CustomizationFormText = "Основная группа";
            this.tableLayoutGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.tableLayoutGroup1.GroupBordersVisible = false;
            this.tableLayoutGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tableNavigatorLayoutItem1,
            this.tableGridLayoutItem1});
            this.tableLayoutGroup1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutGroup1.Name = "tableLayoutGroup1";
            this.tableLayoutGroup1.Size = new System.Drawing.Size(959, 604);
            this.tableLayoutGroup1.TextVisible = false;
            // 
            // tableNavigatorLayoutItem1
            // 
            this.tableNavigatorLayoutItem1.Control = this.tableNavigatorControl1;
            this.tableNavigatorLayoutItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableNavigatorLayoutItem1.CustomizationFormText = "Панель навигации";
            this.tableNavigatorLayoutItem1.Location = new System.Drawing.Point(0, 0);
            this.tableNavigatorLayoutItem1.Name = "tableNavigatorLayoutItem1";
            this.tableNavigatorLayoutItem1.Size = new System.Drawing.Size(939, 23);
            this.tableNavigatorLayoutItem1.TextSize = new System.Drawing.Size(0, 0);
            this.tableNavigatorLayoutItem1.TextVisible = false;
            // 
            // tableGridLayoutItem1
            // 
            this.tableGridLayoutItem1.Control = this.tableGridControl1;
            this.tableGridLayoutItem1.CustomizationFormText = "Таблица";
            this.tableGridLayoutItem1.Location = new System.Drawing.Point(0, 23);
            this.tableGridLayoutItem1.Name = "tableGridLayoutItem1";
            this.tableGridLayoutItem1.Size = new System.Drawing.Size(939, 561);
            this.tableGridLayoutItem1.TextSize = new System.Drawing.Size(0, 0);
            this.tableGridLayoutItem1.TextVisible = false;
            // 
            // formDockPanel1
            // 
            this.formDockPanel1.Controls.Add(this.formDockContainer1);
            this.formDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.formDockPanel1.FloatSize = new System.Drawing.Size(600, 600);
            this.formDockPanel1.ID = new System.Guid("9735312d-4281-4a71-a4ec-f4bf849385e3");
            this.formDockPanel1.Location = new System.Drawing.Point(31, 23);
            this.formDockPanel1.Name = "formDockPanel1";
            this.formDockPanel1.OriginalSize = new System.Drawing.Size(400, 400);
            this.formDockPanel1.Size = new System.Drawing.Size(959, 604);
            this.formDockPanel1.Text = "Форма";
            // 
            // formDockContainer1
            // 
            this.formDockContainer1.Controls.Add(this.formLayoutControl1);
            this.formDockContainer1.Location = new System.Drawing.Point(0, 0);
            this.formDockContainer1.Name = "formDockContainer1";
            this.formDockContainer1.Size = new System.Drawing.Size(959, 604);
            this.formDockContainer1.TabIndex = 0;
            // 
            // formLayoutControl1
            // 
            this.formLayoutControl1.Controls.Add(this.formNavigatorControl1);
            this.formLayoutControl1.Controls.Add(this.PersonCategoryCaptionTextEdit1);
            this.formLayoutControl1.Controls.Add(this.CommentTextEdit1);
            this.formLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayoutControl1.Images = this.icons1;
            this.formLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.formLayoutControl1.Name = "formLayoutControl1";
            this.formLayoutControl1.Root = this.formLayoutGroup1;
            this.formLayoutControl1.Size = new System.Drawing.Size(959, 604);
            this.formLayoutControl1.TabIndex = 0;
            // 
            // formNavigatorControl1
            // 
            this.formNavigatorControl1.DataSource = this.baseXPCollecton1;
            this.formNavigatorControl1.Error = false;
            this.formNavigatorControl1.Location = new System.Drawing.Point(299, 12);
            this.formNavigatorControl1.Name = "formNavigatorControl1";
            this.formNavigatorControl1.ShowToolTips = true;
            this.formNavigatorControl1.Size = new System.Drawing.Size(361, 19);
            this.formNavigatorControl1.StyleController = this.formLayoutControl1;
            this.formNavigatorControl1.TabIndex = 4;
            this.formNavigatorControl1.TableCaption = "Категория лица";
            this.formNavigatorControl1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            // 
            // PersonCategoryCaptionTextEdit1
            // 
            this.PersonCategoryCaptionTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.baseXPCollecton1, "PersonCategoryCaption", true));
            this.PersonCategoryCaptionTextEdit1.Location = new System.Drawing.Point(162, 65);
            this.PersonCategoryCaptionTextEdit1.Name = "PersonCategoryCaptionTextEdit1";
            this.PersonCategoryCaptionTextEdit1.Size = new System.Drawing.Size(773, 20);
            this.PersonCategoryCaptionTextEdit1.StyleController = this.formLayoutControl1;
            this.PersonCategoryCaptionTextEdit1.TabIndex = 5;
            // 
            // CommentTextEdit1
            // 
            this.CommentTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.baseXPCollecton1, "Comment", true));
            this.CommentTextEdit1.Location = new System.Drawing.Point(162, 89);
            this.CommentTextEdit1.Name = "CommentTextEdit1";
            this.CommentTextEdit1.Size = new System.Drawing.Size(773, 20);
            this.CommentTextEdit1.StyleController = this.formLayoutControl1;
            this.CommentTextEdit1.TabIndex = 6;
            // 
            // formLayoutGroup1
            // 
            this.formLayoutGroup1.CustomizationFormText = "Основная группа формы";
            this.formLayoutGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.formLayoutGroup1.GroupBordersVisible = false;
            this.formLayoutGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.formNavigatorLayoutItem1,
            this.formDataLayoutGroup1});
            this.formLayoutGroup1.Location = new System.Drawing.Point(0, 0);
            this.formLayoutGroup1.Name = "formLayoutGroup1";
            this.formLayoutGroup1.Size = new System.Drawing.Size(959, 604);
            this.formLayoutGroup1.TextVisible = false;
            // 
            // formNavigatorLayoutItem1
            // 
            this.formNavigatorLayoutItem1.Control = this.formNavigatorControl1;
            this.formNavigatorLayoutItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.formNavigatorLayoutItem1.CustomizationFormText = "Панель навигации";
            this.formNavigatorLayoutItem1.Location = new System.Drawing.Point(0, 0);
            this.formNavigatorLayoutItem1.Name = "formNavigatorLayoutItem1";
            this.formNavigatorLayoutItem1.Size = new System.Drawing.Size(939, 23);
            this.formNavigatorLayoutItem1.TextSize = new System.Drawing.Size(0, 0);
            this.formNavigatorLayoutItem1.TextVisible = false;
            // 
            // formDataLayoutGroup1
            // 
            this.formDataLayoutGroup1.AppearanceGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataLayoutGroup1.AppearanceGroup.Options.UseBackColor = true;
            this.formDataLayoutGroup1.CustomizationFormText = "Основные данные";
            this.formDataLayoutGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.PersonCategoryCaptionLayoutItem1,
            this.CommentLayoutItem1});
            this.formDataLayoutGroup1.Location = new System.Drawing.Point(0, 23);
            this.formDataLayoutGroup1.Name = "formDataLayoutGroup1";
            this.formDataLayoutGroup1.Size = new System.Drawing.Size(939, 561);
            this.formDataLayoutGroup1.Text = "Основные данные";
            // 
            // PersonCategoryCaptionLayoutItem1
            // 
            this.PersonCategoryCaptionLayoutItem1.Control = this.PersonCategoryCaptionTextEdit1;
            this.PersonCategoryCaptionLayoutItem1.CustomizationFormText = "Название категории лица";
            this.PersonCategoryCaptionLayoutItem1.Location = new System.Drawing.Point(0, 0);
            this.PersonCategoryCaptionLayoutItem1.Name = "PersonCategoryCaptionLayoutItem1";
            this.PersonCategoryCaptionLayoutItem1.Size = new System.Drawing.Size(915, 24);
            this.PersonCategoryCaptionLayoutItem1.Text = "Название категории лица:";
            this.PersonCategoryCaptionLayoutItem1.TextSize = new System.Drawing.Size(135, 13);
            // 
            // CommentLayoutItem1
            // 
            this.CommentLayoutItem1.Control = this.CommentTextEdit1;
            this.CommentLayoutItem1.CustomizationFormText = "Комментарий";
            this.CommentLayoutItem1.Location = new System.Drawing.Point(0, 24);
            this.CommentLayoutItem1.Name = "CommentLayoutItem1";
            this.CommentLayoutItem1.Size = new System.Drawing.Size(915, 495);
            this.CommentLayoutItem1.Text = "Комментарий:";
            this.CommentLayoutItem1.TextSize = new System.Drawing.Size(135, 13);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this._dbInterface1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelMerge1});
            // 
            // itemString1
            // 
            this.itemString1.Caption = "Название категории лица";
            this.itemString1.ControlName = "PersonCategoryCaption";
            this.itemString1.DBInterface = this._dbInterface1;
            this.itemString1.FieldName = "PersonCategoryCaption";
            this.itemString1.FormEdit = this.PersonCategoryCaptionTextEdit1;
            this.itemString1.FormGridColumn = null;
            this.itemString1.FormLayoutItem = this.PersonCategoryCaptionLayoutItem1;
            this.itemString1.ImageName = "";
            this.itemString1.Images = this.icons1;
            this.itemString1.Parent = null;
            this.itemString1.TableGridColumn = this.PersonCategoryCaptionGridColumn1;
            // 
            // itemString2
            // 
            this.itemString2.Caption = "Комментарий";
            this.itemString2.ControlName = "Comment";
            this.itemString2.DBInterface = this._dbInterface1;
            this.itemString2.FieldName = "Comment";
            this.itemString2.FormEdit = this.CommentTextEdit1;
            this.itemString2.FormGridColumn = null;
            this.itemString2.FormLayoutItem = this.CommentLayoutItem1;
            this.itemString2.ImageName = "";
            this.itemString2.Images = this.icons1;
            this.itemString2.Parent = null;
            this.itemString2.TableGridColumn = this.CommentGridColumn1;
            // 
            // PersonCategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._dbInterface1);
            this.DBInterface = this._dbInterface1;
            this.Name = "PersonCategoryView";
            this.Size = new System.Drawing.Size(994, 631);
            this._dbInterface1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseUnitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseXPCollecton1)).EndInit();
            this.dockPanelMerge1.ResumeLayout(false);
            this.tableDockPanel1.ResumeLayout(false);
            this.tableDockContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLayoutControl1)).EndInit();
            this.tableLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icons1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLayoutGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNavigatorLayoutItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridLayoutItem1)).EndInit();
            this.formDockPanel1.ResumeLayout(false);
            this.formDockContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formLayoutControl1)).EndInit();
            this.formLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonCategoryCaptionTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLayoutGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formNavigatorLayoutItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDataLayoutGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonCategoryCaptionLayoutItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentLayoutItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RapidInterface.DBInterface _dbInterface1;
        private DevExpress.Xpo.UnitOfWork baseUnitOfWork1;
        private DevExpress.Xpo.XPCollection baseXPCollecton1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelMerge1;
        private DevExpress.XtraBars.Docking.DockPanel formDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer formDockContainer1;
        private RapidInterface.LayoutControlEx formLayoutControl1;
        private RapidInterface.DataNavigatorEx formNavigatorControl1;
        private DevExpress.Utils.ImageCollection icons1;
        private DevExpress.XtraLayout.LayoutControlGroup formLayoutGroup1;
        private DevExpress.XtraLayout.LayoutControlItem formNavigatorLayoutItem1;
        private DevExpress.XtraLayout.LayoutControlGroup formDataLayoutGroup1;
        private DevExpress.XtraBars.Docking.DockPanel tableDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer tableDockContainer1;
        private RapidInterface.LayoutControlEx tableLayoutControl1;
        private RapidInterface.GridControlEx tableGridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView tableGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand tableGridBand1;
        private RapidInterface.DataNavigatorEx tableNavigatorControl1;
        private DevExpress.XtraLayout.LayoutControlGroup tableLayoutGroup1;
        private DevExpress.XtraLayout.LayoutControlItem tableNavigatorLayoutItem1;
        private DevExpress.XtraLayout.LayoutControlItem tableGridLayoutItem1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PersonCategoryCaptionGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CommentGridColumn1;
        private DevExpress.XtraEditors.TextEdit PersonCategoryCaptionTextEdit1;
        private DevExpress.XtraEditors.TextEdit CommentTextEdit1;
        private DevExpress.XtraLayout.LayoutControlItem PersonCategoryCaptionLayoutItem1;
        private DevExpress.XtraLayout.LayoutControlItem CommentLayoutItem1;
        private RapidInterface.DBInterfaceItemString itemString1;
        private RapidInterface.DBInterfaceItemString itemString2;
    }
}