package mono.com.android.volley;


public class RequestQueue_RequestEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.android.volley.RequestQueue.RequestEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRequestEvent:(Lcom/android/volley/Request;I)V:GetOnRequestEvent_Lcom_android_volley_Request_IHandler:Volley.RequestQueue/IRequestEventListenerInvoker, Xamarin.Android.Volley\n" +
			"";
		mono.android.Runtime.register ("Volley.RequestQueue+IRequestEventListenerImplementor, Xamarin.Android.Volley", RequestQueue_RequestEventListenerImplementor.class, __md_methods);
	}


	public RequestQueue_RequestEventListenerImplementor ()
	{
		super ();
		if (getClass () == RequestQueue_RequestEventListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Volley.RequestQueue+IRequestEventListenerImplementor, Xamarin.Android.Volley", "", this, new java.lang.Object[] {  });
		}
	}


	public void onRequestEvent (com.android.volley.Request p0, int p1)
	{
		n_onRequestEvent (p0, p1);
	}

	private native void n_onRequestEvent (com.android.volley.Request p0, int p1);

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
