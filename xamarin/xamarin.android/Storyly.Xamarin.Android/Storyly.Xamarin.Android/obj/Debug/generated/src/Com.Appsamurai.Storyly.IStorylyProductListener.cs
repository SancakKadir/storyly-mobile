using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Appsamurai.Storyly {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyProductListener']"
	[Register ("com/appsamurai/storyly/StorylyProductListener", "", "Com.Appsamurai.Storyly.IStorylyProductListenerInvoker")]
	public partial interface IStorylyProductListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyProductListener']/method[@name='storylyEvent' and count(parameter)=2 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='com.appsamurai.storyly.analytics.StorylyEvent']]"
		[Register ("storylyEvent", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;)V", "Getproducts_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Handler:Com.Appsamurai.Storyly.IStorylyProductListenerInvoker, Storyly.Xamarin.Android")]
		void products (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyProductListener']/method[@name='storylyHydration' and count(parameter)=2 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='java.util.List&lt;com.appsamurai.storyly.data.managers.product.STRProductInformation&gt;']]"
		[Register ("storylyHydration", "(Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;)V", "GetStorylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Handler:Com.Appsamurai.Storyly.IStorylyProductListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyHydration (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductInformation> products);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly']/interface[@name='StorylyProductListener']/method[@name='storylyUpdateCartEvent' and count(parameter)=6 and parameter[1][@type='com.appsamurai.storyly.StorylyView'] and parameter[2][@type='com.appsamurai.storyly.analytics.StorylyEvent'] and parameter[3][@type='com.appsamurai.storyly.data.managers.product.STRCart'] and parameter[4][@type='com.appsamurai.storyly.data.managers.product.STRCartItem'] and parameter[5][@type='kotlin.jvm.functions.Function1&lt;? super com.appsamurai.storyly.data.managers.product.STRCart, kotlin.Unit&gt;'] and parameter[6][@type='kotlin.jvm.functions.Function1&lt;? super com.appsamurai.storyly.data.managers.product.STRCartEventResult, kotlin.Unit&gt;']]"
		[Register ("storylyUpdateCartEvent", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/data/managers/product/STRCart;Lcom/appsamurai/storyly/data/managers/product/STRCartItem;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)V", "GetStorylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_Handler:Com.Appsamurai.Storyly.IStorylyProductListenerInvoker, Storyly.Xamarin.Android")]
		void StorylyUpdateCartEvent (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCart cart, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCartItem change, global::Kotlin.Jvm.Functions.IFunction1 onSuccess, global::Kotlin.Jvm.Functions.IFunction1 onFail);

	}

	[global::Android.Runtime.Register ("com/appsamurai/storyly/StorylyProductListener", DoNotGenerateAcw=true)]
	internal partial class IStorylyProductListenerInvoker : global::Java.Lang.Object, IStorylyProductListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/StorylyProductListener", typeof (IStorylyProductListenerInvoker));

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

		public static IStorylyProductListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStorylyProductListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.appsamurai.storyly.StorylyProductListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStorylyProductListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_;
#pragma warning disable 0169
		static Delegate Getproducts_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Handler ()
		{
			if (cb_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_ == null)
				cb_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_products_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_));
			return cb_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_;
		}

		static void n_products_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyProductListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Analytics.StorylyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.products (storylyView, e);
		}
#pragma warning restore 0169

		IntPtr id_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_;
		public unsafe void products (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e)
		{
			if (id_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_ == IntPtr.Zero)
				id_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_ = JNIEnv.GetMethodID (class_ref, "storylyEvent", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_, __args);
		}

		static Delegate cb_storylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetStorylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Handler ()
		{
			if (cb_storylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_ == null)
				cb_storylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_StorylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_));
			return cb_storylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_;
		}

		static void n_StorylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_products)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyProductListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var products = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductInformation>.FromJniHandle (native_products, JniHandleOwnership.DoNotTransfer);
			__this.StorylyHydration (storylyView, products);
		}
#pragma warning restore 0169

		IntPtr id_storylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_;
		public unsafe void StorylyHydration (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductInformation> products)
		{
			if (id_storylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_ == IntPtr.Zero)
				id_storylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "storylyHydration", "(Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;)V");
			IntPtr native_products = global::Android.Runtime.JavaList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductInformation>.ToLocalJniHandle (products);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue (native_products);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_products);
		}

		static Delegate cb_storylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_;
#pragma warning disable 0169
		static Delegate GetStorylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_Handler ()
		{
			if (cb_storylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_ == null)
				cb_storylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLL_V (n_StorylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_));
			return cb_storylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_;
		}

		static void n_StorylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storylyView, IntPtr native_e, IntPtr native_cart, IntPtr native_change, IntPtr native_onSuccess, IntPtr native_onFail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.IStorylyProductListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var storylyView = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.StorylyView> (native_storylyView, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Analytics.StorylyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			var cart = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCart> (native_cart, JniHandleOwnership.DoNotTransfer);
			var change = global::Java.Lang.Object.GetObject<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCartItem> (native_change, JniHandleOwnership.DoNotTransfer);
			var onSuccess = (global::Kotlin.Jvm.Functions.IFunction1)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_onSuccess, JniHandleOwnership.DoNotTransfer);
			var onFail = (global::Kotlin.Jvm.Functions.IFunction1)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (native_onFail, JniHandleOwnership.DoNotTransfer);
			__this.StorylyUpdateCartEvent (storylyView, e, cart, change, onSuccess, onFail);
		}
