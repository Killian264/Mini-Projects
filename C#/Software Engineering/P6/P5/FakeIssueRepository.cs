using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;

namespace P6
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        private static List<Issue> _Issues = new List<Issue>(){
            new Issue()
            {
                Id = 1,
                ProjectId = 1,
                Title = "first issue",
                DiscoveryDate = new DateTime(2020, 1, 1, 1, 1, 1),
                Discoverer = "Lawson, Payton",
                InitialDescription = "Super duper super bug",
                Component = "what is this?",
                IssueStatusId = 1,
            },
            new Issue()
            {
                Id = 2,
                ProjectId = 1,
                Title = "Big bug",
                DiscoveryDate = new DateTime(2020, 1, 1, 1, 1, 1),
                Discoverer = "AAAA, AAA",
                InitialDescription = "Super duper super bug",
                Component = "what is this?",
                IssueStatusId = 1,
            },
            new Issue()
            {
                Id = 3,
                ProjectId = 2,
                Title = "program crash",
                DiscoveryDate = new DateTime(2020, 1, 1, 1, 1, 1),
                Discoverer = "Last, First",
                InitialDescription = "Super duper super bug",
                Component = "what is this?",
                IssueStatusId = 1,
            }
        };

        public string ValidateIssue(Issue issue)
        {
            if (issue.Title == "" || issue.Title == null)
            {
                return EMPTY_TITLE_ERROR;
            }

            if (issue.DiscoveryDate == null)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }

            if (DateTime.Compare(issue.DiscoveryDate, System.DateTime.Now) > 0)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }

            if (issue.Discoverer == "" || issue.Discoverer == null)
            {
                return EMPTY_DISCOVERER_ERROR;
            }

            return NO_ERROR;
        }

        private bool IsDuplicate(string title)
        {
            foreach(Issue issue in _Issues)
            {
                if(issue.Title == title)
                {
                    return true;
                }
            }
            return false;
        }

        // Interface Implementation:

        public string Add(Issue issue)
        {
            string check = ValidateIssue(issue);
            if (check == NO_ERROR && IsDuplicate(issue.Title) == false)
            {
                _Issues.Add(issue);
                return NO_ERROR;
            }
            else
            {
                if (IsDuplicate(issue.Title) == true)
                {
                    return "Titles must be unique across all projects.";
                }
                else
                {
                    return check;
                }
            }
        }
        public List<Issue> GetAll(int ProjectId)
        {
            List<Issue> ListOfIssues = new List<Issue>();

            if (ProjectId == 0)
            {
                return _Issues;
            }
            else
            {
                foreach (Issue issue in _Issues)
                {
                    if (issue.ProjectId == ProjectId)
                    {
                        ListOfIssues.Add(issue);
                    }
                }
            }

            return ListOfIssues;
        }
        public bool Remove(Issue issue)
        {
            foreach (Issue current in _Issues)
            {
                if (issue.Id == current.Id)
                {
                    _Issues.Remove(issue);
                    return true;
                }
            }

            return false;
        }
        public string Modify(Issue issue)
        {
            if (ValidateIssue(issue) == NO_ERROR)
            {
                foreach (Issue ish in _Issues)
                {
                    if (issue.Id == ish.Id)
                    {
                        Remove(GetIssueById(issue.Id));
                    }
                }
            }
            return Add(issue);
        }
        public int GetTotalNumberOfIssues(int ProjectId)
        {
            int count = 0;
            foreach(Issue issue in _Issues)
            {
                if(issue.ProjectId == ProjectId)
                {
                    count++;
                }
            }

            return count;
        }
        public List<string> GetIssuesByMonth(int ProjectId)
        {

            List<Issue> issues = GetAll(ProjectId);
            List<string> results = new List<string>();

            Dictionary<long, int> issuesByMonth = new Dictionary<long, int>();
            int discoveries;
            foreach (Issue issue in issues)
            {
                DateTime date = new DateTime(issue.DiscoveryDate.Year, issue.DiscoveryDate.Month, 1, 1, 1, 1);
                long integerDate = date.Ticks;
                discoveries = 1;
                if (!issuesByMonth.ContainsKey(integerDate))
                {
                    issuesByMonth.Add(integerDate, discoveries);
                }
                else
                {
                    discoveries++;
                    issuesByMonth[integerDate] += 1;

                }
            }

            int i = 0;
            foreach (KeyValuePair<long, int> pair in issuesByMonth)
            {
                i++;
                DateTime date = new DateTime(pair.Key);
                results.Add($"{date.Year} - {date.Month}: {pair.Value}");
            }

            return results;
        }
        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {

            List<Issue> issues = GetAll(ProjectId);
            List<string> results = new List<string>();

            Dictionary<string, int> issuesByDiscoverer = new Dictionary<string, int>();
            int discoveries;
            foreach (Issue issue in issues)
            {
                discoveries = 1;
                if (!issuesByDiscoverer.ContainsKey(issue.Discoverer))
                {
                    issuesByDiscoverer.Add(issue.Discoverer, discoveries);
                }
                else
                {
                    discoveries++;
                    issuesByDiscoverer[issue.Discoverer] += 1;

                }
            }

            foreach (KeyValuePair<string, int> pair in issuesByDiscoverer)
            {
                results.Add($"{pair.Key}: {pair.Value}");
            }

            return results;
        }
        public Issue GetIssueById(int Id)
        {

            foreach (Issue issue in _Issues)
            {
                if(issue.Id == Id)
                {
                    return issue;
                }
            }

            return null;
        }
    }
}
