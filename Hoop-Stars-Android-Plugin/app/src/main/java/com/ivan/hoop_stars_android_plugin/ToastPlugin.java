package com.ivan.hoop_stars_android_plugin;

import android.app.Activity;
import android.widget.Toast;

import com.unity3d.player.UnityPlayer;

public class ToastPlugin {

    public static void Show(String text, boolean isLong){

        Activity currentActivity = UnityPlayer.currentActivity;
        Toast.makeText(currentActivity, text, (isLong)?Toast.LENGTH_LONG : Toast.LENGTH_SHORT).show();
    }



}
