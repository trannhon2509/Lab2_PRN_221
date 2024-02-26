using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Lab2_A1.Pages
{
    public class UploadFileModelModel : PageModel
    {
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
        public UploadFileModelModel(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _environment = environment;
        }
        [Required(ErrorMessage = "Please choose at least one file!")]
        [DataType(DataType.Upload)]
        [FileExtensions(Extensions = "png,jpg,jpeg,gif")]
        [Display(Name = "Choose a file(s) to upload.")]
        public IFormFile[] FileUploads;

        public async void OnPostAsync()
        {
            if (FileUploads != null)
            {
                foreach (var FileUpload in FileUploads)
                {
                    var file = Path.Combine(_environment.ContentRootPath, "Images", FileUpload.FileName);

                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        await FileUpload.CopyToAsync(fileStream);
                    }
                }
            }
        }
    }
}
