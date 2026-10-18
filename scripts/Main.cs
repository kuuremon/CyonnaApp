using Godot;

public partial class Main : Control
{
	[Export] private Label _label;
	[Export] private Button _button;

	private int _count = 0;

	public override void _Ready()
	{
		_button.Pressed += OnButtonPressed;
	}

	private void OnButtonPressed()
	{
		_count++;
		_label.Text = $"Klik: {_count}";
	}
}
