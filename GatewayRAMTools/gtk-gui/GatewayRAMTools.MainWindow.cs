
// This file has been generated by the GUI designer. Do not modify.
namespace GatewayRAMTools
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action FileAction;
		
		private global::Gtk.Action ToolsAction;
		
		private global::Gtk.Action HelpAction;
		
		private global::Gtk.Action AboutAction;
		
		private global::Gtk.Action SupportAction;
		
		private global::Gtk.Action SelectAction;
		
		private global::Gtk.Action AllAction;
		
		private global::Gtk.Action NoneAction;
		
		private global::Gtk.Action AllGatewayAction;
		
		private global::Gtk.Action AllRAWAction;
		
		private global::Gtk.Action ViewSelectedPartitionAction;
		
		private global::Gtk.Action ExportRAWRAMDumpAction;
		
		private global::Gtk.Action AddFilesAction;
		
		private global::Gtk.Action ExitAction;
		
		private global::Gtk.Action ProjectHomepageAction;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.MenuBar menubar1;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeFiles;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.ProgressBar prgMain;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button btnAddFiles;
		
		private global::Gtk.Button btnRemove;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget GatewayRAMTools.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, null);
			this.ToolsAction = new global::Gtk.Action ("ToolsAction", global::Mono.Unix.Catalog.GetString ("Tools"), null, null);
			this.ToolsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Tools");
			w1.Add (this.ToolsAction, null);
			this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
			w1.Add (this.HelpAction, null);
			this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
			this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
			w1.Add (this.AboutAction, null);
			this.SupportAction = new global::Gtk.Action ("SupportAction", global::Mono.Unix.Catalog.GetString ("Support"), null, null);
			this.SupportAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Support");
			w1.Add (this.SupportAction, null);
			this.SelectAction = new global::Gtk.Action ("SelectAction", global::Mono.Unix.Catalog.GetString ("Select"), null, null);
			this.SelectAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Select");
			w1.Add (this.SelectAction, null);
			this.AllAction = new global::Gtk.Action ("AllAction", global::Mono.Unix.Catalog.GetString ("All"), null, null);
			this.AllAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("All");
			w1.Add (this.AllAction, null);
			this.NoneAction = new global::Gtk.Action ("NoneAction", global::Mono.Unix.Catalog.GetString ("None"), null, null);
			this.NoneAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("None");
			w1.Add (this.NoneAction, null);
			this.AllGatewayAction = new global::Gtk.Action ("AllGatewayAction", global::Mono.Unix.Catalog.GetString ("All Gateway"), null, null);
			this.AllGatewayAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("All Gateway");
			w1.Add (this.AllGatewayAction, null);
			this.AllRAWAction = new global::Gtk.Action ("AllRAWAction", global::Mono.Unix.Catalog.GetString ("All RAW"), null, null);
			this.AllRAWAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("All RAW");
			w1.Add (this.AllRAWAction, null);
			this.ViewSelectedPartitionAction = new global::Gtk.Action ("ViewSelectedPartitionAction", global::Mono.Unix.Catalog.GetString ("View Selected Partition"), null, null);
			this.ViewSelectedPartitionAction.Sensitive = false;
			this.ViewSelectedPartitionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("View Selected Partition");
			w1.Add (this.ViewSelectedPartitionAction, null);
			this.ExportRAWRAMDumpAction = new global::Gtk.Action ("ExportRAWRAMDumpAction", global::Mono.Unix.Catalog.GetString ("Export RAW RAM Dump"), null, null);
			this.ExportRAWRAMDumpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Export RAW RAM Dump");
			w1.Add (this.ExportRAWRAMDumpAction, null);
			this.AddFilesAction = new global::Gtk.Action ("AddFilesAction", global::Mono.Unix.Catalog.GetString ("Add Files.."), null, null);
			this.AddFilesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Add Files");
			w1.Add (this.AddFilesAction, null);
			this.ExitAction = new global::Gtk.Action ("ExitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, null);
			this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
			w1.Add (this.ExitAction, null);
			this.ProjectHomepageAction = new global::Gtk.Action ("ProjectHomepageAction", global::Mono.Unix.Catalog.GetString ("Project Homepage"), null, null);
			this.ProjectHomepageAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Project Homepage");
			w1.Add (this.ProjectHomepageAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "GatewayRAMTools.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Gateway RAM Tools");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child GatewayRAMTools.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='AddFilesAction' action='AddFilesAction'/><separator/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='ToolsAction' action='ToolsAction'><menu name='SelectAction' action='SelectAction'><menuitem name='AllAction' action='AllAction'/><menuitem name='NoneAction' action='NoneAction'/><separator/><menuitem name='AllGatewayAction' action='AllGatewayAction'/><menuitem name='AllRAWAction' action='AllRAWAction'/></menu><separator/><menuitem name='ViewSelectedPartitionAction' action='ViewSelectedPartitionAction'/><menuitem name='ExportRAWRAMDumpAction' action='ExportRAWRAMDumpAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/><separator/><menuitem name='SupportAction' action='SupportAction'/><menuitem name='ProjectHomepageAction' action='ProjectHomepageAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow.BorderWidth = ((uint)(3));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeFiles = new global::Gtk.TreeView ();
			this.treeFiles.CanFocus = true;
			this.treeFiles.Name = "treeFiles";
			this.GtkScrolledWindow.Add (this.treeFiles);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w4.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.prgMain = new global::Gtk.ProgressBar ();
			this.prgMain.Name = "prgMain";
			this.hbox2.Add (this.prgMain);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.prgMain]));
			w5.Position = 0;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(3));
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnAddFiles = new global::Gtk.Button ();
			this.btnAddFiles.WidthRequest = 95;
			this.btnAddFiles.CanFocus = true;
			this.btnAddFiles.Name = "btnAddFiles";
			this.btnAddFiles.UseUnderline = true;
			this.btnAddFiles.Label = global::Mono.Unix.Catalog.GetString ("Add Files..");
			this.hbox1.Add (this.btnAddFiles);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnAddFiles]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnRemove = new global::Gtk.Button ();
			this.btnRemove.WidthRequest = 95;
			this.btnRemove.Sensitive = false;
			this.btnRemove.CanFocus = true;
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.UseUnderline = true;
			this.btnRemove.Label = global::Mono.Unix.Catalog.GetString ("Remove Ticked");
			this.hbox1.Add (this.btnRemove);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnRemove]));
			w8.PackType = ((global::Gtk.PackType)(1));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.prgMain.Hide ();
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.AboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
			this.SupportAction.Activated += new global::System.EventHandler (this.OnSupportActionActivated);
			this.AllAction.Activated += new global::System.EventHandler (this.OnAllActionActivated);
			this.NoneAction.Activated += new global::System.EventHandler (this.OnNoneActionActivated);
			this.AllGatewayAction.Activated += new global::System.EventHandler (this.OnAllGatewayActionActivated);
			this.AllRAWAction.Activated += new global::System.EventHandler (this.OnAllRAWActionActivated);
			this.ViewSelectedPartitionAction.Activated += new global::System.EventHandler (this.OnViewPartitionTableActionActivated);
			this.ExportRAWRAMDumpAction.Activated += new global::System.EventHandler (this.OnExportRAWDumpActionActivated);
			this.AddFilesAction.Activated += new global::System.EventHandler (this.OnAddFilesActionActivated);
			this.ExitAction.Activated += new global::System.EventHandler (this.OnExitActionActivated);
			this.ProjectHomepageAction.Activated += new global::System.EventHandler (this.OnProjectHomepageActionActivated);
			this.treeFiles.CursorChanged += new global::System.EventHandler (this.OnTreeFilesCursorChanged);
			this.treeFiles.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeFilesRowActivated);
			this.btnAddFiles.Clicked += new global::System.EventHandler (this.OnBtnAddFilesClicked);
			this.btnRemove.Clicked += new global::System.EventHandler (this.OnBtnRemoveClicked);
		}
	}
}
