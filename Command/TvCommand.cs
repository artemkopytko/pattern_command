using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class TvCommand: ICommand
    {
		private Tv _tv;
		public TvCommand(Tv tv)
		{
			_tv = tv;
		}

		public void Execute()
		{
			_tv.TurnOn();
		}

		public void Undo()
		{
			_tv.TurnOff();
		}
		public override string ToString()
		{
			return "Включить телевизор";
		}
    }
}
