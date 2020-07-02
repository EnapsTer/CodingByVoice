using System;
using System.Globalization;
using WindowsInput;
using WindowsInput.Native;

namespace CodingByVoice.Models
{
    class InputCodeSimulator
    {
        static private InputSimulator inputSimulator = new InputSimulator();
        
        public void SimulateKeyWords(string type, string value)
        {
            if (type == "construction" || type == "dataType")
                simulateConstraction(value);
            else if (type == "operator")
                simulateOperator(value);
            else if (type == "sign")
                simulateSign(value);
            else if (type == "command")
                simulateCommand(value);
            else if (type == "number")
                simulateNumber(value);
        }

        public void SimulateVariable(string value, string capital)
        {            
            if (capital == "true")
            {     
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                string capitalizedText = textInfo.ToTitleCase(value);
                inputSimulator.Keyboard.TextEntry(capitalizedText);
            }
            else
            {
                inputSimulator.Keyboard.TextEntry(value);
            }
            
        }

        private void simulateNumber(string value)
        {
            inputSimulator.Keyboard.TextEntry(String.Format("{0}", value));
        }

        private void simulateConstraction(string value)
        {
            inputSimulator.Keyboard.TextEntry(String.Format("{0} ", value));
        }

        private void simulateOperator(string value)
        {
            if (value == "++" || value == "--")
            {
                inputSimulator.Keyboard.TextEntry(value);
            }
            else
            {
                inputSimulator.Keyboard.TextEntry(String.Format(" {0} ", value));
            }
        }

        

        public void simulateCommand(string value)
        {
            switch (value)
            {
                case "undo":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_Z);
                    break;
                case "redo":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_Y);
                    break;
                case "copy":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);
                    break;
                case "paste":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
                    break;
                case "cut":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_X);
                    break;
                case "below":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.DOWN);
                    break;
                case "higher":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.UP);
                    break;
                case "right":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.RIGHT);
                    break;
                case "left":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.LEFT);
                    break;
                case "oneRight":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                    break;
                case "oneLeft":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                    break;
                case "pageUp":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.PRIOR);
                    break;
                case "pageDown":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.NEXT);
                    break;
                case "up":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.UP);
                    break;
                case "down":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                    break;
                case "space":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                    break;
                case "tabulation":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    break;
                case "selectLeftWord":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new[] { VirtualKeyCode.SHIFT, VirtualKeyCode.LEFT });
                    break;
                case "selectRightWord":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new[] { VirtualKeyCode.SHIFT, VirtualKeyCode.RIGHT });
                    break;
                case "selectDown":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new[] { VirtualKeyCode.SHIFT, VirtualKeyCode.DOWN });
                    break;
                case "selectUp":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new[] { VirtualKeyCode.SHIFT, VirtualKeyCode.UP });
                    break;
                case "delete":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.BACK);
                    break;
                case "deleteRow":
                    inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new[] { VirtualKeyCode.SHIFT, VirtualKeyCode.VK_L });
                    break;
                case "deleteOne":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.BACK);
                    break;
                case "enter":
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    break;
            }
            
        }

        private void simulateSign(string value)
        {
            switch (value)
            {
                case ",":
                    inputSimulator.Keyboard.TextEntry(String.Format("{0} ", value));
                    break;
                case ("."):
                    inputSimulator.Keyboard.TextEntry(value);
                    break;
                case ";":
                    inputSimulator.Keyboard.TextEntry(value);
                    //inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    break;
                case @"\":
                    inputSimulator.Keyboard.TextEntry(String.Format(" {0} ", value));
                    break;
                case ":":
                    inputSimulator.Keyboard.TextEntry(String.Format("{0} ", value));
                    break;
                case "_":
                    inputSimulator.Keyboard.TextEntry(String.Format("{0}", value));
                    break;
                case @"//":
                    inputSimulator.Keyboard.TextEntry(String.Format("{0} ", value));
                    break;
                case "|":
                    inputSimulator.Keyboard.TextEntry(String.Format(" {0} ", value));
                    break;
                case @"''":
                    inputSimulator.Keyboard.TextEntry(value);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                    break;
                case @"""":
                    inputSimulator.Keyboard.TextEntry(value);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                    break;
                case "<>":
                    inputSimulator.Keyboard.TextEntry(value);
                    break;
                case "{}":
                    inputSimulator.Keyboard.TextEntry(value);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                    break;
                case "()":
                    inputSimulator.Keyboard.TextEntry(value);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                    break;
                case "[]":
                    inputSimulator.Keyboard.TextEntry(value);
                    inputSimulator.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                    break;
                case "?":
                    inputSimulator.Keyboard.TextEntry(String.Format(" {0} ", value));
                    break;

            }
        }
    }
}
