namespace ShapeWorld.Domain.Models
{
  
  public class Square : Rectangle
    {
      private double EdgeLength;
      public virtual double Depth
      {
        get {
         return 0; 
        }
        set {

        }
        
      }
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
      
     public override double Perimeter()
     {
    return 4 * Length; 
     }  
    }
}