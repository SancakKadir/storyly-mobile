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

namespace Com.Appsamurai.Storyly.Config {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/config/StorylyConfig", DoNotGenerateAcw=true)]
	public sealed partial class StorylyConfig : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']"
		[global::Android.Runtime.Register ("com/appsamurai/storyly/config/StorylyConfig$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/config/StorylyConfig$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/constructor[@name='StorylyConfig.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/appsamurai/storyly/config/StorylyConfig;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig Build ()
			{
				const string __id = "build.()Lcom/appsamurai/storyly/config/StorylyConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setBarStyling' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.config.styling.bar.StorylyBarStyling']]"
			[Register ("setBarStyling", "(Lcom/appsamurai/storyly/config/styling/bar/StorylyBarStyling;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetBarStyling (global::Com.Appsamurai.Storyly.Config.Styling.Bar.StorylyBarStyling styling)
			{
				const string __id = "setBarStyling.(Lcom/appsamurai/storyly/config/styling/bar/StorylyBarStyling;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((styling == null) ? IntPtr.Zero : ((global::Java.Lang.Object) styling).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (styling);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setCustomParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomParameter", "(Ljava/lang/String;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetCustomParameter (string parameter)
			{
				const string __id = "setCustomParameter.(Ljava/lang/String;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				IntPtr native_parameter = JNIEnv.NewString ((string)parameter);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_parameter);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_parameter);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setLabels' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
			[Register ("setLabels", "(Ljava/util/Set;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetLabels (global::System.Collections.Generic.ICollection<string> labels)
			{
				const string __id = "setLabels.(Ljava/util/Set;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				IntPtr native_labels = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (labels);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_labels);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_labels);
					global::System.GC.KeepAlive (labels);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setLayoutDirection' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.StorylyLayoutDirection']]"
			[Register ("setLayoutDirection", "(Lcom/appsamurai/storyly/StorylyLayoutDirection;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetLayoutDirection (global::Com.Appsamurai.Storyly.StorylyLayoutDirection direction)
			{
				const string __id = "setLayoutDirection.(Lcom/appsamurai/storyly/StorylyLayoutDirection;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((direction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) direction).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (direction);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setLocale' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocale", "(Ljava/lang/String;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetLocale (string locale)
			{
				const string __id = "setLocale.(Ljava/lang/String;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				IntPtr native_locale = JNIEnv.NewString ((string)locale);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_locale);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_locale);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setMomentsStyling' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.config.styling.moments.StorylyMomentsStyling']]"
			[Register ("setMomentsStyling", "(Lcom/appsamurai/storyly/config/styling/moments/StorylyMomentsStyling;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetMomentsStyling (global::Com.Appsamurai.Storyly.Config.Styling.Moments.StorylyMomentsStyling styling)
			{
				const string __id = "setMomentsStyling.(Lcom/appsamurai/storyly/config/styling/moments/StorylyMomentsStyling;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((styling == null) ? IntPtr.Zero : ((global::Java.Lang.Object) styling).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (styling);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setProductConfig' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.config.StorylyProductConfig']]"
			[Register ("setProductConfig", "(Lcom/appsamurai/storyly/config/StorylyProductConfig;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetProductConfig (global::Com.Appsamurai.Storyly.Config.StorylyProductConfig config)
			{
				const string __id = "setProductConfig.(Lcom/appsamurai/storyly/config/StorylyProductConfig;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (config);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setShareConfig' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.config.StorylyShareConfig']]"
			[Register ("setShareConfig", "(Lcom/appsamurai/storyly/config/StorylyShareConfig;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetShareConfig (global::Com.Appsamurai.Storyly.Config.StorylyShareConfig config)
			{
				const string __id = "setShareConfig.(Lcom/appsamurai/storyly/config/StorylyShareConfig;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (config);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setStoryGroupStyling' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.config.styling.group.StorylyStoryGroupStyling']]"
			[Register ("setStoryGroupStyling", "(Lcom/appsamurai/storyly/config/styling/group/StorylyStoryGroupStyling;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetStoryGroupStyling (global::Com.Appsamurai.Storyly.Config.Styling.Group.StorylyStoryGroupStyling styling)
			{
				const string __id = "setStoryGroupStyling.(Lcom/appsamurai/storyly/config/styling/group/StorylyStoryGroupStyling;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((styling == null) ? IntPtr.Zero : ((global::Java.Lang.Object) styling).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (styling);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setStoryStyling' and count(parameter)=1 and parameter[1][@type='com.appsamurai.storyly.config.styling.story.StorylyStoryStyling']]"
			[Register ("setStoryStyling", "(Lcom/appsamurai/storyly/config/styling/story/StorylyStoryStyling;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetStoryStyling (global::Com.Appsamurai.Storyly.Config.Styling.Story.StorylyStoryStyling styling)
			{
				const string __id = "setStoryStyling.(Lcom/appsamurai/storyly/config/styling/story/StorylyStoryStyling;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((styling == null) ? IntPtr.Zero : ((global::Java.Lang.Object) styling).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (styling);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setTestMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTestMode", "(Z)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetTestMode (bool isTest)
			{
				const string __id = "setTestMode.(Z)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isTest);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig.Builder']/method[@name='setUserData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setUserData", "(Ljava/util/Map;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;", "")]
			public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder SetUserData (global::System.Collections.Generic.IDictionary<string, string> data)
			{
				const string __id = "setUserData.(Ljava/util/Map;)Lcom/appsamurai/storyly/config/StorylyConfig$Builder;";
				IntPtr native_data = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_data);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_data);
					global::System.GC.KeepAlive (data);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/config/StorylyConfig", typeof (StorylyConfig));

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

		internal StorylyConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::System.Collections.Generic.ICollection<string> Labels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig']/method[@name='getLabels' and count(parameter)=0]"
			[Register ("getLabels", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getLabels.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig']/method[@name='setLabels' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
			[Register ("setLabels", "(Ljava/util/Set;)V", "")]
			set {
				const string __id = "setLabels.(Ljava/util/Set;)V";
				IntPtr native_value = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, string> UserData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig']/method[@name='getUserData' and count(parameter)=0]"
			[Register ("getUserData", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getUserData.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig']/method[@name='setUserData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setUserData", "(Ljava/util/Map;)V", "")]
			set {
				const string __id = "setUserData.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.config']/class[@name='StorylyConfig']/method[@name='copy' and count(parameter)=12 and parameter[1][@type='com.appsamurai.storyly.config.styling.bar.StorylyBarStyling'] and parameter[2][@type='com.appsamurai.storyly.config.styling.group.StorylyStoryGroupStyling'] and parameter[3][@type='com.appsamurai.storyly.config.styling.story.StorylyStoryStyling'] and parameter[4][@type='com.appsamurai.storyly.config.styling.moments.StorylyMomentsStyling'] and parameter[5][@type='com.appsamurai.storyly.config.StorylyProductConfig'] and parameter[6][@type='com.appsamurai.storyly.config.StorylyShareConfig'] and parameter[7][@type='com.appsamurai.storyly.StorylyLayoutDirection'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.Object'] and parameter[10][@type='java.lang.Object'] and parameter[11][@type='boolean'] and parameter[12][@type='java.lang.String']]"
		[Register ("copy", "(Lcom/appsamurai/storyly/config/styling/bar/StorylyBarStyling;Lcom/appsamurai/storyly/config/styling/group/StorylyStoryGroupStyling;Lcom/appsamurai/storyly/config/styling/story/StorylyStoryStyling;Lcom/appsamurai/storyly/config/styling/moments/StorylyMomentsStyling;Lcom/appsamurai/storyly/config/StorylyProductConfig;Lcom/appsamurai/storyly/config/StorylyShareConfig;Lcom/appsamurai/storyly/StorylyLayoutDirection;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;ZLjava/lang/String;)Lcom/appsamurai/storyly/config/StorylyConfig;", "")]
		public unsafe global::Com.Appsamurai.Storyly.Config.StorylyConfig Copy (global::Com.Appsamurai.Storyly.Config.Styling.Bar.StorylyBarStyling bar, global::Com.Appsamurai.Storyly.Config.Styling.Group.StorylyStoryGroupStyling group, global::Com.Appsamurai.Storyly.Config.Styling.Story.StorylyStoryStyling story, global::Com.Appsamurai.Storyly.Config.Styling.Moments.StorylyMomentsStyling moments, global::Com.Appsamurai.Storyly.Config.StorylyProductConfig product, global::Com.Appsamurai.Storyly.Config.StorylyShareConfig share, global::Com.Appsamurai.Storyly.StorylyLayoutDirection layoutDirection, string customParameter, global::Java.Lang.Object _labels, global::Java.Lang.Object _userData, bool isTestMode, string locale)
		{
			const string __id = "copy.(Lcom/appsamurai/storyly/config/styling/bar/StorylyBarStyling;Lcom/appsamurai/storyly/config/styling/group/StorylyStoryGroupStyling;Lcom/appsamurai/storyly/config/styling/story/StorylyStoryStyling;Lcom/appsamurai/storyly/config/styling/moments/StorylyMomentsStyling;Lcom/appsamurai/storyly/config/StorylyProductConfig;Lcom/appsamurai/storyly/config/StorylyShareConfig;Lcom/appsamurai/storyly/StorylyLayoutDirection;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;ZLjava/lang/String;)Lcom/appsamurai/storyly/config/StorylyConfig;";
			IntPtr native_customParameter = JNIEnv.NewString ((string)customParameter);
			IntPtr native_locale = JNIEnv.NewString ((string)locale);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue ((bar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bar).Handle);
				__args [1] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [2] = new JniArgumentValue ((story == null) ? IntPtr.Zero : ((global::Java.Lang.Object) story).Handle);
				__args [3] = new JniArgumentValue ((moments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) moments).Handle);
				__args [4] = new JniArgumentValue ((product == null) ? IntPtr.Zero : ((global::Java.Lang.Object) product).Handle);
				__args [5] = new JniArgumentValue ((share == null) ? IntPtr.Zero : ((global::Java.Lang.Object) share).Handle);
				__args [6] = new JniArgumentValue ((layoutDirection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutDirection).Handle);
				__args [7] = new JniArgumentValue (native_customParameter);
				__args [8] = new JniArgumentValue ((_labels == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _labels).Handle);
				__args [9] = new JniArgumentValue ((_userData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _userData).Handle);
				__args [10] = new JniArgumentValue (isTestMode);
				__args [11] = new JniArgumentValue (native_locale);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Config.StorylyConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_customParameter);
				JNIEnv.DeleteLocalRef (native_locale);
				global::System.GC.KeepAlive (bar);
				global::System.GC.KeepAlive (group);
				global::System.GC.KeepAlive (story);
				global::System.GC.KeepAlive (moments);
				global::System.GC.KeepAlive (product);
				global::System.GC.KeepAlive (share);
				global::System.GC.KeepAlive (layoutDirection);
				global::System.GC.KeepAlive (_labels);
				global::System.GC.KeepAlive (_userData);
			}
		}

	}
}
