using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeitOnlineAPISharp.Models.Department;

namespace ZeitOnlineAPISharp.Endpoints
{
    public class DepartmentEndpoint
    {

        protected API API {get; set;}

        public DepartmentEndpoint(API api) 
        {
            this.API = api;
        }

        public Response Query(String department) 
        {
            String url = String.Format("http://api.zeit.de/department/{0}?api_key={1}&limit={2}", department, this.API.APIKey, this.API.Limit);
            return APIRequester.Request<Response>(url, this.API);
        }
    }
}
