using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class Tv
    {
		public void TurnOn()
		{
			Console.WriteLine("Телевизор включен");
			State = State.On;
		}

        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен");
            State = State.Off;
        }

		public State State { get; set; }
    }
}
