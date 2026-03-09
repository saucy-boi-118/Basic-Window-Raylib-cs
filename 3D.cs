using System;
using Raylib_cs;
using System.Numerics;

namespace Trucle_3D
{
    class Program
    {
        public static void Main()
        {
            // initialize
            const int WINHEIGHT = 512;
            const int WINWIDTH = 1024;

            Raylib.InitWindow(WINWIDTH, WINHEIGHT, "Basic 3D");
            
            // camera
            Camera3D camera = new()
            {
                Position = new Vector3(0f, 10f, 10f),
                Target = new Vector3(0.0f, 0.0f, 0.0f),
                Up = new Vector3(0.0f, 1.0f, 0.0f),
                FovY = 45.0f,
                Projection = CameraProjection.Perspective

            };

            // run at 60 FPS
            Raylib.SetTargetFPS(60);
            

            Vector3 cubePos = new(0f, 0f, 0f);
  

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                
                Raylib.BeginMode3D(camera);

 

                Raylib.DrawCubeV(cubePos, new(10f, 10f, 10f), Color.Red);


                

                Raylib.EndMode3D();
                
                Raylib.EndDrawing();
            }

            // Unloading
            Raylib.CloseWindow();
        }
    }
}
