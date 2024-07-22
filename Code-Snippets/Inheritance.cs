
//
//  About this code snippet
//    In my personal projects I have routinely encountered a question on how to programatically create a topographic map. In one of the attempts of the question I opted for creating a point, randomly finding n angles from that point, drawing lines at each angle, and creating a new point. 
//    Each generation had shorter lengths and checked against a max number of generations before continuing to generate. To attempt the new approach I reused the TopoPoint class I had previously created.
//    I extended TopoPoint to LeafGenPoint so that in addition to the location Vector3, direction Vector3, and the functions associated with TopoPoint (not displayed in this snippet), I could add a list of children points and a generation variable to identify what generation the point belonged to.
//


public class TopoPoint
{
    //Vector3 location: A location in 3d space of the TopoPoint
    private Vector3 location;
    //Vector3 direction: A direction the TopoPoint is "pointing". This is used when performing a walk in that direction of a random distance.
    private Vector3 direction;

    //TopoPoint constructor
    public TopoPoint(Vector3 location, Vector3 direction)
    {
        this.location = location;
        this.direction = direction;
    }
}

public class LeafGenPoint : TopoPoint
{
    //List<LeafGenPoint> ChildPoints: A list of points that are children of this LeafGenPoint. 
    private List<LeafGenPoint> ChildPoints;
    //int generation: An int used to track how many generations deep this LeafGenPoint is. This is used to help identify parents, grandparents, uncles/aunts, and cousins
    private int generation;

        public LeafGenPoint(Vector3 location, Vector3 direction, int gen) : base(location, direction)
    {
        ChildPoints = new List<TopoPoint>();
        generation = gen;
    }

}
