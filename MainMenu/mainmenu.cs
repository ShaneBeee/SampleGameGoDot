using Godot;

namespace Sample.MainMenu;

public partial class mainmenu : Control {

    // Called when the node enters the scene tree for the first time.
    public override void _Ready() {
        GD.Print("READY!!!");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta) {
    }

    public void OnQuitButtonPressed() {
        GD.Print("Quitting!!!");
        GetTree().Quit();
    }

    public void OnPlayButtonPressed() {
        GD.Print("Play button pressed");
    }

}