using Core.ViewModels;
using MvvmCross.Plugin;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Core;

public class App : MvxApplication
{
    public override void Initialize()
    {
        if (Mvx.IoCProvider is null)
            throw new Exception("IoCProvider is null");

        var pluginManager = Mvx.IoCProvider.Resolve<IMvxPluginManager>() ?? throw new Exception("Failed to resolve IMvxPluginManager");
        pluginManager.EnsurePluginLoaded<MvvmCross.Plugin.FieldBinding.Plugin>(true);

        // This only works on Android if you are using MvxSetupActivity and will otherwise be ignored
        RegisterAppStart<MainViewModel>();
    }
}