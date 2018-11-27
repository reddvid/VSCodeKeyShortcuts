using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCodeKeyboardShortcuts.UWP.Classes
{
    class CommandItem
    {
        string _keyBinding;
        public string KeyBinding
        {
            get { return _keyBinding; }
            set
            {
                _keyBinding = value.Trim();
            }
        }

        string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value.Trim();
            }
        }

        string _keyType;
        public string KeyType
        {
            get { return _keyType; }
            set
            {
                _keyType = value.Trim();
            }
        }

        public CommandItem(string keyBind, string desc, string keyType)
        {
            KeyBinding = keyBind;
            Description = desc;
            KeyType = keyType;
        }
    }
}
