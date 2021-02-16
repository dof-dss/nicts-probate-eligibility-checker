using System.ComponentModel.DataAnnotations;

namespace eligibility_checker.Models
{
    public class PageViewModel
    {
        public PageViewModel(PageModel model)
        {
            Page = model.Page;
            Header = model.Header;
            Hint = model.Hint;
            Validation = model.Validation;
        }
        public string Page { get; private set; }

        public string Header { get; private set; }

        public string Hint { get; private set; }

        public string Validation { get; private set; }

        [Required]
        public bool? Answer { get; set; }
    }
}