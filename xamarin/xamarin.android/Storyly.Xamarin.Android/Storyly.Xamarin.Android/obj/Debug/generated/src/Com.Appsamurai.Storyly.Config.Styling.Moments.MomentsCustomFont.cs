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

namespace Com.Appsamurai.Storyly.Config.Styling.Moments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly.config.styling.moments']/class[@name='MomentsCustomFont']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/config/styling/moments/MomentsCustomFont", DoNotGenerateAcw=true)]
	public sealed partial class MomentsCustomFont : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/config/styling/moments/MomentsCustomFont", typeof (MomentsCustomFont));

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

		internal MomentsCustomFont (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly.config.styling.moments']/class[@name='MomentsCustomFont']/constructor[@name='MomentsCustomFont' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Typeface']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/graphics/Typeface;)V", "")]
		public unsafe MomentsCustomFont (string identifier, global::Android.Graphics.Typeface font) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Landroid/graphics/Typeface;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_identifier = JNIEnv.NewString ((string)identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_identifier);
				__args [1] = new JniArgumentValue ((font == null) ? IntPtr.Zero : ((global::Java.Lang.Object) font).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
				global::System.GC.KeepAlive (font);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config.styling.moments']/class[@name='MomentsCustomFont']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Typeface']]"
		[Register ("copy", "(Ljava/lang/String;Landroid/graphics/Typeface;)Lcom/appsamurai/storyly/config/styling/moments/MomentsCustomFont;", "")]
		public unsafe global::Com.Appsamurai.Storyly.Config.Styling.Moments.MomentsCustomFont Copy (string identifier, global::Android.Graphics.Typeface font)
		{
			const string __id = "copy.(Ljava/lang/String;Landroid/graphics/Typeface;)Lcom/appsamurai/storyly/config/styling/moments/MomentsCustomFont;";
			IntPtr native_identifier = JNIEnv.NewString ((string)identifier);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_identifier);
				__args [1] = new JniArgumentValue ((font == null) ? IntPtr.Zero : ((global::Java.Lang.Object) font).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.Styling.Moments.MomentsCustomFont> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
				global::System.GC.KeepAlive (font);
			}
		}

	}
}
