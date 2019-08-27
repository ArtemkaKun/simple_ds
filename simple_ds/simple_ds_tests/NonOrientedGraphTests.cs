using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_ds_tests
{
    [TestClass]
    public class NonOrientedGraphTests
    {
        [TestMethod]
        public void AddNode_1_return_size_1()
        {
            int expected = 1;
            int graph_size;

            simple_ds.Structures.NonOrientedGraph<string> graph = new simple_ds.Structures.NonOrientedGraph<string>();

            graph.AddNode("Artem");
            graph_size = graph.Size();

            Assert.AreEqual(expected, graph_size);
        }

        [TestMethod]
        public void AddNode_12_return_neighbor_1()
        {
            int expected = 1;
            int node_neighbor;

            simple_ds.Structures.NonOrientedGraph<string> graph = new simple_ds.Structures.NonOrientedGraph<string>();

            graph.AddNode("Artem");
            graph.AddNode("Anime");
            graph.AddEdge("Artem", "Anime");

            node_neighbor = graph.PeekNeighbors(graph.PeekNode("Artem")).Count;

            Assert.AreEqual(expected, node_neighbor);
        }

        [TestMethod]
        public void AddNode_123_return_size_1()
        {
            int expected = 2;
            int graph_size;

            simple_ds.Structures.NonOrientedGraph<string> graph = new simple_ds.Structures.NonOrientedGraph<string>();

            graph.AddNode("Artem");
            graph.AddNode("Anime");
            graph.AddNode("Games");
            graph.RemoveNode("Anime");
            graph_size = graph.Size();

            Assert.AreEqual(expected, graph_size);
        }

    }
}
