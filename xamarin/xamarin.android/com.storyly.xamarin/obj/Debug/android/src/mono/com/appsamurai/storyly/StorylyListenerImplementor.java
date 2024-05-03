package mono.com.appsamurai.storyly;


public class StorylyListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.appsamurai.storyly.StorylyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_storylyActionClicked:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/Story;)V:GetStorylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyEvent:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V:GetStorylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyLoadFailed:(Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V:GetStorylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyLoaded:(Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;Lcom/appsamurai/storyly/StorylyDataSource;)V:GetStorylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyStoryDismissed:(Lcom/appsamurai/storyly/StorylyView;)V:GetStorylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyStoryShowFailed:(Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V:GetStorylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyStoryShown:(Lcom/appsamurai/storyly/StorylyView;)V:GetStorylyStoryShown_Lcom_appsamurai_storyly_StorylyView_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyUserInteracted:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V:GetStorylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"";
		mono.android.Runtime.register ("Com.Appsamurai.Storyly.IStorylyListenerImplementor, storyly.xamarin.binding", StorylyListenerImplementor.class, __md_methods);
	}


	public StorylyListenerImplementor ()
	{
		super ();
		if (getClass () == StorylyListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Appsamurai.Storyly.IStorylyListenerImplementor, storyly.xamarin.binding", "", this, new java.lang.Object[] {  });
		}
	}


	public void storylyActionClicked (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.Story p1)
	{
		n_storylyActionClicked (p0, p1);
	}

	private native void n_storylyActionClicked (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.Story p1);


	public void storylyEvent (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.analytics.StorylyEvent p1, com.appsamurai.storyly.StoryGroup p2, com.appsamurai.storyly.Story p3, com.appsamurai.storyly.StoryComponent p4)
	{
		n_storylyEvent (p0, p1, p2, p3, p4);
	}

	private native void n_storylyEvent (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.analytics.StorylyEvent p1, com.appsamurai.storyly.StoryGroup p2, com.appsamurai.storyly.Story p3, com.appsamurai.storyly.StoryComponent p4);


	public void storylyLoadFailed (com.appsamurai.storyly.StorylyView p0, java.lang.String p1)
	{
		n_storylyLoadFailed (p0, p1);
	}

	private native void n_storylyLoadFailed (com.appsamurai.storyly.StorylyView p0, java.lang.String p1);


	public void storylyLoaded (com.appsamurai.storyly.StorylyView p0, java.util.List p1, com.appsamurai.storyly.StorylyDataSource p2)
	{
		n_storylyLoaded (p0, p1, p2);
	}

	private native void n_storylyLoaded (com.appsamurai.storyly.StorylyView p0, java.util.List p1, com.appsamurai.storyly.StorylyDataSource p2);


	public void storylyStoryDismissed (com.appsamurai.storyly.StorylyView p0)
	{
		n_storylyStoryDismissed (p0);
	}

	private native void n_storylyStoryDismissed (com.appsamurai.storyly.StorylyView p0);


	public void storylyStoryShowFailed (com.appsamurai.storyly.StorylyView p0, java.lang.String p1)
	{
		n_storylyStoryShowFailed (p0, p1);
	}

	private native void n_storylyStoryShowFailed (com.appsamurai.storyly.StorylyView p0, java.lang.String p1);


	public void storylyStoryShown (com.appsamurai.storyly.StorylyView p0)
	{
		n_storylyStoryShown (p0);
	}

	private native void n_storylyStoryShown (com.appsamurai.storyly.StorylyView p0);


	public void storylyUserInteracted (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.StoryGroup p1, com.appsamurai.storyly.Story p2, com.appsamurai.storyly.StoryComponent p3)
	{
		n_storylyUserInteracted (p0, p1, p2, p3);
	}

	private native void n_storylyUserInteracted (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.StoryGroup p1, com.appsamurai.storyly.Story p2, com.appsamurai.storyly.StoryComponent p3);

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
