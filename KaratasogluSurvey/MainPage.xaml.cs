namespace KaratasogluSurvey;

public partial class MainPage : ContentPage
{
    private double _age = 18;

    public double Age
    {
        get => _age;
        set
        {
            if (_age != value)
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
                OnPropertyChanged(nameof(AgeDisplay));
            }
        }
    }

    public string AgeDisplay => $"Возраст: {Age:F0}";

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void SubmitButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Спасибо!", "Ваша анкета отправлена.", "OK");
    }
}