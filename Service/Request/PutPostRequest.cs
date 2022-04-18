using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Request
{
    public class PutRequest
    {
        public PutRequest(int _userId, int _id, string _title,string _body)
        {
            userId = _userId;
            id = _id;
            title = _title;
            body = _body;
        }
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
