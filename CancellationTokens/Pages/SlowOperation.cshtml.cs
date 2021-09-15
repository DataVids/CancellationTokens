using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CancellationTokens.Pages
{
    public class SlowOperationModel : PageModel
    {
        public async Task<string> GetSlowData(CancellationToken cancellationToken)
        {
            try
            {
                await Task.Delay(4000, cancellationToken);
            }
            catch(TaskCanceledException)
            {
                //take care of needed cancellations
            }
            return "Slow data is loaded.";
        }
    }
}
