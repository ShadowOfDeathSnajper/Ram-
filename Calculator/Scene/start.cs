using Godot;
using System;

public partial class start : Node2D
{
	private void _on_pressed()
{

	GetTree().ChangeSceneToFile("res://Scene/calculator.tscn")
}
}
