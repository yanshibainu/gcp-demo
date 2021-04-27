using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcctReview;
using gcp_demo.Entities;

namespace gcp_demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DemoDbContext _demoDbContext;

        public IList<Patent> List { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DemoDbContext demoDbContext)
        {
            _logger = logger;
            _demoDbContext = demoDbContext;
        }

        public void OnGet()
        {
            List = _demoDbContext.Patents.ToList();
        }
    }
}
