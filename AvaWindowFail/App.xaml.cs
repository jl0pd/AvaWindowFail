using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Avalonia;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Themes.Fluent;
using Application = System.Windows.Application;

namespace AvaWindowFail
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppBuilder.Configure<AvaApp>().UseWin32().UseSkia().SetupWithoutStarting();
        }
    }

    public class AvaApp : Avalonia.Application
    {
        public override void Initialize()
        {
            base.Styles.Add(new FluentTheme(baseUri: null!) { Mode = FluentThemeMode.Dark });
            base.Initialize();
        }
    }
}
