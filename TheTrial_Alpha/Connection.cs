using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTrial_Alpha
{
    public class Connection
    {
        public Guid host_id;
        public Guid destination_id;

        public Connection()
        {
            this.host_id = Guid.Empty;
            this.destination_id = Guid.Empty;
        }

        public Connection(Guid host, Guid destination)
        {
            this.host_id = host;
            this.destination_id = destination;
        }
    }
}
