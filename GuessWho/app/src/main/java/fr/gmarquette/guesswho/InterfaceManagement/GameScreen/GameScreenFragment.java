/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.GameScreen;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.app.Dialog;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.GridView;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.fragment.app.Fragment;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;

import java.util.ArrayList;
import java.util.concurrent.ExecutionException;

import fr.gmarquette.guesswho.GameData.Database.CallDAOAsync;
import fr.gmarquette.guesswho.GameData.Database.Characters;
import fr.gmarquette.guesswho.GameData.Database.DataBase;
import fr.gmarquette.guesswho.GameSystem.GameInit;
import fr.gmarquette.guesswho.GameSystem.GameManager;
import fr.gmarquette.guesswho.InterfaceManagement.GameSelectionScreen.GameSelectionScreenFragment;
import fr.gmarquette.guesswho.R;

public class GameScreenFragment extends Fragment {

    public static int NUMBER_GUESSED = 1;
    Characters characterToFind;
    private CallDAOAsync callDAOAsync;
    private GameInit gameInit;

    private ArrayList<String> suggestions;
    View viewFragment;
    private GridView gridView;
    Animation fadeIn, fadeOut;

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

        fadeIn = AnimationUtils.loadAnimation(getContext(), R.anim.fade_in);
        fadeOut = AnimationUtils.loadAnimation(getContext(), R.anim.fade_out);
        gridView = viewFragment.findViewById(R.id.grid_view);

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

        GridAdapter gridAdapter = new GridAdapter(requireContext().getApplicationContext(), textAnswer,circleImages, answerImages);
        gridView.setAdapter(gridAdapter);

        suggestions = GameSelectionScreenFragment.getListSuggestions();

        DataBase.getInstance(requireContext().getApplicationContext());
        callDAOAsync = new CallDAOAsync(requireContext().getApplicationContext());
        gameInit = new GameInit(requireContext().getApplicationContext());

        ArrayAdapter<String> adapter = new ArrayAdapter<>(requireContext().getApplicationContext(), android.R.layout.simple_dropdown_item_1line, suggestions);
        AutoCompleteTextView autoCompleteTextView = viewFragment.findViewById(R.id.EnterTextAutoCompleted);



        autoCompleteTextView.setAdapter(adapter);
        autoCompleteTextView.setOnItemClickListener((adapterView, view, position, id) -> {
            String selectedValue = autoCompleteTextView.getAdapter().getItem(position).toString();
            autoCompleteTextView.setText(selectedValue);

            getAnswer(selectedValue);
            autoCompleteTextView.setText("");
        });

        PicturesAlbum.getInstance().setImages();

        gridView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                //Toast.makeText(requireContext().getApplicationContext(),"You Clicked on "+ i + " circle",Toast.LENGTH_SHORT).show();
                //getAnswerPrinted(i, R.drawable.green_mark, R.drawable.fruit, null);
                //characterToFind = new Characters("Charlotte Katakuri", true, "1.057 Md", 860, "Pirate", true, 48, "BigMom's Crew", 0);
                //answerToRequest("Monkey D. Luffy");
                restart();
                getAnswer("Monkey D. Luffy");
            }
        });

        //restart();
        
        return viewFragment;
    }

    public void getAnswer(String selectedValue)
    {
        NUMBER_GUESSED++;

        getAnswerPrinted(NUMBER_GUESSED, R.drawable.green_mark, R.drawable.fruit, selectedValue);
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
        getAnswerPrinted((NUMBER_GUESSED -1) * 7, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateBounty(GameManager.lookingForBounty(character, characterToFind), character);
        getAnswerPrinted(NUMBER_GUESSED*7, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateChapter(GameManager.getAppearanceDiff(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED+1 )*7, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateType(GameManager.getType(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED + 2)*7, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateAlive(GameManager.isAlive(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED + 3)*7, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateAge(GameManager.getAge(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED+4)*7, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        answer = AnimationManager.updateCrew(GameManager.getCrew(character, characterToFind), character);
        getAnswerPrinted((NUMBER_GUESSED + 5)*7, answer.getImageBackground(), answer.getImageAnswer(), answer.getAnswer());

        ((TextView) viewFragment.findViewById(guessAnswer[NUMBER_GUESSED - 1])).setText(selectedValue);

        return GameManager.isSameName(character, characterToFind);
    }

    public void printAnswer(int number, Answering answering)
    {
        getAnswerPrinted((number) * 7, answering.getImageBackground(), answering.getImageAnswer(), answering.getAnswer());
    }


    public void restart()
    {
        cleanPicture();
        try {
            characterToFind = gameInit.getCharacterToFound(suggestions);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        NUMBER_GUESSED = 1;
    }

    private void cleanPicture()
    {
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
        final Dialog dialog = new Dialog(requireContext());
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE);
        dialog.setCancelable(false);
        dialog.setContentView(R.layout.win_popup);

        Button yesButton = dialog.findViewById(R.id.yesButton);
        Button noButton = dialog.findViewById(R.id.noButton);

        TextView answer = dialog.findViewById(R.id.answer);
        answer.setText(characterToFind.getName());

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
        final Dialog dialog = new Dialog(requireContext());
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE);
        dialog.setCancelable(false);
        dialog.setContentView(R.layout.win_popup);

        Button yesButton = dialog.findViewById(R.id.yesButton);
        Button noButton = dialog.findViewById(R.id.noButton);

        TextView answer = dialog.findViewById(R.id.answer);
        answer.setText(characterToFind.getName());

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
                    .setDuration(500)
                    .setListener(new AnimatorListenerAdapter() {
                        @Override
                        public void onAnimationEnd(Animator animation) {
                            super.onAnimationEnd(animation);
                            imageViewBackground.setImageResource(imageBackgroundId);
                            imageViewBackground.animate()
                                    .alpha(1f)
                                    .setDuration(500)
                                    .setListener(null)
                                    .start();
                        }
                    })
                    .start();
        }

        if(imageViewAnswer != null && imageAnswerId != 0)
        {
            imageViewAnswer.animate()
                    .alpha(0f)
                    .setDuration(500)
                    .setListener(new AnimatorListenerAdapter() {
                        @Override
                        public void onAnimationEnd(Animator animation) {
                            super.onAnimationEnd(animation);
                            imageViewAnswer.setImageResource(imageAnswerId);
                            imageViewAnswer.animate()
                                    .alpha(1f)
                                    .setDuration(500)
                                    .setListener(null)
                                    .start();
                        }
                    })
                    .start();
        }

        if(textView != null && answer != null)
        {
            textView.animate()
                    .alpha(0f)
                    .setDuration(500)
                    .setListener(new AnimatorListenerAdapter() {
                        @Override
                        public void onAnimationEnd(Animator animation) {
                            super.onAnimationEnd(animation);
                            textView.setText(answer);
                            textView.animate()
                                    .alpha(1f)
                                    .setDuration(500)
                                    .setListener(null)
                                    .start();
                        }
                    })
                    .start();
        }

    }

    public void getAnswerPrinted(int position, int imageBackgroundId, int answerImageId, String answer) {
        ImageView imageBackground = gridView.getChildAt(position).findViewById(R.id.wr_circle);
        ImageView imageAnswer = gridView.getChildAt(position).findViewById(R.id.answer_circle);
        TextView textAnswer = gridView.getChildAt(position).findViewById(R.id.text_answer);
        crossFading(imageBackground, imageAnswer, textAnswer, imageBackgroundId, answerImageId, answer);
    }
}