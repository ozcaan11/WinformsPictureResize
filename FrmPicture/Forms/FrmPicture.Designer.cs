namespace FrmPicture.Forms
{
    partial class FrmPicture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEditSave = new DevExpress.XtraEditors.PictureEdit();
            this.btnOpnFl = new DevExpress.XtraEditors.ButtonEdit();
            this.lblSave = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEditGet = new DevExpress.XtraEditors.PictureEdit();
            this.lookUpEditPictures = new DevExpress.XtraEditors.LookUpEdit();
            this.lblGet = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGet = new DevExpress.XtraEditors.SimpleButton();
            this.textEditWidth = new DevExpress.XtraEditors.TextEdit();
            this.textEditHeight = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditSave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpnFl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditGet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPictures.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHeight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditHeight);
            this.groupControl1.Controls.Add(this.textEditWidth);
            this.groupControl1.Controls.Add(this.pictureEditSave);
            this.groupControl1.Controls.Add(this.btnOpnFl);
            this.groupControl1.Controls.Add(this.lblSave);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Location = new System.Drawing.Point(19, 19);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 447);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Save image to database";
            // 
            // pictureEditSave
            // 
            this.pictureEditSave.Location = new System.Drawing.Point(5, 152);
            this.pictureEditSave.Name = "pictureEditSave";
            this.pictureEditSave.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditSave.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEditSave.Size = new System.Drawing.Size(290, 290);
            this.pictureEditSave.TabIndex = 4;
            // 
            // btnOpnFl
            // 
            this.btnOpnFl.Location = new System.Drawing.Point(90, 47);
            this.btnOpnFl.Name = "btnOpnFl";
            this.btnOpnFl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnOpnFl.Size = new System.Drawing.Size(205, 20);
            this.btnOpnFl.TabIndex = 3;
            // 
            // lblSave
            // 
            this.lblSave.Location = new System.Drawing.Point(8, 133);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(0, 13);
            this.lblSave.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Choose image";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save to database";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pictureEditGet);
            this.groupControl2.Controls.Add(this.lookUpEditPictures);
            this.groupControl2.Controls.Add(this.lblGet);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.btnGet);
            this.groupControl2.Location = new System.Drawing.Point(325, 19);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(300, 447);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Get image from database";
            // 
            // pictureEditGet
            // 
            this.pictureEditGet.Location = new System.Drawing.Point(5, 152);
            this.pictureEditGet.Name = "pictureEditGet";
            this.pictureEditGet.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditGet.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEditGet.Size = new System.Drawing.Size(290, 290);
            this.pictureEditGet.TabIndex = 4;
            // 
            // lookUpEditPictures
            // 
            this.lookUpEditPictures.Location = new System.Drawing.Point(78, 47);
            this.lookUpEditPictures.Name = "lookUpEditPictures";
            this.lookUpEditPictures.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPictures.Properties.NullText = "Select an image ...";
            this.lookUpEditPictures.Size = new System.Drawing.Size(217, 20);
            this.lookUpEditPictures.TabIndex = 0;
            // 
            // lblGet
            // 
            this.lblGet.Location = new System.Drawing.Point(8, 133);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(0, 13);
            this.lblGet.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Choose image";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(160, 73);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(135, 25);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get from database";
            // 
            // textEditWidth
            // 
            this.textEditWidth.Location = new System.Drawing.Point(47, 76);
            this.textEditWidth.Name = "textEditWidth";
            this.textEditWidth.Size = new System.Drawing.Size(45, 20);
            this.textEditWidth.TabIndex = 5;
            // 
            // textEditHeight
            // 
            this.textEditHeight.Location = new System.Drawing.Point(47, 102);
            this.textEditHeight.Name = "textEditHeight";
            this.textEditHeight.Size = new System.Drawing.Size(45, 20);
            this.textEditHeight.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Width:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Height:";
            // 
            // FrmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 485);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPicture";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture To Db In C#";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditSave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpnFl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditGet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPictures.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHeight.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PictureEdit pictureEditSave;
        private DevExpress.XtraEditors.ButtonEdit btnOpnFl;
        private DevExpress.XtraEditors.LabelControl lblSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPictures;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEditGet;
        private DevExpress.XtraEditors.LabelControl lblGet;
        private DevExpress.XtraEditors.SimpleButton btnGet;
        private DevExpress.XtraEditors.TextEdit textEditHeight;
        private DevExpress.XtraEditors.TextEdit textEditWidth;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

