using Godot;
using System;

public partial class PathSpawner : Path2D{

    public float timer = 0f;

    [Export]
    public float spawnTime = 5f;
    
    private PackedScene _follower = GD.Load<PackedScene>("res://place_holder-level_1_path.tscn");

    public override void _Process(double delta){
        timer += (float)delta;

        if (timer > spawnTime){
            Node instance = _follower.Instantiate();
            AddChild(instance);
            timer = 0;
        }
    }
}
