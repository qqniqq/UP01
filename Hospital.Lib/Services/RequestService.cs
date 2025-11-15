using Hospital.Lib.Interfaces;
using Hospital.Lib.Models;
using System.Collections.Generic;

namespace Hospital.Lib.Services
{
    public class RequestService
    {
        private readonly IRequestRepository _repository;
        public RequestService(IRequestRepository repository)
        {
            _repository = repository;
        }
        public List<RequestView> GetAllRequests()
        {
            return _repository.GetAllRequests();
        }
        public List<RequestView> GetSelectedRequest(string requestId)
        {
            return _repository.GetRequestsById(requestId);
        }
    }
}