#pragma warning restore 0169

		IntPtr id_storylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_;
		public unsafe void StorylyUpdateCartEvent (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCart cart, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCartItem change, global::Kotlin.Jvm.Functions.IFunction1 onSuccess, global::Kotlin.Jvm.Functions.IFunction1 onFail)
		{
			if (id_storylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
				id_storylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID (class_ref, "storylyUpdateCartEvent", "(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/data/managers/product/STRCart;Lcom/appsamurai/storyly/data/managers/product/STRCartItem;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)V");
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue ((storylyView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) storylyView).Handle);
			__args [1] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			__args [2] = new JValue ((cart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cart).Handle);
			__args [3] = new JValue ((change == null) ? IntPtr.Zero : ((global::Java.Lang.Object) change).Handle);
			__args [4] = new JValue ((onSuccess == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onSuccess).Handle);
			__args [5] = new JValue ((onFail == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onFail).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_, __args);
		}

	}

	// event args for com.appsamurai.storyly.StorylyProductListener.storylyEvent
	public partial class productsEventArgs : global::System.EventArgs {
		public productsEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e)
		{
			this.storylyView = storylyView;
			this.e = e;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e;

		public global::Com.Appsamurai.Storyly.Analytics.StorylyEvent Event {
			get { return e; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyProductListener.storylyHydration
	public partial class StorylyHydrationEventArgs : global::System.EventArgs {
		public StorylyHydrationEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductInformation> products)
		{
			this.storylyView = storylyView;
			this.products = products;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductInformation> products;

		public global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductInformation> Products {
			get { return products; }
		}

	}

	// event args for com.appsamurai.storyly.StorylyProductListener.storylyUpdateCartEvent
	public partial class StorylyUpdateCartEventEventArgs : global::System.EventArgs {
		public StorylyUpdateCartEventEventArgs (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCart cart, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCartItem change, global::Kotlin.Jvm.Functions.IFunction1 onSuccess, global::Kotlin.Jvm.Functions.IFunction1 onFail)
		{
			this.storylyView = storylyView;
			this.e = e;
			this.cart = cart;
			this.change = change;
			this.onSuccess = onSuccess;
			this.onFail = onFail;
		}

		global::Com.Appsamurai.Storyly.StorylyView storylyView;

		public global::Com.Appsamurai.Storyly.StorylyView StorylyView {
			get { return storylyView; }
		}

		global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e;

		public global::Com.Appsamurai.Storyly.Analytics.StorylyEvent Event {
			get { return e; }
		}

		global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCart cart;

		public global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCart Cart {
			get { return cart; }
		}

		global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCartItem change;

		public global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCartItem Change {
			get { return change; }
		}

		global::Kotlin.Jvm.Functions.IFunction1 onSuccess;

		public global::Kotlin.Jvm.Functions.IFunction1 OnSuccess {
			get { return onSuccess; }
		}

		global::Kotlin.Jvm.Functions.IFunction1 onFail;

		public global::Kotlin.Jvm.Functions.IFunction1 OnFail {
			get { return onFail; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/appsamurai/storyly/StorylyProductListenerImplementor")]
	internal sealed partial class IStorylyProductListenerImplementor : global::Java.Lang.Object, IStorylyProductListener {

		object sender;

		public IStorylyProductListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/appsamurai/storyly/StorylyProductListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<productsEventArgs> productsHandler;
		#pragma warning restore 0649

		public void products (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e)
		{
			var __h = productsHandler;
			if (__h != null)
				__h (sender, new productsEventArgs (storylyView, e));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyHydrationEventArgs> StorylyHydrationHandler;
		#pragma warning restore 0649

		public void StorylyHydration (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::System.Collections.Generic.IList<global::Com.Appsamurai.Storyly.Data.Managers.Product.STRProductInformation> products)
		{
			var __h = StorylyHydrationHandler;
			if (__h != null)
				__h (sender, new StorylyHydrationEventArgs (storylyView, products));
		}

		#pragma warning disable 0649
		public EventHandler<StorylyUpdateCartEventEventArgs> StorylyUpdateCartEventHandler;
		#pragma warning restore 0649

		public void StorylyUpdateCartEvent (global::Com.Appsamurai.Storyly.StorylyView storylyView, global::Com.Appsamurai.Storyly.Analytics.StorylyEvent e, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCart cart, global::Com.Appsamurai.Storyly.Data.Managers.Product.STRCartItem change, global::Kotlin.Jvm.Functions.IFunction1 onSuccess, global::Kotlin.Jvm.Functions.IFunction1 onFail)
		{
			var __h = StorylyUpdateCartEventHandler;
			if (__h != null)
				__h (sender, new StorylyUpdateCartEventEventArgs (storylyView, e, cart, change, onSuccess, onFail));
		}

		internal static bool __IsEmpty (IStorylyProductListenerImplementor value)
		{
			return value.productsHandler == null && value.StorylyHydrationHandler == null && value.StorylyUpdateCartEventHandler == null;
		}

	}
}
