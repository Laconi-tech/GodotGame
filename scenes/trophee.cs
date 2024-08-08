using Godot;
using System;

public partial class trophee : Area2D
{
	[Export]
	private NodePath target_level;
	
	private void _on_body_entered(Node2D body)
	{
		if(body.Name == "CharacterBody2D"){
			PackedScene newScene = (PackedScene)ResourceLoader.Load(target_level);
			GetTree().ChangeSceneToPacked(newScene);
			//GetTree().ChangeSceneToFile("res://scenes/level2.tscn");
		}
	}
}
