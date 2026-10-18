using Godot;

public partial class Main : Control
{
	private Label _label;

	public override void _Ready()
	{
		_label = GetNode<Label>("Label");
		_label.Text = "Cyonna siap!";
		GD.Print("Main ready");
	}
}
