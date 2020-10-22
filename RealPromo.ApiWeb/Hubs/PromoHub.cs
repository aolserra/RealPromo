using Microsoft.AspNetCore.SignalR;
using RealPromo.ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPromo.ApiWeb.Hubs
{
    public class PromoHub : Hub
    {
        /*
         * Client - JS/C#/Java
         * RPC
         * Client -> Hub
         * Hub -> Client
         */
        public async Task CadastrarPromocao(Promocao promocao)
        {
            /*
             * Banco
             * Queue/Scheduler.......
             * Notificar o usuário (SignalR).
             */

            await Clients.Caller.SendAsync("CadastradoSucesso");
            await Clients.Others.SendAsync("ReceberPromocao", promocao);

        }
    }
}
