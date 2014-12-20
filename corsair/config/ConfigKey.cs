using System;

public partial class ConfigKey : Gtk.Dialog
{
    int key;

    public ConfigKey(int key)
    {
        this.key = key;

        this.Build();

    }

    protected void onAccept(object sender, EventArgs e)
    {
        this.Destroy();
    }

    protected void onCancel(object sender, EventArgs e)
    {
        this.Destroy();
    }

}

