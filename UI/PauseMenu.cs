using Godot;
using System;

public partial class PauseMenu : Control{

    [Export]
    public GameManager GameManager { get; set; }

    // Engine calls when the node is "ready", i.e.
    // When both the node and its children have entered the scene tree
    public override void _Ready(){
        // Hide() will make the node invisible and stop it from processing
        Hide();
        GameManager.Connect("ToggleGamePaused", new Callable(this, nameof(OnGameManagerToggleGamePaused)));
    }

    // Engine calls this method every time it draws a frame
    public override void _Process(double delta){
        // Do nothing, pass
    }

    private void OnGameManagerToggleGamePaused(bool IsPaused){
        if (IsPaused){
            Show();
        } else{
            Hide();
        }

    }

    public void OnResumeButtonPressed(){
        GameManager.GamePaused = false;
    }

    public void OnExitButtonPressed(){
        GetTree().Quit();
    }
}
