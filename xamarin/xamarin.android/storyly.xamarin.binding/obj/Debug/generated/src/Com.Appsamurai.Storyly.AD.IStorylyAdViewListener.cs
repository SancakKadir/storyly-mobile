using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Appsamurai.Storyly.AD {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appsamurai.storyly.ad']/interface[@name='StorylyAdViewListener']"
	[Register ("com/appsamurai/storyly/ad/StorylyAdViewListener", "", "Com.Appsamurai.Storyly.AD.IStorylyAdViewListenerInvoker")]
	public partial interface IStorylyAdViewListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/interface[@name='StorylyAdViewListener']/method[@name='onLoad' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.ad.StorylyAdView']]"
		[Register ("onLoad", "(Lcom/appsamurai/storyly/ad/StorylyAdView;)V", "GetOnLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_Handler:Com.Appsamurai.Storyly.AD.IStorylyAdViewListenerInvoker, storyly.xamarin.binding")]
		void OnLoad (global::Com.Appsamurai.Storyly.AD.StorylyAdView adView);

	}

	[global::Android.Runtime.Register ("com/appsamurai/storyly/ad/StorylyAdViewListener", DoNotGenerateAcw=true)]
	internal partial class IStorylyAdViewListenerInvoker : global::Java.Lang.Object, IStorylyAdViewListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/ad/StorylyAdViewListener", typeof (IStorylyAdViewListenerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IStorylyAdViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStorylyAdViewListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.appsamurai.storyly.ad.StorylyAdViewListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStorylyAdViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_;
#pragma warning disable 0169
		static Delegate GetOnLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_Handler ()
		{
			if (cb_onLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_ == null)
				cb_onLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_));
			return cb_onLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_;
		}

		static void n_OnLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.IStorylyAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.StorylyAdView> (native_adView, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (adView);
		}
#pragma warning restore 0169

		IntPtr id_onLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_;
		public unsafe void OnLoad (global::Com.Appsamurai.Storyly.AD.StorylyAdView adView)
		{
			if (id_onLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_ == IntPtr.Zero)
				id_onLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(Lcom/appsamurai/storyly/ad/StorylyAdView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adView).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_, __args);
		}

	}

	// event args for com.appsamurai.storyly.ad.StorylyAdViewListener.onLoad
	public partial class StorylyAdViewEventArgs : global::System.EventArgs {
		public StorylyAdViewEventArgs (global::Com.Appsamurai.Storyly.AD.StorylyAdView adView)
		{
			this.adView = adView;
		}

		global::Com.Appsamurai.Storyly.AD.StorylyAdView adView;

		public global::Com.Appsamurai.Storyly.AD.StorylyAdView AdView {
			get { return adView; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/appsamurai/storyly/ad/StorylyAdViewListenerImplementor")]
	internal sealed partial class IStorylyAdViewListenerImplementor : global::Java.Lang.Object, IStorylyAdViewListener {

		object sender;

		public IStorylyAdViewListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/appsamurai/storyly/ad/StorylyAdViewListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<StorylyAdViewEventArgs> Handler;
		#pragma warning restore 0649

		public void OnLoad (global::Com.Appsamurai.Storyly.AD.StorylyAdView adView)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new StorylyAdViewEventArgs (adView));
		}

		internal static bool __IsEmpty (IStorylyAdViewListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
