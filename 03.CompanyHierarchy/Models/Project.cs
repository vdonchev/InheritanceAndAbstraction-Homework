namespace _03.CompanyHierarchy.Models
{
    using System;
    using Interfaces;

    public class Project : IProject
    {
        private string projectName;
        private string details;

        public Project(string projectName, DateTime startDate, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = startDate;
            this.Details = details;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }

            private set
            {
                Validators.Validations.IfIsNull(value, "Project name");
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate { get; set; }

        public string Details
        {
            get
            {
                return this.details;
            }

            private set
            {
                Validators.Validations.IfIsNull(value, "Project details");
                this.details = value;
            }
        }

        public bool State { get; private set; } = true;

        public void CloseProject()
        {
            this.State = false;
        }

        public override string ToString() =>
            $"{this.ProjectName}, start date: {this.ProjectStartDate.Date}, Status: {(this.State ? "Open" : "Closed")}";
    }
}