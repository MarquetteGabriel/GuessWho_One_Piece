/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.GameSystem.Music;

import android.media.MediaPlayer;
import android.view.View;

import fr.gmarquette.guesswho.R;

public class PlayNikaLaugh
{
    private static final int volumeNika = BandeSon.volume + 20;

    public static void play(View view)
    {
        MediaPlayer mediaPlayer = MediaPlayer.create(view.getContext(), R.raw.nika_laugh);
        mediaPlayer.setVolume(volumeNika, volumeNika);
        mediaPlayer.start();
        mediaPlayer.setOnCompletionListener(MediaPlayer::release);
    }
}
