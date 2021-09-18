using System.Collections.Generic;
using System.Threading.Tasks;
using DaveEvansTech.Helpers;
using DaveEvansTech.Models;

namespace DaveEvansTech.Contracts
{
    public interface IPostmarkEmailSender
    {
        Task SendEmailPostmarkAsync(PostmarkEmailModel email, List<FileAttachment> fileAttachments=null);

        Task SendTestEmailPostmark();
    }
}