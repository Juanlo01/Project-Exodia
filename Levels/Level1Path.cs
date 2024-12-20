using Godot;
using System;

public partial class Level1Path : PathFollow2D{

    public float speed = 100f;

    public override void _Process(double delta){
        Progress += speed * (float)delta;
    }
}
