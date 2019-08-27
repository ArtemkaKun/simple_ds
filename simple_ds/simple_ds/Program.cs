using System;

namespace simple_ds
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new simple_ds.Structures.NonOrientedGraph<string>();

            graph.AddNode("Artem");
            graph.AddNode("Anime");
            graph.AddEdge("Artem", "Anime");

            var node_neighbor = graph.PeekNeighbors(graph.PeekNode("Artem")).Count;
        }
    }
}
