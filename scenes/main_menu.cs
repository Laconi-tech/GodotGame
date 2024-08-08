using Godot;
using System;

public partial class main_menu : Node
{
	private void _on_level_1_pressed(){
		GetTree().ChangeSceneToFile("res://scenes/level1.tscn");
	}


	private void _on_level_2_pressed(){
		GetTree().ChangeSceneToFile("res://scenes/level2.tscn");
	}
}
