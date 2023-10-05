
namespace ImplAlgorithms.Graphs
{
    internal class BFS
    {
        public static void BreadthFirstSearch(Dictionary<int, List<int>> graph)
        {
            bool[] visited = new bool[graph.Count];
            visited[0] = true;
            Queue<int> queue = new();
            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                int v = queue.Dequeue();
                Console.Write($"{v}, ");
                if(graph.ContainsKey(v))
                {
                    foreach(int u in graph[v])
                    {
                        if (!visited[u])
                        {
                            visited[u] = true;
                            queue.Enqueue(u);
                        }
                    }
                }
            }

        }
    }
}
