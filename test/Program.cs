using System.Runtime.ConstrainedExecution;
using System;
using Raylib_cs;
using System.Numerics;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1000, 1000, "Opperation Window");
            Raylib.SetTargetFPS(60);



            //#######################################

                    Rectangle rect = new Rectangle();
                    Vector2 vector = new Vector2();
                    rect.width = 300;
                    rect.height = 500;

                    vector.X = vector.Y = 0;

                    rect.x = rect.y = 500;

                    System.Console.WriteLine(rect.x);
                    float t = 0;
            
            while (!Raylib.WindowShouldClose())
                {
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.BLACK);

                    if(t < 360)
                    {
                        t++;
                    }
                    else
                    {
                        t = 0;
                    }

                    Raylib.DrawRectanglePro(rect, vector, t, Color.WHITE);
                    
                    Raylib.EndDrawing();
                }
        }
    }
}
