namespace SSOBufRegionEditor {
    partial class Editor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lbId = new Label();
            label1 = new Label();
            lbWidth = new Label();
            lbRadius = new Label();
            lbType = new Label();
            comboRegionType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            constraints = new CheckedListBox();
            lbConstraints = new Label();
            gridPoints = new DataGridView();
            columnX = new DataGridViewTextBoxColumn();
            columnZ = new DataGridViewTextBoxColumn();
            label11 = new Label();
            btRemovePoint = new Button();
            btAdd = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btClose = new Button();
            btSave = new Button();
            label12 = new Label();
            label13 = new Label();
            edtId = new TextBox();
            edtLength = new TextBox();
            edtWidth = new TextBox();
            edtRadius = new TextBox();
            edtHeightLowerLimit = new TextBox();
            edtHeightUpperLimit = new TextBox();
            edtSkillEnter = new TextBox();
            edtSkillEnterLevel = new TextBox();
            edtSkillLeave = new TextBox();
            edtSkillLeaveLevel = new TextBox();
            edtMaxCharacterCount = new TextBox();
            edtPositionX = new TextBox();
            edtPositionZ = new TextBox();
            edtTaskEnter = new TextBox();
            edtTaskLeave = new TextBox();
            edtMiNum = new TextBox();
            lbMiNum = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPoints).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(12, 8);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 0;
            lbId.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 8);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Length";
            // 
            // lbWidth
            // 
            lbWidth.AutoSize = true;
            lbWidth.Location = new Point(264, 8);
            lbWidth.Name = "lbWidth";
            lbWidth.Size = new Size(39, 15);
            lbWidth.TabIndex = 4;
            lbWidth.Text = "Width";
            // 
            // lbRadius
            // 
            lbRadius.AutoSize = true;
            lbRadius.Location = new Point(390, 8);
            lbRadius.Name = "lbRadius";
            lbRadius.Size = new Size(42, 15);
            lbRadius.TabIndex = 6;
            lbRadius.Text = "Radius";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(12, 55);
            lbType.Name = "lbType";
            lbType.Size = new Size(71, 15);
            lbType.TabIndex = 8;
            lbType.Text = "Region Type";
            // 
            // comboRegionType
            // 
            comboRegionType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRegionType.FormattingEnabled = true;
            comboRegionType.Items.AddRange(new object[] { "BUF_REGION_RECT", "BUF_REGION_CIRCLE", "BUF_REGION_POLYGON" });
            comboRegionType.Location = new Point(12, 73);
            comboRegionType.Name = "comboRegionType";
            comboRegionType.Size = new Size(246, 23);
            comboRegionType.TabIndex = 9;
            comboRegionType.SelectedIndexChanged += comboRegionType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 56);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 10;
            label2.Text = "Height Lower Limit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 56);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 12;
            label3.Text = "Height Upper Limit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 14;
            label4.Text = "Skill Enter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 104);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 16;
            label5.Text = "Skill Enter Level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 104);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 18;
            label6.Text = "Skill Leave";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 104);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 20;
            label7.Text = "Skill Leave Level";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 153);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 22;
            label8.Text = "Max Character Count";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(264, 153);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 26;
            label9.Text = "Position Z";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(138, 153);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 24;
            label10.Text = "Position X";
            // 
            // constraints
            // 
            constraints.FormattingEnabled = true;
            constraints.Items.AddRange(new object[] { "Player Valid", "Pet Valid", "Died Region", "No Repeat", "Monster Born Valid", "Init Valid" });
            constraints.Location = new Point(264, 275);
            constraints.Name = "constraints";
            constraints.Size = new Size(246, 238);
            constraints.TabIndex = 28;
            // 
            // lbConstraints
            // 
            lbConstraints.AutoSize = true;
            lbConstraints.Location = new Point(264, 257);
            lbConstraints.Name = "lbConstraints";
            lbConstraints.Size = new Size(67, 15);
            lbConstraints.TabIndex = 29;
            lbConstraints.Text = "Constraints";
            // 
            // gridPoints
            // 
            gridPoints.AllowUserToAddRows = false;
            gridPoints.AllowUserToDeleteRows = false;
            gridPoints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPoints.Columns.AddRange(new DataGridViewColumn[] { columnX, columnZ });
            gridPoints.Location = new Point(12, 275);
            gridPoints.Name = "gridPoints";
            gridPoints.RowHeadersVisible = false;
            gridPoints.Size = new Size(248, 213);
            gridPoints.TabIndex = 30;
            // 
            // columnX
            // 
            columnX.HeaderText = "X";
            columnX.Name = "columnX";
            // 
            // columnZ
            // 
            columnZ.HeaderText = "Z";
            columnZ.Name = "columnZ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 257);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 31;
            label11.Text = "Points";
            // 
            // btRemovePoint
            // 
            btRemovePoint.Enabled = false;
            btRemovePoint.Location = new Point(185, 494);
            btRemovePoint.Name = "btRemovePoint";
            btRemovePoint.Size = new Size(75, 23);
            btRemovePoint.TabIndex = 32;
            btRemovePoint.Text = "Remove";
            btRemovePoint.UseVisualStyleBackColor = true;
            btRemovePoint.Click += btRemovePoint_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(106, 494);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 33;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btClose);
            flowLayoutPanel1.Controls.Add(btSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 524);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(524, 42);
            flowLayoutPanel1.TabIndex = 34;
            // 
            // btClose
            // 
            btClose.Location = new Point(436, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 1;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(355, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 0;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(138, 207);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 37;
            label12.Text = "Task Leave";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 207);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 35;
            label13.Text = "Task Enter";
            // 
            // edtId
            // 
            edtId.Location = new Point(12, 26);
            edtId.Name = "edtId";
            edtId.Size = new Size(120, 23);
            edtId.TabIndex = 38;
            edtId.KeyPress += integerEditKeyPress;
            // 
            // edtLength
            // 
            edtLength.Location = new Point(138, 26);
            edtLength.Name = "edtLength";
            edtLength.Size = new Size(120, 23);
            edtLength.TabIndex = 39;
            edtLength.KeyPress += floatEditKeyPress;
            // 
            // edtWidth
            // 
            edtWidth.Location = new Point(264, 26);
            edtWidth.Name = "edtWidth";
            edtWidth.Size = new Size(120, 23);
            edtWidth.TabIndex = 40;
            edtWidth.KeyPress += floatEditKeyPress;
            // 
            // edtRadius
            // 
            edtRadius.Location = new Point(390, 26);
            edtRadius.Name = "edtRadius";
            edtRadius.Size = new Size(120, 23);
            edtRadius.TabIndex = 41;
            edtRadius.KeyPress += floatEditKeyPress;
            // 
            // edtHeightLowerLimit
            // 
            edtHeightLowerLimit.Location = new Point(264, 73);
            edtHeightLowerLimit.Name = "edtHeightLowerLimit";
            edtHeightLowerLimit.Size = new Size(120, 23);
            edtHeightLowerLimit.TabIndex = 42;
            edtHeightLowerLimit.KeyPress += floatEditKeyPress;
            // 
            // edtHeightUpperLimit
            // 
            edtHeightUpperLimit.Location = new Point(390, 73);
            edtHeightUpperLimit.Name = "edtHeightUpperLimit";
            edtHeightUpperLimit.Size = new Size(120, 23);
            edtHeightUpperLimit.TabIndex = 43;
            edtHeightUpperLimit.KeyPress += floatEditKeyPress;
            // 
            // edtSkillEnter
            // 
            edtSkillEnter.Location = new Point(12, 122);
            edtSkillEnter.Name = "edtSkillEnter";
            edtSkillEnter.Size = new Size(120, 23);
            edtSkillEnter.TabIndex = 44;
            edtSkillEnter.KeyPress += integerEditKeyPress;
            // 
            // edtSkillEnterLevel
            // 
            edtSkillEnterLevel.Location = new Point(138, 122);
            edtSkillEnterLevel.Name = "edtSkillEnterLevel";
            edtSkillEnterLevel.Size = new Size(120, 23);
            edtSkillEnterLevel.TabIndex = 45;
            edtSkillEnterLevel.KeyPress += integerEditKeyPress;
            // 
            // edtSkillLeave
            // 
            edtSkillLeave.Location = new Point(264, 122);
            edtSkillLeave.Name = "edtSkillLeave";
            edtSkillLeave.Size = new Size(120, 23);
            edtSkillLeave.TabIndex = 46;
            edtSkillLeave.KeyPress += integerEditKeyPress;
            // 
            // edtSkillLeaveLevel
            // 
            edtSkillLeaveLevel.Location = new Point(390, 122);
            edtSkillLeaveLevel.Name = "edtSkillLeaveLevel";
            edtSkillLeaveLevel.Size = new Size(120, 23);
            edtSkillLeaveLevel.TabIndex = 47;
            edtSkillLeaveLevel.KeyPress += integerEditKeyPress;
            // 
            // edtMaxCharacterCount
            // 
            edtMaxCharacterCount.Location = new Point(12, 171);
            edtMaxCharacterCount.Name = "edtMaxCharacterCount";
            edtMaxCharacterCount.Size = new Size(120, 23);
            edtMaxCharacterCount.TabIndex = 48;
            edtMaxCharacterCount.KeyPress += integerEditKeyPress;
            // 
            // edtPositionX
            // 
            edtPositionX.Location = new Point(140, 171);
            edtPositionX.Name = "edtPositionX";
            edtPositionX.Size = new Size(120, 23);
            edtPositionX.TabIndex = 49;
            edtPositionX.KeyPress += floatEditKeyPress;
            // 
            // edtPositionZ
            // 
            edtPositionZ.Location = new Point(264, 171);
            edtPositionZ.Name = "edtPositionZ";
            edtPositionZ.Size = new Size(120, 23);
            edtPositionZ.TabIndex = 50;
            edtPositionZ.KeyPress += floatEditKeyPress;
            // 
            // edtTaskEnter
            // 
            edtTaskEnter.Location = new Point(12, 225);
            edtTaskEnter.Name = "edtTaskEnter";
            edtTaskEnter.Size = new Size(120, 23);
            edtTaskEnter.TabIndex = 51;
            edtTaskEnter.KeyPress += integerEditKeyPress;
            // 
            // edtTaskLeave
            // 
            edtTaskLeave.Location = new Point(138, 225);
            edtTaskLeave.Name = "edtTaskLeave";
            edtTaskLeave.Size = new Size(120, 23);
            edtTaskLeave.TabIndex = 52;
            edtTaskLeave.KeyPress += integerEditKeyPress;
            // 
            // edtMiNum
            // 
            edtMiNum.Location = new Point(390, 171);
            edtMiNum.Name = "edtMiNum";
            edtMiNum.Size = new Size(120, 23);
            edtMiNum.TabIndex = 54;
            edtMiNum.KeyPress += integerEditKeyPress;
            // 
            // lbMiNum
            // 
            lbMiNum.AutoSize = true;
            lbMiNum.Location = new Point(390, 153);
            lbMiNum.Name = "lbMiNum";
            lbMiNum.Size = new Size(48, 15);
            lbMiNum.TabIndex = 53;
            lbMiNum.Text = "MiNum";
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 566);
            Controls.Add(edtMiNum);
            Controls.Add(lbMiNum);
            Controls.Add(edtTaskLeave);
            Controls.Add(edtTaskEnter);
            Controls.Add(edtPositionZ);
            Controls.Add(edtPositionX);
            Controls.Add(edtMaxCharacterCount);
            Controls.Add(edtSkillLeaveLevel);
            Controls.Add(edtSkillLeave);
            Controls.Add(edtSkillEnterLevel);
            Controls.Add(edtSkillEnter);
            Controls.Add(edtHeightUpperLimit);
            Controls.Add(edtHeightLowerLimit);
            Controls.Add(edtRadius);
            Controls.Add(edtWidth);
            Controls.Add(edtLength);
            Controls.Add(edtId);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btAdd);
            Controls.Add(btRemovePoint);
            Controls.Add(label11);
            Controls.Add(gridPoints);
            Controls.Add(lbConstraints);
            Controls.Add(constraints);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboRegionType);
            Controls.Add(lbType);
            Controls.Add(lbRadius);
            Controls.Add(lbWidth);
            Controls.Add(label1);
            Controls.Add(lbId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Editor";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Region Edit";
            ((System.ComponentModel.ISupportInitialize)gridPoints).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label label1;
        private Label lbWidth;
        private Label lbRadius;
        private Label lbType;
        private ComboBox comboRegionType;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckedListBox constraints;
        private Label lbConstraints;
        private DataGridView gridPoints;
        private DataGridViewTextBoxColumn columnX;
        private DataGridViewTextBoxColumn columnZ;
        private Label label11;
        private Button btRemovePoint;
        private Button btAdd;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btSave;
        private Button btClose;
        private Label label12;
        private Label label13;
        private TextBox edtId;
        private TextBox edtLength;
        private TextBox edtWidth;
        private TextBox edtRadius;
        private TextBox edtHeightLowerLimit;
        private TextBox edtHeightUpperLimit;
        private TextBox edtSkillEnter;
        private TextBox edtSkillEnterLevel;
        private TextBox edtSkillLeave;
        private TextBox edtSkillLeaveLevel;
        private TextBox edtMaxCharacterCount;
        private TextBox edtPositionX;
        private TextBox edtPositionZ;
        private TextBox edtTaskEnter;
        private TextBox edtTaskLeave;
        private TextBox edtMiNum;
        private Label lbMiNum;
    }
}