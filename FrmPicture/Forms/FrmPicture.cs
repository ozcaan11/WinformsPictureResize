using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FrmPicture.Models;

namespace FrmPicture.Forms
{
    public partial class FrmPicture : XtraForm
    {
        private readonly myDb _db = new myDb();
        private string _fileName;
        private string _safeFileName;
        public byte[] ImageBytes;

        public FrmPicture()
        {
            InitializeComponent();

            btnOpnFl.Click += (sender, args) => GetImageFromFileAndShowNameInTextEdit();
            btnSave.Click += (sender, args) => SaveImageToDatabaseAndShowInPictureEdit();
            btnGet.Click += (sender, args) => GetImageFromDatabaseAndShowInPictureEdit();
            Load += (sender, args) =>
            {
                lookUpEditPictures.Properties.ValueMember = "id";
                lookUpEditPictures.Properties.DisplayMember = "name";
                lookUpEditPictures.Properties.DataSource = _db.Books
                    .Select(x => new {x.id, x.name}).ToList();
            };

            pictureEditGet.MouseHover += (sender, args) =>
            {
                if (pictureEditGet.Image != null)
                    new FrmShowPicture(GetResizedImage(pictureEditGet.Image, 590, 740)).Show();
            };
        }

        private void GetImageFromFileAndShowNameInTextEdit()
        {
            var open = new OpenFileDialog
            {
                Filter = @"Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
            };

            if (open.ShowDialog() != DialogResult.OK) return;

            _fileName = open.FileName;
            _safeFileName = open.SafeFileName;
            btnOpnFl.Text = _safeFileName;
        }

        private static Image GetResizedImage(Image image, int width, int height)
        {
            var orgImage = image;
            var tmpImageRszd = new Bitmap(width, height);
            var tmpGraphics = Graphics.FromImage(tmpImageRszd);
            tmpGraphics.InterpolationMode = InterpolationMode.Bicubic;
            tmpGraphics.DrawImage(orgImage, 0, 0, tmpImageRszd.Width + 1, tmpImageRszd.Height + 1);
            Image rszdImage = tmpImageRszd;
            return rszdImage;
        }

        private Image GetResizedImage(int width, int height)
        {
            var orgImage = Image.FromFile(_fileName);
            var tmpImageRszd = new Bitmap(width, height);
            var tmpGraphics = Graphics.FromImage(tmpImageRszd);
            tmpGraphics.InterpolationMode = InterpolationMode.Bicubic;
            tmpGraphics.DrawImage(orgImage, 0, 0, tmpImageRszd.Width + 1, tmpImageRszd.Height + 1);
            Image rszdImage = tmpImageRszd;
            return rszdImage;
        }

        private void SaveImageToDatabaseAndShowInPictureEdit()
        {
            var rszdImage = GetResizedImage(Convert.ToInt32(textEditWidth.Text), Convert.ToInt32(textEditHeight.Text));

            using (var memoryStream = new MemoryStream())
            {
                rszdImage.Save(memoryStream, ImageFormat.Jpeg);
                ImageBytes = memoryStream.ToArray();

                memoryStream.Read(ImageBytes, 0, Convert.ToInt32(ImageBytes.Length));
                pictureEditSave.Image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }

            try
            {
                var book = new Book
                {
                    author = _fileName,
                    name = _safeFileName,
                    image = ImageBytes
                };
                _db.Books.Add(book);
                _db.SaveChanges();
                MessageBox.Show(@"Succesfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lblSave.Text = pictureEditSave.Image.Height + @"x" + pictureEditSave.Image.Width;
        }

        private void GetImageFromDatabaseAndShowInPictureEdit()
        {
            var id = Convert.ToInt32(lookUpEditPictures.EditValue.ToString());
            var book = _db.Books.Select(x => new {x.id, x.image})
                .FirstOrDefault(c => c.id == id);

            if (book != null)
                pictureEditGet.Image = Image.FromStream(new MemoryStream(book.image));
        }
    }
}