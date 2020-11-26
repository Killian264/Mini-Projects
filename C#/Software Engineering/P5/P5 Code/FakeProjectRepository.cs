using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public class FakeProjectRepository : IProjectRepository
    {
        // Error Strings. These are returned as error codes. The
        const string NO_ERROR = "";
        const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project id.";
        const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        const string NO_PROJECT_FOUND_ERROR = "No project found.";
        const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank.";

        private static List<Project> Projects;

        public FakeProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new List<Project>();

                Projects.Add(new Project // req 6a
                {
                    Id = GetNextId(),
                    Name = "Sample Project 1",
                });

                Projects.Add(new Project // req 6a
                {
                    Id = GetNextId(),
                    Name = "Sample Project 2",
                });

                Projects.Add(new Project // req 6a
                {
                    Id = GetNextId(),
                    Name = "Sample Project =)",
                });
            }
        }
        public string Add(Project project, out int Id)//idk what this outId is for. referenced in UML diagram.
        {
            project.Name = project.Name.Trim(); //req 6c
            project.Id = GetNextId();
            Id = project.Id;
            if (project.Name != "") // req 6d
            {
                if (!IsDuplicateName(project.Name)) //req 6f
                {
                    Projects.Add(project);
                    return NO_ERROR;
                }
                else
                {
                    return DUPLICATE_PROJECT_NAME_ERROR;
                }
            }
            else
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            
        }
        public string Remove(int projectId)
        {
            Project projectToDelete = null;

            foreach(Project project in Projects)
            {
                if (project.Id == projectId)
                {
                    projectToDelete = project;
                }
            }

            if(projectToDelete == null)
            {
                return NO_PROJECT_FOUND_ERROR;
            }
            
            Projects.Remove(projectToDelete);
            return NO_ERROR;
        }
        public string Modify(int projectId, Project project)
        {
            Project ProjectToMod = null;

            foreach (Project prjt in Projects)
            {
                if (prjt.Id == projectId)
                {
                    ProjectToMod = prjt;
                }
            }

            foreach (Project prjt in Projects)
            {
                if (project.Name == prjt.Name)
                {
                    return DUPLICATE_PROJECT_NAME_ERROR;
                }
            }

            if (ProjectToMod == null)
            {
                return NO_PROJECT_FOUND_ERROR;
            }

            if(project.Name == "")
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }

            ProjectToMod.Name = project.Name;
            return NO_ERROR;
        }
        public List<Project> GetAll()
        {
            return Projects;
        }
        public bool IsDuplicateName(string projectName)
        {
            foreach(Project project in Projects)
            {
                if(project.Name == projectName)
                {
                    return true;
                }
            }
            return false;
        }
        private int GetNextId()
        {
            int largestId = 0;

            if (Projects == null)
            {
                return 0;
            }
            foreach(Project p in Projects)
            {
                if(p.Id > largestId)
                {
                    largestId = p.Id;
                }
            }

            return largestId+1;
        }
    }
}
