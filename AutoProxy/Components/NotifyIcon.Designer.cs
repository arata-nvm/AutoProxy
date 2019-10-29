namespace AutoProxy.Components
{
    partial class NotifyIcon
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIcon));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAutorunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsetAutorunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.reloadConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAutorunMenuItem,
            this.unsetAutorunMenuItem,
            this.reloadConfigMenuItem,
            this.exitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            // 
            // setAutorunMenuItem
            // 
            this.setAutorunMenuItem.Name = "setAutorunMenuItem";
            this.setAutorunMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setAutorunMenuItem.Text = "AddAutorun";
            // 
            // unsetAutorunMenuItem
            // 
            this.unsetAutorunMenuItem.Name = "unsetAutorunMenuItem";
            this.unsetAutorunMenuItem.Size = new System.Drawing.Size(160, 22);
            this.unsetAutorunMenuItem.Text = "RemoveAutorun";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AutoProxy";
            this.notifyIcon1.Visible = true;
            // 
            // reloadConfigMenuItem
            // 
            this.reloadConfigMenuItem.Name = "reloadConfigMenuItem";
            this.reloadConfigMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reloadConfigMenuItem.Text = "ReloadConfig";
            this.contextMenuStrip1.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAutorunMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsetAutorunMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadConfigMenuItem;
    }
}
