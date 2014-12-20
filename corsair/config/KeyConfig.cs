using System;

namespace config
{
    public partial class KeyConfig : Gtk.Window
    {
        public KeyConfig()
            : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}

