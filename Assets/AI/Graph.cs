using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public List<GraphNode> nodes;

    public Graph()
    {
        nodes = new List<GraphNode>();
    }

    public void AddNode(Vector2 position)
    {
        nodes.Add(new GraphNode(position));
    }

    public void AddEdge(int nodeIndex1, int nodeIndex2)
    {
        if (nodeIndex1 >= 0 && nodeIndex1 < nodes.Count && nodeIndex2 >= 0 && nodeIndex2 < nodes.Count)
        {
            GraphNode node1 = nodes[nodeIndex1];
            GraphNode node2 = nodes[nodeIndex2];

            node1.neighbors.Add(node2);
            node2.neighbors.Add(node1);
        }
    }
}
