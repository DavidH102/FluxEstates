using FluxEstates.Models.Services;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System.Windows;

namespace FluxEstates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddSingleton<EstateApplication>();
            serviceCollection.AddMudServices();

#if DEBUG
            serviceCollection.AddBlazorWebViewDeveloperTools();
#endif

            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}