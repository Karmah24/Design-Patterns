namespace Remote
{
    public class MacroOffCmd : Command
    {
        Command[] commands;
        public MacroOffCmd(Command[] commands)
        {
            this.commands = commands;
        }
        public void execute()
        {
            foreach (var command in commands)
            {
                command.execute();
            }
        }
        public void undo()
        {
            for (int i = commands.Count() - 1; i >= 0; i--)
            {
                commands[i].undo();
            }
        }
    }
}