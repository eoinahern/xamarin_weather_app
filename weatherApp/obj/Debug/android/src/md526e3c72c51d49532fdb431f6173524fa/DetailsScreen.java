package md526e3c72c51d49532fdb431f6173524fa;


public class DetailsScreen
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("weatherApp.DetailsScreen, weatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DetailsScreen.class, __md_methods);
	}


	public DetailsScreen () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DetailsScreen.class)
			mono.android.TypeManager.Activate ("weatherApp.DetailsScreen, weatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
