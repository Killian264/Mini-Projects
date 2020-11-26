using System.Collections.Generic;

namespace P6
{
    public class FakeProjectRepository : IProjectRepository
    {
        public const string NO_ERROR = "";
        public const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project id.";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        public const string NO_PROJECT_FOUND_ERROR = "No project found.";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank.";

        private static List<Project> _Projects = new List<Project>();
        public FakeProjectRepository()
        {
            if (_Projects.Count == 0)
            {
                int idToIgnore;
                // Populate some temporary values to work with
                Add(new Project { Name = "Accounting project" }, out idToIgnore);
                Add(new Project { Name = "Big expensive project" }, out idToIgnore);
                Add(new Project { Name = "Some other project" }, out idToIgnore);
            }
        }
        public string Add(Project project, out int Id)
        {
            Id = 0;
            string newProjectName = project.Name.Trim();
            if (IsDupliclateName(newProjectName))
            {
                return DUPLICATE_PROJECT_NAME_ERROR;
            }
            if (newProjectName == "")
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            project.Id = GetNextId();
            _Projects.Add(project);
            Id = project.Id;
            return NO_ERROR;
        }
        public List<Project> GetAll()
        {
            return _Projects;
        }
        public string Remove(int projectId)
        {
            int index = 0;
            foreach (Project project in _Projects)
            {
                if (project.Id == projectId)
                {
                    _Projects.RemoveAt(index);
                    return NO_ERROR;
                }
                index++;
            }
            return NO_PROJECT_FOUND_ERROR;
        }
        public string Modify(int projectId, Project project)
        {
            if (projectId != project.Id)
            {
                return MODIFIED_PROJECT_ID_ERROR;
            }
            if (IsDupliclateName(project.Name)) {
                return DUPLICATE_PROJECT_NAME_ERROR;
            }
            if (project.Name.Trim() == "")
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            int index = 0;
            foreach (Project p in _Projects)
            {
                if (projectId == p.Id)
                {
                    _Projects[index] = project;
                    return NO_ERROR;
                }
                index++;
            }
            return NO_PROJECT_FOUND_ERROR;
        }
        private int GetNextId()
        {
            int currentMaxId = 0;
            foreach( Project p in _Projects)
            {
                currentMaxId = p.Id;
            }
            return ++currentMaxId;
        }
        public bool IsDupliclateName(string projectName)
        {
            bool isDuplicate = false;
            foreach (Project p in _Projects)
            {
                if (projectName == p.Name)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }
    }
}
