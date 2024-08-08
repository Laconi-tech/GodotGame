using Godot;
using System;

public partial class game_manager : Node
{	
	private int Points = 0;
	private Label PointsLabelInstance;
	
		public override void _Ready()
	{
		//game_manager = GetNode<Node>("%game_manager");
		PointsLabelInstance = GetNode<Label>("%PointsLabel");
		GD.Print(PointsLabelInstance);
	}
	
	public void _Add_Points()
	{
		Points += 1;
		PointsLabelInstance.Text = "Points : " + Points;
		GD.Print(Points);
		//GD.Print("oubaouba");
	}
}
