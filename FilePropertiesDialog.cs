namespace FileFinder;

public partial class FilePropertiesDialog : Form
{
    public FilePropertiesDialog(FileProperties props)
    {
        InitializeComponent();
        ApplyLanguage();
        lblNameValue.Text    = props.Name;
        txtPathValue.Text    = props.Path;
        lblSizeValue.Text    = props.Size;
        lblAuthorValue.Text  = props.Author;
        lblCreatedValue.Text = props.CreatedAt;
    }

    private void ApplyLanguage()
    {
        Text             = Lang.PropTitle;
        lblName.Text     = Lang.PropName;
        lblPath.Text     = Lang.PropPath;
        lblSize.Text     = Lang.PropSize;
        lblAuthor.Text   = Lang.PropAuthor;
        lblCreated.Text  = Lang.PropCreated;
    }
}
