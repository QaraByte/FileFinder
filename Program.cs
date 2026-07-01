namespace FileFinder;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Lang.Load();
        Application.Run(new MainForm());
    }
}
