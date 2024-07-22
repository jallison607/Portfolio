//
//  About this code snippet
//    In my personal projects I have routinely encountered a question on how to programatically create a topographic map. In one of the attempts of the question I opted for creating a point, randomly finding n angles from that point, drawing lines at each angle, and creating a new point. 
//    Each generation had shorter lengths and checked against a max number of generations before continuing to generate. After generation, I wanted to see the pattern created so I used the following recursive function to dig down through the points, their children, and the children's children. 
//    Using Unity3D I plotted the final generation points, with no further children, as a spheres in the workspace.
//

public class TopoGenLeaf{

    //Draws a sphere for the passed point, Recursively checks each child point for additional points to draw
    //Parameters
    //  LeafGenPoint point : the passed LeafGenPoint
    private void DrawLeafGenPoints(LeafGenPoint point)
    {
        //Draw the LeafGenPoint
        
        if(point.GetChildren().Count == 0)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = point.GetLocation();
            sphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            point.SetAsEdge();
        }
    
        //Draw the children of the LeafGenPoint
        foreach (LeafGenPoint child in point.GetChildren())
        {
            DrawLeafGenPoints(child);
        }
    }
  
}
