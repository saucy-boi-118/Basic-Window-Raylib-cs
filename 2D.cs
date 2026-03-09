using System;
using Raylib_cs;
using System.Numerics;

class Program
{
public static void Main()
        {
            // initialize
            const int WINSIZE = 500;

            Raylib.InitWindow(WINSIZE, WINSIZE, "Basic 2D");

            Raylib.SetTargetFPS(60);

            Vector2 circPos = new(250, 250);

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();


                Raylib.ClearBackground(Color.RayWhite);

                Raylib.DrawCircleV(circPos, 15, Color.Beige);

                Raylib.DrawText("Hello World!", 200, 250, 25, Color.Black);


                Raylib.EndDrawing();
            }

            // Unloading
            Raylib.CloseWindow();
        }        
}

