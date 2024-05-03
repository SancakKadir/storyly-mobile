package crc64e90d040245927deb;


public class MainActivity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.appsamurai.storyly.StorylyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateOptionsMenu:(Landroid/view/Menu;)Z:GetOnCreateOptionsMenu_Landroid_view_Menu_Handler\n" +
			"n_onOptionsItemSelected:(Landroid/view/MenuItem;)Z:GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_storylyActionClicked:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/Story;)V:GetStorylyActionClicked_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_Story_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyEvent:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/analytics/StorylyEvent;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V:GetStorylyEvent_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_analytics_StorylyEvent_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyLoadFailed:(Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V:GetStorylyLoadFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyLoaded:(Lcom/appsamurai/storyly/StorylyView;Ljava/util/List;Lcom/appsamurai/storyly/StorylyDataSource;)V:GetStorylyLoaded_Lcom_appsamurai_storyly_StorylyView_Ljava_util_List_Lcom_appsamurai_storyly_StorylyDataSource_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyStoryDismissed:(Lcom/appsamurai/storyly/StorylyView;)V:GetStorylyStoryDismissed_Lcom_appsamurai_storyly_StorylyView_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyStoryShowFailed:(Lcom/appsamurai/storyly/StorylyView;Ljava/lang/String;)V:GetStorylyStoryShowFailed_Lcom_appsamurai_storyly_StorylyView_Ljava_lang_String_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyStoryShown:(Lcom/appsamurai/storyly/StorylyView;)V:GetStorylyStoryShown_Lcom_appsamurai_storyly_StorylyView_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"n_storylyUserInteracted:(Lcom/appsamurai/storyly/StorylyView;Lcom/appsamurai/storyly/StoryGroup;Lcom/appsamurai/storyly/Story;Lcom/appsamurai/storyly/StoryComponent;)V:GetStorylyUserInteracted_Lcom_appsamurai_storyly_StorylyView_Lcom_appsamurai_storyly_StoryGroup_Lcom_appsamurai_storyly_Story_Lcom_appsamurai_storyly_StoryComponent_Handler:Com.Appsamurai.Storyly.IStorylyListenerInvoker, storyly.xamarin.binding\n" +
			"";
		mono.android.Runtime.register ("com.storyly.xamarin.MainActivity, com.storyly.xamarin", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class) {
			mono.android.TypeManager.Activate ("com.storyly.xamarin.MainActivity, com.storyly.xamarin", "", this, new java.lang.Object[] {  });
		}
	}


	public MainActivity (int p0)
	{
		super (p0);
		if (getClass () == MainActivity.class) {
			mono.android.TypeManager.Activate ("com.storyly.xamarin.MainActivity, com.storyly.xamarin", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public boolean onCreateOptionsMenu (android.view.Menu p0)
	{
		return n_onCreateOptionsMenu (p0);
	}

	private native boolean n_onCreateOptionsMenu (android.view.Menu p0);


	public boolean onOptionsItemSelected (android.view.MenuItem p0)
	{
		return n_onOptionsItemSelected (p0);
	}

	private native boolean n_onOptionsItemSelected (android.view.MenuItem p0);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


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
