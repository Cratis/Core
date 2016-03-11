using Machine.Specifications;

namespace Cratis.Core.Specifications.Specifications.given
{
    public class rules_and_coloured_shapes : coloured_shapes
    {
        protected static Specification<ColoredShape> red;
        protected static Specification<ColoredShape> blue;
        protected static Specification<ColoredShape> green;
        protected static Specification<ColoredShape> yellow;
        protected static Specification<ColoredShape> circles;
        protected static Specification<ColoredShape> squares;
        protected static Specification<ColoredShape> triangles;
        protected static Specification<ColoredShape> pentagons;

        Establish context = () =>
            {
                red = new ColourRule("Red");
                blue = new ColourRule("Blue");
                green = new ColourRule("Green");
                yellow = new ColourRule("Yellow");
                circles = new ShapeRule("Circle");
                squares = new ShapeRule("Square");
                triangles = new ShapeRule("Triangle");
                pentagons = new ShapeRule("Pentagon");
            };
    }

    public class ColourRule : Specification<ColoredShape>
    {
        readonly string _colour;

        public ColourRule(string matchingColour)
        {
            _colour = matchingColour;
            Predicate = shape => shape.Colour == _colour;
        }
    }

    public class ShapeRule : Specification<ColoredShape>
    {
        readonly string _shape;

        public ShapeRule(string matchingShape)
        {
            _shape = matchingShape;
            Predicate = shape => shape.Shape == _shape;
        }
    }
}