using Engine.EventArgs;
using Engine.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CC31N_TeamMaki;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private  GameSessions _gameSessions = new GameSessions();
    public MainWindow()
    {
        InitializeComponent();
     
        _gameSessions.OnMessageRaised += OnGameMessageRaised;

        DataContext = _gameSessions;
    }

    private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
    {
        _gameSessions.MoveNorth();
    }

    private void OnClick_MoveWest(object sender, RoutedEventArgs e)
    {
        _gameSessions.MoveWest();
    }

    private void OnClick_MoveEast(object sender, RoutedEventArgs e)
    {
        _gameSessions.MoveEast();
    }

    private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
    {
        _gameSessions.MoveSouth();
    }
    private void OnClick_AttackMonster(object sender, RoutedEventArgs e)
    {
        _gameSessions.AttackCurrentMonster();
    }
    private void OnGameMessageRaised (object sender, GameMessageEventArgs e)
    {
        GameMessages.Document.Blocks.Add(new Paragraph(new Run(e.Message)));
        GameMessages.ScrollToEnd(); 
    }
}