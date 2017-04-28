﻿using UnityEngine;
using System.Collections;

public class ShowPanels : MonoBehaviour {

	public GameObject optionsPanel;							//Store a reference to the Game Object OptionsPanel 
	public GameObject optionsTint;							//Store a reference to the Game Object OptionsTint 
	public GameObject menuPanel;							//Store a reference to the Game Object MenuPanel 
	public GameObject pausePanel;							//Store a reference to the Game Object PausePanel
	public GameObject playerPanel;							//Store a reference to the Game Object PlayerPanel 
	public GameObject playerTint;							//Store a reference to the Game Object PlayerTint
	public GameObject joystickCanvas;
	public GameObject joyStat;
	public GameObject playCanvas;
	public GameObject charPanel;
	public GameObject buttonCanvas;


	//Call this function to activate and display the Options panel during the main menu
	public void ShowOptionsPanel()
	{
		optionsPanel.SetActive(true);
		optionsTint.SetActive(true);
		//joystickCanvas.SetActive (false);
	}

	//Call this function to deactivate and hide the Options panel during the main menu
	public void HideOptionsPanel()
	{
		optionsPanel.SetActive(false);
		optionsTint.SetActive(false);
		//if(joyStat.activeInHierarchy == true)
			//joystickCanvas.SetActive (true);
		//else if(joyStat.activeInHierarchy == true)
			//joystickCanvas.SetActive (true);
	}

	//Call this function to activate and display the main menu panel during the main menu
	public void ShowMenu()
	{
		menuPanel.SetActive (true);
	}

	//Call this function to deactivate and hide the main menu panel during the main menu
	public void HideMenu()
	{
		menuPanel.SetActive (false);

		/*
		optionsPanel.SetActive(false);
		optionsTint.SetActive(false);
		playerPanel.SetActive(true);
		playerTint.SetActive(true);
		*/
	}
	
	//Call this function to activate and display the Pause panel during game play
	public void ShowPausePanel()
	{
		pausePanel.SetActive (true);
		optionsTint.SetActive(true);
	}

	//Call this function to deactivate and hide the Pause panel during game play
	public void HidePausePanel()
	{
		pausePanel.SetActive (false);
		optionsTint.SetActive(false);

	}

	//Call this function to activate and display the Settings panel
	public void ShowPlayerPanel()
	{
		playerPanel.SetActive(true);
		playerTint.SetActive(true);
		//joystickCanvas.SetActive (false);
	}

	//Call this function to deactivate and hide the Settings panel
	public void HidePlayerPanel()
	{
		playerPanel.SetActive(false);
		playerTint.SetActive(false);
		//if(joyStat.activeInHierarchy == false)
			//joystickCanvas.SetActive (false);
		//else if(joyStat.activeInHierarchy == true)
			//joystickCanvas.SetActive (true);
	}

	public void HidePlayCanvas()
	{
		playCanvas.SetActive (false);
	}

	public void ShowPlayCanvas()
	{
		playCanvas.SetActive (true);
	}

	public void HideCharPanel()
	{
		charPanel.SetActive (false);
	}

	public void ShowButtonCanvas()
	{
		buttonCanvas.SetActive (true);
	}

	public void HideButtonCanvas()
	{
		buttonCanvas.SetActive (false);
	}

}
