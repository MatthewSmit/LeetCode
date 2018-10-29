using System;
using System.Collections.Generic;

namespace LeetCode.Coderbyte
{
    public static class CorrectPathImpl
    {
        private sealed class Node
        {
            private readonly bool[,] visited;
            private readonly string str;
            private readonly int index;
            private readonly int x;
            private readonly int y;

            public Node(string str)
            {
                this.str = str;
                visited = new bool[5, 5];
                visited[x, y] = true;
            }

            private Node(string str, int index, int x, int y, string path, bool[,] visited)
            {
                this.str = str;
                this.index = index;
                this.x = x;
                this.y = y;
                Path = path;
                this.visited = (bool[,])visited.Clone();
                this.visited[x, y] = true;
            }

            public IEnumerable<Node> Neighbours
            {
                get
                {
                    if (index < str.Length)
                    {
                        switch (str[index])
                        {
                            case 'u':
                                if (y > 0 && !visited[x, y - 1])
                                {
                                    yield return new Node(str, index + 1, x, y - 1, Path + "u", visited);
                                }
                                break;

                            case 'd':
                                if (y < 4 && !visited[x, y + 1])
                                {
                                    yield return new Node(str, index + 1, x, y + 1, Path + "d", visited);
                                }
                                break;

                            case 'l':
                                if (x > 0 && !visited[x - 1, y])
                                {
                                    yield return new Node(str, index + 1, x - 1, y, Path + "l", visited);
                                }
                                break;

                            case 'r':
                                if (x < 4 && !visited[x + 1, y])
                                {
                                    yield return new Node(str, index + 1, x + 1, y, Path + "r", visited);
                                }
                                break;

                            case '?':
                                if (x > 0 && !visited[x - 1, y])
                                {
                                    yield return new Node(str, index + 1, x - 1, y, Path + "l", visited);
                                }

                                if (y > 0 && !visited[x, y - 1])
                                {
                                    yield return new Node(str, index + 1, x, y - 1, Path + "u", visited);
                                }

                                if (x < 4 && !visited[x + 1, y])
                                {
                                    yield return new Node(str, index + 1, x + 1, y, Path + "r", visited);
                                }

                                if (y < 4 && !visited[x, y + 1])
                                {
                                    yield return new Node(str, index + 1, x, y + 1, Path + "d", visited);
                                }
                                break;

                            default:
                                throw new NotImplementedException();
                        }
                    }
                }
            }

            public bool IsEnd => x == 4 && y == 4 && index == str.Length;

            public string Path { get; } = "";
        }

        public static string CorrectPath(string str)
        {
            var startNode = new Node(str);
            var stack = new Stack<Node>();
            stack.Push(startNode);

            while (stack.Count > 0)
            {
                var value = stack.Pop();
                foreach (var neighbour in value.Neighbours)
                {
                    if (neighbour.IsEnd)
                    {
                        return neighbour.Path;
                    }

                    stack.Push(neighbour);
                }
            }

            throw new NotImplementedException();
        }

        public static void Main()
        {
            Console.WriteLine(CorrectPath(Console.ReadLine()));
        }
    }
}
