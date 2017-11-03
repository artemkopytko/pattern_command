using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class ControlledSystems
    {
		public enum State
		{
			Off = 0,
			On = 1
		}

		public enum LightsState
		{
			Off = 0,
			Low = 1,
			Medium = 2,
			High = 3
		}
    }
}
