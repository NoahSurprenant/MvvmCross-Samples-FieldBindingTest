using Android.Runtime;
using Core;
using MvvmCross.Platforms.Android.Views;

namespace AndroidApp;

[Application]
public class MainApplication : MvxAndroidApplication<Setup, App>
{
    public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }
}