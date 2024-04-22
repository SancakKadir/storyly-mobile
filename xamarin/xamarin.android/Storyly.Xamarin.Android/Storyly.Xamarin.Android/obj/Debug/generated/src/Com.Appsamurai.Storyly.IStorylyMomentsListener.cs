using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Appsamurai.Storyly {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyMomentsListener.DefaultImpls']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/StorylyMomentsListener$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class StorylyMomentsListenerDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StorylyMomentsListener$DefaultImpls", typeof (StorylyMomentsListenerDefaultImpls));

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

		internal StorylyMomentsListenerDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyMomentsListener.DefaultImpls']/method[@name='storyHeaderClicked' and count(parameter)=4 and parameter[1][@type='com.appsamurai.storyly.StorylyMomentsListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView'] and parameter[3][@type='com.appsamurai.storyly.StoryGroup'] and parameter[4][@type='com.appsamurai.storyly.Story']]"
		[Register ("storyHeaderClicked", "(Lcom/appsamurai/storyly/StorylyMomentsListener;Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;)V", "")]
		public static unsafe void StoryHeaderClicked (global::Com.Appsamurai.Storyly.IStorylyMomentsListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story)
		{
			const string __id = "storyHeaderClicked.(Lcom/appsamurai/storyly/StorylyMomentsListener;Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				__args [2] = new JniArgumentValue ((storyGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyGroup).Handle);
				__args [3] = new JniArgumentValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
				global::System.GC.KeepAlive (storyGroup);
				global::System.GC.KeepAlive (story);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyMomentsListener']"
	[Register ("com/appsamurai/storyly/StorylyMomentsListener", "", "Com.Appsamurai.Storyly.IStorylyMomentsListenerInvoker")]
	public partial interface IStorylyMomentsListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyMomentsListener']/method[@name='storyHeaderClicked' and count(parameter)=3 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='com.appsamurai.storyly.StoryGroup'] and parameter[3][@type='com.appsamurai.storyly.Story']]"
		[Register ("storyHeaderClicked", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;)V", "GetStoryHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Handler:Com.Appsamurai.Storyly.IStorylyMomentsListenerInvoker, Storyly.Xamarin.Android")]
		void StoryHeaderClicked (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story);

	}

	[global::Android.Runtime.Register ("com/appsamurai/storyly/StorylyMomentsListener", DoNotGenerateAcw=true)]
	internal partial class IStorylyMomentsListenerInvoker : global::Java.Lang.Object, IStorylyMomentsListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StorylyMomentsListener", typeof (IStorylyMomentsListenerInvoker));

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

		public static IStorylyMomentsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStorylyMomentsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.appsamurai.storyly.StorylyMomentsListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStorylyMomentsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_storyHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_;
#pragma warning disable 0169
		static Delegate GetStoryHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Handler ()
		{
			if (cb_storyHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_ == null)
				cb_storyHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_StoryHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_));
			return cb_storyHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_;
		}

		static void n_StoryHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_storyGroup, IntPtr native_story)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyMomentsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var storyGroup = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryGroup> (native_storyGroup, JniHandleOwnership.DoNotTransfer);
			var story = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Story> (native_story, JniHandleOwnership.DoNotTransfer);
			__this.StoryHeaderClicked (storylyView, storyGroup, story);
		}
#pragma warning restore 0169

		IntPtr id_storyHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_;
		public unsafe void StoryHeaderClicked (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story)
		{
			if (id_storyHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_ == IntPtr.Zero)
				id_storyHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_ = JNIEnv.GetMethodID (class_ref, "storyHeaderClicked", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue ((storyGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyGroup).Handle);
			__args [2] = new JValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storyHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_, __args);
		}

	}

	// event args for com.appsamurai.storyly.StorylyMomentsListener.storyHeaderClicked
	public partial class StorylyMomentsEventArgs : global::System.EventArgs {
		public StorylyMomentsEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story)
		{
			this.storylyView = storylyView;
			this.storyGroup = storyGroup;
			this.story = story;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		global::Com.Appsamurai.Storyly.StoryGroup storyGroup;

		public global::Com.Appsamurai.Storyly.StoryGroup StoryGroup {
			get { return storyGroup; }
		}

		global::Com.Appsamurai.Storyly.Story story;

		public global::Com.Appsamurai.Storyly.Story Story {
			get { return story; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/appsamurai/storyly/StorylyMomentsListenerImplementor")]
	internal sealed partial class IStorylyMomentsListenerImplementor : global::Java.Lang.Object, IStorylyMomentsListener {

		object sender;

		public IStorylyMomentsListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/appsamurai/storyly/StorylyMomentsListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<StorylyMomentsEventArgs> Handler;
		#pragma warning restore 0649

		public void StoryHeaderClicked (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new StorylyMomentsEventArgs (storylyView, storyGroup, story));
		}

		internal static bool __IsEmpty (IStorylyMomentsListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
