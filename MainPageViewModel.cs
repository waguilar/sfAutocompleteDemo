using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace sfAutocompleteTest;

public class MainPageViewModel : INotifyPropertyChanged
{
    //Properties
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    private string selectedMediaText;
    public string SelectedMediaText
    {
        get => selectedMediaText;
        set
        {
            if (selectedMediaText != value)
                selectedMediaText = value;
            OnPropertyChanged();
        }
    }

    private SocialMedia socialMedia;
    public SocialMedia SocialMedia
    {
        get => socialMedia;
        set
        {
            if (socialMedia != value)
                socialMedia = value;
            OnPropertyChanged();
        }
    }
    
    //Constructor
    public MainPageViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>();
        this.SocialMedias.Add(new SocialMedia() { Name = "Facebook", ID = 0 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Google Plus", ID = 1 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Instagram", ID = 2 });
        this.SocialMedias.Add(new SocialMedia() { Name = "LinkedIn", ID = 3 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Skype", ID = 4 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Telegram", ID = 5 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Televzr", ID = 6 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tik Tok", ID = 7 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tout", ID = 8 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tumblr", ID = 9 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Twitter", ID = 10 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Vimeo", ID = 11 });
        this.SocialMedias.Add(new SocialMedia() { Name = "WhatsApp", ID = 12 });
        this.SocialMedias.Add(new SocialMedia() { Name = "YouTube", ID = 13 });
    }

    //INotifyPropertyChanged Implementation
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

//Model
public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}
