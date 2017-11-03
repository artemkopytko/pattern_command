using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class LightsCommand : ICommand
    {
        private Light _light;
        private Stack<LightsState> _states;

        public LightsCommand(Light light)
        {
            _light = light;
            _states = new Stack<LightsState>();
        }

        public void Execute()
        {
            _states.Push(_light.State);
            _light.ToggleLight();
        }

        public void Undo()
        {
            var prevState = _states.Pop();
            _light.SetState(prevState);
        }

        public override string ToString()
        {
            return "Включить свет";
        }


    }
}