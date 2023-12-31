﻿namespace VSON.Core.Svg
{

    public class SvgRectangle : SvgBaseElement
    {
        #region Constructors
        public SvgRectangle() { }

        public SvgRectangle(double x, double y, double width, double height, SvgStyle style, double xRadius = 0, double yRadius = 0) : this()        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Style = style;
            this.XRadius = xRadius;
            this.YRadius = yRadius;
        }

        public SvgRectangle(System.Drawing.RectangleF rectangle, SvgStyle style = null) : this()
        {
            this.X = rectangle.X;
            this.Y = rectangle.Y;
            this.Width = rectangle.Width;
            this.Height = rectangle.Height;
            this.Style = style;
        }
        #endregion Constructors

        #region Properties
        public double X { get; set; } = 0;

        public double Y { get; set; } = 0;

        public double Width { get; set; } = 100;
        
        public double Height { get; set; } = 100;

        public double XRadius { get; set; } = 0;

        public double YRadius { get; set; } = 0;
        #endregion Properties

        #region Methods
        public override string ToXML()
        {
            return
                $" <rect" +
                $" class=\"{this.Class}\"" +
                $" id=\"{this.Id}\"" +
                $" x=\"{this.X}\"" +
                $" y=\"{this.Y}\"" +
                $" rx=\"{this.XRadius}\"" +
                $" ry=\"{this.YRadius}\"" +
                $" width=\"{this.Width}\"" +
                $" height=\"{this.Height}\"" +
                $" style=\"{this.Style.ToXML()}\"" +
                $" />";
        }
        #endregion Methods
    }
}
