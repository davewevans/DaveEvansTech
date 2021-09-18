using Blazored.Toast.Services;
using DaveEvansTech.Contracts;

namespace DaveEvansTech.Helpers
{
    public class AppToastService : IAppToastService
    {
        private readonly IToastService _toastService;

        public AppToastService(IToastService toastService)
        {
            _toastService = toastService;
        }
        
        public void ShowSuccessToast(string heading, string message)
        {
            _toastService.ShowSuccess(message, heading);
        }
    
        public void ShowInfoToast(string heading, string message)
        {
            _toastService.ShowInfo(message, heading);
        }
    
        public void ShowErrorToast(string heading, string message)
        {
            _toastService.ShowError(message, heading);
        }
    
        public void ShowWarningToast(string heading, string message)
        {
            _toastService.ShowWarning(message, heading);
        }
    }
}