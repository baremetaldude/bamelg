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
			this._connections = new System.Windows.Forms.ListView();
			this._tableEndpoints = new System.Windows.Forms.TableLayoutPanel();
			this._menu = new System.Windows.Forms.MenuStrip();
			this._registry = new System.Windows.Forms.ToolStripMenuItem();
			this._registrySave = new System.Windows.Forms.ToolStripMenuItem();
			this._registryReload = new System.Windows.Forms.ToolStripMenuItem();
			this._status = new System.Windows.Forms.StatusStrip();
			this._statusText = new System.Windows.Forms.ToolStripStatusLabel();
			this._trace = new System.Windows.Forms.ToolStripMenuItem();
			this._endpoint1 = new BamelgForwarderSetup.EndpointProperties();
			this._endpoint2 = new BamelgForwarderSetup.EndpointProperties();
			this._tableEndpoints.SuspendLayout();
			this._menu.SuspendLayout();
			this._status.SuspendLayout();
			this.SuspendLayout();
			// 
			// _connections
			// 
			this._connections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._connections.Location = new System.Drawing.Point(12, 27);
			this._connections.Name = "_connections";
			this._connections.Size = new System.Drawing.Size(121, 315);
			this._connections.TabIndex = 0;
			this._connections.UseCompatibleStateImageBehavior = false;
			// 
			// _tableEndpoints
			// 
			this._tableEndpoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._tableEndpoints.ColumnCount = 1;
			this._tableEndpoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableEndpoints.Controls.Add(this._endpoint1, 0, 0);
			this._tableEndpoints.Controls.Add(this._endpoint2, 0, 1);
			this._tableEndpoints.Location = new System.Drawing.Point(139, 12);
			this._tableEndpoints.Name = "_tableEndpoints";
			this._tableEndpoints.RowCount = 2;
			this._tableEndpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableEndpoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableEndpoints.Size = new System.Drawing.Size(315, 330);
			this._tableEndpoints.TabIndex = 3;
			// 
			// _menu
			// 
			this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._registry});
			this._menu.Location = new System.Drawing.Point(0, 0);
			this._menu.Name = "_menu";
			this._menu.Size = new System.Drawing.Size(466, 24);
			this._menu.TabIndex = 5;
			this._menu.Text = "menuStrip2";
			// 
			// _registry
			// 
			this._registry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._trace,
            this._registrySave,
            this._registryReload});
			this._registry.Name = "_registry";
			this._registry.Size = new System.Drawing.Size(59, 20);
			this._registry.Text = "Control";
			// 
			// _registrySave
			// 
			this._registrySave.Name = "_registrySave";
			this._registrySave.Size = new System.Drawing.Size(152, 22);
			this._registrySave.Text = "Save";
			// 
			// _registryReload
			// 
			this._registryReload.Name = "_registryReload";
			this._registryReload.Size = new System.Drawing.Size(152, 22);
			this._registryReload.Text = "Reload";
			this._registryReload.Click += new System.EventHandler(this._registryReload_Click);
			// 
			// _status
			// 
			this._status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusText});
			this._status.Location = new System.Drawing.Point(0, 345);
			this._status.Name = "_status";
			this._status.Size = new System.Drawing.Size(466, 22);
			this._status.TabIndex = 6;
			this._status.Text = "statusStrip1";
			// 
			// _statusText
			// 
			this._statusText.Name = "_statusText";
			this._statusText.Size = new System.Drawing.Size(39, 17);
			this._statusText.Text = "Status";
			// 
			// _trace
			// 
			this._trace.Name = "_trace";
			this._trace.Size = new System.Drawing.Size(152, 22);
			this._trace.Text = "Trace";
			this._trace.Click += new System.EventHandler(this._trace_Click);
			// 
			// _endpoint1
			// 
			this._endpoint1.Dock = System.Windows.Forms.DockStyle.Fill;
			this._endpoint1.Location = new System.Drawing.Point(3, 3);
			this._endpoint1.Name = "_endpoint1";
			this._endpoint1.Size = new System.Drawing.Size(309, 159);
			this._endpoint1.TabIndex = 1;
			// 
			// _endpoint2
			// 
			this._endpoint2.Dock = System.Windows.Forms.DockStyle.Fill;
			this._endpoint2.Location = new System.Drawing.Point(3, 168);
			this._endpoint2.Name = "_endpoint2";
			this._endpoint2.Size = new System.Drawing.Size(309, 159);
			this._endpoint2.TabIndex = 2;
			// 
			// Setup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 367);
			this.Controls.Add(this._status);
			this.Controls.Add(this._tableEndpoints);
			this.Controls.Add(this._connections);
			this.Controls.Add(this._menu);
			this.MinimumSize = new System.Drawing.Size(482, 406);
			this.Name = "Setup";
			this.Text = "BamelgForwarder setup";
			this.Shown += new System.EventHandler(this.Setup_Shown);
			this._tableEndpoints.ResumeLayout(false);
			this._menu.ResumeLayout(false);
			this._menu.PerformLayout();
			this._status.ResumeLayout(false);
			this._status.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView _connections;
		private EndpointProperties _endpoint1;
		private EndpointProperties _endpoint2;
		private System.Windows.Forms.TableLayoutPanel _tableEndpoints;
		private System.Windows.Forms.MenuStrip _menu;
		private System.Windows.Forms.ToolStripMenuItem _registry;
		private System.Windows.Forms.ToolStripMenuItem _registrySave;
		private System.Windows.Forms.ToolStripMenuItem _registryReload;
		private System.Windows.Forms.ToolStripMenuItem _trace;
		private System.Windows.Forms.StatusStrip _status;
		private System.Windows.Forms.ToolStripStatusLabel _statusText;
	}
}

