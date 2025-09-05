using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Define o DataContext - é aqui que a "mágica" acontece
            DataContext = new PessoaViewModel();
        }
        public class PessoaViewModel : INotifyPropertyChanged
        {
            private string _nome = "João Silva";
            private int _idade = 25;

            // Propriedade com notificação de mudança
            public string Nome
            {
                get => _nome;
                set
                {
                    _nome = value;
                    OnPropertyChanged(nameof(Nome)); // Notifica a UI que mudou
                }
            }

            // Propriedade com notificação de mudança
            public int Idade
            {
                get => _idade;
                set
                {
                    _idade = value;
                    OnPropertyChanged(nameof(Idade)); // Notifica a UI que mudou
                }
            }

            // Coleção observável - notifica automaticamente quando items são adicionados/removidos
            public ObservableCollection<string> Hobbies { get; set; }

            // Command para botão
            public ICommand AtualizarCommand { get; }

            public PessoaViewModel()
            {
                // Inicializa a lista de hobbies
                Hobbies = new ObservableCollection<string>
            {
                "Programar",
                "Ler livros",
                "Jogar videogame",
                "Fazer exercícios"
            };

                // Inicializa o command
                AtualizarCommand = new RelayCommand(AtualizarDados);
            }

            private void AtualizarDados()
            {
                Nome = "Maria Santos";
                Idade = 30;

                Hobbies.Clear();
                Hobbies.Add("Pintar");
                Hobbies.Add("Cozinhar");
                Hobbies.Add("Viajar");
            }

            // Implementação do INotifyPropertyChanged
            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // Implementação simples de ICommand
        public class RelayCommand : ICommand
        {
            private readonly System.Action _execute;

            public RelayCommand(System.Action execute)
            {
                _execute = execute;
            }

            public bool CanExecute(object parameter) => true;

            public void Execute(object parameter) => _execute();

            public event System.EventHandler CanExecuteChanged;
        }

    }

}