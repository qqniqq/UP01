using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Lib.Models;

namespace Hospital.Lib.Interfaces
{
    public interface IRequestRepository
    {
        List<RequestView> GetAllRequests();
        List<RequestView> GetRequestsById(string requestId);
    }
}
