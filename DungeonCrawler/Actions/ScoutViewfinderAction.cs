﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.Actions
{
    class ScoutViewfinderAction : Action
    {
        int parentId;

        public ScoutViewfinderAction(int playerId)
        {
            parentId = playerId;
        }

        public override void Update(float elapsed)
        {
        }
    }
}