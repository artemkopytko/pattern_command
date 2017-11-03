using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput;
            remote.SetCommandForButton(1, new LightsCommand(new Light()));
            remote.SetCommandForButton(2, new TvCommand(new Tv()));
            remote.SetCommandForButton(3, new MusicCommand(new Music()));
            remote.SetCommandForButton(4, new TeapotCommand(new Teapot()));
            var teapotCommand = new TeapotCommand(new Teapot());
            var tvCommand = new TvCommand(new Tv());
            var macroCommand = new MacroCommand(new List<ICommand> { teapotCommand, tvCommand });
            remote.SetCommandForButton(5, macroCommand);
            do
            {
                Console.WriteLine("Выберите вариант ниже:");
                Console.WriteLine(remote);
                Console.Write("\nВаш выбор: ");
                var input = Console.ReadLine();
                int buttonId;
                int.TryParse(input, out buttonId);
                remote.PushButton(buttonId);
                remote.UndoButton(buttonId);
                Console.Write("\nВы хотите продолжить (y/n): ");
                userInput = Console.ReadLine();
            } while (userInput == "y");
        }
        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен");
            State = State.Off;
        }
        public State State { get; set; }
    }
}

