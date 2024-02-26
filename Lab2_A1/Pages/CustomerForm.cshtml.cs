using Lab2_A1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab2_A1.Pages
{
    public class CustomerFormModel : PageModel
    {
        public string Messsage { get; set; }
        [BindProperty]
        public Customer customerInfo { get; set; }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Messsage = "Infomation is OK.";
                ModelState.Clear();
            }
            else
            {
                Messsage = "Error on input data.";
            }
        }
    }
}
