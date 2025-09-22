/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.ProfileMenu;

import android.app.Dialog;
import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageButton;
import android.widget.ProgressBar;
import android.widget.Switch;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.navigation.Navigation;

import com.google.android.material.bottomsheet.BottomSheetBehavior;
import com.google.android.material.bottomsheet.BottomSheetDialog;
import com.google.android.material.bottomsheet.BottomSheetDialogFragment;

import fr.gmarquette.guesswho.GameData.ImportDataManager;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.Music.BandeSon;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.Music.PlayNikaLaugh;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.Notifications.NotificationManager;
import fr.gmarquette.guesswho.R;

public class SettingsFragment extends BottomSheetDialogFragment {

    private ImageButton imageButtonVolume;
    private ImageButton imageButtonNotifications;
    private SharedPreferences sharedPreferences;
    private Switch switchNotifications, switchVolume;
    public SettingsFragment() {
    }


    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState)
    {
        BottomSheetDialog dialog = (BottomSheetDialog) super.onCreateDialog(savedInstanceState);
        View view = View.inflate(requireContext(), R.layout.fragment_settings, null);
        dialog.setContentView(view);

        BottomSheetBehavior<View> bottomSheetBehavior = BottomSheetBehavior.from((View) view.getParent());
        bottomSheetBehavior.setDraggable(false);
        bottomSheetBehavior.setState(BottomSheetBehavior.STATE_EXPANDED);
        return dialog;
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_settings, container, false);
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);

        TextView winsTextView = view.findViewById(R.id.wins);
        TextView losesTextView = view.findViewById(R.id.loses);
        TextView ratioTextView = view.findViewById(R.id.textRatio);
        ImageButton button = view.findViewById(R.id.importData);
        ProgressBar progressBar = view.findViewById(R.id.progressBarRatioWinLoses);
        imageButtonVolume = view.findViewById(R.id.imageButtonVolume);
        imageButtonNotifications = view.findViewById(R.id.imageButtonNotifications);
        switchNotifications = view.findViewById(R.id.switchNotifications);
        switchVolume = view.findViewById(R.id.switchVolume);
        ImageButton nikaButton = view.findViewById(R.id.playNika);
        TextView dateOfUpdateTextView = view.findViewById(R.id.dateOfUpdate);

        sharedPreferences = requireActivity().getSharedPreferences("GuessWhoApp", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        int wins = sharedPreferences.getInt("wins", 0);
        int loses = sharedPreferences.getInt("loses", 0);
        boolean volume = sharedPreferences.getBoolean("Volume", true);
        boolean notification = sharedPreferences.getBoolean("Notification", true);
        String dateOfUpdate = sharedPreferences.getString("Date of Update", "26/07/2001");

        button.setOnClickListener(view1 -> {
            editor.putBoolean("isUpdated", false);
            editor.apply();
            ImportDataManager.getInstance().importManager(requireContext());
            Navigation.findNavController(requireActivity(), R.id.fragmentContainerView5).navigate(R.id.action_settingsFragment_to_loadingScreenFragment);
        });

        nikaButton.setOnClickListener(view1 -> PlayNikaLaugh.play(view));

        switchNotifications.setOnClickListener(view1 -> {
            if(switchNotifications.isChecked())
            {
                editor.putBoolean("Notification", true);
                editor.apply();
                imageButtonNotifications.setImageResource(R.drawable.notifications_on);
                NotificationManager.sendNotifications(requireContext());
            }
            else
            {
                editor.putBoolean("Notification", false);
                editor.apply();
                imageButtonNotifications.setImageResource(R.drawable.notifications_none);
                NotificationManager.cancelNotification(requireContext());
            }
        });
        switchVolume.setOnClickListener(view1 -> {
            if(switchVolume.isChecked())
            {
                editor.putBoolean("Volume", true);
                editor.apply();
                imageButtonVolume.setImageResource(R.drawable.volume_up);
                BandeSon.getInstance().startPlaying();
            }
            else
            {
                editor.putBoolean("Volume", false);
                editor.apply();
                imageButtonVolume.setImageResource(R.drawable.volume_off);
            }
            BandeSon.getInstance().setVolume(sharedPreferences.getBoolean("Volume", true));
        });


        int ratio;
        if(loses == 0 && wins == 0)
        {
            ratio = 0;
        }
        else
        {
             ratio = (wins * 100)/(loses + wins);
        }

        winsTextView.setText(String.valueOf(wins));
        losesTextView.setText(String.valueOf(loses));
        ratioTextView.setText(ratio + " %");

        progressBar.setProgress(ratio);
        dateOfUpdateTextView.setText(dateOfUpdate);
        updateVolume(volume);
        updateNotifications(notification);

        ImageButton backButton = view.findViewById(R.id.backButton);
        backButton.setOnClickListener(view1 -> requireActivity().onBackPressed());

    }

    private void updateVolume(boolean state)
    {
        if(state)
        {
            switchVolume.setChecked(true);
            imageButtonVolume.setImageResource(R.drawable.volume_up);
        }
        else
        {
            switchVolume.setChecked(false);
            imageButtonVolume.setImageResource(R.drawable.volume_off);
        }
    }

    private void updateNotifications(boolean state)
    {
        if(state)
        {
            switchNotifications.setChecked(true);
            imageButtonNotifications.setImageResource(R.drawable.notifications_on);
        }
        else
        {
            switchNotifications.setChecked(false);
            imageButtonNotifications.setImageResource(R.drawable.notifications_none);
        }
    }
}