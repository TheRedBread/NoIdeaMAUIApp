namespace NoIdeaMAUIApp.Controls;

public class GridBackground : GraphicsView
{
    public GridBackground()
    {
        Drawable = new GridDrawable();
        InputTransparent = true;
    }

    private class GridDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Color.FromArgb("#E7E9E2");
            canvas.StrokeSize = 1;

            const float spacing = 16;

            for (float x = 0; x <= dirtyRect.Width; x += spacing)
            {
                canvas.DrawLine(x, 0, x, dirtyRect.Height);
            }
            for (float y = 0; y <= dirtyRect.Height; y += spacing)
            {
                canvas.DrawLine(0, y, dirtyRect.Width, y);
            }
        }
    }
}
