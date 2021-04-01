using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Main : Form
    {
        private FileHelper<List<Picture>> _fileHelper = new FileHelper<List<Picture>>(Program.FilePath);

        // Index of picture which is currently displaying
        private int CurrentIndex = 1;

        public Main()
        {
            InitializeComponent();
            PictureBoxSettings();

            LoadListOfPictures();

            // Default setting - 5 seconds of interval between each picture
            timerSlideShow.Interval = 5000;
        }

        private void PictureBoxSettings()
        {
            pbViewer.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void LoadListOfPictures()
        {
            var listOfPictures = _fileHelper.DeserializeFromFile();
            pbViewer.ImageLocation = listOfPictures[0].PicturePath;
        }

        private void btnEditPictures_Click(object sender, EventArgs e)
        {
            var pictureEdit = new PictureEdit();
            pictureEdit.ShowDialog();
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            fbdSelectPicture.ShowDialog();
            var path = fbdSelectPicture.SelectedPath;
            var fileBrowser = new FileBrowser(path);

            fileBrowser.PictureAdded += FileBrowser_PictureAdded;
            fileBrowser.ShowDialog();
            fileBrowser.PictureAdded -= FileBrowser_PictureAdded;
        }

        private void FileBrowser_PictureAdded()
        {
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pbViewer_SizeChanged(object sender, EventArgs e)
        {
            if (pbViewer.Width < pbViewer.Image.Width || pbViewer.Height < pbViewer.Image.Height)
                pbViewer.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pbViewer.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void cbSlideShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSlideShow.Checked)
            {
                nudSlideChangeTime.Enabled = true;
                timerSlideShow.Enabled = true;
                lblChange1.ForeColor = Color.Black;
                lblChange2.ForeColor = Color.Black;
            }
            else
            {
                nudSlideChangeTime.Enabled = false;
                timerSlideShow.Enabled = false;
                lblChange1.ForeColor = Color.Gray;
                lblChange2.ForeColor = Color.Gray;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            DisplayPrevious();
        }

        private void DisplayPrevious()
        {
            var listOfPictures = _fileHelper.DeserializeFromFile();

            if (listOfPictures.Count > 0)
            {
                CurrentIndex--;
                if (CurrentIndex < 1)
                    CurrentIndex = listOfPictures.Count;
                try
                {
                    pbViewer.ImageLocation = listOfPictures[CurrentIndex - 1].PicturePath;
                    lbPictureNumber.Text = Convert.ToString(CurrentIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("Obrazek nie istnieje pod danym adresem");
                }
            }

            if (listOfPictures.Count == 0)
                pbViewer.Image = null;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisplayNext();
        }

        private void DisplayNext()
        {
            var listOfPictures = _fileHelper.DeserializeFromFile();

            if (listOfPictures.Count > 0)
            {
                CurrentIndex++;
                if (CurrentIndex > listOfPictures.Count)
                    CurrentIndex = 1;
                try
                {
                    pbViewer.ImageLocation = listOfPictures[CurrentIndex - 1].PicturePath;
                    lbPictureNumber.Text = Convert.ToString(CurrentIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("Obrazek nie istnieje pod danym adresem");
                }
            }

            if (listOfPictures.Count == 0)
                pbViewer.Image = null;
        }

        private void nudSlideChangeTime_ValueChanged(object sender, EventArgs e)
        {
            timerSlideShow.Interval = Convert.ToInt32(nudSlideChangeTime.Value * 1000);
        }

        private void timerSlideShow_Tick(object sender, EventArgs e)
        {
            DisplayNext();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
