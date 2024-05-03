package mono.com.appsamurai.storyly;


public class StorylyProductListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.appsamurai.storyly.StorylyProductListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_storylyHydration:(Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;)V:GetStorylyHydration_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Handler:Com.Appsamurai.Storyly.IStorylyProductListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyProductEvent:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;)V:GetStorylyProductEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Handler:Com.Appsamurai.Storyly.IStorylyProductListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyUpdateCartEvent:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/data/managers/product/STRCart;Lcom/appsamurai/storyly/data/managers/product/STRCartItem;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function1;)V:GetStorylyUpdateCartEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_data_managers_product_STRCart_Lcom_appsamurai_storyly_data_managers_product_STRCartItem_Lkotlin_jvm_functions_Function1_Lkotlin_jvm_functions_Function1_Handler:Com.Appsamurai.Storyly.IStorylyProductListenerInvoker, storyly.xamarin.binding\n" +
			"";
		mono.android.Runtime.register ("Com.Appsamurai.Storyly.IStorylyProductListenerImplementor, storyly.xamarin.binding", StorylyProductListenerImplementor.class, __md_methods);
	}


	public StorylyProductListenerImplementor ()
	{
		super ();
		if (getClass () == StorylyProductListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Appsamurai.Storyly.IStorylyProductListenerImplementor, storyly.xamarin.binding", "", this, new java.lang.Object[] {  });
		}
	}


	public void storylyHydration (com.appsamurai.storyly.StorylyView p0, java.util.List p1)
	{
		n_storylyHydration (p0, p1);
	}

	private native void n_storylyHydration (com.appsamurai.storyly.StorylyView p0, java.util.List p1);


	public void storylyProductEvent (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.analytics.StorylyEvent p1)
	{
		n_storylyProductEvent (p0, p1);
	}

	private native void n_storylyProductEvent (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.analytics.StorylyEvent p1);


	public void storylyUpdateCartEvent (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.analytics.StorylyEvent p1, com.appsamurai.storyly.data.managers.product.STRCart p2, com.appsamurai.storyly.data.managers.product.STRCartItem p3, kotlin.jvm.functions.Function1 p4, kotlin.jvm.functions.Function1 p5)
	{
		n_storylyUpdateCartEvent (p0, p1, p2, p3, p4, p5);
	}

	private native void n_storylyUpdateCartEvent (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.analytics.StorylyEvent p1, com.appsamurai.storyly.data.managers.product.STRCart p2, com.appsamurai.storyly.data.managers.product.STRCartItem p3, kotlin.jvm.functions.Function1 p4, kotlin.jvm.functions.Function1 p5);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
