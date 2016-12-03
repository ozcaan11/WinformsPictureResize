# WinformsPictureResize
simple winforms app that resize picture and save it to the database

-----------

      
      private readonly myDb _db = new myDb();      
      private string _fileName;      
      private string _safeFileName;      
      public byte[] ImageBytes;

####
-----
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

####
-----

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

####

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

####
-----

          private void SaveImageToDatabaseAndShowInPictureEdit()
          {
              var rszdImage = GetResizedImage(Convert.ToInt32(textEditWidth.Text), 
                                              Convert.ToInt32(textEditHeight.Text));

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

####
-----

          private void GetImageFromDatabaseAndShowInPictureEdit()
          {
              var id = Convert.ToInt32(lookUpEditPictures.EditValue.ToString());
              var book = _db.Books.Select(x => new {x.id, x.image})
                  .FirstOrDefault(c => c.id == id);

              if (book != null)
                  pictureEditGet.Image = Image.FromStream(new MemoryStream(book.image));
          }

