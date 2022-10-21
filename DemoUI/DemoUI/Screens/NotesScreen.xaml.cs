namespace DemoUI.Screens;

public partial class NotesScreen : ContentPage
{
    private string fileName  = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
	public NotesScreen()
	{
		InitializeComponent();
	}

    async void OnSaveButtonClick(object sender, EventArgs e)
    {
        await File.WriteAllTextAsync(fileName, editor.Text);
        await DisplayAlert("Notes", "File saved!", "Ok");
    }

    async void OnSaveDeleteClick(object sender, EventArgs e)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            await DisplayAlert("Notes", "File deleted!", "OK");
        }
        editor.Text = string.Empty;
    }
}