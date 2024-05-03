using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly", Managed="Com.Appsamurai.Storyly")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.ad", Managed="Com.Appsamurai.Storyly.AD")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.analytics", Managed="Com.Appsamurai.Storyly.Analytics")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.config", Managed="Com.Appsamurai.Storyly.Config")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.config.styling.bar", Managed="Com.Appsamurai.Storyly.Config.Styling.Bar")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.config.styling.group", Managed="Com.Appsamurai.Storyly.Config.Styling.Group")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.config.styling.moments", Managed="Com.Appsamurai.Storyly.Config.Styling.Moments")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.config.styling.story", Managed="Com.Appsamurai.Storyly.Config.Styling.Story")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.data.managers.product", Managed="Com.Appsamurai.Storyly.Data.Managers.Product")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.storylylist", Managed="Com.Appsamurai.Storyly.Storylylist")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.appsamurai.storyly.util.notification", Managed="Com.Appsamurai.Storyly.Util.Notification")]

delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPLLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

