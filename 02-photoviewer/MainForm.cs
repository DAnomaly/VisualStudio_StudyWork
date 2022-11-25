using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _02_photoviewer
{
    public partial class photoViewer : Form
    {
        public photoViewer()
        {
            InitializeComponent();
        }

        #region 버튼 클릭 이벤트

        /// <summary>
        /// Show a picture button - Click event
        /// </summary>
        private void showBtn_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// Clear the picture button - Click event
        /// </summary>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear th picture.
            pictureBox1.Image = null;
        }

        /// <summary>
        /// Set the background color button - Click event
        /// </summary>
        private void backgroundBtn_Click(object sender, EventArgs e)
        {
            // Show the  color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if(colorDialog.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog.Color;
        }

        /// <summary>
        /// Close button - Click event
        /// </summary>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        #endregion

        #region 체크박스 이벤트

        /// <summary>
        /// Stretch checkbox - check evnet
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
        #endregion
    }
}
