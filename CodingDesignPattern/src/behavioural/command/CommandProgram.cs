namespace CodingDesignPattern.src.behavioural.command
{
    public class CommandProgram
    {
        public void Run()
        {
            // Receivers
            Light livingRoomLight = new Light();
            Fan ceilingFan = new Fan();

            // Commands
            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);
            ICommand fanOn = new FanOnCommand(ceilingFan);
            ICommand fanOff = new FanOffCommand(ceilingFan);

            // Invoker
            RemoteControl remote = new RemoteControl();

            // Execute Commands
            remote.ExecuteCommand(lightOn);
            remote.ExecuteCommand(fanOn);

            // Undo Commands
            remote.UndoLastCommand();
            remote.UndoLastCommand();
            remote.UndoLastCommand();
        }
    }
}