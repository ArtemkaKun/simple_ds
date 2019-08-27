using System;
using System.Collections.Generic;

namespace simple_ds.Structures
{
    public class NonOrientedGraph<T>
    {
        private int size_of_graph;
        private readonly List<GraphNode<T>>graph_data;

        public NonOrientedGraph()
        {
            size_of_graph = 0;
            graph_data = new List<GraphNode<T>>();
        }

        public int Size()
        {
            return size_of_graph;
        }

        public bool IsEmpty()
        {
            if (Size() == 0)
            {
                return true;
            }

            return false;
        }

        public void AddNode(T node_value)
        {
            ++size_of_graph;
            graph_data.Add(new GraphNode<T>(node_value));
        }

        public void AddEdge(T node_value, T neighbor_node_value)
        {
            if (PeekNode(node_value) != null && PeekNode(neighbor_node_value) != null)
            {
                var one_node = PeekNode(node_value);
                var other_node = PeekNode(neighbor_node_value);

                one_node.AddNeighbor(other_node);
                other_node.AddNeighbor(one_node);
            }
        }

        public List<GraphNode<T>> PeekNeighbors(GraphNode<T> node)
        {
            return node.GetNodeNeighbors();
        }

        public GraphNode<T> PeekNode(T node_value)
        {
            if (!IsEmpty())
            {
                for (var one_node = 0; one_node < size_of_graph; ++one_node)
                {
                    if (graph_data[one_node].GetNodeData().ToString() == node_value.ToString())
                    {
                        return graph_data[one_node];
                    }
                }
            }
            else
            {
                throw new Exception("Cannot peek node. Graph is empty!");
            }

            return null;
        }

        public void RemoveNode(T node_value)
        {
            for (var one_node = 0; one_node < size_of_graph; ++one_node)
            {
                if (graph_data[one_node].GetNodeData().ToString() == node_value.ToString())
                {
                    graph_data[one_node].ClearNode();
                    graph_data.Remove(graph_data[one_node]);
                    --size_of_graph;
                    break;
                }
            }
        }
    }

    public class GraphNode<T>
    {
        private T node_data;
        private List<GraphNode<T>> neighbor_nodes;

        public GraphNode(T value)
        {
            node_data = value;
            neighbor_nodes = new List<GraphNode<T>>();
        }

        public void AddNeighbor(GraphNode<T> node)
        {
            neighbor_nodes.Add(node);
        }

        public void SetNodeData(T value)
        {
            node_data = value;
        }

        public T GetNodeData()
        {
            return node_data;
        }

        public List<GraphNode<T>> GetNodeNeighbors()
        {
            return neighbor_nodes;
        }

        public void ClearNode()
        {
            node_data = default(T);
            neighbor_nodes = null;
        }
    }
}
