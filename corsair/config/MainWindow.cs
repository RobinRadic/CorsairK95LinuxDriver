using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
    public MainWindow()
        : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void btnG1Click(object sender, EventArgs e)
    {
        ConfigKey configKeyDialog = new ConfigKey(1);
        configKeyDialog.Show();
    }
}
