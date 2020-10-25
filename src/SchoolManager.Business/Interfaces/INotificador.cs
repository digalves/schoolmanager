using SchoolManager.Business.Notifications;
using System.Collections.Generic;

namespace Core.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handler(Notificacao notificacao);
    }
}
