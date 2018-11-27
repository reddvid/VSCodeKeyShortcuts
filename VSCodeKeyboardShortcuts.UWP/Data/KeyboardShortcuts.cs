using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSCodeKeyboardShortcuts.UWP.Classes;

namespace VSCodeKeyboardShortcuts.UWP.Data
{
    class KeyboardShortcuts
    {
        ObservableCollection<CommandItem> _key;
        public ObservableCollection<CommandItem> KeyboardShortcutsData
        {
            get
            {
                _key = new ObservableCollection<CommandItem>();

                _key.Add(new CommandItem("Ctrl+Shift+P, F1", "Show Command Palette", "General"));
                _key.Add(new CommandItem("Ctrl+P", "Quick Open, Go to File…", "General"));
                _key.Add(new CommandItem("Ctrl+Shift+N", "New window/instance", "General"));
                _key.Add(new CommandItem("Ctrl+Shift+W", "Close window/instance", "General"));
                _key.Add(new CommandItem("Ctrl+,", "User Settings", "General"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+S", "Keyboard Shortcuts", "General"));


                _key.Add(new CommandItem("Ctrl+X", "Cut line (empty selection)", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+C", "Copy line (empty selection)", "Basic editing"));
                _key.Add(new CommandItem("Alt+ ↑ / ↓", "Move line up/down", "Basic editing"));
                _key.Add(new CommandItem("Shift+Alt + ↓ / ↑", "Copy line up/down", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+Shift+K", "Delete line", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+Enter", "Insert line below", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+Shift+Enter", "Insert line above", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+Shift+\\", "Jump to matching bracket", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+] / [", "Indent/outdent line", "Basic editing"));
                _key.Add(new CommandItem("Home / End", "Go to beginning/end of line", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+Home", "Go to beginning of file", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+End", "Go to end of file", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+↑ / ↓", "Scroll line up/down", "Basic editing"));
                _key.Add(new CommandItem("Alt+PgUp / PgDn", "Scroll page up/down", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+Shift+[", "Fold (collapse) region", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+Shift+]", "Unfold (uncollapse) region", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+[", "Fold (collapse) all subregions", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+]", "Unfold (uncollapse) all subregions", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+0", "Fold (collapse) all regions", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+J", "Unfold (uncollapse) all regions", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+C", "Add line comment", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+U", "Remove line comment", "Basic editing"));
                _key.Add(new CommandItem("Ctrl+/", "Toggle line comment", "Basic editing"));
                _key.Add(new CommandItem("Shift+Alt+A", "Toggle block comment", "Basic editing"));
                _key.Add(new CommandItem("Alt+Z", "Toggle word wrap", "Basic editing"));


                _key.Add(new CommandItem("Ctrl+T", "Show all Symbols", "Navigation"));
                _key.Add(new CommandItem("Ctrl+G", "Go to Line...", "Navigation"));
                _key.Add(new CommandItem("Ctrl+P", "Go to File...", "Navigation"));
                _key.Add(new CommandItem("Ctrl+Shift+O", "Go to Symbol...", "Navigation"));
                _key.Add(new CommandItem("Ctrl+Shift+M", "Show Problems panel", "Navigation"));
                _key.Add(new CommandItem("F8", "Go to next error or warning", "Navigation"));
                _key.Add(new CommandItem("Shift+F8", "Go to previous error or warning", "Navigation"));
                _key.Add(new CommandItem("Ctrl+Shift+Tab", "Navigate editor group history", "Navigation"));
                _key.Add(new CommandItem("Alt+ ← / →", "Go back / forward", "Navigation"));
                _key.Add(new CommandItem("Ctrl+M", "Toggle Tab moves focus", "Navigation"));


                _key.Add(new CommandItem("Ctrl+F", "Find", "Search and replace"));
                _key.Add(new CommandItem("Ctrl+H", "Replace", "Search and replace"));
                _key.Add(new CommandItem("F3 / Shift+F3", "Find next/previous", "Search and replace"));
                _key.Add(new CommandItem("Alt+Enter", "Select all occurences of Find match", "Search and replace"));
                _key.Add(new CommandItem("Ctrl+D", "Add selection to next Find match", "Search and replace"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+D", "Move last selection to next Find match", "Search and replace"));
                _key.Add(new CommandItem("Alt+C / R / W", "Toggle case-sensitive / regex / whole word", "Search and replace"));


                _key.Add(new CommandItem("Alt+Click", "Insert cursor", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Ctrl+Alt+ ↑ / ↓", "Insert cursor above / below", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Ctrl+U", "Undo last cursor operation", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Shift+Alt+I", "Insert cursor at end of each line selected", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Ctrl+I", "Select current line", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Ctrl+Shift+L", "Select all occurrences of current selection", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Ctrl+F2", "Select all occurrences of current word", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Shift+Alt+→", "Expand selection", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Shift+Alt+←", "Shrink selection", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Shift+Alt + (drag mouse)", "Column (box) selection", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Ctrl+Shift+Alt+ (arrow key)", "Column (box) selection", "Multi-cursor and selection"));
                _key.Add(new CommandItem("Ctrl+Shift+Alt+PgUp/PgDn", "Column (box) selection page up/down", "Multi-cursor and selection"));


                _key.Add(new CommandItem("Ctrl+Space", "Trigger suggestion", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+Shift+Space", "Trigger parameter hints", "Rich languages editing"));
                _key.Add(new CommandItem("Shift+Alt+F", "Format document", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+F", "Format selection", "Rich languages editing"));
                _key.Add(new CommandItem("F12", "Go to Definition", "Rich languages editing"));
                _key.Add(new CommandItem("Alt+F12", "Peek Definition", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+K F12", "Open Definition to the side", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+.", "Quick Fix", "Rich languages editing"));
                _key.Add(new CommandItem("Shift+F12", "Show References", "Rich languages editing"));
                _key.Add(new CommandItem("F2", "Rename Symbol", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+X", "Trim trailing whitespace", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+K M", "Change file language", "Rich languages editing"));
                _key.Add(new CommandItem("", "", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+F4, Ctrl+W", "Close editor", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+K F", "Close folder", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+\\", "Split editor", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+ 1 / 2 / 3", "Focus into 1st, 2nd or 3rd editor group", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+ ←/→", "Focus into previous/next editor group", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+Shift+PgUp / PgDn", "Move editor left/right", "Rich languages editing"));
                _key.Add(new CommandItem("Ctrl+K ← / →", "Move active editor group", "Rich languages editing"));

                _key.Add(new CommandItem("Ctrl+N", "New File", "File management"));
                _key.Add(new CommandItem("Ctrl+O", "Open File...", "File management"));
                _key.Add(new CommandItem("Ctrl+S", "Save", "File management"));
                _key.Add(new CommandItem("Ctrl+Shift+S", "Save As...", "File management"));
                _key.Add(new CommandItem("Ctrl+K S", "Save All", "File management"));
                _key.Add(new CommandItem("Ctrl+F4", "Close", "File management"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+W", "Close All", "File management"));
                _key.Add(new CommandItem("Ctrl+Shift+T", "Reopen closed editor", "File management"));
                _key.Add(new CommandItem("Ctrl+K Enter", "Keep preview mode editor open", "File management"));
                _key.Add(new CommandItem("Ctrl+Tab", "Open next", "File management"));
                _key.Add(new CommandItem("Ctrl+Shift+Tab", "Open previous", "File management"));
                _key.Add(new CommandItem("Ctrl+K P", "Copy path of active file", "File management"));
                _key.Add(new CommandItem("Ctrl+K R", "Reveal active file in Explorer", "File management"));
                _key.Add(new CommandItem("Ctrl+K O", "Show active file in new window/instance", "File management"));


                _key.Add(new CommandItem("F11", "Toggle full screen", "Display"));
                _key.Add(new CommandItem("Shift+Alt+0", "Toggle editor layout (horizontal/vertical)", "Display"));
                _key.Add(new CommandItem("Ctrl+ = / -", "Zoom in/out", "Display"));
                _key.Add(new CommandItem("Ctrl+B", "Toggle Sidebar visibility", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+E", "Show Explorer / Toggle focus", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+F", "Show Search", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+G", "Show Source Control", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+D", "Show Debug", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+X", "Show Extensions", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+H", "Replace in files", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+J", "Toggle Search details", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+U", "Show Output panel", "Display"));
                _key.Add(new CommandItem("Ctrl+Shift+V", "Open Markdown preview", "Display"));
                _key.Add(new CommandItem("Ctrl+K V", "Open Markdown preview to the side", "Display"));
                _key.Add(new CommandItem("Ctrl+K Z", "Zen Mode (Esc Esc to exit)", "Display"));
               

                _key.Add(new CommandItem("F9", "Toggle breakpoint", "Debug"));
                _key.Add(new CommandItem("F5", "Start/Continue", "Debug"));
                _key.Add(new CommandItem("Shift+F5", "Stop", "Debug"));
                _key.Add(new CommandItem("F11 / Shift+F11", "Step into/out", "Debug"));
                _key.Add(new CommandItem("F10", "Step over", "Debug"));
                _key.Add(new CommandItem("Ctrl+K Ctrl+I", "Show hover", "Debug"));


                _key.Add(new CommandItem("Ctrl+`", "Show integrated terminal", "Integrated terminal"));
                _key.Add(new CommandItem("Ctrl+Shift+`", "Create new terminal", "Integrated terminal"));
                _key.Add(new CommandItem("Ctrl+C", "Copy selection", "Integrated terminal"));
                _key.Add(new CommandItem("Ctrl+V", "Paste into active terminal", "Integrated terminal"));
                _key.Add(new CommandItem("Ctrl+↑ / ↓", "Scroll up/down", "Integrated terminal"));
                _key.Add(new CommandItem("Shift+PgUp / PgDn", "Scroll page up/down", "Integrated terminal"));
                _key.Add(new CommandItem("Ctrl+Home / End", "Scroll to top/bottom", "Integrated terminal"));



                return _key;
            }
            set { _key = value; }
        }
    }
}
