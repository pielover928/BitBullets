﻿using DungeonCrawler.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.States
{
    abstract class State
    {
        public NetGameState netState;
        //How often the game updates
        public float TickRate { get => 1000/20; }
        //How often the network updates
        public abstract float NetTickRate { get; }

        public enum StateType
        {
            InGameState,
            ServerState
        }


        public abstract void Init();
        public abstract void Update(float deltaTime);
        public abstract void Render();
        public virtual void ProcessNetworkMessages()
        {
            netState.ProcessMessages();
        }
    }
}
