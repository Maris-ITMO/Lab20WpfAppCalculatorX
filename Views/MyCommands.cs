using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab20WpfAppCalculatorX.Views
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedUICommand Dark { get; set; }
        public static RoutedUICommand Light { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputsExit = new InputGestureCollection();
            inputsExit.Add(new KeyGesture(Key.Q, ModifierKeys.Control, "Ctrl+Q"));
            Exit = new RoutedUICommand("_Выход", "Exit", typeof(MyCommands), inputsExit);

            Light = new RoutedUICommand("_Светлая тема", "Light", typeof(MyCommands));

            Dark = new RoutedUICommand("_Темная тема", "Dark", typeof(MyCommands));
        }
    }
}
