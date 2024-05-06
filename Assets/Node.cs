using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Node : MonoBehaviour
{
    //list containing all of this node's neighbours
    public List<Node> neighbours = new List<Node>();

    //node variable indicating the 'parent' for this node when forming a path
    public Node parent;  

}
