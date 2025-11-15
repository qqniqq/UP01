using System.Collections.Generic;
using Hospital.Lib.Interfaces;
using Hospital.Lib.Models;
using MySql.Data.MySqlClient;

namespace Hospital.Data
{
    public class MySqlRequestRepository : IRequestRepository
    {
        private readonly string _connectionString;
        public MySqlRequestRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<RequestView> GetAllRequests()
        {
            var result = new List<RequestView>();

            string query = @"
            SELECT r.id, d.department_name, ri.drug_name, ri.quantity, 
                   r.request_date, r.status, r.approved_by, r.comment
            FROM Request r
            JOIN RequestItems ri ON r.id = ri.request_id
            JOIN Department d ON r.department_id = d.id
        ";

            using (var con = new MySqlConnection(_connectionString))
            using (var cmd = new MySqlCommand(query, con))
            {
                con.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new RequestView
                    {
                        Id = reader.GetString(0),
                        DepartmentName = reader.GetString(1),
                        DrugName = reader.GetString(2),
                        Quantity = reader.GetInt32(3),
                        RequestDate = reader.GetDateTime(4),
                        Status = reader.GetString(5),
                        ApprovedBy = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        Comment = reader.IsDBNull(7) ? "" : reader.GetString(7)
                    });
                }
            }
            return result;
        }
        public List<RequestView> GetRequestsById(string requestId)
        {
            var result = new List<RequestView>();

            string query = @"
            SELECT r.id, d.department_name, ri.drug_name, ri.quantity, 
                   r.request_date, r.status, r.approved_by, r.comment
            FROM Request r
            JOIN RequestItems ri ON r.id = ri.request_id
            JOIN Department d ON r.department_id = d.id
            WHERE r.id = @id
        ";
            using (var con = new MySqlConnection(_connectionString))
            using (var cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", requestId);
                con.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new RequestView
                    {
                        Id = reader.GetString(0),
                        DepartmentName = reader.GetString(1),
                        DrugName = reader.GetString(2),
                        Quantity = reader.GetInt32(3),
                        RequestDate = reader.GetDateTime(4),
                        Status = reader.GetString(5),
                        ApprovedBy = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        Comment = reader.IsDBNull(7) ? "" : reader.GetString(7)
                    });
                }
            }
            return result;
        }
    }
}
