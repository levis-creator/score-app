using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Counter_app.Views.UserControls
{
    /// <summary>
    /// Interaction logic for Score.xaml
    /// </summary>
    public partial class Score : UserControl
    {
        public Score()
        {
            InitializeComponent();
            DataContext = this;
        }
        private string teamName;
        private int score = 0;
        public event PropertyChangedEventHandler PropertyChanged;
        public string? TeamName
        {
            get { return teamName; }
            set
            {
                teamName = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string? propertName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertName));
        }

        private void Add_Score(object sender, RoutedEventArgs e)
        {
            score++;
            display_score.Text = score.ToString();
        }
        private void Subtract_Score(object sender, RoutedEventArgs e)
        {
            if (score != 0)
            {
                score--;
                display_score.Text = score.ToString();
            }
        }
    }

}
