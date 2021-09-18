using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DaveEvansTech.Models;

namespace DaveEvansTech.Contracts
{
    public interface IRepository
    {
        Task<bool> ClientExistsByEmail(string email);
        Task<ClientModel> GetClientByEmail(string email);
        
        Task AddNewClient(ClientModel client);

        Task UpdateClient(ClientModel client);

        Task DeleteClient(int clientID);

        Task<List<BriefModel>> GetBriefsByClientId(int clientId);

        Task AddBrief(BriefModel brief);

        Task<bool> IsSavedBriefAsync(BriefModel brief);

        Task<BriefModel> GetIncompleteBriefAsync(int clientId);

        Task UpdateBriefAsync(BriefModel brief);

        Task DeleteBrief(int briefID);

        Task SaveContactForm(ContactModel contact);

        Task SaveFeedBackForm(FeedbackModel feedback);

        Task DeleteFeedback(int feedbackID);

        Task AddProject(ProjectModel project);

        Task UpdateProject(ProjectModel project);

        Task DeleteProject(int projectID);

        Task AddProgressReport(ProgressReportModel progressReport);

        Task UpdateProgressReport(ProgressReportModel progressReport);

        Task DeleteProgressReport(int progressReportID);

        Task<List<UploadedFileModel>> GetUploadedFilesAsync(Guid guid);
    }
}