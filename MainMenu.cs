using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// This script manages the main menu of the game, including navigation to game levels,
// displaying instructions, and adjusting game settings like volume.

public class MainMenu : MonoBehaviour
{
    public GameObject settingsPanel;        // Reference to the settings panel in the menu
    public GameObject instructionsPanel;    // Reference to the instructions panel in the menu
    public Slider volumeSlider;             // Reference to the slider for controlling game volume

    // Initialize the main menu by setting initial volume and hiding panels
    void Start()
    {
        // Set the initial slider value to the current game volume
        volumeSlider.value = AudioListener.volume;

        // Attach the volume control function to the slider's value change event
        volumeSlider.onValueChanged.AddListener(SetVolume);

        // Hide settings and instructions panels by default
        settingsPanel.SetActive(false);
        instructionsPanel.SetActive(false);
    }

    // Load the first level of the game when "Play Game" is selected
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_1");  // Load the scene named "Level_1"
    }

    // Show the instructions panel when "Instructions" is selected
    public void ShowInstructions()
    {
        instructionsPanel.SetActive(true);  // Display the instructions panel
    }

    // Hide the instructions panel when "Back" is selected in the instructions panel
    public void HideInstructions()
    {
        instructionsPanel.SetActive(false); // Hide the instructions panel
    }

    // Show the settings panel when "Settings" is selected
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);      // Display the settings panel
    }

    // Hide the settings panel when "Back" is selected in the settings panel
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);     // Hide the settings panel
    }

    // Adjust the game volume based on the slider's current value
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;      // Set the game's master volume
    }

    public void ExitGame()
    {
        Application.Quit();            // Close the application (works in the built game only)
    }
}
