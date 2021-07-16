 public class CompositionPattern
    {
        public static  void Button_Click(ICommand command)
        {
            command.Invoke();
        }
        
        static void Main_()
        {
            Button_Click(new SaveCommand());
            SaveCommand _doc1Command = new SaveCommand();
            SaveCommand _doc2Command = new SaveCommand();
            SaveCommand _doc3Command = new SaveCommand();
            SaveCommand _doc4Command = new SaveCommand();

            SaveAllCommand _compositeCommand = new SaveAllCommand();
            _compositeCommand.AddCommand(_doc1Command);
            _compositeCommand.AddCommand(_doc2Command);
            _compositeCommand.AddCommand(_doc3Command);
            _compositeCommand.AddCommand(_doc4Command);
            Button_Click(_compositeCommand);
        }

    }
    public interface ICommand {

        void Invoke();
    
    }
    public class SaveCommand:ICommand
    {
        public void Invoke() { }
    }

    public class SaveAllCommand:ICommand
    {
        List<ICommand> _saveCommands = new List<ICommand>();
        public void Invoke() { 
        
            for(int i = 0; i < _saveCommands.Count; i++) { _saveCommands[i].Invoke(); }
        
        }
        public void AddCommand(ICommand command) { _saveCommands.Add(command); }
        public void RemoveCommand(ICommand command) { _saveCommands.Add(command); }
        public void Clear(ICommand command) { _saveCommands.Clear(); }
    }
