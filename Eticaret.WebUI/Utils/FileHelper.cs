namespace Eticaret.WebUI.Utils
{
    public static class FileHelper
    {
        public static  async Task<string> FileLoaderAysnc(IFormFile formFile, string filePath="/Img/")
        {
            string fileName = "";
            if (formFile != null && formFile.Length > 0)

            {
                fileName = formFile.FileName.ToLower();
                string directory =Directory.GetCurrentDirectory() + "/wwwroot"+ filePath+fileName;

                 
                using (var stream = new FileStream(directory, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            return fileName;
        }

        public static bool FileRemover(string fileName, string filePath = "/Img/")
        {
            string directory = Directory.GetCurrentDirectory() + "/wwwroot" + filePath + fileName;
            if (File.Exists(directory))
            {
                File.Delete(directory);
                return true;
            }
            return false;
        }




        /*
        public static string GetFileExtension(string fileName)
        {
            return Path.GetExtension(fileName);
        }
        public static string GetNewFileName(string fileName)
        {
            return Guid.NewGuid() + GetFileExtension(fileName);
        }
        public static string GetPath(string fileName, string folderName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, fileName);
        }
        public static void UploadFile(IFormFile file, string folderName)
        {
            if (file != null && file.Length > 0)
            {
                string fileName = GetNewFileName(file.FileName);
                string path = GetPath(fileName, folderName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
        }
        public static void DeleteFile(string fileName, string folderName)
        {
            string path = GetPath(fileName, folderName);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }*/

    }
}
