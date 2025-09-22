/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.GameSelectionScreen;

import android.media.AudioManager;
import android.net.Uri;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.TextView;
import android.widget.VideoView;

import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;

import java.util.ArrayList;
import java.util.Objects;

import fr.gmarquette.guesswho.InterfaceManagement.MainActivityViewModel;
import fr.gmarquette.guesswho.R;

public class GameSelectionScreenFragment extends Fragment{

    private MainActivityViewModel activityViewModel;
    public static ArrayList<String> arrayList = new ArrayList<>();

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View viewFragment = inflater.inflate(R.layout.fragment_game_selection_screen, container, false);
        activityViewModel = new ViewModelProvider(requireActivity()).get(MainActivityViewModel.class);

        VideoView videoView = viewFragment.findViewById(R.id.video_gear5);
        Uri uri = Uri.parse("android.resource://" + requireActivity().getPackageName() + "/" + R.raw.presentation_gear5);
        videoView.setVideoURI(uri);
        videoView.setAudioFocusRequest(AudioManager.AUDIOFOCUS_NONE);

        videoView.setOnPreparedListener(mp -> {
            mp.setVolume(0,0);
            mp.setLooping(true);
            mp.start();
        });

        videoView.setOnCompletionListener(mp -> {
            mp.seekTo(0);
            mp.start();
        });

        Button button = viewFragment.findViewById(R.id.playButton);
        SeekBar seekBar = viewFragment.findViewById(R.id.seekBarDifficulty);
        TextView textView = viewFragment.findViewById(R.id.text_difficulty);

        seekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean b) {
                LevelDifficulty levelDifficulty = LevelDifficulty.getLevelDifficultyByValue(progress);
                if (levelDifficulty != null)
                {
                    textView.setText(levelDifficulty.toString());
                }
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });

        button.setOnClickListener(view -> {

            arrayList.clear();
            getSuggestions(seekBar.getProgress());

            NavController navController = Navigation.findNavController(requireActivity(), R.id.fragmentContainerView5);
            navController.navigate(R.id.action_gameSelectionScreenFragment_to_gameScreenFragment);
        });

        return viewFragment;
    }

    private void getSuggestions(int level)
    {
        for(String character : Objects.requireNonNull(activityViewModel.getCharacterNameList().getValue()))
        {
            int position = activityViewModel.getCharacterNameList().getValue().indexOf(character);
            if(Objects.requireNonNull(activityViewModel.getCharacterLevelList().getValue()).get(position) <= level)
            {
                if(!arrayList.contains(character))
                {
                    arrayList.add(character);
                }
            }
        }
        activityViewModel.setSuggestions(arrayList);
    }
}