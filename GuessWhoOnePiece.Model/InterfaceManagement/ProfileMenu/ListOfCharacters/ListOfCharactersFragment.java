/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.ProfileMenu.ListOfCharacters;

import android.app.Dialog;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.lifecycle.ViewModelProvider;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.google.android.material.bottomsheet.BottomSheetBehavior;
import com.google.android.material.bottomsheet.BottomSheetDialog;
import com.google.android.material.bottomsheet.BottomSheetDialogFragment;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import fr.gmarquette.guesswho.GameData.Database.Characters;
import fr.gmarquette.guesswho.GameData.Database.DataBase;
import fr.gmarquette.guesswho.InterfaceManagement.MainActivityViewModel;
import fr.gmarquette.guesswho.R;

public class ListOfCharactersFragment extends BottomSheetDialogFragment implements ListOfCharacterInterface{

    private MainActivityViewModel itemViewModel;
    private ListFragmentAdapter adapter;
    private final ExecutorService executorService = Executors.newSingleThreadExecutor();

    public ListOfCharactersFragment() {
    }
    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState)
    {
        BottomSheetDialog dialog = (BottomSheetDialog) super.onCreateDialog(savedInstanceState);
        View view = View.inflate(requireContext(), R.layout.fragment_list_of_characters, null);
        dialog.setContentView(view);

        BottomSheetBehavior<View> bottomSheetBehavior = BottomSheetBehavior.from((View) view.getParent());
        bottomSheetBehavior.setState(BottomSheetBehavior.STATE_EXPANDED);
        bottomSheetBehavior.setDraggable(false);
        return dialog;
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_list_of_characters, container, false);
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
        RecyclerView recyclerView = view.findViewById(R.id.listCharacter);
        recyclerView.setLayoutManager(new LinearLayoutManager(getContext()));
        recyclerView.setHasFixedSize(true);
        EditText editText = view.findViewById(R.id.filterCharacter);
        editText.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {}

            @Override
            public void afterTextChanged(Editable editable) {
                filter(editable.toString());
            }
        });

        itemViewModel = new ViewModelProvider(requireActivity()).get(MainActivityViewModel.class);

        adapter = new ListFragmentAdapter(getContext(),
                itemViewModel.getCharacterNameList().getValue(),
                itemViewModel.getCharacterPicturesList().getValue(), this, itemViewModel);
        recyclerView.setAdapter(adapter);
        adapter.notifyDataSetChanged();
    }

    @Override
    public void onItemClick(int positon) {

        executorService.submit(() -> {
            String characters = itemViewModel.getCharacterNameList().getValue().get(positon);
            Characters character = DataBase.getInstance(requireContext()).dao().getCharacterFromName(characters);
            itemViewModel.setCharacterInfo(character);

            requireActivity().runOnUiThread(() -> {
                NavController navController = Navigation.findNavController(requireActivity(), R.id.fragmentContainerView5);
                navController.navigate(R.id.action_listOfCharactersFragment_to_characterDatasFragment);
            });
        });
    }

    private void filter(String text)
    {
        List<String> filteredListName = new ArrayList<>();
        List<String> filteredListPicture = new ArrayList<>();
        for (String character : itemViewModel.getCharacterNameList().getValue())
        {
            if(character.toLowerCase().contains(text.toLowerCase()))
            {
                filteredListName.add(character);
                int position = itemViewModel.getCharacterNameList().getValue().indexOf(character);
                filteredListPicture.add(itemViewModel.getCharacterPicturesList().getValue().get(position));
            }
        }

        adapter.filterList(filteredListName, filteredListPicture);
    }
}