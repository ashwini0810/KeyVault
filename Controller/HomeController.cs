using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
 using Microsoft.Extensions.Logging;
    

    namespace AzureKeyVaulWebApp.Controllers
    {
        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;
            private readonly IConfiguration _configuration;

            public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
            {
                _logger = logger;
                _configuration = configuration;
            }

            public IActionResult Index()
            {
                // Read the secret from the Azure Key Vault
                string secretValue = _configuration["ConString"];
                //string secretValue1 = _configuration["FeatureMeshOffline"];

            // Pass the secret value to the view
            ViewBag.SecretValue = secretValue;
           // ViewBag.SecretValue = secretValue1;


            return View();
            }

            // Other action methods and methods of HomeController
        }
    }

