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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyLayoutDirection']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/StorylyLayoutDirection", DoNotGenerateAcw=true)]
	public sealed partial class StorylyLayoutDirection : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyLayoutDirection']/field[@name='LTR']"
		[Register ("LTR")]
		public static global::Com.Appsamurai.Storyly.StorylyLayoutDirection Ltr {
			get {
				const string __id = "LTR.Lcom/appsamurai/storyly/StorylyLayoutDirection;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyLayoutDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyLayoutDirection']/field[@name='RTL']"
		[Register ("RTL")]
		public static global::Com.Appsamurai.Storyly.StorylyLayoutDirection Rtl {
			get {
				const string __id = "RTL.Lcom/appsamurai/storyly/StorylyLayoutDirection;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyLayoutDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyLayoutDirection.WhenMappings']"
		[global::Android.Runtime.Register ("com/appsamurai/storyly/StorylyLayoutDirection$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StorylyLayoutDirection$WhenMappings", typeof (WhenMappings));

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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StorylyLayoutDirection", typeof (StorylyLayoutDirection));

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

		internal StorylyLayoutDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyLayoutDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/appsamurai/storyly/StorylyLayoutDirection;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.StorylyLayoutDirection ValueOf (string value)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/appsamurai/storyly/StorylyLayoutDirection;";
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyLayoutDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StorylyLayoutDirection']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/appsamurai/storyly/StorylyLayoutDirection;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.StorylyLayoutDirection[] Values ()
		{
			const string __id = "values.()[Lcom/appsamurai/storyly/StorylyLayoutDirection;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Appsamurai.Storyly.StorylyLayoutDirection[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appsamurai.Storyly.StorylyLayoutDirection));
			} finally {
			}
		}

	}
}
