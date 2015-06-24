package com.phychips.arete.popservice;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.preference.PreferenceManager;

public class BootReceiver extends BroadcastReceiver 
{
	@Override
	public void onReceive(Context context, Intent intent) 
	{
		System.out.println("onReceive");
		
		if (intent.getAction().equals(Intent.ACTION_BOOT_COMPLETED)) 
		{
			Intent i = new Intent(context, AretePopService.class);
			
			SharedPreferences prefs = PreferenceManager
					.getDefaultSharedPreferences(context);
			
			if(prefs.getBoolean("PLUG_AND_PLAY", false))
			{
				System.out.println("PLUG_AND_PLAY");
				
				try
				{
					context.startService(i);
				}
				catch(Exception e)
				{
					e.printStackTrace();
				}	
			}

		}
	}

}
