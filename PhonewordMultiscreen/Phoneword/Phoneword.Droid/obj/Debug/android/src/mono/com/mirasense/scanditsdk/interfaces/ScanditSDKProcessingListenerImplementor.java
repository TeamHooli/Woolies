package mono.com.mirasense.scanditsdk.interfaces;


public class ScanditSDKProcessingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mirasense.scanditsdk.interfaces.ScanditSDKProcessingListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_didProcess:([BIILcom/mirasense/scanditsdk/interfaces/ScanditSDKScanSession;)V:GetDidProcess_arrayBIILcom_mirasense_scanditsdk_interfaces_ScanditSDKScanSession_Handler:Scandit.Interfaces.IScanditSDKProcessingListenerInvoker, ScanditSDK\n" +
			"";
		mono.android.Runtime.register ("Scandit.Interfaces.IScanditSDKProcessingListenerImplementor, ScanditSDK, Version=4.8.1.0, Culture=neutral, PublicKeyToken=null", ScanditSDKProcessingListenerImplementor.class, __md_methods);
	}


	public ScanditSDKProcessingListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ScanditSDKProcessingListenerImplementor.class)
			mono.android.TypeManager.Activate ("Scandit.Interfaces.IScanditSDKProcessingListenerImplementor, ScanditSDK, Version=4.8.1.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void didProcess (byte[] p0, int p1, int p2, com.mirasense.scanditsdk.interfaces.ScanditSDKScanSession p3)
	{
		n_didProcess (p0, p1, p2, p3);
	}

	private native void n_didProcess (byte[] p0, int p1, int p2, com.mirasense.scanditsdk.interfaces.ScanditSDKScanSession p3);

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
