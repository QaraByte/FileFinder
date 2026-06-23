namespace FileFinder;

public partial class FilePropertiesDialog : Form
{
    public FilePropertiesDialog(FileProperties props)
    {
        InitializeComponent();
        lblNameValue.Text = props.Name;
        txtPathValue.Text = props.Path;
        lblSizeValue.Text = props.Size;
        lblAuthorValue.Text = props.Author;
        lblCreatedValue.Text = props.CreatedAt;
    }
}
