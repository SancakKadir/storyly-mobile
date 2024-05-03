package mono.com.appsamurai.storyly.ad;


public class StorylyAdViewListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.appsamurai.storyly.ad.StorylyAdViewListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLoad:(Lcom/appsamurai/storyly/ad/StorylyAdView;)V:GetOnLoad_Lcom_appsamurai_storyly_ad_StorylyAdView_Handler:Com.Appsamurai.Storyly.AD.IStorylyAdViewListenerInvoker, storyly.xamarin.binding\n" +
			"";
		mono.android.Runtime.register ("Com.Appsamurai.Storyly.AD.IStorylyAdViewListenerImplementor, storyly.xamarin.binding", StorylyAdViewListenerImplementor.class, __md_methods);
	}


	public StorylyAdViewListenerImplementor ()
	{
		super ();
		if (getClass () == StorylyAdViewListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Appsamurai.Storyly.AD.IStorylyAdViewListenerImplementor, storyly.xamarin.binding", "", this, new java.lang.Object[] {  });
		}
	}


	public void onLoad (com.appsamurai.storyly.ad.StorylyAdView p0)
	{
		n_onLoad (p0);
	}

	private native void n_onLoad (com.appsamurai.storyly.ad.StorylyAdView p0);

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
