/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.GameScreen.View;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.app.Dialog;
import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewTreeObserver;
import android.view.Window;
import android.view.inputmethod.InputMethodManager;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.GridView;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;

import com.squareup.picasso.Picasso;

import java.util.ArrayList;
import java.util.concurrent.ExecutionException;

import fr.gmarquette.guesswho.GameData.Database.CallDAOAsync;
import fr.gmarquette.guesswho.GameData.Database.Characters;
import fr.gmarquette.guesswho.GameData.Database.DataBase;
import fr.gmarquette.guesswho.InterfaceManagement.GameScreen.AnimationManager;
import fr.gmarquette.guesswho.InterfaceManagement.GameScreen.Answering;
import fr.gmarquette.guesswho.InterfaceManagement.GameScreen.PicturesAlbum;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.GameInit;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.GameManager;
import fr.gmarquette.guesswho.InterfaceManagement.MainActivityViewModel;
import fr.gmarquette.guesswho.R;

public class GameScreenFragment extends Fragment {

    public static int NUMBER_GUESSED = 1;
    Characters characterToFind;
    private CallDAOAsync callDAOAsync;
    private GameInit gameInit;

    private ArrayList<String> suggestions;
    View viewFragment;
    GridAdapter gridAdapter;
    private GridView gridView;

    AutoCompleteTextView autoCompleteTextView;
    String[] textAnswer = {"","","","","","","","","","", "","","","","","","","","","", "","","","",
            "","","","","","", "","","","","","","","","","", "", ""};
    int[] circleImages = {R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle,
            R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle,
            R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle,
            R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle,
            R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle, R.drawable.gray_circle,  R.drawable.gray_circle};
    int[] answerImages = {R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle,
            R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle,
            R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle,
            R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle,
            R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle, R.drawable.empty_circle,  R.drawable.empty_circle};
    public GameScreenFragment() {
        // Required empty public constructor
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        viewFragment = inflater.inflate(R.layout.fragment_game_screen, container, false);
        MainActivityViewModel mainActivityViewModel = new ViewModelProvider(requireActivity()).get(MainActivityViewModel.class);
        suggestions = (ArrayList<String>) mainActivityViewModel.getSuggestions().getValue();
        gridView = viewFragment.findViewById(R.id.grid_view);

        gridAdapter = new GridAdapter(requireContext().getApplicationContext(), textAnswer, circleImages, answerImages);
        gridView.setAdapter(gridAdapter);

        DataBase.getInstance(requireContext().getApplicationContext());
        callDAOAsync = new CallDAOAsync(requireContext().getApplicationContext());
        gameInit = new GameInit(requireContext().getApplicationContext());

        ArrayAdapter<String> adapter = new ArrayAdapter<>(requireContext().getApplicationContext(), android.R.layout.simple_dropdown_item_1line, suggestions);
        autoCompleteTextView = viewFragment.findViewById(R.id.EnterTextAutoCompleted);

        autoCompleteTextView.setAdapter(adapter);
        autoCompleteTextView.setOnItemClickListener((adapterView, view, position, id) -> {
            String selectedValue = autoCompleteTextView.getAdapter().getItem(position).toString();
            autoCompleteTextView.setText(selectedValue);

            InputMethodManager imm = (InputMethodManager) requireContext().getSystemService(Context.INPUT_METHOD_SERVICE);
            imm.hideSoftInputFromWindow(autoCompleteTextView.getWindowToken(), 0);

            getAnswer(selectedValue);
            autoCompleteTextView.setText("");
        });

        ImageButton backButton = viewFragment.findViewById(R.id.backButton);
        backButton.setOnClickListener(view -> requireActivity().onBackPressed());

        PicturesAlbum.getInstance().setImages();
        restart();
        
        return viewFragment;
    }

    public void getAnswer(String selectedValue)
    {
        NUMBER_GUESSED++;

        boolean result = answerToRequest(selectedValue);
        if(result)
        {
            displayWinDialog();
        }
        else if(NUMBER_GUESSED == 6)
        {
            displayLooseDialog();
        }
    }

