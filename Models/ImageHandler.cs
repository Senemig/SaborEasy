using System.IO;
using Microsoft.AspNetCore.Http;

namespace Sabor_Easy_MVC.Models
{
    public static class ImageHandler
    {
        public static string UploadImage(IFormFile file)
        {
            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return fileName;
        }
    }
}