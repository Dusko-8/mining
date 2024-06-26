﻿using Mining;

class Program
{
    static void Main(string[] args)
    {
        // Set the console window settings
        ConsoleWindowSettings.ApplySettings(121, 30);
        

        Menu menu = new Menu();
        menu.generateMenu();

        ClearConsole();

        Player player = new Player();
        Map map = new Map(5, player);
        GameLogic gameLogic = new GameLogic();

        gameLogic.map = map.map;
        gameLogic.mapobj = map;

        while (true)
        {
            gameLogic.check_for_movement(player);
        }
        

        // Your application logic here
        Console.ReadLine(); // Keep the console window open
    }

    static void ClearConsole()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
    }
}