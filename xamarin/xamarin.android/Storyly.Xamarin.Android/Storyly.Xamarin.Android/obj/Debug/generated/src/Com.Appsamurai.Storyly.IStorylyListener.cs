using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Appsamurai.Storyly {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/StorylyListener$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class StorylyListenerDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StorylyListener$DefaultImpls", typeof (StorylyListenerDefaultImpls));

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

		internal StorylyListenerDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']/method[@name='storylyActionClicked' and count(parameter)=3 and parameter[1][@type='com.appsamurai.storyly.StorylyListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView'] and parameter[3][@type='com.appsamurai.storyly.Story']]"
		[Register ("storylyActionClicked", "(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/Story;)V", "")]
		public static unsafe void StorylyActionClicked (global::Com.Appsamurai.Storyly.IStorylyListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Story story)
		{
			const string __id = "storylyActionClicked.(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/Story;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				__args [2] = new JniArgumentValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
				global::System.GC.KeepAlive (story);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']/method[@name='storylyEvent' and count(parameter)=6 and parameter[1][@type='com.appsamurai.storyly.StorylyListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView'] and parameter[3][@type='com.appsamurai.storyly.analytics.StorylyEvent'] and parameter[4][@type='com.appsamurai.storyly.StoryGroup'] and parameter[5][@type='com.appsamurai.storyly.Story'] and parameter[6][@type='com.appsamurai.storyly.StoryComponent']]"
		[Register ("storylyEvent", "(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V", "")]
		public static unsafe void StorylyEvent (global::Com.Appsamurai.Storyly.IStorylyListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent)
		{
			const string __id = "storylyEvent.(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [3] = new JniArgumentValue ((storyGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyGroup).Handle);
				__args [4] = new JniArgumentValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
				__args [5] = new JniArgumentValue ((storyComponent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyComponent).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
				global::System.GC.KeepAlive (e);
				global::System.GC.KeepAlive (storyGroup);
				global::System.GC.KeepAlive (story);
				global::System.GC.KeepAlive (storyComponent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']/method[@name='storylyLoadFailed' and count(parameter)=3 and parameter[1][@type='com.appsamurai.storyly.StorylyListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView'] and parameter[3][@type='java.lang.String']]"
		[Register ("storylyLoadFailed", "(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V", "")]
		public static unsafe void StorylyLoadFailed (global::Com.Appsamurai.Storyly.IStorylyListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage)
		{
			const string __id = "storylyLoadFailed.(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V";
			IntPtr native_errorMessage = JNIEnv.NewString ((string)errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				__args [2] = new JniArgumentValue (native_errorMessage);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']/method[@name='storylyLoaded' and count(parameter)=4 and parameter[1][@type='com.appsamurai.storyly.StorylyListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView'] and parameter[3][@type='java.util.List&lt;com.appsamurai.storyly.StoryGroup&gt;'] and parameter[4][@type='com.appsamurai.storyly.StorylyDataSource']]"
		[Register ("storylyLoaded", "(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;Lcom/appsamurai/storyly/StorylyDataSource;)V", "")]
		public static unsafe void StorylyLoaded (global::Com.Appsamurai.Storyly.IStorylyListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.StoryGroup> storyGroupList, global::Com.Appsamurai.Storyly.StorylyDataSource dataSource)
		{
			const string __id = "storylyLoaded.(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;Lcom/appsamurai/storyly/StorylyDataSource;)V";
			IntPtr native_storyGroupList = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.StoryGroup>.ToLocalJniHandle (storyGroupList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				__args [2] = new JniArgumentValue (native_storyGroupList);
				__args [3] = new JniArgumentValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_storyGroupList);
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
				global::System.GC.KeepAlive (storyGroupList);
				global::System.GC.KeepAlive (dataSource);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']/method[@name='storylyStoryDismissed' and count(parameter)=2 and parameter[1][@type='com.appsamurai.storyly.StorylyListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView']]"
		[Register ("storylyStoryDismissed", "(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;)V", "")]
		public static unsafe void StorylyStoryDismissed (global::Com.Appsamurai.Storyly.IStorylyListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView)
		{
			const string __id = "storylyStoryDismissed.(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']/method[@name='storylyStoryShowFailed' and count(parameter)=3 and parameter[1][@type='com.appsamurai.storyly.StorylyListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView'] and parameter[3][@type='java.lang.String']]"
		[Register ("storylyStoryShowFailed", "(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V", "")]
		public static unsafe void StorylyStoryShowFailed (global::Com.Appsamurai.Storyly.IStorylyListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage)
		{
			const string __id = "storylyStoryShowFailed.(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V";
			IntPtr native_errorMessage = JNIEnv.NewString ((string)errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				__args [2] = new JniArgumentValue (native_errorMessage);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMessage);
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']/method[@name='storylyStoryShown' and count(parameter)=2 and parameter[1][@type='com.appsamurai.storyly.StorylyListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView']]"
		[Register ("storylyStoryShown", "(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;)V", "")]
		public static unsafe void StorylyStoryShown (global::Com.Appsamurai.Storyly.IStorylyListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView)
		{
			const string __id = "storylyStoryShown.(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyListener.DefaultImpls']/method[@name='storylyUserInteracted' and count(parameter)=5 and parameter[1][@type='com.appsamurai.storyly.StorylyListener'] and parameter[2][@type='com.appsamurai.storyly.StorylyView'] and parameter[3][@type='com.appsamurai.storyly.StoryGroup'] and parameter[4][@type='com.appsamurai.storyly.Story'] and parameter[5][@type='com.appsamurai.storyly.StoryComponent']]"
		[Register ("storylyUserInteracted", "(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V", "")]
		public static unsafe void StorylyUserInteracted (global::Com.Appsamurai.Storyly.IStorylyListener this_, global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent)
		{
			const string __id = "storylyUserInteracted.(Lcom/appsamurai/storyly/StorylyListener;Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
				__args [2] = new JniArgumentValue ((storyGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyGroup).Handle);
				__args [3] = new JniArgumentValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
				__args [4] = new JniArgumentValue ((storyComponent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyComponent).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (storylyView);
				global::System.GC.KeepAlive (storyGroup);
				global::System.GC.KeepAlive (story);
				global::System.GC.KeepAlive (storyComponent);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']"
	[Register ("com/appsamurai/storyly/StorylyListener", "", "Com.Appsamurai.Storyly.IStorylyListenerInvoker")]
	public partial interface IStorylyListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']/method[@name='storylyActionClicked' and count(parameter)=2 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='com.appsamurai.storyly.Story']]"
		[Register ("storylyActionClicked", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/Story;)V", "GetStorylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyActionClicked (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Story story);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']/method[@name='storylyEvent' and count(parameter)=5 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='com.appsamurai.storyly.analytics.StorylyEvent'] and parameter[3][@type='com.appsamurai.storyly.StoryGroup'] and parameter[4][@type='com.appsamurai.storyly.Story'] and parameter[5][@type='com.appsamurai.storyly.StoryComponent']]"
		[Register ("storylyEvent", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V", "GetStorylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyEvent (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']/method[@name='storylyLoadFailed' and count(parameter)=2 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='java.lang.String']]"
		[Register ("storylyLoadFailed", "(Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V", "GetStorylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyLoadFailed (global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']/method[@name='storylyLoaded' and count(parameter)=3 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='java.util.List&lt;com.appsamurai.storyly.StoryGroup&gt;'] and parameter[3][@type='com.appsamurai.storyly.StorylyDataSource']]"
		[Register ("storylyLoaded", "(Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;Lcom/appsamurai/storyly/StorylyDataSource;)V", "GetStorylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyLoaded (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.StoryGroup> storyGroupList, global::Com.Appsamurai.Storyly.StorylyDataSource dataSource);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']/method[@name='storylyStoryDismissed' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.StorylyView']]"
		[Register ("storylyStoryDismissed", "(Lcom/appsamurai/storyly/StorylyView;)V", "GetStorylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyStoryDismissed (global::Com.Appsamurai.Storyly.StorylyView storylyView);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']/method[@name='storylyStoryShowFailed' and count(parameter)=2 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='java.lang.String']]"
		[Register ("storylyStoryShowFailed", "(Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V", "GetStorylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyStoryShowFailed (global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']/method[@name='storylyStoryShown' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.StorylyView']]"
		[Register ("storylyStoryShown", "(Lcom/appsamurai/storyly/StorylyView;)V", "GetStorylyStoryShown_Lcom_appsamurai_storyly_StorylyView_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyStoryShown (global::Com.Appsamurai.Storyly.StorylyView storylyView);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyListener']/method[@name='storylyUserInteracted' and count(parameter)=4 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='com.appsamurai.storyly.StoryGroup'] and parameter[3][@type='com.appsamurai.storyly.Story'] and parameter[4][@type='com.appsamurai.storyly.StoryComponent']]"
		[Register ("storylyUserInteracted", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V", "GetStorylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyUserInteracted (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent);

	}

	[global::Android.Runtime.Register ("com/appsamurai/storyly/StorylyListener", DoNotGenerateAcw=true)]
	internal partial class IStorylyListenerInvoker : global::Java.Lang.Object, IStorylyListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StorylyListener", typeof (IStorylyListenerInvoker));

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

		public static IStorylyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStorylyListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.appsamurai.storyly.StorylyListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStorylyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_storylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_;
#pragma warning disable 0169
		static Delegate GetStorylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_Handler ()
		{
			if (cb_storylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_ == null)
				cb_storylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_StorylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_));
			return cb_storylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_;
		}

		static void n_StorylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_story)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var story = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Story> (native_story, JniHandleOwnership.DoNotTransfer);
			__this.StorylyActionClicked (storylyView, story);
		}
#pragma warning restore 0169

		IntPtr id_storylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_;
		public unsafe void StorylyActionClicked (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Story story)
		{
			if (id_storylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_ == IntPtr.Zero)
				id_storylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_ = JNIEnv.GetMethodID (class_ref, "storylyActionClicked", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/Story;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_, __args);
		}

		static Delegate cb_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_;
#pragma warning disable 0169
		static Delegate GetStorylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_Handler ()
		{
			if (cb_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ == null)
				cb_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_StorylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_));
			return cb_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_;
		}

		static void n_StorylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_e, IntPtr native_storyGroup, IntPtr native_story, IntPtr native_storyComponent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Analytics.StorylyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			var storyGroup = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryGroup> (native_storyGroup, JniHandleOwnership.DoNotTransfer);
			var story = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Story> (native_story, JniHandleOwnership.DoNotTransfer);
			var storyComponent = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryComponent> (native_storyComponent, JniHandleOwnership.DoNotTransfer);
			__this.StorylyEvent (storylyView, e, storyGroup, story, storyComponent);
		}
#pragma warning restore 0169

		IntPtr id_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_;
		public unsafe void StorylyEvent (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent)
		{
			if (id_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ == IntPtr.Zero)
				id_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ = JNIEnv.GetMethodID (class_ref, "storylyEvent", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			__args [2] = new JValue ((storyGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyGroup).Handle);
			__args [3] = new JValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
			__args [4] = new JValue ((storyComponent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyComponent).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_, __args);
		}

		static Delegate cb_storylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStorylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_Handler ()
		{
			if (cb_storylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ == null)
				cb_storylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_StorylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_));
			return cb_storylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_;
		}

		static void n_StorylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_errorMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var errorMessage = JNIEnv.GetString (native_errorMessage, JniHandleOwnership.DoNotTransfer);
			__this.StorylyLoadFailed (storylyView, errorMessage);
		}
#pragma warning restore 0169

		IntPtr id_storylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_;
		public unsafe void StorylyLoadFailed (global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage)
		{
			if (id_storylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ == IntPtr.Zero)
				id_storylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "storylyLoadFailed", "(Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V");
			IntPtr native_errorMessage = JNIEnv.NewString ((string)errorMessage);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue (native_errorMessage);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_errorMessage);
		}

		static Delegate cb_storylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_;
#pragma warning disable 0169
		static Delegate GetStorylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_Handler ()
		{
			if (cb_storylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_ == null)
				cb_storylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_StorylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_));
			return cb_storylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_;
		}

		static void n_StorylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_storyGroupList, IntPtr native_dataSource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var storyGroupList = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.StoryGroup>.FromJniHandle (native_storyGroupList, JniHandleOwnership.DoNotTransfer);
			var dataSource = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyDataSource> (native_dataSource, JniHandleOwnership.DoNotTransfer);
			__this.StorylyLoaded (storylyView, storyGroupList, dataSource);
		}
#pragma warning restore 0169

		IntPtr id_storylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_;
		public unsafe void StorylyLoaded (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.StoryGroup> storyGroupList, global::Com.Appsamurai.Storyly.StorylyDataSource dataSource)
		{
			if (id_storylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_ == IntPtr.Zero)
				id_storylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_ = JNIEnv.GetMethodID (class_ref, "storylyLoaded", "(Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;Lcom/appsamurai/storyly/StorylyDataSource;)V");
			IntPtr native_storyGroupList = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.StoryGroup>.ToLocalJniHandle (storyGroupList);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue (native_storyGroupList);
			__args [2] = new JValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_, __args);
			JNIEnv.DeleteLocalRef (native_storyGroupList);
		}

		static Delegate cb_storylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_;
#pragma warning disable 0169
		static Delegate GetStorylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_Handler ()
		{
			if (cb_storylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_ == null)
				cb_storylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_StorylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_));
			return cb_storylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_;
		}

		static void n_StorylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			__this.StorylyStoryDismissed (storylyView);
		}
#pragma warning restore 0169

		IntPtr id_storylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_;
		public unsafe void StorylyStoryDismissed (global::Com.Appsamurai.Storyly.StorylyView storylyView)
		{
			if (id_storylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_ == IntPtr.Zero)
				id_storylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_ = JNIEnv.GetMethodID (class_ref, "storylyStoryDismissed", "(Lcom/appsamurai/storyly/StorylyView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_, __args);
		}

		static Delegate cb_storylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStorylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_Handler ()
		{
			if (cb_storylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ == null)
				cb_storylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_StorylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_));
			return cb_storylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_;
		}

		static void n_StorylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_errorMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var errorMessage = JNIEnv.GetString (native_errorMessage, JniHandleOwnership.DoNotTransfer);
			__this.StorylyStoryShowFailed (storylyView, errorMessage);
		}
#pragma warning restore 0169

		IntPtr id_storylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_;
		public unsafe void StorylyStoryShowFailed (global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage)
		{
			if (id_storylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ == IntPtr.Zero)
				id_storylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "storylyStoryShowFailed", "(Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V");
			IntPtr native_errorMessage = JNIEnv.NewString ((string)errorMessage);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue (native_errorMessage);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_errorMessage);
		}

		static Delegate cb_storylyStoryShown_Lcom_appsamurai_storyly_StorylyView_;
#pragma warning disable 0169
		static Delegate GetStorylyStoryShown_Lcom_appsamurai_storyly_StorylyView_Handler ()
		{
			if (cb_storylyStoryShown_Lcom_appsamurai_storyly_StorylyView_ == null)
				cb_storylyStoryShown_Lcom_appsamurai_storyly_StorylyView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_StorylyStoryShown_Lcom_appsamurai_storyly_StorylyView_));
			return cb_storylyStoryShown_Lcom_appsamurai_storyly_StorylyView_;
		}

		static void n_StorylyStoryShown_Lcom_appsamurai_storyly_StorylyView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			__this.StorylyStoryShown (storylyView);
		}
#pragma warning restore 0169

		IntPtr id_storylyStoryShown_Lcom_appsamurai_storyly_StorylyView_;
		public unsafe void StorylyStoryShown (global::Com.Appsamurai.Storyly.StorylyView storylyView)
		{
			if (id_storylyStoryShown_Lcom_appsamurai_storyly_StorylyView_ == IntPtr.Zero)
				id_storylyStoryShown_Lcom_appsamurai_storyly_StorylyView_ = JNIEnv.GetMethodID (class_ref, "storylyStoryShown", "(Lcom/appsamurai/storyly/StorylyView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyStoryShown_Lcom_appsamurai_storyly_StorylyView_, __args);
		}

		static Delegate cb_storylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_;
#pragma warning disable 0169
		static Delegate GetStorylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_Handler ()
		{
			if (cb_storylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ == null)
				cb_storylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_StorylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_));
			return cb_storylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_;
		}

		static void n_StorylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_storyGroup, IntPtr native_story, IntPtr native_storyComponent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var storyGroup = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryGroup> (native_storyGroup, JniHandleOwnership.DoNotTransfer);
			var story = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Story> (native_story, JniHandleOwnership.DoNotTransfer);
			var storyComponent = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryComponent> (native_storyComponent, JniHandleOwnership.DoNotTransfer);
			__this.StorylyUserInteracted (storylyView, storyGroup, story, storyComponent);
		}
#pragma warning restore 0169

		IntPtr id_storylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_;
		public unsafe void StorylyUserInteracted (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent)
		{
			if (id_storylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ == IntPtr.Zero)
				id_storylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_ = JNIEnv.GetMethodID (class_ref, "storylyUserInteracted", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue ((storyGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyGroup).Handle);
			__args [2] = new JValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
			__args [3] = new JValue ((storyComponent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storyComponent).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_, __args);
		}

	}

	// event args for com.appsamurai.storyly.StorylyListener.storylyActionClicked
	public partial class StorylyActionClickedEventArgs : global::System.EventArgs {
		public StorylyActionClickedEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Story story)
		{
			this.storylyView = storylyView;
			this.story = story;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		global::Com.Appsamurai.Storyly.Story story;

		public global::Com.Appsamurai.Storyly.Story Story {
			get { return story; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyListener.storylyEvent
	public partial class StorylyEventEventArgs : global::System.EventArgs {
		public StorylyEventEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent)
		{
			this.storylyView = storylyView;
			this.e = e;
			this.storyGroup = storyGroup;
			this.story = story;
			this.storyComponent = storyComponent;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e;

		public global::Com.Appsamurai.Storyly.Analytics.StorylyEvent Event {
			get { return e; }
		}

		global::Com.Appsamurai.Storyly.StoryGroup storyGroup;

		public global::Com.Appsamurai.Storyly.StoryGroup StoryGroup {
			get { return storyGroup; }
		}

		global::Com.Appsamurai.Storyly.Story story;

		public global::Com.Appsamurai.Storyly.Story Story {
			get { return story; }
		}

		global::Com.Appsamurai.Storyly.StoryComponent storyComponent;

		public global::Com.Appsamurai.Storyly.StoryComponent StoryComponent {
			get { return storyComponent; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyListener.storylyLoadFailed
	public partial class StorylyLoadFailedEventArgs : global::System.EventArgs {
		public StorylyLoadFailedEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage)
		{
			this.storylyView = storylyView;
			this.errorMessage = errorMessage;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		string errorMessage;

		public string ErrorMessage {
			get { return errorMessage; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyListener.storylyLoaded
	public partial class StorylyLoadedEventArgs : global::System.EventArgs {
		public StorylyLoadedEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.StoryGroup> storyGroupList, global::Com.Appsamurai.Storyly.StorylyDataSource dataSource)
		{
			this.storylyView = storylyView;
			this.storyGroupList = storyGroupList;
			this.dataSource = dataSource;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.StoryGroup> storyGroupList;

		public global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.StoryGroup> StoryGroupList {
			get { return storyGroupList; }
		}

		global::Com.Appsamurai.Storyly.StorylyDataSource dataSource;

		public global::Com.Appsamurai.Storyly.StorylyDataSource DataSource {
			get { return dataSource; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyListener.storylyStoryDismissed
	public partial class StorylyStoryDismissedEventArgs : global::System.EventArgs {
		public StorylyStoryDismissedEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView)
		{
			this.storylyView = storylyView;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyListener.storylyStoryShowFailed
	public partial class StorylyStoryShowFailedEventArgs : global::System.EventArgs {
		public StorylyStoryShowFailedEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage)
		{
			this.storylyView = storylyView;
			this.errorMessage = errorMessage;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		string errorMessage;

		public string ErrorMessage {
			get { return errorMessage; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyListener.storylyStoryShown
	public partial class StorylyStoryShownEventArgs : global::System.EventArgs {
		public StorylyStoryShownEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView)
		{
			this.storylyView = storylyView;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyListener.storylyUserInteracted
	public partial class StorylyUserInteractedEventArgs : global::System.EventArgs {
		public StorylyUserInteractedEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent)
		{
			this.storylyView = storylyView;
			this.storyGroup = storyGroup;
			this.story = story;
			this.storyComponent = storyComponent;
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

		global::Com.Appsamurai.Storyly.StoryComponent storyComponent;

		public global::Com.Appsamurai.Storyly.StoryComponent StoryComponent {
			get { return storyComponent; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/appsamurai/storyly/StorylyListenerImplementor")]
	internal sealed partial class IStorylyListenerImplementor : global::Java.Lang.Object, IStorylyListener {

		object sender;

		public IStorylyListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/appsamurai/storyly/StorylyListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<StorylyActionClickedEventArgs> StorylyActionClickedHandler;
		#pragma warning restore 0649

		public void StorylyActionClicked (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Story story)
		{
			var __h = StorylyActionClickedHandler;
			if (__h != null)
				__h (sender, new StorylyActionClickedEventArgs (storylyView, story));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyEventEventArgs> StorylyEventHandler;
		#pragma warning restore 0649

		public void StorylyEvent (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent)
		{
			var __h = StorylyEventHandler;
			if (__h != null)
				__h (sender, new StorylyEventEventArgs (storylyView, e, storyGroup, story, storyComponent));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyLoadFailedEventArgs> StorylyLoadFailedHandler;
		#pragma warning restore 0649

		public void StorylyLoadFailed (global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage)
		{
			var __h = StorylyLoadFailedHandler;
			if (__h != null)
				__h (sender, new StorylyLoadFailedEventArgs (storylyView, errorMessage));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyLoadedEventArgs> StorylyLoadedHandler;
		#pragma warning restore 0649

		public void StorylyLoaded (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.StoryGroup> storyGroupList, global::Com.Appsamurai.Storyly.StorylyDataSource dataSource)
		{
			var __h = StorylyLoadedHandler;
			if (__h != null)
				__h (sender, new StorylyLoadedEventArgs (storylyView, storyGroupList, dataSource));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyStoryDismissedEventArgs> StorylyStoryDismissedHandler;
		#pragma warning restore 0649

		public void StorylyStoryDismissed (global::Com.Appsamurai.Storyly.StorylyView storylyView)
		{
			var __h = StorylyStoryDismissedHandler;
			if (__h != null)
				__h (sender, new StorylyStoryDismissedEventArgs (storylyView));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyStoryShowFailedEventArgs> StorylyStoryShowFailedHandler;
		#pragma warning restore 0649

		public void StorylyStoryShowFailed (global::Com.Appsamurai.Storyly.StorylyView storylyView, string errorMessage)
		{
			var __h = StorylyStoryShowFailedHandler;
			if (__h != null)
				__h (sender, new StorylyStoryShowFailedEventArgs (storylyView, errorMessage));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyStoryShownEventArgs> StorylyStoryShownHandler;
		#pragma warning restore 0649

		public void StorylyStoryShown (global::Com.Appsamurai.Storyly.StorylyView storylyView)
		{
			var __h = StorylyStoryShownHandler;
			if (__h != null)
				__h (sender, new StorylyStoryShownEventArgs (storylyView));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyUserInteractedEventArgs> StorylyUserInteractedHandler;
		#pragma warning restore 0649

		public void StorylyUserInteracted (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.StoryGroup storyGroup, global::Com.Appsamurai.Storyly.Story story, global::Com.Appsamurai.Storyly.StoryComponent storyComponent)
		{
			var __h = StorylyUserInteractedHandler;
			if (__h != null)
				__h (sender, new StorylyUserInteractedEventArgs (storylyView, storyGroup, story, storyComponent));
		}

		internal static bool __IsEmpty (IStorylyListenerImplementor value)
		{
			return value.StorylyActionClickedHandler == null && value.StorylyEventHandler == null && value.StorylyLoadFailedHandler == null && value.StorylyLoadedHandler == null && value.StorylyStoryDismissedHandler == null && value.StorylyStoryShowFailedHandler == null && value.StorylyStoryShownHandler == null && value.StorylyUserInteractedHandler == null;
		}

	}
}
