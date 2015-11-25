namespace _03.CompanyHierarchy.Interfaces
{
    using System;

    public interface IProject
    {
        string ProjectName { get; }

        DateTime ProjectStartDate { get; }

        string Details { get; }

        bool State { get; }

        void CloseProject();
    }
}