package net.iditu;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Rect;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.view.animation.AnimationUtils;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.Toast;

public class IamHereActivity extends Activity {
	
	FrameLayout bg=null;
    @Override
    public void onCreate(Bundle bundle)
    {
        super.onCreate(bundle);
  
        Intent intent = getIntent();
        setContentView(R.layout.shortcut_onekey);
        bg = (FrameLayout)findViewById(R.id.anim_layout);
        Rect rect = intent.getSourceBounds();
        if(rect != null)
        {
			//int i = getResources().getDimensionPixelSize(0x7f0b001d);
            int i=10;
        	int j = rect.left + rect.width() / 2;
            int k = i + rect.top;
            android.widget.RelativeLayout.LayoutParams layoutparams = (android.widget.RelativeLayout.LayoutParams)bg.getLayoutParams();
            layoutparams.leftMargin = j - layoutparams.width / 2;
            layoutparams.topMargin = k - layoutparams.height / 2;
            bg.setLayoutParams(layoutparams);
        }
        play(this);
        mHandler.sendEmptyMessageDelayed(1, 1000);
    }
    public static void play(IamHereActivity onekeyactivity)
    {
        onekeyactivity.bg.setVisibility(0);
        ImageView imageview = (ImageView)onekeyactivity.findViewById(R.id.anim_image);
        imageview.setVisibility(0);
        imageview.startAnimation(AnimationUtils.loadAnimation(onekeyactivity, R.anim.shortcut_onekey));
    }

    
	private Handler mHandler = new Handler() {

		public void handleMessage(Message msg) {

			Toast.makeText(getApplicationContext(), "toast handle message",
				     Toast.LENGTH_SHORT).show();

			if (1 == msg.what)
				finish(); // 动画播放结束，结束我们的Activity界面
		}
	};

}
