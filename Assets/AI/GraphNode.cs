using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNode : MonoBehaviour
{
    public Vector2 position;
    public List<GraphNode> neighbors;

    public GraphNode(Vector2 position)
    {
        this.position = position;
        neighbors = new List<GraphNode>();
    }
}
