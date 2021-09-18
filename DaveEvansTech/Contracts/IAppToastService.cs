namespace DaveEvansTech.Contracts
{
    public interface IAppToastService
    {
        void ShowSuccessToast(string heading, string message);
        
        void ShowInfoToast(string heading, string message);
        
        void ShowErrorToast(string heading, string message);
        
        void ShowWarningToast(string heading, string message);
        
    }
}