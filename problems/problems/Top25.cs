using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using problems.Classes;

namespace problems
{
    public class Top25
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {

            // Time Complexity: O(n^2)
            // Space Complexity: O(n)

            List<int[]> result = new List<int[]>();

            if (array.Length == 0)
                return result;

            Array.Sort(array);

            for (var i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;

                if (i > 0 && array[i] == array[i - 1])
                {
                    continue;
                }

                while (left < right)
                {
                    int currentSum = array[i] + array[left] + array[right];
                    if (currentSum == targetSum)
                    {
                        int[] sumList = { array[i], array[left], array[right] };
                        result.Add(sumList);
                        left++;
                        right--;
                    }
                    else if (currentSum < targetSum)
                    {
                        left++;
                    }
                    else if (currentSum > targetSum)
                    {
                        right--;
                    }
                }
            }

            // Write your code here.
            return result;
        }

        public int[] TopKFrequentElements(int[] nums, int k)
        {

            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = dictionary[nums[i]] + 1;
                }
                else
                {
                    dictionary.Add(nums[i], 1);
                }
            }

            var list = new List<int>();
            for (var i = 0; i < k; i++)
            {
                var maxKey = dictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                if (maxKey != null)
                {
                    list.Add(maxKey);
                    dictionary.Remove(maxKey);
                }
            }

            return list.ToArray();

        }

        private static List<string> GetTopKFrequentWords(int k, string[] keywords, string[] reviews)
        {
            var count = new Dictionary<string, int>();
            foreach (var review in reviews)
            {
                var result = Regex.Replace(review, @"[^\w\s]", string.Empty);
                var currentWords = new HashSet<string>(result.ToLower().Split(" ").ToList());

                foreach (var word in keywords)
                {
                    if (currentWords.Contains(word))
                    {
                        if (count.ContainsKey(word))
                            count[word] = count[word] += 1;
                        else
                            count.Add(word, 1);
                    }
                }
            }

            var candidates = new List<string>(count.Keys).ToArray();
            Array.Sort(candidates, (w1, w2) => count[w1].Equals(count[w2]) ? w1.CompareTo(w2) : count[w2] - count[w1]);

            return candidates.ToList().GetRange(0, k);
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            // Time and Space Complexity: O(n + m) | O(1)
            ListNode preHead = new ListNode(-1);

            ListNode prev = preHead;
            while (l1 != null && l2 != null)
            {

                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }

                prev = prev.next;
            }

            if (l1 == null)
            {
                prev.next = l2;
            }

            if (l2 == null)
            {
                prev.next = l1;
            }

            return preHead.next;
        }

        public string MostCommonWords(string paragraph, string[] banned)
        {
            // Time and Space Complexity: O(M + N) | O(M + N)

            paragraph = Regex.Replace(paragraph, @"[^\w\s]", "");
            paragraph = paragraph.ToLower();

            Dictionary<string, int> wordMap = new Dictionary<string, int>();
            string[] words = paragraph.Split(" ");

            foreach (string word in words)
            {
                if (banned.Contains(word))
                    continue;

                if (!wordMap.ContainsKey(word))
                    wordMap.Add(word, 1);
                else
                    wordMap[word] = wordMap[word] + 1;
            }

            return wordMap.Aggregate((x, y) => x.Value > y.Value ? y : x).Key;
        }

        public string[] ReorderLogFiles(string[] logs)
        {
            // Time and Space Complexity: O(M * N * LogN) | O(M * N)

            var letterLogs = new List<Log>();
            var digitLogs = new List<string>();

            foreach (var logEntry in logs)
            {
                var space = logEntry.IndexOf(" ", StringComparison.Ordinal);
                var id = logEntry.Substring(0, space);
                var log = logEntry.Substring(space + 1);

                if (log[0] >= '0' && log[0] <= '9')
                {
                    digitLogs.Add(logEntry);
                }
                else
                {
                    letterLogs.Add(new Log(id, log));
                }
            }

            var resultList = letterLogs
                .OrderBy(x => x.LogEntry)
                .ThenBy(x => x.Id)
                .Select(x => $"{x.Id} {x.LogEntry}")
                .ToList();

            resultList.AddRange(digitLogs);

            return resultList.ToArray();
        }

        private List<Numeral> Numerals = new List<Numeral>()
        {
            new Numeral("M", 1000),
            new Numeral("CM", 900),
            new Numeral("D", 500),
            new Numeral("CD", 400),
            new Numeral("C", 100),
            new Numeral("XC", 90),
            new Numeral("L", 50),
            new Numeral("XL", 40),
            new Numeral("X", 10),
            new Numeral("IX", 9),
            new Numeral("V", 5),
            new Numeral("IV", 4),
            new Numeral("I", 1)
        };

        public string IntToRoman(int num)
        {
            // Time and Space complexity: O(1) | O(1)

            string result = "";
            foreach (var numeral in Numerals)
            {
                var numberOfSymbols = num / numeral.Value;
                if (numberOfSymbols != 0)
                    result += string.Concat(Enumerable.Repeat(numeral.Symbol, numberOfSymbols));
                num %= numeral.Value;
            }
            return result;
        }

        private class Numeral
        {
            public string Symbol { get; set; }
            public int Value { get; set; }

            public Numeral(string symbol, int value)
            {
                Symbol = symbol;
                Value = value;
            }
        }

        public int MaxSubArray(int[] nums)
        {
            // Time and Space Complexity: O(n) | O(1) - one pass and constant space

            int size = nums.Length;
            int max_so_far = int.MinValue;
            int max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + nums[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;

        }

        public int[] PrisonAfterNDays(int[] cells, int days)
        {
            // Time Complexity: O(min(N, 2^K))
            // Space Complexity O(2^K)

            var seen = new Dictionary<int, int>();
            var isFastForwarded = false;

            // step 1). convert the cells to bitmap
            var stateBitmap = 0x0;
            foreach (var cell in cells)
            {
                stateBitmap <<= 1;
                stateBitmap = (stateBitmap | cell);
            }

            // step 2). run the simulation with dictionary
            while (days > 0)
            {
                if (!isFastForwarded)
                {
                    if (seen.ContainsKey(stateBitmap))
                    {
                        // the length of the cycle is seen[state_key] - N
                        days %= seen[stateBitmap] - days;
                        isFastForwarded = true;
                    }
                    else
                        seen.Add(stateBitmap, days);
                }

                // check if there is still some steps remained,
                // with or without the fast forwarding.
                if (days > 0)
                {
                    days -= 1;
                    stateBitmap = nextDay(stateBitmap);
                }
            }

            // step 3). convert the bitmap back to the state cells
            var result = new int[cells.Length];
            for (var i = cells.Length - 1; i >= 0; i--)
            {
                result[i] = (stateBitmap & 0x1);
                stateBitmap >>= 1;
            }

            return result;
        }

        private int nextDay(int stateBitmap)
        {
            stateBitmap = ~(stateBitmap << 1) ^ (stateBitmap >> 1);
            // set the head and tail to zero
            stateBitmap &= 0x7e;
            return stateBitmap;
        }

        public int NumberOfIslands(char[,] grid)
        {
            // Time complexity : O(M X N) where M is the number of rows and N is the number of columns.
            
            // Note that Union operation takes essentially constant time[1] when UnionFind is implemented with both path compression and union by rank.

            // Space complexity : O(M X N) as required by UnionFind data structure.

            var count = 0;
            for (var i = 0; i < grid.GetLength(0); i++)
            {
                for (var j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '1')
                    {
                        count += 1;
                        GetBFS(grid, i, j);
                    }
                }
            }

            return count;
        }

        private static void GetBFS(char[,] grid, int i, int j)
        {
            if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i, j] == '0')
                return;

            grid[i, j] = '0';
            GetBFS(grid, i + 1, j); // up
            GetBFS(grid, i - 1, j); // down
            GetBFS(grid, i, j + 1); // left
            GetBFS(grid, i, j - 1); // right
        }

        public int[][] MergeIntervals(int[][] intervals)
        {
            // Time complexity : O(nlogn)

            // Other than the sort invocation, we do a simple linear scan of the list, so the runtime is dominated by the O(nlogn) complexity of sorting.

            // Space complexity : O(n)

            if (intervals.Any())
            {
                return intervals.ToArray();
            }

            List<int[]> mergedMeetings = new List<int[]>();
            List<int[]> sortedTimes = intervals.Select(x => x).OrderBy(x => x[0]).ToList();
            mergedMeetings.Add(sortedTimes[0]);

            foreach (var meeting in sortedTimes)
            {
                int[] lastMeeting = mergedMeetings.Last();
                if (meeting[0] <= lastMeeting[1])
                {
                    lastMeeting[1] = Math.Max(meeting[1], lastMeeting[1]);
                }
                else
                {
                    mergedMeetings.Add(meeting);
                }
            }

            return mergedMeetings.ToArray();
        }

        public int MinCostToConnectRopes(int[] ropes)
        {
            if (ropes == null || !ropes.Any()) return 0;

            var operand = new List<int>(ropes);
            var finalSum = 0;
            while (operand.Count > 1)
            {
                operand = operand.OrderBy(x => x).ToList();
                var op1 = operand.FirstOrDefault();
                operand.Remove(op1);

                var op2 = operand.FirstOrDefault();
                operand.Remove(op2);

                var sum = op1 + op2;
                finalSum += sum;

                operand.Add(sum);
            }

            return finalSum;
        }

        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            // keyword search
            // Time and Space Complexity: O(NlogN) | O(N)
            var suggestion = new List<IList<string>>();

            Array.Sort(products);
            var left = 0;
            var right = products.Length - 1;

            for (var i = 0; i < searchWord.Length; i++)
            {
                while (left <= right && (products[left].Length <= i || products[left][i] != searchWord[i]))
                    left += 1;

                while (left <= right && (products[right].Length <= i || products[right][i] != searchWord[i]))
                    right -= 1;

                if (left + 3 <= right)
                {
                    var end = left + 3;
                    suggestion.Add(products[left..end]);
                }
                else
                {
                    var end = right + 1;
                    suggestion.Add(products[left..end]);
                }

            }

            return suggestion;
        }

        public int SearchRotatedArray(int[] nums, int target)
        {
            // Time and Space Complexity: O(logN) | O(1)
            
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                    return mid; // if found return index
                else if (nums[mid] >= nums[start])
                {
                    // pivot element is larger than first element in array
                    // if target is located in the non-rotated subarray go left
                    if (target >= nums[start] && target < nums[mid])
                        end = mid - 1;
                    else
                        //otherwise go right
                        start = mid + 1;
                }
                else
                {
                    // pivot is smaller than first element of array
                    // if target is located in the non-rotated subarray, go right
                    if (target <= nums[end] && target > nums[mid])
                        start = mid + 1;
                    // otherwise, go left
                    else
                        end = mid - 1;
                }
            }

            return -1;
        }

        public bool WordBreak(string s, List<string> wordDict)
        {
            // Time complexity : O(n ^ 2).For every starting index, the search can continue till the end of the given string.
            // Space complexity : O(n). Queue of at most n size is needed.

            HashSet<string> wordDictSet = wordDict.ToHashSet();
            Queue<int> queue = new Queue<int>();
            int[] visited = new int[s.Length];

            queue.Enqueue(0);

            while (queue.Any())
            {
                int start = queue.Dequeue();
                if (visited[start] == 0)
                {
                    for (int end = start + 1; end <= s.Length; end++)
                    {
                        if (wordDictSet.Contains(s.Substring(start, end - start)))
                        {
                            queue.Enqueue(end);
                            if (end == s.Length)
                            {
                                return true;
                            }
                        }
                    }

                    visited[start] = 1;
                }
            }

            return false;
        }

        public string LongestPalindrome(string s)
        {
            // Space and Time Complexity: O(n^2) -> expands palindrome from center | O(1)

            if (string.IsNullOrEmpty(s))
                return "";

            var start = 0;
            var end = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var len1 = expandFromMiddle(s, i, i);
                var len2 = expandFromMiddle(s, i, i + 1);

                var len = Math.Max(len1, len2);

                if (len > end - start)
                {
                    start = i - ((len - 1) / 2);
                    end = i + (len / 2);
                }
            }

            return s.Substring(start, end);

        }

        private int expandFromMiddle(string s, int left, int right)
        {

            if (s == null || left > right) return 0;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right + left - 1;
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // Time Complexity: O(NK), where NN is the length of strs, and K is the maximum length of a string in strs
            // Space Complexity: O(NK), the total information content stored in answer

            var result = new List<IList<string>>();
            var answer = new Dictionary<string, IList<string>>();

            var count = new int[26];
            foreach (var str in strs)
            {
                Array.Fill(count, 0);

                foreach (var ch in str.ToCharArray())
                    count[ch - 'a']++;

                var sb = new StringBuilder();
                for (var i = 0; i < 26; i++)
                {
                    sb.Append("#");
                    sb.Append(count[i]);
                }

                var key = sb.ToString();

                if (!answer.ContainsKey(key))
                    answer.Add(key, new List<string>());

                var newList = answer[key];
                newList.Add(str);
                answer[key] = newList;

                int val;
                int.TryParse(sb.ToString(), out val);
            }

            var flattenList = answer.SelectMany(x => x.Value).ToList();
            result.Add(flattenList);

            return result;

        }

        public bool IsSubtreeOfAnotherTree(TreeNode s, TreeNode t)
        {
            // Space and Time Complexity: O(m * n) | O(n) -> uses stack space
            return Traverse(s, t);
        }
        public bool Equals(TreeNode x, TreeNode y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            
            return x.val == y.val && Equals(x.left, y.left) && Equals(x.right, y.right);
        }
        public bool Traverse(TreeNode s, TreeNode t)
        {
            return s != null && (Equals(s, t) || Equals(s.left, t) || Traverse(s.right, t));
        }

        public IList<IList<int>> VerticalOrderTraversal(TreeNode root)
        {
            // Space and Time Complexity: O(n) | O(n)

            List<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            int column = 0;
            int minColumnIndex = 0;
            int maxColumnIndex = 0;

            // queue to keep track of tree nodes and horizontal distance
            Queue<KeyValuePair<TreeNode, int>> queue = new Queue<KeyValuePair<TreeNode, int>>();

            // add root to the queue with hd == 0
            queue.Enqueue(KeyValuePair.Create(root, 0));

            // create a dictionary to keep track of horizontal distance and list of nodes
            Dictionary<int, List<int>> columnTable = new Dictionary<int, List<int>>();

            while (queue.Any())
            {
                // deque first item from queue
                KeyValuePair<TreeNode, int> current = queue.Dequeue();
                root = current.Key; // set current node to root
                column = current.Value; // get current column value of node

                if (root != null)
                {
                    if (!columnTable.ContainsKey(column))
                    {
                        // if new column, add to list and initialize values
                        columnTable.Add(column, new List<int>());
                    }

                    // add new root value
                    columnTable[column].Add(root.val);

                    // keep track of min and max columns in tree to iterate through node values later on
                    minColumnIndex = Math.Min(column, minColumnIndex);
                    maxColumnIndex = Math.Max(column, maxColumnIndex);

                    // add left and right child nodes of root with new horizontal distances (-1 for left, + 1 for right)
                    queue.Enqueue(KeyValuePair.Create(root.left, column - 1));
                    queue.Enqueue(KeyValuePair.Create(root.right, column + 1));
                }
            }

            // iterate through tree from min to max columns and add node values to each list, then return result
            for (var i = minColumnIndex; i < maxColumnIndex + 1; i++)
            {
                result.Add(columnTable[i]);
                // to find sum just total node values at the end.
            }

            return result;
        }

        public IList<int> InOrderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            if (root == null)
                return result;

            TreeNode current = root;

            while (current != null || stack.Any())
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                result.Add(current.val);
                current = current.right;
            }

            return result;
        }

        public IList<IList<int>> LevelOrderTraversal(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int totalWidth = 1;
            while (queue.Any())
            {
                int size = queue.Count;

                // used to stored current level of all tree nodes
                List<int> currentLevel = new List<int>();

                int incrementalCount = 0;
                // iterate based on size of queue
                for (int i = 0; i < size; i++)
                {
                    // get the current node
                    TreeNode current = queue.Dequeue();

                    // add current node val to current level
                    currentLevel.Add(current.val);

                    if (current.left != null)
                    {
                        // add the left node of parent to queue
                        // so they can be processed on the next round
                        queue.Enqueue(current.left);
                        incrementalCount++;
                    }

                    if (current.right != null)
                    {
                        // add the right node of parent to queue
                        // so they can be processed on the next round
                        queue.Enqueue(current.right);
                        incrementalCount++;
                    }

                    if (incrementalCount > totalWidth)
                        totalWidth = incrementalCount;
                }

                result.Add(currentLevel); // add each level of nodes to result
            }

            return result;
        }

    }
}
