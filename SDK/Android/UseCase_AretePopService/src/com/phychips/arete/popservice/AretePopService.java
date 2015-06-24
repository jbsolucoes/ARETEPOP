package com.phychips.arete.popservice;

import android.app.Service;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.net.Uri;
import android.os.IBinder;

public class AretePopService extends Service {
	@Override
	public IBinder onBind(Intent arg0) {
		return null;
	}

	@Override
	public void onStart(Intent intent, int startId) 
	{
		IntentFilter filter = new IntentFilter();
		filter.addAction(Intent.ACTION_HEADSET_PLUG);		
		registerReceiver(receiver, filter);
		
		System.out.println("AretePopService.onStart");
	}

	@Override
	public void onDestroy() 
	{
		unregisterReceiver(receiver);
		System.out.println("AretePopService.onDestroy");
	}

	private final BroadcastReceiver receiver = new BroadcastReceiver() 
	{
		@Override
		public void onReceive(Context context, Intent intent) 
		{
			if (intent.getAction().equals(Intent.ACTION_HEADSET_PLUG))
			{
				if (intent.hasExtra("state"))
				{				
					// Plugged
					if (intent.getIntExtra("state", 0) == 1)
				    {
						Intent i = new Intent(Intent.ACTION_VIEW);
						i.addCategory(Intent.CATEGORY_DEFAULT);
						i.addCategory(Intent.CATEGORY_BROWSABLE);
						i.setData(Uri.parse("rfid://com.phychips.aretepop.main"));
						i.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
						
						
						try
						{
							startActivity(i);
						}
						catch(Exception e)
						{
							e.printStackTrace();
						}
						finally
						{
							System.out.println("service broadcast receiver - startActivity");	
						}						
				    }
				}
			}
		}
	};
}
