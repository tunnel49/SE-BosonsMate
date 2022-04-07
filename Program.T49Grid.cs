using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using VRage;
using VRage.Collections;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.GUI.TextPanel;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ModAPI.Ingame.Utilities;
using VRage.Game.ObjectBuilders.Definitions;
using VRageMath;

namespace IngameScript
{
    partial class Program
    {
        public class T49Grid
        {
            private readonly IMyProgrammableBlock me;
            private readonly string gridname;

            public T49Grid(IMyProgrammableBlock me, MyIni ini)
            {
                this.me = me;
                this.gridname = ini.Get("T49Grid", "Name").ToString("Undefined");
            }
            public void Tick100()
            {
                if (me.CubeGrid.CustomName.StartsWith("SmallGrid ") ||
                    me.CubeGrid.CustomName.StartsWith("LargeGrid ") )
                {
                    me.CubeGrid.CustomName = gridname;
                }
                // Initialize Groups?
            }
        }
    }
}
