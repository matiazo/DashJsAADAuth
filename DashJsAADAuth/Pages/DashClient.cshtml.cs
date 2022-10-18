using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DashJsAADAuth.Pages
{
    public class DashClientModel : PageModel
    {
        public string ClientId { get; set; } = "";
        public string Scope { get; set; } = "";

        private IConfiguration config;

        public DashClientModel(IConfiguration configRoot)
        {
            config = configRoot;

            ClientId = config["ClientId"];
            Scope = config["Scope"];
        }

        public void OnGet()
        {
        }
    }
}
