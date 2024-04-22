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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/StoryEmojiComponent", DoNotGenerateAcw=true)]
	public sealed partial class StoryEmojiComponent : global::Com.Appsamurai.Storyly.StoryComponent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StoryEmojiComponent", typeof (StoryEmojiComponent));

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

		internal StoryEmojiComponent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/constructor[@name='StoryEmojiComponent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;ILjava/lang/String;)V", "")]
		public unsafe StoryEmojiComponent (string id, global::System.Collections.Generic.IList<string> emojiCodes, int selectedEmojiIndex, string customPayload) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/List;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString ((string)id);
			IntPtr native_emojiCodes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (emojiCodes);
			IntPtr native_customPayload = JNIEnv.NewString ((string)customPayload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_emojiCodes);
				__args [2] = new JniArgumentValue (selectedEmojiIndex);
				__args [3] = new JniArgumentValue (native_customPayload);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_emojiCodes);
				JNIEnv.DeleteLocalRef (native_customPayload);
				global::System.GC.KeepAlive (emojiCodes);
			}
		}

		public unsafe string CustomPayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/method[@name='getCustomPayload' and count(parameter)=0]"
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

		public unsafe global::System.Collections.Generic.IList<string> EmojiCodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/method[@name='getEmojiCodes' and count(parameter)=0]"
			[Register ("getEmojiCodes", "()Ljava/util/List;", "")]
			get {
				const string __id = "getEmojiCodes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int SelectedEmojiIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/method[@name='getSelectedEmojiIndex' and count(parameter)=0]"
			[Register ("getSelectedEmojiIndex", "()I", "")]
			get {
				const string __id = "getSelectedEmojiIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Component2 ()
		{
			const string __id = "component2.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()I", "")]
		public unsafe int Component3 ()
		{
			const string __id = "component3.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/String;", "")]
		public unsafe string Component4 ()
		{
			const string __id = "component4.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryEmojiComponent']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/util/List;ILjava/lang/String;)Lcom/appsamurai/storyly/StoryEmojiComponent;", "")]
		public unsafe global::Com.Appsamurai.Storyly.StoryEmojiComponent Copy (string id, global::System.Collections.Generic.IList<string> emojiCodes, int selectedEmojiIndex, string customPayload)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/util/List;ILjava/lang/String;)Lcom/appsamurai/storyly/StoryEmojiComponent;";
			IntPtr native_id = JNIEnv.NewString ((string)id);
			IntPtr native_emojiCodes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (emojiCodes);
			IntPtr native_customPayload = JNIEnv.NewString ((string)customPayload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_emojiCodes);
				__args [2] = new JniArgumentValue (selectedEmojiIndex);
				__args [3] = new JniArgumentValue (native_customPayload);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryEmojiComponent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_emojiCodes);
				JNIEnv.DeleteLocalRef (native_customPayload);
				global::System.GC.KeepAlive (emojiCodes);
			}
		}

	}
}
