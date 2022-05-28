using System.Text;

namespace Remote
{
    public class RemoteControl
    {
        Command[] onCommands, offCommands;
        Command undoCommand;
        public RemoteControl()
        {
            onCommands = new Command[8];
            offCommands = new Command[8];
            Command noCommand = new NoCommand();
            undoCommand = noCommand;
            for (int i = 0; i < 8; i++)
            {
                onCommands[i] = offCommands[i] = noCommand;
            }
        }
        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void onButtonPush(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }
        public void offButtonPush(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }
        public void undoButtonPush()
        {
            undoCommand.undo();
        }
        public override string? ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++) 
            {
                str.Append("[slot " + i + "] " + onCommands[i].GetType().Name + " " + offCommands[i].GetType().Name + "\n"); 
            }
            str.Append("[undo] " + undoCommand.GetType().Name + "\n");
            return str.ToString();
        }
    }
}