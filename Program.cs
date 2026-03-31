using System;
using Raylib_cs;
using System.Numerics;


namespace AlignG
{
    class Program()
    {
        public static void Main()
        {
            // INIT GAME---->
            Raylib.InitWindow(1000, 500, "3D Shooter");

            //CAMERA
            Camera3D camera = new()
            {
                Position = new Vector3(0.0f, 0.0f, 25.0f), // position
                Target = new Vector3(0.0f, 0.0f, 0.0f), // where its points
                Up = new Vector3(0.0f, 10.0f, 0.0f), // got no clue
                FovY = 60.0f, // field of view
                Projection = CameraProjection.Perspective // first person, third person, etc

            };

            // better visibility, esc to leave
            Raylib.DisableCursor();

            //Target FPS
            Raylib.SetTargetFPS(60);

            // GAME VARIABLES ----->

            // move the player (camera, and bounding box)
            Vector3 playerPos = new(0.0f, 0.0f, 0.0f);
            Vector3 rotationV = new(0.0f,0.0f,0.0f);
            Vector3 movementV = new(0.0f,0.0f,0.0f);
            float movementS = 7.5f;
            float mouseSens = 0.01f;

            while(Raylib.WindowShouldClose() == false)
            {
                // WASD controls ----->
                
                //Reset movement vector
                movementV = new(0.0f, 0.0f, 0.0f);
                
                //divide by smaller number to go faster
                if (Raylib.IsKeyDown(KeyboardKey.W)) movementV.X += movementS/4;
                if (Raylib.IsKeyDown(KeyboardKey.D)) movementV.Y += movementS/4;
                
                // negative for reverse movement
                if (Raylib.IsKeyDown(KeyboardKey.S)) movementV.X += -movementS/4;
                if (Raylib.IsKeyDown(KeyboardKey.A)) movementV.Y += -movementS/4;


                // rotation on mouse, divided by a number to reduce sensitivity
                rotationV.X = (Raylib.GetMouseDelta().X * mouseSens);
                rotationV.Y = (Raylib.GetMouseDelta().Y * mouseSens);
                    
                
                //Updating camera FOR MOVEMENT
                Raylib.UpdateCamera(ref camera, CameraMode.FirstPerson);
                Raylib.UpdateCameraPro( ref camera, movementV, rotationV, 0.0f);


                // Begin Drawing ...>
                Raylib.BeginDrawing();
                

                // draw background
                Raylib.ClearBackground(Color.White);

                // camera mode
                Raylib.BeginMode3D(camera);

           

                Raylib.EndMode3D();

                // End Drawing ...>
                Raylib.EndDrawing();
            }



            // Unload Stuff --->
            Raylib.CloseWindow();

            }

        }   
}