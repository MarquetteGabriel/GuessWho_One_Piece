/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.LoadingScreen;

import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;

import androidx.appcompat.app.AppCompatActivity;
import androidx.navigation.NavController;
import androidx.navigation.fragment.NavHostFragment;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import fr.gmarquette.guesswho.R;

public class MainActivity extends AppCompatActivity {

    NavController navController;
    NavHostFragment navHostFragment;
    int currentFragmentId, backFragmentId;

    private Animation fromBottom, toBottom, openMenu, closeMenu;
    private FloatingActionButton fab_menu, fab_list, fab_settings, fab_help;
    private boolean clicked;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        fab_menu = findViewById(R.id.menubtn);
        fab_list = findViewById(R.id.listbtn);
        fab_settings = findViewById(R.id.settingsbtn);
        fab_help = findViewById(R.id.helpbtn);

        fromBottom = AnimationUtils.loadAnimation(this, R.anim.from_botton_anim);
        toBottom = AnimationUtils.loadAnimation(this, R.anim.to_bottom_anim);
        openMenu = AnimationUtils.loadAnimation(this, R.anim.rotate_open);
        closeMenu = AnimationUtils.loadAnimation(this, R.anim.rotate_close);

        fab_menu.setOnClickListener(view -> onMenuButtonClicked());
        fab_list.setOnClickListener(view -> onListButtonClicked());
        fab_settings.setOnClickListener(view -> onSettingsClicked());
        fab_help.setOnClickListener(view -> onHelpClicked());

        navHostFragment = (NavHostFragment) getSupportFragmentManager().findFragmentById(R.id.fragmentContainerView5);
        assert navHostFragment != null;
        navController = navHostFragment.getNavController();

        navController.addOnDestinationChangedListener((controller, destination, arguments) -> {
            currentFragmentId = destination.getId();

            if(destination.getId() == R.id.gameScreenFragment || destination.getId() == R.id.gameSelectionScreenFragment)
            {
                backFragmentId = destination.getId();
            }

            if (destination.getId() == R.id.loadingScreenFragment) {
                fab_menu.setVisibility(View.INVISIBLE);
                fab_menu.setClickable(false);
            } else {
                fab_menu.setVisibility(View.VISIBLE);
                fab_menu.setClickable(true);
            }
        });
    }

    private void onSettingsClicked() {
        onMenuButtonClicked();
        navController.navigate(R.id.settingsFragment);
    }

    private void onListButtonClicked()
    {
        onMenuButtonClicked();
        navController.navigate(R.id.listOfCharactersFragment);
    }

    private void onHelpClicked()
    {
        onMenuButtonClicked();
        navController.navigate(R.id.helpFragment);
    }

    private void onMenuButtonClicked()
    {
        setVisibility(clicked);
        setAnimation(clicked);
        setClickable(clicked);
        clicked = !clicked;
    }

    private void setAnimation(boolean clicked)
    {
        if(!clicked)
        {
            fab_menu.setAnimation(openMenu);
            fab_list.startAnimation(fromBottom);
            fab_settings.startAnimation(fromBottom);
            fab_help.setAnimation(fromBottom);
        }
        else
        {
            fab_menu.startAnimation(closeMenu);
            fab_list.startAnimation(toBottom);
            fab_settings.startAnimation(toBottom);
            fab_help.setAnimation(toBottom);
        }
    }

    private void setVisibility(boolean clicked)
    {
        if(!clicked)
        {
            fab_list.setVisibility(View.VISIBLE);
            fab_settings.setVisibility(View.VISIBLE);
            fab_help.setVisibility(View.VISIBLE);
        }
        else
        {
            fab_list.setVisibility(View.INVISIBLE);
            fab_settings.setVisibility(View.INVISIBLE);
            fab_help.setVisibility(View.VISIBLE);
        }
    }

    private void setClickable(boolean clicked)
    {
        if(clicked)
        {
            fab_list.setClickable(false);
            fab_settings.setClickable(false);
            fab_help.setClickable(false);
        }
        else
        {
            fab_list.setClickable(true);
            fab_settings.setClickable(true);
            fab_help.setClickable(true);
        }
    }

    @Override
    public void onBackPressed() {
        if (navHostFragment != null) {

            if (navHostFragment.getChildFragmentManager().getBackStackEntryCount() == 1) {
                finish();
            }

            if (currentFragmentId == R.id.gameScreenFragment) {
                navHostFragment.getNavController().popBackStack(R.id.gameSelectionScreenFragment, false);
            }

            if (currentFragmentId == R.id.helpFragment || currentFragmentId == R.id.settingsFragment || currentFragmentId == R.id.listOfCharactersFragment) {
                if (backFragmentId == R.id.gameScreenFragment) {
                    navHostFragment.getNavController().popBackStack(R.id.gameScreenFragment, false);
                }
                else {
                    navHostFragment.getNavController().popBackStack(R.id.gameSelectionScreenFragment, false);
                }
            }
        }
        else
        {
            super.onBackPressed();
        }
    }
}