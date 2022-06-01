namespace Remote
{
    public class MacroOnCmd : Command
    {
        Command[] commands;
        public MacroOnCmd(Command[] commands)
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