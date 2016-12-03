using System.Drawing;
using DevExpress.XtraEditors;

namespace FrmPicture.Forms
{
    public partial class FrmShowPicture : XtraForm
    {
        public FrmShowPicture(Image image)
        {
            InitializeComponent();
            pictureEditFull.Image = image;
            MouseLeave += (sender, args) => Close();
        }
    }
}