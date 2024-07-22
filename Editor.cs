using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSOBufRegionEditor {
    public partial class Editor : Form {
        private fMain parent;
        private List<Vector2> localPoints;
        private Data region;
        public Result result = Result.CANCELED;

        public enum Result {
            CANCELED,
            SAVED
        }

        public Editor(fMain parent, Data region) {
            InitializeComponent();
            this.parent = parent;
            this.region = region;

            load();
        }

        private void enablePoints(bool enable) {
            gridPoints.Enabled = enable;
            btAdd.Enabled = enable;
            btRemovePoint.Enabled = enable;

            if (enable) {
                gridPoints.Enabled = true;
                gridPoints.DefaultCellStyle.BackColor = Color.White; // or your default color
                gridPoints.DefaultCellStyle.ForeColor = Color.Black; // or your default color
                gridPoints.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver; // or your default color
                gridPoints.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // or your default color
            } else {
                gridPoints.Enabled = false;
                gridPoints.DefaultCellStyle.BackColor = Color.Gray; // or any color indicating disabled state
                gridPoints.DefaultCellStyle.ForeColor = Color.DarkGray; // or any color indicating disabled state
                gridPoints.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray; // or any color indicating disabled state
                gridPoints.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkGray; // or any color indicating disabled state
            }
            gridPoints.Refresh();
        }

        private void save() {
            region.id = int.Parse(edtId.Text);
            region.regionType = (BuffRegionType)comboRegionType.SelectedIndex;
            region.len = float.Parse(edtLength.Text);
            region.radius = float.Parse(edtRadius.Text);
            region.width = float.Parse(edtWidth.Text);
            region.heightLowerLimit = float.Parse(edtHeightLowerLimit.Text);
            region.heightUpperLimit = float.Parse(edtHeightUpperLimit.Text);
            region.skillEnter = int.Parse(edtSkillEnter.Text);
            region.skillLevelEnter = int.Parse(edtSkillEnterLevel.Text);
            region.skillLeave = int.Parse(edtSkillLeave.Text);
            region.skillLevelLeave = int.Parse(edtSkillLeaveLevel.Text);
            region.maxCharacterNum = int.Parse(edtMaxCharacterCount.Text);
            region.pos.x = float.Parse(edtPositionX.Text);
            region.pos.z = float.Parse(edtPositionZ.Text);
            region.taskEnter = int.Parse(edtTaskEnter.Text);
            region.taskLeave = int.Parse(edtTaskLeave.Text);
            region.misteryousNumber = int.Parse(edtMiNum.Text);

            region.playerValid = constraints.GetItemChecked(0);
            region.petValid = constraints.GetItemChecked(1);
            region.diedRegion = constraints.GetItemChecked(2);
            region.noRepeat = constraints.GetItemChecked(3);
            region.monsterBornValid = constraints.GetItemChecked(4);
            region.initValid = constraints.GetItemChecked(5);

            if (region.regionType != BuffRegionType.BUF_REGION_POLYGON) {
                localPoints.Clear();
                gridPoints.Rows.Clear();
            }

            for (var i = 0; i < gridPoints.Rows.Count; i++) {
                var row = gridPoints.Rows[i];
                localPoints[i].x = float.Parse(row.Cells[0].Value.ToString());
                localPoints[i].z = float.Parse(row.Cells[1].Value.ToString());
            }

            region.points = localPoints;

        }

        private void load() {
            localPoints = new List<Vector2>();

            foreach (var point in region.points) {
                Vector2 copyPoint = new Vector2();
                copyPoint.x = point.x;
                copyPoint.z = point.z;
                localPoints.Add(copyPoint);
            }

            edtId.Text = region.id.ToString();
            comboRegionType.SelectedIndex = (int)region.regionType;
            edtLength.Text = region.len.ToString();
            edtWidth.Text = region.width.ToString();
            edtRadius.Text = region.radius.ToString();
            edtHeightLowerLimit.Text = region.heightLowerLimit.ToString();
            edtHeightUpperLimit.Text = region.heightUpperLimit.ToString();
            edtSkillEnter.Text = region.skillEnter.ToString();
            edtSkillEnterLevel.Text = region.skillLevelEnter.ToString();
            edtSkillLeave.Text = region.skillLeave.ToString();
            edtSkillLeaveLevel.Text = region.skillLevelLeave.ToString();
            edtMaxCharacterCount.Text = region.maxCharacterNum.ToString();
            edtPositionX.Text = region.pos.x.ToString();
            edtPositionZ.Text = region.pos.z.ToString();
            edtTaskEnter.Text = region.taskEnter.ToString();
            edtTaskLeave.Text = region.taskLeave.ToString();
            edtMiNum.Text = region.misteryousNumber.ToString();

            constraints.SetItemChecked(0, region.playerValid);
            constraints.SetItemChecked(1, region.petValid);
            constraints.SetItemChecked(2, region.diedRegion);
            constraints.SetItemChecked(3, region.noRepeat);
            constraints.SetItemChecked(4, region.monsterBornValid);
            constraints.SetItemChecked(5, region.initValid);

            gridPoints.Rows.Clear();
            foreach (var point in localPoints)
                gridPoints.Rows.Add(
                    point.x,
                    point.z
                );

            enablePoints(region.regionType == BuffRegionType.BUF_REGION_POLYGON);
        }

        private void btSave_Click(object sender, EventArgs e) {
            save();
            result = Result.SAVED;
            Close();
        }

        private void integerEditKeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                !(e.KeyChar == '-' && (sender as TextBox).SelectionStart == 0))
                e.Handled = true;
        }

        private void floatEditKeyPress(object sender, KeyPressEventArgs e) {
            var decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar.ToString() != decimalSeparator &&
                !(e.KeyChar == '-' && (sender as TextBox).SelectionStart == 0)) {
                e.Handled = true;
            }

            if (e.KeyChar.ToString() == decimalSeparator && (sender as TextBox).Text.IndexOf(decimalSeparator) > -1 ||
                e.KeyChar == '-' && (sender as TextBox).Text.IndexOf(e.KeyChar) > -1) {
                e.Handled = true;
            }
        }

        private void btAdd_Click(object sender, EventArgs e) {
            gridPoints.Rows.Add(0, 0);
            Vector2 newPoint = new Vector2();
            newPoint.x = 0;
            newPoint.z = 0;
            localPoints.Add(newPoint);
        }

        private void btRemovePoint_Click(object sender, EventArgs e) {
            var currentCell = gridPoints.CurrentCell;
            if (currentCell == null) return;

            var currentRow = currentCell.RowIndex;
            localPoints.RemoveAt(currentRow);
            gridPoints.Rows.RemoveAt(currentRow);
        }

        private void btClose_Click(object sender, EventArgs e) {
            result = Result.CANCELED;
            Close();
        }

        private void comboRegionType_SelectedIndexChanged(object sender, EventArgs e) {
            enablePoints(comboRegionType.SelectedIndex == (int)BuffRegionType.BUF_REGION_POLYGON);
        }
    }
}
