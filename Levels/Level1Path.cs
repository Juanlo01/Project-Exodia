using Godot;
using System;

public partial class Level1Path : PathFollow2D{

    // Speed our enemies will follow the path in
    public float runSpeed = 100f;

    public override void _Process(double delta){ // delta = The time since the last frame
        // Makes the enemies move along their given path
        Progress += runSpeed * (float)delta;

        // When the enemy gets to the end, it destroys itself.
        if (Loop == false && ProgressRatio == 1){
            QueueFree();
        }
    }
}
