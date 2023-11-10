using PruebaAPIcorreo.Models;

namespace PruebaAPIcorreo.Sevices
{
    public interface IEmailServices
    {
        void SendEmail(EmailDTO request); // Añadir proveedor
    }
}

