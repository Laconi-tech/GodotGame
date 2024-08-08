using Godot;
using System;

public partial class CursorSight : Node
{
	public override void _Ready()
	{
		var cursorSight = ResourceLoader.Load("res://cursor-sight128.png");
		Input.SetCustomMouseCursor(cursorSight);
	}
}
