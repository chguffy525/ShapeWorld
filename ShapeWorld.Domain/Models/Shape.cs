namespace ShapeWorld.Domain.Models
{
  public abstract class Shape //abstract means you cannot have an instance of shape, but something can BE a shape
  {  
    //Fields
    

    //Properties
    public int NumberOfEdges   {get;private set;}
    //Methods  
    public abstract double Surface();
    public double Volume()
    {
      return 0;
    }
    public virtual double Perimeter()
    {
      return 0; 
    }
    //controllers
    public Shape(int edge)
    {
      NumberOfEdges = edge;
    } 
        
  }
    
}