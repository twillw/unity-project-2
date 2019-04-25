using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    int level;
    enum Screen { MainMenu, Password, Win }
    Screen currentScreen = Screen.MainMenu;

    string easyPassword = "table";
    string hardPassword = "headphones";

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            RunPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Invalid level");
        }
    }

    void RunPassword(string input)
    {
        if (level == 1)
        {
            if (input == easyPassword)
            {
                // TODO: go to win screen
                Terminal.WriteLine("You're in!");
            }
            else 
            {
                Terminal.WriteLine("Incorrent password");
            }
        }
        else if (level == 2)
        {
            if (input == hardPassword)
            {
                // TODO: go to win screen
                Terminal.WriteLine("You're in!");
            }
            else
            {
                Terminal.WriteLine("Incorrect password");
            }
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
