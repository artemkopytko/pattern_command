using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
	public class Light
	{
		public void ToggleLight()
		{
			switch (State)
			{
				case LightsState.Off:
					State = LightsState.Low;
					break;
				case LightsState.Low:
					State = LightsState.Medium;
					break;
				case LightsState.Medium:
					State = LightsState.High;
					break;
				case LightsState.High:
					State = LightsState.Off;
					break;
			}
			PrintLight();
		}

		public void TurnOff()
		{
			State = LightsState.Off;
            PrintLight();
		}

		public void SetState(LightsState state)
		{
			State = state;
		}

		public LightsState State { get; set; }

        private void PrintLight()
        {
            switch (State)
            {
                case LightsState.Off:
                    Console.WriteLine("Свет выключен");
                    break;
                case LightsState.Low:
                    Console.WriteLine("Свет тусклый");
                    break;
                case LightsState.Medium:
                    Console.WriteLine("Свет средний");
                    break;
                case LightsState.High:
                    Console.WriteLine("Свет яркий");
                    break;
            }
        }
	}
}
