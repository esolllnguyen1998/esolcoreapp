using System.Threading.Tasks;

namespace EsolCoreApp.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}