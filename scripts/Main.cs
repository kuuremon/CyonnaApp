using Godot;

public partial class Main : Control
{
	[Export] private Label _contentLabel;
	[Export] private Button _mindmapButton;
	[Export] private Button _scheduleButton;
	[Export] private Button _tasksButton;
	[Export] private Button _flashcardsButton;

	public override void _Ready()
	{
		_mindmapButton.Pressed += () => ShowPage("Mindmap");
		_scheduleButton.Pressed += () => ShowPage("Schedule");
		_tasksButton.Pressed += () => ShowPage("Tasks");
		_flashcardsButton.Pressed += () => ShowPage("Flashcards");

		ShowPage("Mindmap");
	}

	private void ShowPage(string pageName)
	{
		_contentLabel.Text = $"Halaman: {pageName}";
	}
}
