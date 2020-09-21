﻿using System;
using System.Diagnostics;

namespace Juce.Core.Sequencing
{
    public class LogInstruction : InstantInstruction
    {
        private readonly string log;

        public LogInstruction(string log)
        {
            this.log = log;
        }

        protected override void OnInstantStart()
        {
            UnityEngine.Debug.Log(log);
        }
    }
}