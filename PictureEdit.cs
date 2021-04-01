using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class PictureEdit : Form
    {
        private FileHelper<List<Picture>> _fileHelper = new FileHelper<List<Picture>>(Program.FilePath);

        public PictureEdit()
        {
            InitializeComponent();
            LoadData();

            pbMiniature.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void LoadData()
        {
            dgvPictureList.DataSource = _fileHelper.DeserializeFromFile();
        }

        private void dgvPictureList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var listOfPictures = _fileHelper.DeserializeFromFile();

            string path = dgvPictureList.SelectedRows[0].Cells[1].Value.ToString();

            try 
            {
                pbMiniature.ImageLocation = path;
            }
            catch (Exception)
            {
                MessageBox.Show("Nie istnieje obrazek pod podaną ścieżką");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var listOfPictures = _fileHelper.DeserializeFromFile();
            int selectedPictureIndex = Convert.ToInt32(dgvPictureList.SelectedRows[0].Cells[0].Value);

            if (dgvPictureList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz zdjęcie do usunięcia");
            }
            else
            {
                listOfPictures.RemoveAll(x => x.Number == selectedPictureIndex);
                _fileHelper.SerializeToFile(listOfPictures);

                SetNewNumberOrder();
                LoadData();
            }
        }

        private void SetNewNumberOrder()
        {
            var listOfPictures = _fileHelper.DeserializeFromFile();

            for (int x = 1; x <= listOfPictures.Count; x++)
                listOfPictures[x - 1].Number = x;

            _fileHelper.SerializeToFile(listOfPictures);
            LoadData();
        }
    }
}
