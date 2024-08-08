using Godot;
using System;

public partial class collectable : Area2D
{
	//private Node game_manager;
	private game_manager gameManagerInstance;
	
	public override void _Ready()
	{
		//game_manager = GetNode<Node>("%game_manager");
		gameManagerInstance = GetNode<game_manager>("%GameManager");
		//GD.Print(gameManagerInstance);
	}
	
	private void _on_body_entered(Node2D body)
	{
		if(body.Name == "CharacterBody2D"){
			QueueFree();
			//game_manager._Add_Points();
			gameManagerInstance._Add_Points();
		}
	}
}
