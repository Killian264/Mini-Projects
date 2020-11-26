using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository()
        {
            Add(1, "Open");
            Add(2, "Assigned");
            Add(3, "Fixed");
            Add(4, "Closed - Won't Fix");
            Add(5, "Closed - Fixed");
            Add(6, "Closed - by Design");
        }

        // Interface Implementation:

        public void Add(int Id, string value)
        {
            IssueStatus issueStatus = new IssueStatus
            {
                Id = Id,
                Value = value
            };
            _IssueStatuses.Add(issueStatus);
        }
        public List<IssueStatus> GetAll()
        {
            return _IssueStatuses;
        }
        public int GetIdByStatus(string value)
        {
            foreach(IssueStatus issueStatus in _IssueStatuses)
            {
                if (value == issueStatus.Value)
                {
                    return issueStatus.Id;
                }
            }
            return 0; //should never happen.
        }
        public string GetValueById(int Id)
        {
            foreach(IssueStatus issueStatus in _IssueStatuses)
            {
                if(Id == issueStatus.Id)
                {
                    return issueStatus.Value;
                }
            }
            return null;
        }
    }
}
