/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.LoadingScreen;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ProgressBar;
import android.widget.TextView;

import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;
import androidx.navigation.Navigation;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Locale;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import fr.gmarquette.guesswho.GameData.Database.DataBase;
import fr.gmarquette.guesswho.GameData.ImportDataManager;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.Music.BandeSon;
import fr.gmarquette.guesswho.InterfaceManagement.MainActivityViewModel;
import fr.gmarquette.guesswho.R;

public class LoadingScreenFragment extends Fragment {

    private float avancement;
    private View view;
    private static final int MAX_PROGRESS_BAR = 100;
    private ProgressBar progressBar;
    private TextView textView;
    private final ExecutorService executorService = Executors.newSingleThreadExecutor();
    private ImportDataManager importDataManager;
    private MainActivityViewModel mainActivityViewModel;
    private BandeSon bandeSon;

    public LoadingScreenFragment() {
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.fragment_loading_screen, container, false);
        mainActivityViewModel = new ViewModelProvider(requireActivity()).get(MainActivityViewModel.class);

        progressBar = view.findViewById(R.id.progressBar);
        textView = view.findViewById(R.id.textProgressBar);
        textView.setText("0 %");

        SharedPreferences sharedPreferences = requireActivity().getSharedPreferences("GuessWhoApp", Context.MODE_PRIVATE);
        boolean isUpdated = sharedPreferences.getBoolean("isUpdated", false);

        boolean volume = sharedPreferences.getBoolean("Volume", true);
        bandeSon = BandeSon.getInstance();
        bandeSon.playOpening();
        bandeSon.setVolume(volume);


        if(isUpdated)
        {
            progressBar.setProgress(MAX_PROGRESS_BAR);
            textView.setText(R.string.MaxProgressBar);
        }
        else
        {
            avancement = 0;
            String today = getToday();
            SharedPreferences.Editor editor = sharedPreferences.edit();
            editor.putBoolean("isUpdated", true);
            editor.putString("Date of Update", today);
            editor.apply();
        }

        importDataManager = ImportDataManager.getInstance();
        setLoadingBar();

        return view;
    }

    private void setLoadingBar()
    {
        executorService.submit(() ->
        {
            if(progressBar.getProgress() != MAX_PROGRESS_BAR)
            {
                while(importDataManager.getNameList() == null || importDataManager.getNameList().isEmpty())
                {

                }

                int max = importDataManager.getNameList().size();
                while (avancement < MAX_PROGRESS_BAR)
                {
                    avancement = importDataManager.getAvancement(max);

                    requireActivity().runOnUiThread(() -> {
                        progressBar.setProgress((int) avancement);
                        progressBar.setMax(MAX_PROGRESS_BAR);
                        String text = (int) avancement + " %";
                        textView.setText(text);
                    });
                }
            }
            mainActivityViewModel.setCharacterNameList(DataBase.getInstance(requireContext()).dao().getAllNames());
            mainActivityViewModel.setCharacterLevelList(DataBase.getInstance(requireContext()).dao().getAllLevels());
            mainActivityViewModel.setCharacterPicturesList(DataBase.getInstance(requireContext()).dao().getAllPictures());

            requireActivity().runOnUiThread(() -> {
                bandeSon.stop();
                bandeSon.startPlaying();
                SharedPreferences sharedPreferences = requireActivity().getSharedPreferences("GuessWhoApp", Context.MODE_PRIVATE);
                boolean volume = sharedPreferences.getBoolean("Volume", true);
                bandeSon.setVolume(volume);
                Navigation.findNavController(view).navigate(R.id.action_loadingScreenFragment_to_gameSelectionScreenFragment);
            });

        });
    }

    private static String getToday()
    {
        LocalDate date = LocalDate.now();
        Locale locale = Locale.getDefault();
        DateTimeFormatter formatter;
        // Etats-Unis, Philippines, Belize, Canada (Quebec), Bahamas
        if (locale.getCountry().equals("US") || locale.getCountry().equals("PH") || locale.getCountry().equals("BZ")
                || locale.getCountry().equals("CA") || locale.getCountry().equals("BS")) {
            formatter = DateTimeFormatter.ofPattern("MM/dd/yyyy", locale);
        }
        else
        {
            formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy").withLocale(locale);
        }
        return date.format(formatter);
    }
}