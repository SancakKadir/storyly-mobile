package mono.com.appsamurai.storyly;


public class StorylyMomentsListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.appsamurai.storyly.StorylyMomentsListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_storyHeaderClicked:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;)V:GetStoryHeaderClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Handler:Com.Appsamurai.Storyly.IStorylyMomentsListenerInvoker, storyly.xamarin.binding\n" +
			"";
		mono.android.Runtime.register ("Com.Appsamurai.Storyly.IStorylyMomentsListenerImplementor, storyly.xamarin.binding", StorylyMomentsListenerImplementor.class, __md_methods);
	}


	public StorylyMomentsListenerImplementor ()
	{
		super ();
		if (getClass () == StorylyMomentsListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Appsamurai.Storyly.IStorylyMomentsListenerImplementor, storyly.xamarin.binding", "", this, new java.lang.Object[] {  });
		}
	}


	public void storyHeaderClicked (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.StoryGroup p1, com.appsamurai.storyly.Story p2)
	{
		n_storyHeaderClicked (p0, p1, p2);
	}

	private native void n_storyHeaderClicked (com.appsamurai.storyly.StorylyView p0, com.appsamurai.storyly.StoryGroup p1, com.appsamurai.storyly.Story p2);

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
