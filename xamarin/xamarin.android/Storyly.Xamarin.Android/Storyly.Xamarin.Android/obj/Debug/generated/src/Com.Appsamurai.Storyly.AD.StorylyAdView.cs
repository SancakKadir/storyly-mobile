//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Appsamurai.Storyly.AD {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/ad/StorylyAdView", DoNotGenerateAcw=true)]
	public abstract partial class StorylyAdView : global::Android.Widget.FrameLayout {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/ad/StorylyAdView", typeof (StorylyAdView));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected StorylyAdView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/constructor[@name='StorylyAdView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe StorylyAdView (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/constructor[@name='StorylyAdView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe StorylyAdView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/constructor[@name='StorylyAdView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe StorylyAdView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getCustomData;
#pragma warning disable 0169
		static Delegate GetGetCustomDataHandler ()
		{
			if (cb_getCustomData == null)
				cb_getCustomData = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCustomData));
			return cb_getCustomData;
		}

		static IntPtr n_GetCustomData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.CustomData);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> CustomData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='getCustomData' and count(parameter)=0]"
			[Register ("getCustomData", "()Ljava/util/Map;", "GetGetCustomDataHandler")]
			get; 
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIcon));
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		public abstract global::Android.Net.Uri Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Landroid/net/Uri;", "GetGetIconHandler")]
			get; 
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0 OnActionClicked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='getOnActionClicked' and count(parameter)=0]"
			[Register ("getOnActionClicked", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnActionClicked.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='setOnActionClicked' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnActionClicked", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnActionClicked.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTitle));
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public abstract string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get; 
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Destroy));
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public abstract void Destroy ();

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_Load));
			return cb_load;
		}

		static long n_Load (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Load ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()J", "GetLoadHandler")]
		public abstract long Load ();

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Pause));
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public abstract void Pause ();

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Reset));
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public abstract void Reset ();

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Resume));
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public abstract void Resume ();

		static Delegate cb_setLayers_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetLayers_Ljava_util_Map_Handler ()
		{
			if (cb_setLayers_Ljava_util_Map_ == null)
				cb_setLayers_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetLayers_Ljava_util_Map_));
			return cb_setLayers_Ljava_util_Map_;
		}

		static void n_SetLayers_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layers)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layers = global::Android.Runtime.JavaDictionary<string, global::Android.Views.View>.FromJniHandle (native_layers, JniHandleOwnership.DoNotTransfer);
			__this.SetLayers (layers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='setLayers' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, ? extends android.view.View&gt;']]"
		[Register ("setLayers", "(Ljava/util/Map;)V", "GetSetLayers_Ljava_util_Map_Handler")]
		public abstract void SetLayers (global::System.Collections.Generic.IDictionary<string, global::Android.Views.View> layers);

	}

	[global::Android.Runtime.Register ("com/appsamurai/storyly/ad/StorylyAdView", DoNotGenerateAcw=true)]
	internal partial class StorylyAdViewInvoker : StorylyAdView {
		public StorylyAdViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/ad/StorylyAdView", typeof (StorylyAdViewInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> CustomData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='getCustomData' and count(parameter)=0]"
			[Register ("getCustomData", "()Ljava/util/Map;", "GetGetCustomDataHandler")]
			get {
				const string __id = "getCustomData.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Net.Uri Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Landroid/net/Uri;", "GetGetIconHandler")]
			get {
				const string __id = "getIcon.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public override unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()J", "GetLoadHandler")]
		public override unsafe long Load ()
		{
			const string __id = "load.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public override unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public override unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public override unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/class[@name='StorylyAdView']/method[@name='setLayers' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, ? extends android.view.View&gt;']]"
		[Register ("setLayers", "(Ljava/util/Map;)V", "GetSetLayers_Ljava_util_Map_Handler")]
		public override unsafe void SetLayers (global::System.Collections.Generic.IDictionary<string, global::Android.Views.View> layers)
		{
			const string __id = "setLayers.(Ljava/util/Map;)V";
			IntPtr native_layers = global::Android.Runtime.JavaDictionary<string, global::Android.Views.View>.ToLocalJniHandle (layers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_layers);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_layers);
				global::System.GC.KeepAlive (layers);
			}
		}

	}
}
