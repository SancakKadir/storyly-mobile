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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/StoryType", DoNotGenerateAcw=true)]
	public sealed partial class StoryType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']/field[@name='Ad']"
		[Register ("Ad")]
		public static global::Com.Appsamurai.Storyly.StoryType Ad {
			get {
				const string __id = "Ad.Lcom/appsamurai/storyly/StoryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']/field[@name='Image']"
		[Register ("Image")]
		public static global::Com.Appsamurai.Storyly.StoryType Image {
			get {
				const string __id = "Image.Lcom/appsamurai/storyly/StoryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']/field[@name='Live']"
		[Register ("Live")]
		public static global::Com.Appsamurai.Storyly.StoryType Live {
			get {
				const string __id = "Live.Lcom/appsamurai/storyly/StoryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']/field[@name='LongVideo']"
		[Register ("LongVideo")]
		public static global::Com.Appsamurai.Storyly.StoryType LongVideo {
			get {
				const string __id = "LongVideo.Lcom/appsamurai/storyly/StoryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']/field[@name='Unknown']"
		[Register ("Unknown")]
		public static global::Com.Appsamurai.Storyly.StoryType Unknown {
			get {
				const string __id = "Unknown.Lcom/appsamurai/storyly/StoryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']/field[@name='Video']"
		[Register ("Video")]
		public static global::Com.Appsamurai.Storyly.StoryType Video {
			get {
				const string __id = "Video.Lcom/appsamurai/storyly/StoryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StoryType", typeof (StoryType));

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

		internal StoryType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/appsamurai/storyly/StoryType;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.StoryType ValueOf (string value)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/appsamurai/storyly/StoryType;";
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StoryType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/class[@name='StoryType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/appsamurai/storyly/StoryType;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.StoryType[] Values ()
		{
			const string __id = "values.()[Lcom/appsamurai/storyly/StoryType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Appsamurai.Storyly.StoryType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appsamurai.Storyly.StoryType));
			} finally {
			}
		}

	}
}
