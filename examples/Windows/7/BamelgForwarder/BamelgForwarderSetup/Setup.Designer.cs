namespace BamelgForwarderSetup {
	partial class Setup {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
			this._connections = new System.Windows.Forms.ListView();
			this._connectorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._tableEndpoints = new System.Windows.Forms.TableLayoutPanel();
			this._endpoint1 = new BamelgForwarderSetup.EndpointProperties();
			this._endpoint2 = new BamelgForwarderSetup.EndpointProperties();
			this._menu = new System.Windows.Forms.MenuStrip();
			this._traceMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._trace = new System.Windows.Forms.ToolStripMenuItem();
			this._traceTransfer = new System.Windows.Forms.ToolStripMenuItem();
			this._save = new System.Windows.Forms.ToolStripMenuItem();
			this._reload = new System.Windows.Forms.ToolStripMenuItem();
			this._stop = new System.Windows.Forms.ToolStripMenuItem();
			this._status = new System.Windows.Forms.StatusStrip();
			this._statusText = new System.Windows.Forms.ToolStripStatusLabel();
			this._connectorContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._add = new System.Windows.Forms.Button();
			this._remove = new System.Windows.Forms.Button();
			this._apply = new System.Windows.Forms.Button();
			this._revert = new System.Windows.Forms.Button();
			this._statisticsTimer = new System.Windows.Forms.Timer(this.components);
			this._updateStatistics = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this._tableEndpoints.SuspendLayout();
			this._menu.SuspendLayout();
			this._status.SuspendLayout();
			this._connectorContext.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
			// 
			// _connections
			// 
			this._connections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._connections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._connectorName});
			this._connections.FullRowSelect = true;
			this._connections.LabelEdit = true;
			this._connections.LabelWrap = false;
			this._connections.Location = new System.Drawing.Point(12, 27);
			this._connections.MultiSelect = false;
			this._connections.Name = "_connections";
			this._connections.Size = new System.Drawing.Size(172, 305);
			this._connections.TabIndex = 0;
			this._connections.UseCompatibleStateImageBehavior = false;
			this._connections.View = System.Windows.Forms.View.Details;
			this._connections.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this._connections_AfterLabelEdit);
			this._connections.SelectedIndexChanged += new System.EventHandler(this._connections_SelectedIndexChanged);
			this._connections.KeyDown += new System.Windows.Forms.KeyEventHandler(this._connections_KeyDown);
			// 
			// _connectorName
			// 
			this._connectorName.Text = "Name";
			this._connectorName.Width = 163;
			// 
			// _tableEndpoints
			// 
			this._tableEndpoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._tableEndpoints.ColumnCount = 1;
			this._tableEndpoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableEndpoints.Controls.Add(this._endpoint1, 0, 0);
			this._tableEndpoints.Controls.Add(this._endpoint2, 0, 1);
			this._tableEndpoints.Location = new System.Drawing.Point(190, 12);
			this._tableEndpoints.Name = "_tableEndpoints";
			this._tableEndpoints.RowCount = 2;
			this._tableEndpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableEndpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableEndpoints.Size = new System.Drawing.Size(264, 320);
			this._tableEndpoints.TabIndex = 3;
			// 
			// _endpoint1
			// 
			this._endpoint1.Dock = System.Windows.Forms.DockStyle.Fill;
			this._endpoint1.Location = new System.Drawing.Point(3, 3);
			this._endpoint1.Name = "_endpoint1";
			this._endpoint1.Size = new System.Drawing.Size(258, 154);
			this._endpoint1.TabIndex = 1;
			// 
			// _endpoint2
			// 
			this._endpoint2.Dock = System.Windows.Forms.DockStyle.Fill;
			this._endpoint2.Location = new System.Drawing.Point(3, 163);
			this._endpoint2.Name = "_endpoint2";
			this._endpoint2.Size = new System.Drawing.Size(258, 154);
			this._endpoint2.TabIndex = 2;
			// 
			// _menu
			// 
			this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._traceMenu});
			this._menu.Location = new System.Drawing.Point(0, 0);
			this._menu.Name = "_menu";
			this._menu.Size = new System.Drawing.Size(466, 24);
			this._menu.TabIndex = 5;
			this._menu.Text = "menuStrip2";
			// 
			// _traceMenu
			// 
			this._traceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._trace,
            this._traceTransfer,
            toolStripSeparator1,
            this._save,
            this._reload,
            toolStripSeparator2,
            this._updateStatistics,
            this.toolStripSeparator3,
            this._stop});
			this._traceMenu.Name = "_traceMenu";
			this._traceMenu.Size = new System.Drawing.Size(59, 20);
			this._traceMenu.Text = "Control";
			// 
			// _trace
			// 
			this._trace.Name = "_trace";
			this._trace.Size = new System.Drawing.Size(160, 22);
			this._trace.Text = "Trace";
			this._trace.Click += new System.EventHandler(this._trace_Click);
			// 
			// _traceTransfer
			// 
			this._traceTransfer.Name = "_traceTransfer";
			this._traceTransfer.Size = new System.Drawing.Size(160, 22);
			this._traceTransfer.Text = "Trace transfer";
			this._traceTransfer.Click += new System.EventHandler(this._traceTransfer_Click);
			// 
			// _save
			// 
			this._save.Name = "_save";
			this._save.Size = new System.Drawing.Size(160, 22);
			this._save.Text = "Save";
			this._save.Click += new System.EventHandler(this._save_Click);
			// 
			// _reload
			// 
			this._reload.Name = "_reload";
			this._reload.Size = new System.Drawing.Size(160, 22);
			this._reload.Text = "Reload";
			this._reload.Click += new System.EventHandler(this._reload_Click);
			// 
			// _stop
			// 
			this._stop.Name = "_stop";
			this._stop.Size = new System.Drawing.Size(160, 22);
			this._stop.Text = "Stop";
			this._stop.Click += new System.EventHandler(this._stop_Click);
			// 
			// _status
			// 
			this._status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusText});
			this._status.Location = new System.Drawing.Point(0, 364);
			this._status.Name = "_status";
			this._status.Size = new System.Drawing.Size(466, 22);
			this._status.TabIndex = 6;
			this._status.Text = "statusStrip1";
			// 
			// _statusText
			// 
			this._statusText.Name = "_statusText";
			this._statusText.Size = new System.Drawing.Size(59, 17);
			this._statusText.Text = "Loading...";
			// 
			// _connectorContext
			// 
			this._connectorContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem});
			this._connectorContext.Name = "_connectorContext";
			this._connectorContext.Size = new System.Drawing.Size(118, 26);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			// 
			// _add
			// 
			this._add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._add.Location = new System.Drawing.Point(12, 338);
			this._add.Name = "_add";
			this._add.Size = new System.Drawing.Size(23, 23);
			this._add.TabIndex = 8;
			this._add.Text = "+";
			this._add.UseVisualStyleBackColor = true;
			this._add.Click += new System.EventHandler(this._add_Click);
			// 
			// _remove
			// 
			this._remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._remove.Location = new System.Drawing.Point(41, 338);
			this._remove.Name = "_remove";
			this._remove.Size = new System.Drawing.Size(23, 23);
			this._remove.TabIndex = 9;
			this._remove.Text = "-";
			this._remove.UseVisualStyleBackColor = true;
			this._remove.Click += new System.EventHandler(this._remove_Click);
			// 
			// _apply
			// 
			this._apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._apply.Location = new System.Drawing.Point(379, 338);
			this._apply.Name = "_apply";
			this._apply.Size = new System.Drawing.Size(75, 23);
			this._apply.TabIndex = 10;
			this._apply.Text = "Apply";
			this._apply.UseVisualStyleBackColor = true;
			this._apply.Click += new System.EventHandler(this._apply_Click);
			// 
			// _revert
			// 
			this._revert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._revert.Location = new System.Drawing.Point(298, 338);
			this._revert.Name = "_revert";
			this._revert.Size = new System.Drawing.Size(75, 23);
			this._revert.TabIndex = 11;
			this._revert.Text = "Revert";
			this._revert.UseVisualStyleBackColor = true;
			this._revert.Click += new System.EventHandler(this._revert_Click);
			// 
			// _statisticsTimer
			// 
			this._statisticsTimer.Interval = 1000;
			this._statisticsTimer.Tick += new System.EventHandler(this._statisticsTimer_Tick);
			// 
			// _updateStatistics
			// 
			this._updateStatistics.Name = "_updateStatistics";
			this._updateStatistics.Size = new System.Drawing.Size(160, 22);
			this._updateStatistics.Text = "Update statistics";
			this._updateStatistics.Click += new System.EventHandler(this._updateStatistics_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
			// 
			// Setup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 386);
			this.Controls.Add(this._revert);
			this.Controls.Add(this._apply);
			this.Controls.Add(this._remove);
			this.Controls.Add(this._add);
			this.Controls.Add(this._status);
			this.Controls.Add(this._tableEndpoints);
			this.Controls.Add(this._connections);
			this.Controls.Add(this._menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(482, 406);
			this.Name = "Setup";
			this.Text = "BamelgForwarder";
			this.Shown += new System.EventHandler(this.Setup_Shown);
			this._tableEndpoints.ResumeLayout(false);
			this._menu.ResumeLayout(false);
			this._menu.PerformLayout();
			this._status.ResumeLayout(false);
			this._status.PerformLayout();
			this._connectorContext.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView _connections;
		private EndpointProperties _endpoint1;
		private EndpointProperties _endpoint2;
		private System.Windows.Forms.TableLayoutPanel _tableEndpoints;
		private System.Windows.Forms.MenuStrip _menu;
		private System.Windows.Forms.ToolStripMenuItem _traceMenu;
		private System.Windows.Forms.StatusStrip _status;
		private System.Windows.Forms.ToolStripStatusLabel _statusText;
		private System.Windows.Forms.ToolStripMenuItem _trace;
		private System.Windows.Forms.ToolStripMenuItem _traceTransfer;
		private System.Windows.Forms.ContextMenuStrip _connectorContext;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.Button _add;
		private System.Windows.Forms.Button _remove;
		private System.Windows.Forms.ColumnHeader _connectorName;
		private System.Windows.Forms.ToolStripMenuItem _save;
		private System.Windows.Forms.ToolStripMenuItem _reload;
		private System.Windows.Forms.ToolStripMenuItem _stop;
		private System.Windows.Forms.Button _apply;
		private System.Windows.Forms.Button _revert;
		private System.Windows.Forms.Timer _statisticsTimer;
		private System.Windows.Forms.ToolStripMenuItem _updateStatistics;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}

