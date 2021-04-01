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
    public partial class FileBrowser : Form
    {
        private FileHelper<List<Picture>> _fileHelper = new FileHelper<List<Picture>>(Program.FilePath);

        private string _path;
        private List<string> listOfImages = new List<string>();

        ImageList largeImages = new ImageList();
        ImageList images = new ImageList();

        public delegate void MyDelegate();
        public event MyDelegate PictureAdded;

        public FileBrowser(string path)
        {
            InitializeComponent();

            _path = path;
            AddFilesToBrowser();
            lvImages.View = View.SmallIcon;
        }

        private void OnPictureAdded()
        {
            PictureAdded?.Invoke();
        }

        public void AddFilesToBrowser()
        {
            images.ImageSize = new Size(80, 80);
            lvImages.SmallImageList = images;

            int imagesQuantity = 0;
            try
            {
                foreach (string item in Directory.GetFiles(_path))
                {
                    if (item.Contains(".jpg") || item.Contains(".gif") || item.Contains(".png"))
                    {
                        imagesQuantity++;
                        images.Images.Add(Image.FromFile(item));
                        largeImages.Images.Add(Image.FromFile(item));

                        FileInfo info = new FileInfo(item);
                        listOfImages.Add(info.FullName);

                        lvImages.Items.Add(info.Name, imagesQuantity - 1);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wybierz folder");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var directoryInfo = Directory.GetFiles(_path);
                var picturesList = _fileHelper.DeserializeFromFile();
                var addedPicture = new Picture();
                var selectedItem = lvImages.SelectedItems[0].Index;

                var img = new Bitmap(directoryInfo[selectedItem]);

                addedPicture.Number = picturesList.Count + 1;
                addedPicture.PicturePath = directoryInfo[selectedItem];
                addedPicture.Width = img.Height;
                addedPicture.Height = img.Width;

                picturesList.Add(addedPicture);

                _fileHelper.SerializeToFile(picturesList);

                OnPictureAdded();
                Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Nie wybrałeś pliku");
            }
        }
    }
}
