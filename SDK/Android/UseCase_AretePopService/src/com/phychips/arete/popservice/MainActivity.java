package com.phychips.arete.popservice;


import android.os.Bundle;
import android.preference.PreferenceManager;
import android.app.Activity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.widget.CompoundButton;
import android.widget.ToggleButton;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
				
		SharedPreferences prefs = PreferenceManager
				.getDefaultSharedPreferences(getBaseContext());
		ToggleButton tglPlugAndPlay = (ToggleButton) findViewById(R.id.toggle_plug_and_play);
		tglPlugAndPlay.setChecked(prefs.getBoolean("PLUG_AND_PLAY", false));
		tglPlugAndPlay.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener()
		{
		    boolean bPlugAndPlay = false;

		    @Override
		    public void onCheckedChanged(CompoundButton buttonView,
			    boolean isChecked)
		    {
			if (isChecked)
			{
			    bPlugAndPlay = true;
			    Intent i = new Intent(getBaseContext(), AretePopService.class);
				getBaseContext().startService(i);
			}
			else
			{
			    bPlugAndPlay = false;
			    Intent i = new Intent(getBaseContext(), AretePopService.class);
				getBaseContext().stopService(i);
			}

			SharedPreferences prefs = PreferenceManager
				.getDefaultSharedPreferences(MainActivity.this);
			SharedPreferences.Editor editor = prefs.edit();
			editor.putBoolean("PLUG_AND_PLAY", bPlugAndPlay);
			editor.commit();
			
		    }
		});	
	}

}
