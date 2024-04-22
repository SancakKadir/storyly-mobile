using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Appsamurai.Storyly.AD {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appsamurai.storyly.ad']/interface[@name='StorylyAdViewProvider']"
	[Register ("com/appsamurai/storyly/ad/StorylyAdViewProvider", "", "Com.Appsamurai.Storyly.AD.IStorylyAdViewProviderInvoker")]
	public partial interface IStorylyAdViewProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.ad']/interface[@name='StorylyAdViewProvider']/method[@name='onRequest' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.ad.StorylyAdViewListener']]"
		[Register ("onRequest", "(Lcom/appsamurai/storyly/ad/StorylyAdViewListener;)V", "GetOnRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_Handler:Com.Appsamurai.Storyly.AD.IStorylyAdViewProviderInvoker, Storyly.Xamarin.Android")]
		void OnRequest (global::Com.Appsamurai.Storyly.AD.IStorylyAdViewListener adViewListener);

	}

	[global::Android.Runtime.Register ("com/appsamurai/storyly/ad/StorylyAdViewProvider", DoNotGenerateAcw=true)]
	internal partial class IStorylyAdViewProviderInvoker : global::Java.Lang.Object, IStorylyAdViewProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/ad/StorylyAdViewProvider", typeof (IStorylyAdViewProviderInvoker));

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

		public static IStorylyAdViewProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStorylyAdViewProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.appsamurai.storyly.ad.StorylyAdViewProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStorylyAdViewProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_;
#pragma warning disable 0169
		static Delegate GetOnRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_Handler ()
		{
			if (cb_onRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_ == null)
				cb_onRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_));
			return cb_onRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_;
		}

		static void n_OnRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adViewListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.IStorylyAdViewProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adViewListener = (global::Com.Appsamurai.Storyly.AD.IStorylyAdViewListener)global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.AD.IStorylyAdViewListener> (native_adViewListener, JniHandleOwnership.DoNotTransfer);
			__this.OnRequest (adViewListener);
		}
#pragma warning restore 0169

		IntPtr id_onRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_;
		public unsafe void OnRequest (global::Com.Appsamurai.Storyly.AD.IStorylyAdViewListener adViewListener)
		{
			if (id_onRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_ == IntPtr.Zero)
				id_onRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_ = JNIEnv.GetMethodID (class_ref, "onRequest", "(Lcom/appsamurai/storyly/ad/StorylyAdViewListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adViewListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adViewListener).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequest_Lcom_appsamurai_storyly_ad_StorylyAdViewListener_, __args);
		}

	}
}
