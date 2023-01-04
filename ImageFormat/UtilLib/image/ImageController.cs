using System.Drawing.Imaging;

namespace UtilLib.image
{
    internal class ImageController
    {
        private Image FromImage;

        public ImageController(string fromFilePath)
        {
            if (!File.Exists(fromFilePath)) throw new FileNotFoundException(fromFilePath);
            FromImage = Image.FromFile(fromFilePath);
        }

        public Image? Format(string toFilePath, ImageFormat format)
        {
            // GDI+ BMP, GIF, EXIF, JPG, PNG, TIFF
            try
            {
                FromImage.Save(toFilePath, format);
                return Image.FromFile(toFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Image? Format(string toFilePath, ImageFormat format, out string? errorMessage)
        {
            try
            {
                FromImage.Save(toFilePath, format);
                errorMessage = null;
                return Image.FromFile(toFilePath);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return null;
            }
        }

        public Image? Resize(string toFilePath, int width, int height)
        {
            try
            {
                Bitmap toImage = new Bitmap(FromImage, width, height);
                toImage.Save(toFilePath, FromImage.RawFormat);
                return Image.FromFile(toFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Image? Resize(string toFilePath, int width, int height, out string? errorMessage)
        {
            try
            {
                Bitmap toImage = new Bitmap(FromImage, width, height);
                toImage.Save(toFilePath, FromImage.RawFormat);
                errorMessage = null;
                return Image.FromFile(toFilePath);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return null;
            }
        }

    }
}
