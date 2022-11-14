using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe.Models.Base
{
    public class HealthCheckResponse
    {
        public bool CanConnectToDb { get; set; }

        public bool DoesItWork { get; set; }
    }
}
