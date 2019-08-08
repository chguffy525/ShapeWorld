namespace ShapeWorld.Domain.Models
{
  public class Triangle : Shape
  {
   public virtual double Length {get; set;}
    public virtual double Width {get; set;}
    public override double Surface()
    {
      return (Length * Width) * .5;

    }
    public Triangle() : base(3)
    {
      
    }
  }
}