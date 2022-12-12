using IconApp.Model;
using IconApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace IconApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ICourierService _courierService;

        public IndexModel(ILogger<IndexModel> logger, ICourierService courierService)
        {
            _logger = logger;
            _courierService = courierService;
        }

        [Required]
        [BindProperty]
        public int Width { get; set; }

        [Required]
        [BindProperty]
        public int Height { get; set; }

        [Required]
        [BindProperty]
        public int Depth { get; set; }

        [Required]
        [BindProperty]
        public int Weight { get; set; }

        [BindProperty]
        public bool IsPost { get; set; }


        [BindProperty]
        public List<PackageCourier> Packages { get; set; }


        public void OnGet()
        {
            Packages = new List<PackageCourier>();
            IsPost = false;
        }

        public void OnPost()
        {
            Packages = new List<PackageCourier>();
            IsPost = true;

            if (ModelState.IsValid)
            {
                Packages = _courierService.GetAllPackages(new PackageInput()
                {
                    Dimension = new Dimension() { Depth = Depth, Height = Height, Width = Width },
                    Weight = Weight
                });
            }
        }
    }
}