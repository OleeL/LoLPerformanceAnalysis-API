﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR;

namespace LoLPerformanceAnalysisAPI.Controllers
{

    public interface IClientHub
    {
        Task UpdateGameInfo(string user, string message);
    }

    public class ClientHub : Hub<IClientHub>
    {
        public ClientHub()
        {

        }

        public string HelloWorld() => "Hello World! Oli";

    }
}