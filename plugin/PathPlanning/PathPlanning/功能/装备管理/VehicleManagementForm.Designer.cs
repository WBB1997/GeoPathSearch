
namespace PathPlanning
{
    partial class VehicleManagementForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_InVec = new System.Windows.Forms.Button();
            this.btn_RmVec = new System.Windows.Forms.Button();
            this.btn_AddVec = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.vecTypeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vecNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vecStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList_Vehicle = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Button = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel);
            this.splitContainer.Panel2.Controls.Add(this.listView);
            this.splitContainer.Size = new System.Drawing.Size(748, 460);
            this.splitContainer.SplitterDistance = 189;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(189, 460);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btn_Run);
            this.panel.Controls.Add(this.btn_InVec);
            this.panel.Controls.Add(this.btn_RmVec);
            this.panel.Controls.Add(this.btn_AddVec);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(485, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(69, 460);
            this.panel.TabIndex = 1;
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Run.Location = new System.Drawing.Point(12, 361);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(45, 90);
            this.btn_Run.TabIndex = 3;
            this.btn_Run.Text = "路径规划";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_InVec
            // 
            this.btn_InVec.Enabled = false;
            this.btn_InVec.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_InVec.Location = new System.Drawing.Point(19, 126);
            this.btn_InVec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InVec.Name = "btn_InVec";
            this.btn_InVec.Size = new System.Drawing.Size(32, 32);
            this.btn_InVec.TabIndex = 2;
            this.btn_InVec.Text = "*";
            this.btn_InVec.UseVisualStyleBackColor = true;
            // 
            // btn_RmVec
            // 
            this.btn_RmVec.Enabled = false;
            this.btn_RmVec.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_RmVec.Location = new System.Drawing.Point(19, 76);
            this.btn_RmVec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RmVec.Name = "btn_RmVec";
            this.btn_RmVec.Size = new System.Drawing.Size(32, 32);
            this.btn_RmVec.TabIndex = 1;
            this.btn_RmVec.Text = "-";
            this.btn_RmVec.UseVisualStyleBackColor = true;
            // 
            // btn_AddVec
            // 
            this.btn_AddVec.Enabled = false;
            this.btn_AddVec.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AddVec.Location = new System.Drawing.Point(19, 26);
            this.btn_AddVec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddVec.Name = "btn_AddVec";
            this.btn_AddVec.Size = new System.Drawing.Size(32, 32);
            this.btn_AddVec.TabIndex = 0;
            this.btn_AddVec.Text = "+";
            this.btn_AddVec.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(479, 460);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vecTypeLabel,
            this.vecNameLabel,
            this.vecStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 457);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(748, 29);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // vecTypeLabel
            // 
            this.vecTypeLabel.Name = "vecTypeLabel";
            this.vecTypeLabel.Size = new System.Drawing.Size(100, 24);
            this.vecTypeLabel.Text = "装备类型：";
            // 
            // vecNameLabel
            // 
            this.vecNameLabel.Name = "vecNameLabel";
            this.vecNameLabel.Size = new System.Drawing.Size(46, 24);
            this.vecNameLabel.Text = "名称";
            // 
            // vecStatusLabel
            // 
            this.vecStatusLabel.Name = "vecStatusLabel";
            this.vecStatusLabel.Size = new System.Drawing.Size(126, 24);
            this.vecStatusLabel.Text = "|  装备总数：0";
            // 
            // imageList_Vehicle
            // 
            this.imageList_Vehicle.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Vehicle.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Vehicle.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Button
            // 
            this.imageList_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Button.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Button.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // VehicleManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(748, 486);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleManagementForm";
            this.Text = "装备管理";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel vecTypeLabel;
        private System.Windows.Forms.ToolStripStatusLabel vecNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel vecStatusLabel;
        private System.Windows.Forms.ImageList imageList_Vehicle;
        private System.Windows.Forms.ImageList imageList_Button;
        private System.Windows.Forms.Button btn_InVec;
        private System.Windows.Forms.Button btn_RmVec;
        private System.Windows.Forms.Button btn_AddVec;
        private System.Windows.Forms.Button btn_Run;
    }
}