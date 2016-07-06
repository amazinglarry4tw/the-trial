using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTrial_Alpha
{
    public class Portal
    {
        public string name;
        public string message;
        public Connection connection;

        public Portal()
        {
            this.name = string.Empty;
            this.message = string.Empty;
            this.connection = new Connection();
        }
    }
}
