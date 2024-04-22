using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Appsamurai.Storyly.Storylypresenter.Product.Variant {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appsamurai.storyly.storylypresenter.product.variant']/class[@name='StorylyVariantUpdatableAdapter.DefaultImpls']"
	[global::Android.Runtime.Register ("com/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class StorylyVariantUpdatableAdapterDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter$DefaultImpls", typeof (StorylyVariantUpdatableAdapterDefaultImpls));

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

		internal StorylyVariantUpdatableAdapterDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.storylypresenter.product.variant']/class[@name='StorylyVariantUpdatableAdapter.DefaultImpls']/method[@name='areContentsSame' and count(parameter)=3 and parameter[1][@type='com.appsamurai.storyly.storylypresenter.product.variant.StorylyVariantUpdatableAdapter'] and parameter[2][@type='com.appsamurai.storyly.data.managers.product.STRProductVariant'] and parameter[3][@type='com.appsamurai.storyly.data.managers.product.STRProductVariant']]"
		[Register ("areContentsSame", "(Lcom/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter;Lcom/appsamurai/storyly/data/managers/product/STRProductVariant;Lcom/appsamurai/storyly/data/managers/product/STRProductVariant;)Z", "")]
		public static unsafe bool AreContentsSame (global::Com.Appsamurai.Storyly.Storylypresenter.Product.Variant.IStorylyVariantUpdatableAdapter this_, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant oldItem, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant newItem)
		{
			const string __id = "areContentsSame.(Lcom/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter;Lcom/appsamurai/storyly/data/managers/product/STRProductVariant;Lcom/appsamurai/storyly/data/managers/product/STRProductVariant;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((oldItem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldItem).Handle);
				__args [2] = new JniArgumentValue ((newItem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newItem).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (oldItem);
				global::System.GC.KeepAlive (newItem);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.storylypresenter.product.variant']/class[@name='StorylyVariantUpdatableAdapter.DefaultImpls']/method[@name='autoNotify' and count(parameter)=4 and parameter[1][@type='com.appsamurai.storyly.storylypresenter.product.variant.StorylyVariantUpdatableAdapter'] and parameter[2][@type='androidx.recyclerview.widget.RecyclerView.Adapter&lt;T&gt;'] and parameter[3][@type='java.util.List&lt;com.appsamurai.storyly.data.managers.product.STRProductVariant&gt;'] and parameter[4][@type='java.util.List&lt;com.appsamurai.storyly.data.managers.product.STRProductVariant&gt;']]"
		[Register ("autoNotify", "(Lcom/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter;Landroidx/recyclerview/widget/RecyclerView$Adapter;Ljava/util/List;Ljava/util/List;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends androidx.recyclerview.widget.RecyclerView.ViewHolder"})]
		public static unsafe void AutoNotify (global::Com.Appsamurai.Storyly.Storylypresenter.Product.Variant.IStorylyVariantUpdatableAdapter this_, global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter receiver, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant> old, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant> @new)
		{
			const string __id = "autoNotify.(Lcom/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter;Landroidx/recyclerview/widget/RecyclerView$Adapter;Ljava/util/List;Ljava/util/List;)V";
			IntPtr native_old = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant>.ToLocalJniHandle (old);
			IntPtr native__new = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant>.ToLocalJniHandle (@new);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [2] = new JniArgumentValue (native_old);
				__args [3] = new JniArgumentValue (native__new);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_old);
				JNIEnv.DeleteLocalRef (native__new);
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (receiver);
				global::System.GC.KeepAlive (old);
				global::System.GC.KeepAlive (@new);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appsamurai.storyly.storylypresenter.product.variant']/interface[@name='StorylyVariantUpdatableAdapter']"
	[Register ("com/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter", "", "Com.Appsamurai.Storyly.Storylypresenter.Product.Variant.IStorylyVariantUpdatableAdapterInvoker")]
	public partial interface IStorylyVariantUpdatableAdapter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.storylypresenter.product.variant']/interface[@name='StorylyVariantUpdatableAdapter']/method[@name='areContentsSame' and count(parameter)=2 and parameter[1][@type='com.appsamurai.storyly.data.managers.product.STRProductVariant'] and parameter[2][@type='com.appsamurai.storyly.data.managers.product.STRProductVariant']]"
		[Register ("areContentsSame", "(Lcom/appsamurai/storyly/data/managers/product/STRProductVariant;Lcom/appsamurai/storyly/data/managers/product/STRProductVariant;)Z", "GetAreContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Handler:Com.Appsamurai.Storyly.Storylypresenter.Product.Variant.IStorylyVariantUpdatableAdapterInvoker, Storyly.Xamarin.Android")]
		bool AreContentsSame (global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant oldItem, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant newItem);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.storylypresenter.product.variant']/interface[@name='StorylyVariantUpdatableAdapter']/method[@name='autoNotify' and count(parameter)=3 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView.Adapter&lt;T&gt;'] and parameter[2][@type='java.util.List&lt;com.appsamurai.storyly.data.managers.product.STRProductVariant&gt;'] and parameter[3][@type='java.util.List&lt;com.appsamurai.storyly.data.managers.product.STRProductVariant&gt;']]"
		[Register ("autoNotify", "(Landroidx/recyclerview/widget/RecyclerView$Adapter;Ljava/util/List;Ljava/util/List;)V", "GetAutoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_Handler:Com.Appsamurai.Storyly.Storylypresenter.Product.Variant.IStorylyVariantUpdatableAdapterInvoker, Storyly.Xamarin.Android")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends androidx.recyclerview.widget.RecyclerView.ViewHolder"})]
		void AutoNotify (global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter p0, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant> old, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant> @new);

	}

	[global::Android.Runtime.Register ("com/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter", DoNotGenerateAcw=true)]
	internal partial class IStorylyVariantUpdatableAdapterInvoker : global::Java.Lang.Object, IStorylyVariantUpdatableAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/storylypresenter/product/variant/StorylyVariantUpdatableAdapter", typeof (IStorylyVariantUpdatableAdapterInvoker));

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

		public static IStorylyVariantUpdatableAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStorylyVariantUpdatableAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.appsamurai.storyly.storylypresenter.product.variant.StorylyVariantUpdatableAdapter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStorylyVariantUpdatableAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_areContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_;
#pragma warning disable 0169
		static Delegate GetAreContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Handler ()
		{
			if (cb_areContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_ == null)
				cb_areContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_AreContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_));
			return cb_areContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_;
		}

		static bool n_AreContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldItem, IntPtr native_newItem)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Storylypresenter.Product.Variant.IStorylyVariantUpdatableAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldItem = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant> (native_oldItem, JniHandleOwnership.DoNotTransfer);
			var newItem = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant> (native_newItem, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AreContentsSame (oldItem, newItem);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_areContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_;
		public unsafe bool AreContentsSame (global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant oldItem, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant newItem)
		{
			if (id_areContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_ == IntPtr.Zero)
				id_areContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_ = JNIEnv.GetMethodID (class_ref, "areContentsSame", "(Lcom/appsamurai/storyly/data/managers/product/STRProductVariant;Lcom/appsamurai/storyly/data/managers/product/STRProductVariant;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((oldItem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldItem).Handle);
			__args [1] = new JValue ((newItem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newItem).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_areContentsSame_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_Lcom_appsamurai_storyly_data_managers_product_STRProductVariant_, __args);
			return __ret;
		}

		static Delegate cb_autoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAutoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_autoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_ == null)
				cb_autoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_AutoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_));
			return cb_autoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_;
		}

		static void n_AutoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_old, IntPtr native__new)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Storylypresenter.Product.Variant.IStorylyVariantUpdatableAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			var old = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant>.FromJniHandle (native_old, JniHandleOwnership.DoNotTransfer);
			var @new = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant>.FromJniHandle (native__new, JniHandleOwnership.DoNotTransfer);
			__this.AutoNotify (p0, old, @new);
		}
#pragma warning restore 0169

		IntPtr id_autoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_;
		public unsafe void AutoNotify (global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter p0, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant> old, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant> @new)
		{
			if (id_autoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_autoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "autoNotify", "(Landroidx/recyclerview/widget/RecyclerView$Adapter;Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_old = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant>.ToLocalJniHandle (old);
			IntPtr native__new = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductVariant>.ToLocalJniHandle (@new);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_old);
			__args [2] = new JValue (native__new);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_autoNotify_Landroidx_recyclerview_widget_RecyclerView_Adapter_Ljava_util_List_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_old);
			JNIEnv.DeleteLocalRef (native__new);
		}

	}
}