    public boolean answerToRequest(String selectedValue)
    {
        Characters character;
        try {
            character = callDAOAsync.getCharacterFromNameAsync(selectedValue).get();
        } catch (ExecutionException | InterruptedException e) {
            throw new RuntimeException(e);
        }

        Answering answer = AnimationManager.updateFruit(GameManager.hasEatenDevilFruit(character, characterToFind), character);
        int[] guessAnswer = {R.id.guess_1, R.id.guess_2, R.id.guess_3, R.id.guess_4, R.id.guess_5, R.id.guess_6};
        getAnswerPrinted((NUMBER_GUESSED -1), answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateBounty(GameManager.lookingForBounty(character, characterToFind), character);
        getAnswerPrinted(((NUMBER_GUESSED -1) + 6), answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateChapter(GameManager.getAppearanceDiff(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED -1) + 2*6, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateType(GameManager.getType(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED -1)+3*6, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateAlive(GameManager.isAlive(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED -1)+4*6, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateAge(GameManager.getAge(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED -1)+5*6, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateCrew(GameManager.getCrew(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED -1)+6*6, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        ((TextView) viewFragment.findViewById(guessAnswer[NUMBER_GUESSED - 1])).setText(selectedValue);

        return GameManager.isSameName(character, characterToFind);
    }


    public void restart()
    {
        cleanPicture();
        try {
            characterToFind = gameInit.getCharacterToFound(suggestions);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        NUMBER_GUESSED = 0;
    }

    private void cleanPicture()
    {
        try {
            cleanGridView(gridView);
        }
        catch (Exception e)
        {
            gridView.getViewTreeObserver().addOnGlobalLayoutListener(new ViewTreeObserver.OnGlobalLayoutListener() {
                @Override
                public void onGlobalLayout() {
                    cleanGridView(gridView);
                    gridView.getViewTreeObserver().removeOnGlobalLayoutListener(this);

                }
            });
        }
    }

    private void cleanGridView(GridView gridView)
    {
        for (int i = 0; i < 6; i++) {
            String guess = "guess_" + (i + 1);
            int id = getResources().getIdentifier(guess, "id", requireContext().getPackageName());
            TextView textView = viewFragment.findViewById(id);
            int stringId = getResources().getIdentifier(guess, "string", requireContext().getPackageName());
            String guessString = getResources().getString(stringId);
            textView.setText(guessString);
        }

        for(int i = 0; i < gridView.getCount(); i++)
        {
            ImageView imageViewBackground = gridView.getChildAt(i).findViewById(R.id.wr_circle);
            imageViewBackground.setImageResource(PicturesAlbum.getInstance().WRONG_ANSWER);
            ImageView imageViewAnswer = gridView.getChildAt(i).findViewById(R.id.answer_circle);
            imageViewAnswer.setImageResource(PicturesAlbum.getInstance().EMPTY_ANSWER);
            TextView textView = gridView.getChildAt(i).findViewById(R.id.text_answer);
            textView.setText("");
        }
    }

    private void displayWinDialog()
    {
        SharedPreferences sharedPreferences = requireActivity().getSharedPreferences("GuessWhoApp", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putInt("wins", sharedPreferences.getInt("wins", 0) + 1);
        editor.apply();

        final Dialog dialog = new Dialog(requireContext());
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE);
        dialog.setCancelable(false);
        dialog.setContentView(R.layout.win_popup);

        Button yesButton = dialog.findViewById(R.id.yesButton);
        Button noButton = dialog.findViewById(R.id.noButton);

        TextView answer = dialog.findViewById(R.id.answer);
        ImageView pictureCharacter = dialog.findViewById(R.id.characterPictureFinal);
        answer.setText(characterToFind.getName());
        Picasso.get().load(characterToFind.getPicture()).into(pictureCharacter);

        yesButton.setOnClickListener(view -> {
            restart();
            dialog.dismiss();
        });

        noButton.setOnClickListener(view -> {
            dialog.dismiss();
            NavController navController = Navigation.findNavController(requireActivity(), R.id.fragmentContainerView5);
            navController.navigate(R.id.gameSelectionScreenFragment);
        });

        dialog.show();
    }

    private void displayLooseDialog()
    {
        SharedPreferences sharedPreferences = requireActivity().getSharedPreferences("GuessWhoApp", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putInt("loses", sharedPreferences.getInt("loses", 0) + 1);
        editor.apply();


        final Dialog dialog = new Dialog(requireContext());
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE);
        dialog.setCancelable(false);
        dialog.setContentView(R.layout.win_popup);

        Button yesButton = dialog.findViewById(R.id.yesButton);
        Button noButton = dialog.findViewById(R.id.noButton);

        TextView answer = dialog.findViewById(R.id.answer);
        ImageView pictureCharacter = dialog.findViewById(R.id.characterPictureFinal);
        answer.setText(characterToFind.getName());
        Picasso.get().load(characterToFind.getPicture()).into(pictureCharacter);

        yesButton.setOnClickListener(view -> {
            restart();
            dialog.dismiss();
        });

        noButton.setOnClickListener(view -> {
            dialog.dismiss();
            NavController navController = Navigation.findNavController(requireActivity(), R.id.fragmentContainerView5);
            navController.navigate(R.id.gameSelectionScreenFragment);
        });

        dialog.show();
    }


    public void crossFading(final ImageView imageViewBackground, final ImageView imageViewAnswer, final TextView textView, final int imageBackgroundId, final int imageAnswerId, final String answer) {

        if(imageViewBackground != null && imageBackgroundId != 0)
        {
            imageViewBackground.animate()
                    .alpha(0f)
                    .setDuration(300)
                    .setListener(new AnimatorListenerAdapter() {
                        @Override
                        public void onAnimationEnd(Animator animation) {
                            imageViewBackground.setImageResource(imageBackgroundId);
                            imageViewBackground.animate().alpha(1f).setDuration(500).start();
                        }
                    }).start();
        }

        if(imageViewAnswer != null && imageAnswerId != 0)
        {
            imageViewAnswer.animate()
                    .alpha(0f)
                    .setDuration(300)
                    .setListener(new AnimatorListenerAdapter() {
                        @Override
                        public void onAnimationEnd(Animator animation) {
                            imageViewAnswer.setImageResource(imageAnswerId);
                            imageViewAnswer.animate().alpha(1f).setDuration(500).start();
                        }
                    }).start();
        }

        if(textView != null)
        {
            textView.animate()
                    .alpha(0f)
                    .setDuration(300)
                    .setListener(new AnimatorListenerAdapter() {
                        @Override
                        public void onAnimationEnd(Animator animation) {
                            textView.setText(answer);
                            textView.animate().alpha(1f).setDuration(500).start();
                        }
                    }).start();
        }
    }
    public void getAnswerPrinted(int position, int imageBackgroundId, int answerImageId, String answer) {

        ImageView imageBackground = gridView.getChildAt(position).findViewById(R.id.wr_circle);
        ImageView imageAnswer = gridView.getChildAt(position).findViewById(R.id.answer_circle);
        TextView textAnswer = gridView.getChildAt(position).findViewById(R.id.text_answer);

        // With animation partially working
        /*
        crossFading(imageBackground, imageAnswer, textAnswer, imageBackgroundId, answerImageId, answer);
         */

        // Without animation
        imageBackground.setImageResource(imageBackgroundId);
        imageAnswer.setImageResource(answerImageId);
        textAnswer.setText(answer);
    }
}