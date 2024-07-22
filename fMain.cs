using System.Windows.Forms;

namespace SSOBufRegionEditor {
    public partial class fMain : Form {
        private String filename;
        public Header header;
        public List<Data> regions;
        public fMain() {
            InitializeComponent();
        }

        private void openMenu_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "SEV files (*.sev)|*.sev";
            openFileDialog.Title = "Select bufregion.sev";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                filename = openFileDialog.FileName;

                open();
            }
        }

        public void save() {
            lbStatus.Text = $"Saving {filename} ...";
            var file = File.Open(filename, FileMode.Create);
            var writer = new BinaryWriter(file);

            header.write(writer);
            foreach (var region in regions)
                region.write(writer);

            writer.Close();
            file.Close();

            reload();
        }

        public void open() {
            lbStatus.Text = $"Reading {filename} ...";
            var file = File.Open(filename, FileMode.Open);
            var reader = new BinaryReader(file);

            header = new Header();
            regions = new List<Data>();

            header.read(reader);
            for (var i = 0; i < header.regionCount; i++) {
                var data = new Data(header);
                data.read(reader);
                regions.Add(data);
            }

            reader.Close();
            file.Close();

            reload();
        }

        public void reload() {
            edtVersion.Text = header.version.ToString();
            edtRegions.Text = regions.Count.ToString();
            edtTimestamp.Text = header.timestamp.ToString();

            grid.Rows.Clear();

            foreach (var data in regions) {
                grid.Rows.Add(
                    data.id,
                    data.regionType.ToString()
                );
            }

            lbStatus.Text = $"File: {filename}";
            enableControls(true);
        }

        public void enableControls(bool enable) {
            btAdd.Enabled = enable;
            btEdit.Enabled = enable;
            btRemove.Enabled = enable;
            saveMenu.Enabled = enable;
        }

        private void btEdit_Click(object sender, EventArgs e) {
            var currentRow = grid.CurrentRow;
            if (currentRow == null) return;

            var index = currentRow.Index;

            Editor editor = new Editor(this, regions[index]);
            editor.ShowDialog();

            if (editor.result == Editor.Result.SAVED)
                reload();
        }

        private void btAdd_Click(object sender, EventArgs e) {
            Data newRegion = new Data(header);

            Editor editor = new Editor(this, newRegion);
            editor.ShowDialog();

            if (editor.result == Editor.Result.SAVED) {
                regions.Add(newRegion);
                header.regionCount = regions.Count;
                reload();
            }
        }

        private void saveMenu_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "SEV files (*.sev)|*.sev";
            saveFileDialog.Title = "Select a .sev file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                filename = saveFileDialog.FileName;

                save();
            }
        }

        private void btRemove_Click(object sender, EventArgs e) {
            var currentRow = grid.CurrentRow;
            if (currentRow == null) return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                var index = currentRow.Index;
                regions.RemoveAt(index);
                reload();
            }
        }

        private void getInfoFromAllMaps() {
            var path = "D:\\maps\\maps";
            var output = "";

            string[] directories = Directory.GetDirectories(path);

            foreach (string directory in directories) {
                if (!File.Exists(directory + "\\bufregion.sev"))
                    continue;

                var filename = directory + "\\bufregion.sev";
                var directoryName = Path.GetFileName(directory);

                var file = File.Open(filename, FileMode.Open);
                var reader = new BinaryReader(file);

                var header = new Header();
                var regions = new List<Data>();

                header.read(reader);
                for (var i = 0; i < header.regionCount; i++) {
                    var data = new Data(header);
                    data.read(reader);
                    regions.Add(data);
                }

                reader.Close();
                file.Close();

                foreach (var region in regions) {
                    output += $"{directoryName};{header.version};{region.id}\n";
                }
            }

            File.WriteAllText("D:\\maps\\sheet.csv", output);
        }

        private void tEMPToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }
    }
}
