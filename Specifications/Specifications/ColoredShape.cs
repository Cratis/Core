namespace Cratis.Core.Specifications.Specifications
{

    public class ColoredShape
    {
        public string Shape { get; set; }
        public string Colour { get; set; }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Shape, Colour);
        }
    }
}
