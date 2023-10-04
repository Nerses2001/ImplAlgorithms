
using System.Collections.Generic;
using System.ComponentModel;

namespace ImplAlgorithms.Graph
{
    // Complexity O(V + E)
/*    0 -- 1 -- 3
      |         |
      2         4 -- 5
*/
    internal class DFS
    {
        public static void DepthFirstTraversal(Dictionary<int, List<int>> graph, int v, List<bool> visited)
        {
            visited[v] = true;
    //        Console.WriteLine("------------------");

            foreach (int neighbor in graph[v])
            {
                if (!visited[neighbor])
                    DepthFirstTraversal(graph, neighbor, visited);
            }
            Console.Write($"{v}, ");

        }
    }
}
