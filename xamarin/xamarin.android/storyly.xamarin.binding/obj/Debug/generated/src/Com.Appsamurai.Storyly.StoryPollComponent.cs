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

namespace Com.Appsamurai.Storyly {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/StoryPollComponent", DoNotGenerateAcw=true)]
	public sealed partial class StoryPollComponent : global::Com.Appsamurai.Storyly.StoryComponent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StoryPollComponent", typeof (StoryPollComponent));

		internal static new IntPtr class_ref {
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

		internal StoryPollComponent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/constructor[@name='StoryPollComponent' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;ILjava/lang/String;)V", "")]
		public unsafe StoryPollComponent (string p0, string p1, global::System.Collections.Generic.IList<string> p2, int p3, string p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p4 = JNIEnv.NewString ((string)p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				global::System.GC.KeepAlive (p2);
			}
		}

		public unsafe string CustomPayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='getCustomPayload' and count(parameter)=0]"
			[Register ("getCustomPayload", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCustomPayload.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<string> Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='getOptions' and count(parameter)=0]"
			[Register ("getOptions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getOptions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int SelectedOptionIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='getSelectedOptionIndex' and count(parameter)=0]"
			[Register ("getSelectedOptionIndex", "()I", "")]
			get {
				const string __id = "getSelectedOptionIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/String;", "")]
		public unsafe string Component2 ()
		{
			const string __id = "component2.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Component3 ()
		{
			const string __id = "component3.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()I", "")]
		public unsafe int Component4 ()
		{
			const string __id = "component4.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Ljava/lang/String;", "")]
		public unsafe string Component5 ()
		{
			const string __id = "component5.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryPollComponent']/method[@name='copy' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;ILjava/lang/String;)Lcom/appsamurai/storyly/StoryPollComponent;", "")]
		public unsafe global::Com.Appsamurai.Storyly.StoryPollComponent Copy (string id, string title, global::System.Collections.Generic.IList<string> options, int selectedOptionIndex, string customPayload)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;ILjava/lang/String;)Lcom/appsamurai/storyly/StoryPollComponent;";
			IntPtr native_id = JNIEnv.NewString ((string)id);
			IntPtr native_title = JNIEnv.NewString ((string)title);
			IntPtr native_options = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (options);
			IntPtr native_customPayload = JNIEnv.NewString ((string)customPayload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_title);
				__args [2] = new JniArgumentValue (native_options);
				__args [3] = new JniArgumentValue (selectedOptionIndex);
				__args [4] = new JniArgumentValue (native_customPayload);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryPollComponent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_title);
				JNIEnv.DeleteLocalRef (native_options);
				JNIEnv.DeleteLocalRef (native_customPayload);
				global::System.GC.KeepAlive (options);
			}
		}

	}
}
