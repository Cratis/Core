using System.Linq;
using Machine.Specifications;

namespace Cratis.Core.Specifications.Specifications.given
{
    public class coloured_shapes
    {
        protected static IQueryable<ColoredShape> my_coloured_shapes;
        protected static string[] colours;
        protected static string[] shapes;

        protected static ColoredShape red_square = new ColoredShape(){ Colour = "Red", Shape = "Square"};
        protected static ColoredShape red_circle = new ColoredShape(){ Colour = "Red", Shape = "Circle"};
        protected static ColoredShape green_circle = new ColoredShape(){ Colour = "Green", Shape = "Circle"};
        protected static ColoredShape green_square = new ColoredShape(){ Colour = "Green", Shape = "Square"};

        Establish context = () =>
            {
                colours = new string[] {"Red","Blue","Green","Yellow"};
                shapes = new string[]{"Square","Circle","Triangle","Pentagon"};

                my_coloured_shapes = BuildColouredShapes();
            };

        static IQueryable<ColoredShape> BuildColouredShapes()
        {
           return (from colour in colours
                    from shape in shapes
                    select new ColoredShape { Colour = colour, Shape = shape }).AsQueryable();
        }
    }
}