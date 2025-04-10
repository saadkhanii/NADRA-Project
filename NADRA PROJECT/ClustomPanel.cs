using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NADRA_PROJECT
{
    public class CustomPanel : Panel
    {
        public int CornerRadius { get; set; } = 20;

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);

            // Define the rectangle dimensions
            Rect rect = new Rect(0, 0, this.ActualWidth, this.ActualHeight);

            // Create a rounded rectangle geometry
            var roundedRect = new RectangleGeometry(rect, CornerRadius, CornerRadius);

            // Fill background with gradient
            var gradientBrush = new LinearGradientBrush(
                Colors.WhiteSmoke,
                Color.FromRgb(0, 152, 70),  // Green color
                new Point(0.5, 0),
                new Point(0.5, 1)           // Vertical gradient
            );

            dc.DrawGeometry(gradientBrush, new Pen(Brushes.Black, 2), roundedRect);
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            foreach (UIElement child in InternalChildren)
            {
                // Measure each child
                child.Measure(availableSize);
            }

            return availableSize; // Return available size for this panel
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            foreach (UIElement child in InternalChildren)
            {
                // Arrange each child to fit within the panel
                child.Arrange(new Rect(new Point(0, 0), finalSize));
            }

            return finalSize; // Return the final size of the panel
        }
    }
}
