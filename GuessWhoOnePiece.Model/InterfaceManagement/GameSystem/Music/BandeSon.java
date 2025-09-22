/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.GameSystem.Music;

import android.content.Context;
import android.content.SharedPreferences;
import android.media.MediaPlayer;

import java.util.ArrayList;
import java.util.List;

import fr.gmarquette.guesswho.R;

public class BandeSon {

    private BandeSon() {}
    private static class BandeSonHolder
    {
        private final static BandeSon instance = new BandeSon();
    }
    public static BandeSon getInstance()
    {
        return BandeSon.BandeSonHolder.instance;
    }

    static final int volume = 15;
    MediaPlayer mediaPlayer;
    Context context;
    List<Integer> playlist = new ArrayList<>();

    public void init(Context context)
    {
        this.context = context;
        init();
    }

    private void init()
    {
        playlist.add(R.raw.bs_ado_binksunosake);
        playlist.add(R.raw.bs_ado_im_invincible);
        playlist.add(R.raw.bs_ado_backlight);
        playlist.add(R.raw.bs_ado_newgenesis);
        playlist.add(R.raw.bs_ado_totmusica);
        playlist.add(R.raw.bs_ed_un_memories);
        playlist.add(R.raw.bs_fierce_attack);
        playlist.add(R.raw.bs_it_awakens);
        playlist.add(R.raw.bs_katakuri_system_defence_deploy);
        playlist.add(R.raw.bs_overtaken);
    }



    public void playOpening()
    {
        try
        {
            mediaPlayer = MediaPlayer.create(context, R.raw.bs_op_quinze_wego);
            mediaPlayer.start();
        }
        catch (Exception ignored)
        {
        }

    }

    public void stop()
    {
        mediaPlayer.stop();
        mediaPlayer.release();
    }

    public void pause()
    {
        mediaPlayer.pause();
    }

    public void resume()
    {
        mediaPlayer.start();
    }

    public void startPlaying()
    {
        int trackIndex = (int) (Math.random() * playlist.size());
        playSongs(trackIndex);
    }

    private void playSongs(int trackIndex)
    {
        SharedPreferences sharedPreferences = context.getSharedPreferences("GuessWhoApp", Context.MODE_PRIVATE);
        boolean volumeState = sharedPreferences.getBoolean("Volume", true);
        if(trackIndex == this.playlist.size())
        {
            trackIndex = 0;
        }

        int currentIndex = trackIndex;
        mediaPlayer = MediaPlayer.create(context, playlist.get(trackIndex));
        mediaPlayer.start();
        setVolume(volumeState);
        mediaPlayer.setOnCompletionListener(mp -> playSongs(currentIndex + 1));
    }

    public void setVolume(boolean state)
    {
        if(state)
        {
            mediaPlayer.setVolume(volume, volume);
        }
        else
        {
            mediaPlayer.setVolume(0, 0);
        }
    }
}

