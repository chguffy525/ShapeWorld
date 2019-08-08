namespace ShapeWorld.Domain.Models
{
  public class Cube : Square
  {
    private double EdgeLength;
      public override double Length
       {
         get
       {
        return EdgeLength;
       } 
       set
       {
        EdgeLength = value;
       }
       }

      public override double Width
       {
         get
       {
        return EdgeLength;
       } 
       set
       {
        EdgeLength = value;
       }
       }
       public override double Depth
       {
         get
         {
           return EdgeLength;
         }
         set
         {
           EdgeLength = value;
         }
       }
       public new double Surface()
       {
        return Length * Width * Depth;
       }

  }
}