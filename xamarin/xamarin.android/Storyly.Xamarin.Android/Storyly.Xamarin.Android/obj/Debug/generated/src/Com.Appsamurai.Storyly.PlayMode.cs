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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/PlayMode", DoNotGenerateAcw=true)]
	public sealed partial class PlayMode : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode']/field[@name='Default']"
		[Register ("Default")]
		public static global::Com.Appsamurai.Storyly.PlayMode Default {
			get {
				const string __id = "Default.Lcom/appsamurai/storyly/PlayMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.PlayMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode']/field[@name='Story']"
		[Register ("Story")]
		public static global::Com.Appsamurai.Storyly.PlayMode Story {
			get {
				const string __id = "Story.Lcom/appsamurai/storyly/PlayMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.PlayMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode']/field[@name='StoryGroup']"
		[Register ("StoryGroup")]
		public static global::Com.Appsamurai.Storyly.PlayMode StoryGroup {
			get {
				const string __id = "StoryGroup.Lcom/appsamurai/storyly/PlayMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.PlayMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode.Companion']"
		[global::Android.Runtime.Register ("com/appsamurai/storyly/PlayMode$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/PlayMode$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode.Companion']/constructor[@name='PlayMode.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (_constructor_marker);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode.Companion']/method[@name='getFromValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getFromValue", "(Ljava/lang/String;)Lcom/appsamurai/storyly/PlayMode;", "")]
			public unsafe global::Com.Appsamurai.Storyly.PlayMode GetFromValue (string s)
			{
				const string __id = "getFromValue.(Ljava/lang/String;)Lcom/appsamurai/storyly/PlayMode;";
				IntPtr native_s = JNIEnv.NewString ((string)s);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_s);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.PlayMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_s);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/PlayMode", typeof (PlayMode));

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

		internal PlayMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/appsamurai/storyly/PlayMode;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.PlayMode ValueOf (string value)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/appsamurai/storyly/PlayMode;";
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.PlayMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='PlayMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/appsamurai/storyly/PlayMode;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.PlayMode[] Values ()
		{
			const string __id = "values.()[Lcom/appsamurai/storyly/PlayMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Appsamurai.Storyly.PlayMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appsamurai.Storyly.PlayMode));
			} finally {
			}
		}

	}
}
