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
    public partial class PictureSelection : Form
    {
        private FileHelper<List<Picture>> _fileHelper = new FileHelper<List<Picture>>(Program.FilePath);

        public PictureSelection()
        {
            InitializeComponent();
        }
    }
}
