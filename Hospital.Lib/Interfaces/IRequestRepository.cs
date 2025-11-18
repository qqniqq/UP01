using System.Collections.Generic;
using Hospital.Lib.Models;

namespace Hospital.Lib.Interfaces
{
    public interface IRequestRepository
    {
        List<RequestView> GetAllRequests();
        List<RequestView> GetRequestsById(string requestId);
    }
}
