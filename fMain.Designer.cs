namespace SSOBufRegionEditor {
    partial class fMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openMenu = new ToolStripMenuItem();
            saveMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitMenu = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbStatus = new ToolStripStatusLabel();
            panel1 = new Panel();
            lbTimestamp = new Label();
            edtTimestamp = new TextBox();
            lbRegions = new Label();
            edtRegions = new TextBox();
            lbVersion = new Label();
            edtVersion = new TextBox();
            panel2 = new Panel();
            grid = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnRegionType = new DataGridViewTextBoxColumn();
            panelBottom = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btAdd = new Button();
            btEdit = new Button();
            btRemove = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            panelBottom.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(862, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenu, saveMenu, toolStripSeparator1, exitMenu });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openMenu
            // 
            openMenu.Name = "openMenu";
            openMenu.Size = new Size(103, 22);
            openMenu.Text = "Open";
            openMenu.Click += openMenu_Click;
            // 
            // saveMenu
            // 
            saveMenu.Enabled = false;
            saveMenu.Name = "saveMenu";
            saveMenu.Size = new Size(103, 22);
            saveMenu.Text = "Save";
            saveMenu.Click += saveMenu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(100, 6);
            // 
            // exitMenu
            // 
            exitMenu.Name = "exitMenu";
            exitMenu.Size = new Size(103, 22);
            exitMenu.Text = "Exit";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbStatus });
            statusStrip1.Location = new Point(0, 530);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(862, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(85, 17);
            lbStatus.Text = "No file opened";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTimestamp);
            panel1.Controls.Add(edtTimestamp);
            panel1.Controls.Add(lbRegions);
            panel1.Controls.Add(edtRegions);
            panel1.Controls.Add(lbVersion);
            panel1.Controls.Add(edtVersion);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(862, 63);
            panel1.TabIndex = 2;
            // 
            // lbTimestamp
            // 
            lbTimestamp.AutoSize = true;
            lbTimestamp.Location = new Point(236, 5);
            lbTimestamp.Name = "lbTimestamp";
            lbTimestamp.Size = new Size(66, 15);
            lbTimestamp.TabIndex = 5;
            lbTimestamp.Text = "Timestamp";
            // 
            // edtTimestamp
            // 
            edtTimestamp.Location = new Point(236, 23);
            edtTimestamp.Name = "edtTimestamp";
            edtTimestamp.ReadOnly = true;
            edtTimestamp.Size = new Size(166, 23);
            edtTimestamp.TabIndex = 4;
            // 
            // lbRegions
            // 
            lbRegions.AutoSize = true;
            lbRegions.Location = new Point(124, 5);
            lbRegions.Name = "lbRegions";
            lbRegions.Size = new Size(49, 15);
            lbRegions.TabIndex = 3;
            lbRegions.Text = "Regions";
            // 
            // edtRegions
            // 
            edtRegions.Location = new Point(124, 23);
            edtRegions.Name = "edtRegions";
            edtRegions.ReadOnly = true;
            edtRegions.Size = new Size(106, 23);
            edtRegions.TabIndex = 2;
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Location = new Point(12, 5);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(45, 15);
            lbVersion.TabIndex = 1;
            lbVersion.Text = "Version";
            // 
            // edtVersion
            // 
            edtVersion.Location = new Point(12, 23);
            edtVersion.Name = "edtVersion";
            edtVersion.ReadOnly = true;
            edtVersion.Size = new Size(106, 23);
            edtVersion.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(grid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 87);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(862, 409);
            panel2.TabIndex = 3;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { columnId, columnRegionType });
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(5, 5);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(852, 399);
            grid.TabIndex = 0;
            // 
            // columnId
            // 
            columnId.HeaderText = "ID";
            columnId.Name = "columnId";
            columnId.ReadOnly = true;
            columnId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnRegionType
            // 
            columnRegionType.HeaderText = "Region Type";
            columnRegionType.Name = "columnRegionType";
            columnRegionType.ReadOnly = true;
            columnRegionType.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnRegionType.Width = 350;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(flowLayoutPanel1);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 496);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(862, 34);
            panelBottom.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btAdd);
            flowLayoutPanel1.Controls.Add(btEdit);
            flowLayoutPanel1.Controls.Add(btRemove);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(617, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 34);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btAdd
            // 
            btAdd.Enabled = false;
            btAdd.Location = new Point(3, 3);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 0;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btEdit
            // 
            btEdit.Enabled = false;
            btEdit.Location = new Point(84, 3);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(75, 23);
            btEdit.TabIndex = 1;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btRemove
            // 
            btRemove.Enabled = false;
            btRemove.Location = new Point(165, 3);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(75, 23);
            btRemove.TabIndex = 2;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 552);
            Controls.Add(panel2);
            Controls.Add(panelBottom);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kuroro Bufregion Editor v0.3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            panelBottom.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openMenu;
        private ToolStripMenuItem saveMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitMenu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbStatus;
        private Panel panel1;
        private Panel panel2;
        private DataGridView grid;
        private TextBox edtVersion;
        private Label lbTimestamp;
        private TextBox edtTimestamp;
        private Label lbRegions;
        private TextBox edtRegions;
        private Label lbVersion;
        private Panel panelBottom;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btAdd;
        private Button btEdit;
        private Button btRemove;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnRegionType;
    }
}
