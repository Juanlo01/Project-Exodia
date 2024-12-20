using Godot;
using System;

public partial class GameManager : Node{

    private bool _gamePaused = false;

    // Define the signal as an event
    [Signal]
    public delegate void ToggleGamePausedEventHandler(bool isPaused);

    


    public bool GamePaused{

        get => _gamePaused;

        set{
            _gamePaused = value;
            GetTree().Paused = _gamePaused;
            EmitSignal("ToggleGamePaused", _gamePaused);
        }

    }

    public override void _Input(InputEvent @event){
        if (@event.IsActionPressed("pause")){
            GamePaused = !_gamePaused;
        }
    }

    
}
