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

namespace Com.Appsamurai.Storyly.Databinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly.databinding']/class[@name='StMomentsFooterViewBinding']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/databinding/StMomentsFooterViewBinding", DoNotGenerateAcw=true)]
	public sealed partial class StMomentsFooterViewBinding : global::Java.Lang.Object, global::AndroidX.ViewBinding.IViewBinding {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly.databinding']/class[@name='StMomentsFooterViewBinding']/field[@name='stMomentsLiked']"
		[Register ("stMomentsLiked")]
		public global::Android.Widget.ImageView StMomentsLiked {
			get {
				const string __id = "stMomentsLiked.Landroid/widget/ImageView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stMomentsLiked.Landroid/widget/ImageView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appsamurai.storyly.databinding']/class[@name='StMomentsFooterViewBinding']/field[@name='stMomentsUnliked']"
		[Register ("stMomentsUnliked")]
		public global::Android.Widget.ImageView StMomentsUnliked {
			get {
				const string __id = "stMomentsUnliked.Landroid/widget/ImageView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stMomentsUnliked.Landroid/widget/ImageView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/databinding/StMomentsFooterViewBinding", typeof (StMomentsFooterViewBinding));

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

		internal StMomentsFooterViewBinding (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Android.Widget.FrameLayout Root {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.databinding']/class[@name='StMomentsFooterViewBinding']/method[@name='getRoot' and count(parameter)=0]"
			[Register ("getRoot", "()Landroid/widget/FrameLayout;", "")]
			get {
				const string __id = "getRoot.()Landroid/widget/FrameLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.databinding']/class[@name='StMomentsFooterViewBinding']/method[@name='bind' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("bind", "(Landroid/view/View;)Lcom/appsamurai/storyly/databinding/StMomentsFooterViewBinding;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.Databinding.StMomentsFooterViewBinding Bind (global::Android.Views.View rootView)
		{
			const string __id = "bind.(Landroid/view/View;)Lcom/appsamurai/storyly/databinding/StMomentsFooterViewBinding;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rootView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootView).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Databinding.StMomentsFooterViewBinding> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rootView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.databinding']/class[@name='StMomentsFooterViewBinding']/method[@name='inflate' and count(parameter)=1 and parameter[1][@type='android.view.LayoutInflater']]"
		[Register ("inflate", "(Landroid/view/LayoutInflater;)Lcom/appsamurai/storyly/databinding/StMomentsFooterViewBinding;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.Databinding.StMomentsFooterViewBinding Inflate (global::Android.Views.LayoutInflater inflater)
		{
			const string __id = "inflate.(Landroid/view/LayoutInflater;)Lcom/appsamurai/storyly/databinding/StMomentsFooterViewBinding;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inflater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inflater).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Databinding.StMomentsFooterViewBinding> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inflater);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.databinding']/class[@name='StMomentsFooterViewBinding']/method[@name='inflate' and count(parameter)=3 and parameter[1][@type='android.view.LayoutInflater'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='boolean']]"
		[Register ("inflate", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Z)Lcom/appsamurai/storyly/databinding/StMomentsFooterViewBinding;", "")]
		public static unsafe global::Com.Appsamurai.Storyly.Databinding.StMomentsFooterViewBinding Inflate (global::Android.Views.LayoutInflater inflater, global::Android.Views.ViewGroup parent, bool attachToParent)
		{
			const string __id = "inflate.(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Z)Lcom/appsamurai/storyly/databinding/StMomentsFooterViewBinding;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((inflater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inflater).Handle);
				__args [1] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [2] = new JniArgumentValue (attachToParent);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Databinding.StMomentsFooterViewBinding> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inflater);
				global::System.GC.KeepAlive (parent);
			}
		}

	}
}
