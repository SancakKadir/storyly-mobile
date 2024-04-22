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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/StoryGroupBadgeStyle", DoNotGenerateAcw=true)]
	public sealed partial class StoryGroupBadgeStyle : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StoryGroupBadgeStyle", typeof (StoryGroupBadgeStyle));

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

		internal StoryGroupBadgeStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/constructor[@name='StoryGroupBadgeStyle' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Long;Ljava/lang/String;)V", "")]
		public unsafe StoryGroupBadgeStyle (string text, global::Java.Lang.Integer textColor, global::Java.Lang.Integer backgroundColor, global::Java.Lang.Long endTime, string template) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Long;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString ((string)text);
			IntPtr native_template = JNIEnv.NewString ((string)template);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((textColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textColor).Handle);
				__args [2] = new JniArgumentValue ((backgroundColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) backgroundColor).Handle);
				__args [3] = new JniArgumentValue ((endTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endTime).Handle);
				__args [4] = new JniArgumentValue (native_template);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_template);
				global::System.GC.KeepAlive (textColor);
				global::System.GC.KeepAlive (backgroundColor);
				global::System.GC.KeepAlive (endTime);
			}
		}

		public unsafe global::Java.Lang.Integer BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getBackgroundColor.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Long EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()Ljava/lang/Long;", "")]
			get {
				const string __id = "getEndTime.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Template {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='getTemplate' and count(parameter)=0]"
			[Register ("getTemplate", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTemplate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Integer TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getTextColor.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer Component2 ()
		{
			const string __id = "component2.()Ljava/lang/Integer;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer Component3 ()
		{
			const string __id = "component3.()Ljava/lang/Integer;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/Long;", "")]
		public unsafe global::Java.Lang.Long Component4 ()
		{
			const string __id = "component4.()Ljava/lang/Long;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='component5' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryGroupBadgeStyle']/method[@name='copy' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Long;Ljava/lang/String;)Lcom/appsamurai/storyly/StoryGroupBadgeStyle;", "")]
		public unsafe global::Com.Appsamurai.Storyly.StoryGroupBadgeStyle Copy (string text, global::Java.Lang.Integer textColor, global::Java.Lang.Integer backgroundColor, global::Java.Lang.Long endTime, string template)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Long;Ljava/lang/String;)Lcom/appsamurai/storyly/StoryGroupBadgeStyle;";
			IntPtr native_text = JNIEnv.NewString ((string)text);
			IntPtr native_template = JNIEnv.NewString ((string)template);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((textColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textColor).Handle);
				__args [2] = new JniArgumentValue ((backgroundColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) backgroundColor).Handle);
				__args [3] = new JniArgumentValue ((endTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endTime).Handle);
				__args [4] = new JniArgumentValue (native_template);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryGroupBadgeStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_template);
				global::System.GC.KeepAlive (textColor);
				global::System.GC.KeepAlive (backgroundColor);
				global::System.GC.KeepAlive (endTime);
			}
		}

	}
}
