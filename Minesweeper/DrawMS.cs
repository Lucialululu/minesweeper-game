using System.Numerics;
using Raylib_cs;

namespace Minesweeper;

public static class DrawMS {
    public static void Bomb(int x, int y, Texture2D bombTexture) {
    Raylib.DrawTexture(bombTexture, x, y, Color.White);
    }  

    public static void Number(string bombCount, int x, int y) {
        switch (bombCount) {
            case "0": 
                Raylib.DrawRectangle(x, y, MagicNumbers.CELL_WIDTH, MagicNumbers.CELL_HEIGHT, Color.White);
                break;
            case "1":
                Raylib.DrawText(bombCount, x + MagicNumbers.CELL_WIDTH / 3, y + MagicNumbers.CELL_HEIGHT / 3, 20, Color.Blue);
                break;
            case "2":
                Raylib.DrawText(bombCount, x + MagicNumbers.CELL_WIDTH / 3, y + MagicNumbers.CELL_HEIGHT / 3, 20, Color.Green);
                break;
            case "3":
                Raylib.DrawText(bombCount, x + MagicNumbers.CELL_WIDTH / 3, y + MagicNumbers.CELL_HEIGHT / 3, 20, Color.Red);
                break;
            case "4":
                Raylib.DrawText(bombCount, x + MagicNumbers.CELL_WIDTH / 3, y + MagicNumbers.CELL_HEIGHT / 3, 20, Color.DarkBlue);
                break;
            case "5":
                Raylib.DrawText(bombCount, x + MagicNumbers.CELL_WIDTH / 3, y + MagicNumbers.CELL_HEIGHT / 3, 20, Color.Maroon);
                break;
            case "6":
                Raylib.DrawText(bombCount, x + MagicNumbers.CELL_WIDTH / 3, y + MagicNumbers.CELL_HEIGHT / 3, 20, Color.Maroon);
                break; 
            case "7":
                Raylib.DrawText(bombCount, x + MagicNumbers.CELL_WIDTH / 3, y + MagicNumbers.CELL_HEIGHT / 3, 20, Color.Black);
                break;
            case "8":
                Raylib.DrawText(bombCount, x + MagicNumbers.CELL_WIDTH / 3, y + MagicNumbers.CELL_HEIGHT / 3, 20, Color.Gray);
                break;   
        }
        
    }
    public static void Flag(int x, int y, Texture2D flagTexture) {
        Raylib.DrawTexture(flagTexture, x, y, Color.White);
    }

    public static void Layer(int x, int y, int i, int j) {
        Color lightGreen = new Color(170, 215, 81, 255); // Light green
        Color darkGreen = new Color(162, 209, 73, 255); // Dark green

        Color cellColor = ((i + j) % 2 == 0) ? lightGreen : darkGreen;
        Raylib.DrawRectangle(x, y, MagicNumbers.CELL_WIDTH, MagicNumbers.CELL_WIDTH, cellColor);
    }

    public static void RevealedCell(int x, int y, int i, int j) {
    Color lightBrown = new Color(205, 133, 63, 255); // Light brown
    Color darkBrown = new Color(139, 69, 19, 255);   // Dark brown

    Color cellColor = ((i + j) % 2 == 0) ? lightBrown : darkBrown;
    Raylib.DrawRectangle(x, y, MagicNumbers.CELL_WIDTH, MagicNumbers.CELL_HEIGHT, cellColor);
    }

    public static void LoseBomb(int x, int y, Texture2D boomTexture) {
    Raylib.DrawTexture(boomTexture, x, y, Color.White);
    }
    public static void FalseFlag(int x, int y, Texture2D nobombTexture) {
    Raylib.DrawTexture(nobombTexture, x, y, Color.White);
    }
    public static void Reset(int width) {
        Raylib.DrawText("RESET", width*40, 0, 40, Color.Black);
    }
    public static void Win(int height) {
        Raylib.DrawText("YOU WIN!!!", 0, height * 40, 40, Color.Black);
    }
    public static void Time(string time) {
        Raylib.DrawText(time.ToUpper(), Raylib.GetScreenWidth() - 100, 50, 20, Color.Black);
    }
}