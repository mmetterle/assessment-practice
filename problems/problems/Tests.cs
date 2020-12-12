using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32.SafeHandles;
using problems.Classes;

namespace problems
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var logs = new string[]
            {
                "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"
            };
            ReorderLogFiles(logs);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var nums = new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};

            var size = nums.Length;
            var max_so_far = int.MinValue;
            var max_ending_here = 0;

            for (var i = 0; i < size; i++)
            {
                max_ending_here += nums[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            var stringBuilder = new StringBuilder();
            stringBuilder.Append("0");
            stringBuilder.Append("1");

            var fff = stringBuilder.ToString().Reverse().ToArray();
            var ddd = int.Parse(stringBuilder.ToString());

            string charsStr = new string(fff);
            Console.WriteLine(fff);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //var x = -123;
            var x = 1534236469;

            var sign = '+';

            var numArray = x.ToString().ToCharArray();
            if (numArray[0] == '-')
            {
                numArray = numArray.Skip(1).ToArray();
                sign = '-';
            }

            var sb = new StringBuilder();
            for (var i = numArray.Length - 1; i >= 0; i--)
            {
                sb.Append(numArray[i]);
            }

            int value;
            if (!int.TryParse(sb.ToString(), out value))
                value = 0;

            if (sign == '-')
                value *= -1;

        }

        [TestMethod]
        public void TestMethod4()
        {
            int number = 19;
            var value = IsHappy(number);

        }

        [TestMethod]
        public void TestMethod5()
        {
            int number = 121;
            var value = IsPalindrome(number);

        }

        [TestMethod]
        public void TestMethod6()
        {
            var array = new[] {"practice", "makes", "perfect", "coding", "makes"};
            var value = ShortestDistance(array, "practice", "coding");

            var dd = "";

        }

        [TestMethod]
        public void TestMethod7()
        {
            var str = "leetcode";
            var arr = new[] {"leet", "code"};

            WordBreak(str, arr);

        }

        [TestMethod]
        public void TestMethod8()
        {
            var arr = new[] {0, 1, 2, 3, 4, 5, 6, 7, 9};

            MissingNumber(arr);

        }

        [TestMethod]
        public void TestMethod9()
        {
            //var arr = new[] {"dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"};
            var arr = new[] {"a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo", "a2 act car"};

            ReorderLogFiles2(arr);

        }

        [TestMethod]
        public void TestMethod10()
        {
            //var arr = new[] {"dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"};
            var str = "eleetminicoworoep";

            FindTheLongestSubstringEventCountVowels(str);

        }

        [TestMethod]
        public void TestMethod11()
        {
            var products = new[] {"mobile", "mouse", "moneypot", "monitor", "mousepad"};
            var searchWord = "mouse";

            string[] banned = new[] {"4"};
            string paragraph = "";

            paragraph = paragraph.ToLower();
            paragraph = Regex.Replace(paragraph, @"[^\w\d\s]", "");
            var paragraphList = paragraph.Split(" ");
            for (var i = 0; i < paragraphList.Length; i++)
            {
                var val = paragraphList[i];
            }

            SuggestedProducts(products, searchWord);
        }

        [TestMethod]
        public void TestMethod12()
        {
            var searchWord = "ababcbacadefegdehijhklij";

            PartitionLabels(searchWord);
        }


        [TestMethod]
        public void TestMethod13()
        {
            var top = 2;
            var array = new[] {1, 1, 1, 2, 2, 3};

            //TopKFrequent(array, top);
        }


        [TestMethod]
        public void TestMethod14()
        {
            var flightLength = 90;
            var movieLengths = new[] {1, 10, 25, 35, 60};

            MoviesOnAFlight(flightLength, movieLengths);

            var movieLengths2 = new[] {20, 50, 40, 25, 30, 10};
            MoviesOnAFlight(flightLength, movieLengths2);


            var movieLengths3 = new[] {90, 85, 75, 60, 120, 150, 125};
            flightLength = 250;
            MoviesOnAFlight(flightLength, movieLengths3);
        }

        [TestMethod]
        public void TestMethod15()
        {
            TopNBuzzwords(6, 2, new List<string> {"elmo", "elsa", "legos", "drone", "tablet", "warcraft"}, 6,
                new List<string>
                {
                    "Elmo is the hottest of the season! Elmo will be on every kid's wishlist!",
                    "The new Elmo dolls are super high quality",
                    "Expect the Elsa dolls to be very popular this year, Elsa!",
                    "Elsa and Elmo are the toys I'll be buying for my kids, Elsa is good",
                    "For parents of older kids, look into buying them a drone",
                    "Warcraft is slowly rising in popularity ahead of the holiday season"
                });
        }

        [TestMethod]
        public void TestMethod16()
        {
            var secretFruitsList = new List<IList<string>>
            {
                new List<string>
                {
                    "orange",
                    "mongo"
                },
                new List<string>
                {
                    "watermelon",
                    "mongo"
                }
            };

            var customerPurchasedList = new List<string>
            {
                "orange",
                "mongo",
                "strawberry",
                "watermelon",
                "mongo"
            };

            var val = SecretFruitList(secretFruitsList, customerPurchasedList);

            secretFruitsList = new List<IList<string>>
            {
                new List<string>
                {
                    "watermelon",
                    "anything",
                    "mongo"
                }
            };

            customerPurchasedList = new List<string>
            {
                "watermelon",
                "orange",
                "mongo"
            };

            val = SecretFruitList(secretFruitsList, customerPurchasedList);

            customerPurchasedList = new List<string>
            {
                "watermelon",
                "apple",
                "orange",
                "mongo"
            };

            val = SecretFruitList(secretFruitsList, customerPurchasedList);

        }

        [TestMethod]
        public void TestMethod17()
        {
            var wordList = new List<string>
            {
                "practice",
                "makes",
                "perfect",
                "coding",
                "makes"
            };

            var word1 = "coding";
            var word2 = "practice";

            ShortestWordDistance(wordList, word1, word2);


            word1 = "makes";
            word2 = "coding";

            ShortestWordDistance(wordList, word1, word2);
        }

        [TestMethod]
        public void TestMethod18()
        {
            var array = new[] {2, 2, 2, 3, 5, 5, 7, 7, 7, 8, 8, 10, 10, 10, 10, 10, 12, 15, 15};
            var target = 7;
            CountNumberInSortedArray(array, target);

            array = new[] {2, 2, 2, 3, 5, 5, 7, 7, 7, 8, 8, 10, 10, 10, 10, 10, 12, 15, 15};
            target = 10;
            CountNumberInSortedArray(array, target);

            array = new[] {1, 1, 1, 4, 4, 6, 6, 6};
            target = 2;
            CountNumberInSortedArray(array, target);
        }

        [TestMethod]
        public void TestMethod19()
        {
            var array = new[]
            {
                "205.251.242.103", "104.36.196.223", "151.101.40.116", "205.251.242.103", "104.196.174.50",
                "52.205.157.89", "205.251.242.103", "151.101.40.116"
            };
            RemoveDuplicateIPv4Addresses(array);

            //array = new[] { 2, 2, 2, 3, 5, 5, 7, 7, 7, 8, 8, 10, 10, 10, 10, 10, 12, 15, 15 };
            //CountNumberInSortedArray(array, target);

            //array = new[] { 1, 1, 1, 4, 4, 6, 6, 6 };
            //CountNumberInSortedArray(array, target);
        }

        [TestMethod]
        public void TestMethod20()
        {
            var s = "cbaebabacd";
            var p = "abc";
            FindAnagrams(s, p);
        }

        [TestMethod]
        public void TestMethod21()
        {
            var uniqueSubStr = "ABC";
            UniqueLetterString(uniqueSubStr);

        }

        [TestMethod]
        public void TestMethod22()
        {
            var array = new[] {6, 5, 4};
            RollDice(array);

            array = new[] {6, 6, 1};
            RollDice(array);

            array = new[] {6, 1, 5, 4};
            RollDice(array);
        }

        [TestMethod]
        public void TestMethod23()
        {
            var str = "bbeadcxede";
            PartitionLabelsReturnSubStrings(str);

            str = "baddacx";
            PartitionLabelsReturnSubStrings(str);
        }

        [TestMethod]
        public void TestMethod24()
        {
            var d = 4;
            var arr = new int[] {1, 2, 3, 4, 5};
            rotLeft(arr, d);
        }

        [TestMethod]
        public void TestMethod25()
        {
            char[,] grid =
            {
                {'O', 'O', 'O', 'O'},
                {'D', 'O', 'D', 'O'},
                {'O', 'O', 'O', 'O'},
                {'X', 'D', 'D', 'O'}
            };

            TreasureIsland(grid);
        }

        [TestMethod]
        public void TestMethod26()
        {
            var userMap = new Dictionary<string, IList<string>>
            {
                {"David", new List<string> {"song1", "song2", "song3", "song4", "song8"}},
                {"Emma", new List<string> {"song5", "song6", "song7"}}
            };

            var genreMap = new Dictionary<string, IList<string>>
            {
                {"Rock", new List<string> {"song1", "song3"}},
                {"Dubstep", new List<string> {"song7"}},
                {"Techno", new List<string> {"song2", "song4"}},
                {"Pop", new List<string> {"song5", "song6"}},
                {"Jazz", new List<string> {"song8", "song9"}}
            };

            FavoriteGenres(userMap, genreMap);
        }

        [TestMethod]
        public void TestMethod27()
        {
            var array = new int[] {2, 4, 5, 3, 3, 9, 2, 2, 2};

            LoadBalancer(array);
        }


        [TestMethod]
        public void TestMethod28()
        {
            //https://www.youtube.com/watch?v=NUlsvZhV4cs
            // Input:
            //              20
            //            /   \
            //          12     18
            //       /  |  \   / \
            //     11   2   3 15  8

            var left = new Node(12);
            left.children = new List<Node> {new Node(11), new Node(2), new Node(3)};

            var right = new Node(18);
            right.children = new List<Node> {new Node(15), new Node(8)};

            var root = new Node(20);
            root.children = new List<Node> {left, right};

            var maxNode = GetMaximumAverage(root);

            Console.WriteLine("Max Average: " + maxNode.val); // output: 18


            // Input:
            //              1
            //           / / \ \
            //         -5 21  5 -1

            var left1 = new Node(-5);
            var left2 = new Node(21);
            var right1 = new Node(5);
            var right2 = new Node(-1);

            //root = new Node(1);
            //root.children = new List<Node> { left1, left2, right1, right2 };

            root = new Node(1);
            root.children = new List<Node> {new Node(-5), new Node(21), new Node(5), new Node(-1)};

            maxNode = GetMaximumAverage(root);

            Console.WriteLine("Max Average: " + maxNode.val); // output: 21
        }

        [TestMethod]
        public void TestMethod29()
        {
            int[,] grid =
            {
                {0, 1, 1, 0, 1},
                {0, 1, 0, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 1, 0, 0, 0}
            };

            //ZombieInfection(grid);
            ZombieInaMatrix(grid);
        }

        [TestMethod]
        public void TestMethod30()
        {
            var numOfCities = 3;
            var cities = new[] {"c1", "c2", "c3"};
            var xCoordinates = new[] {3, 2, 1};
            var yCoordinates = new[] {3, 2, 3};
            var numOfQueries = 3;
            var queries = new[] {"c1", "c2", "c3"};

            var result = NearestCities(numOfCities, cities.ToList(), xCoordinates.ToList(), yCoordinates.ToList(),
                numOfQueries, queries.ToList());

            numOfCities = 6;
            cities = new[] {"green", "yellow", "red", "blue", "grey", "pink"};
            xCoordinates = new[] {10, 20, 15, 30, 10, 15};
            yCoordinates = new[] {30, 25, 30, 40, 25, 25};
            numOfQueries = 4;
            queries = new[] {"grey", "blue", "red", "pink"};

            result = NearestCities(numOfCities, cities.ToList(), xCoordinates.ToList(), yCoordinates.ToList(),
                numOfQueries, queries.ToList());
        }


        [TestMethod]
        public void TestMethod31()
        {
            //Scanner sc = new Scanner(System.in);
            //int n = sc.nextInt();
            int n = 0;

            var hmap = new Dictionary<int, List<int>>();

            for (var i = 0; i < n; i++)
            {
                //int parent = sc.nextInt();
                //int child = sc.nextInt();
                int parent = 0;
                int child = 0;
                if (hmap.ContainsKey(parent))
                {
                    hmap[parent].Add(child);
                }
                else
                {
                    var temp = new List<int>();
                    temp.Add(child);
                    hmap[parent] = temp;
                }

                if (!hmap.ContainsKey(child))
                {
                    hmap.Add(child, new List<int>());
                }
            }

            //int parentNode = sc.nextInt();
            int parentNode = 0;
            maxSum = new Pair(0, 0);
            maxTenureNode = -1;

            FindHighestTenure(hmap, parentNode);
        }

        [TestMethod]
        public void TestMethod32()
        {
            var inventory = new List<int>();
            inventory.Add(2);
            inventory.Add(8);
            inventory.Add(4);
            inventory.Add(10);
            inventory.Add(6);

            var val = MaxProfit(inventory, 20); // 110
            inventory.Clear();

            inventory.Add(2);
            inventory.Add(5);

            val = MaxProfit(inventory, 4); // 14
            inventory.Clear();

            inventory.Add(3);
            inventory.Add(5);
            val = MaxProfit(inventory, 6); //19
        }


        [TestMethod]
        public void TestMethod33()
        {
            var blocks = new[] {"10", "20", "X", "+"};
            var val = BaseBallScoreKeeping(blocks); // 130

            blocks = new[] {"10", "20", "Z", "30", "+"};
            val = BaseBallScoreKeeping(blocks); // 80
        }

        [TestMethod]
        public void TestMethod34()
        {
            var numComputer = 3;
            var hardDiskSpace = new[] {8, 2, 4};
            var segmentLength = 2;

            var val = MaxAvailableDiskSpace(numComputer, hardDiskSpace, segmentLength);
        }

        [TestMethod]
        public void TestMethod35()
        {
            int[,] grid =
            {
                {7, 5, 3},
                {2, 0, 9},
                {4, 5, 9}
            };

            var val = MaxOfMinAltitude(grid); //3

            int[,] grid2 =
            {
                {5, 1},
                {4, 5}
            };

            //Explanation:
            //Possible paths:
            //Here are some paths from[0, 0] to[2, 2] and the minimum value on each path:
            //7 -> 2 -> 4 -> 5 -> 9 => min value is 2
            //7 -> 2 -> 0 -> 9 -> 9 => min value is 0
            //7 -> 2 -> 0 -> 5 -> 9 => min value is 0
            //In the end the max score(the min value) of all the paths is 3.

            val = MaxOfMinAltitude(grid2); //4
            //Explanation:
            //Possible paths:
            //5 -> 1 -> 5 => min value is 1
            //5 -> 4 -> 5 => min value is 4
            //Return the max value among minimum values => max(4, 1) = 4.

            int[,] grid3 =
            {
                {1, 2, 3},
                {4, 5, 1}
            };

            val = MaxOfMinAltitude(grid3); //4 
            //Explanation:
            //Possible paths:
            //1 -> 2 -> 3 -> 1
            //1 -> 2 -> 5 -> 1
            //1 -> 4 -> 5 -> 1
            //So min of all the paths = [2, 2, 4].Note that we don't include the first and final entry.
            //Return the max of that, so 4.
        }

        [TestMethod]
        public void TestMethod36()
        {
            // https://www.geeksforgeeks.org/shortest-distance-between-two-nodes-in-bst/

            TestNode root = null;
            root = Insert(root, 2);
            Insert(root, 1);
            Insert(root, 3);

            var val = FindDistWrapper(root, 1, 3);
        }


        [TestMethod]
        public void TestMethod37()
        {
            var k = 2;
            var keywords = new[] {"anacell", "cetracular", "betacellular"};
            var reviews = new[]
            {
                "Anacell provides the best services in the city",
                "betacellular has awesome services",
                "Best services provided by anacell, everyone should use anacell",
            };

            var val = GetTopKFrequent(k, keywords, reviews);


            k = 2;
            keywords = new[] {"anacell", "betacellular", "cetracular", "deltacellular", "eurocell"};
            reviews = new[]
            {
                "I love anacell Best services; Best services provided by anacell",
                "betacellular has great services",
                "deltacellular provides much better services than betacellular",
                "cetracular is worse than anacell",
                "Betacellular is better than deltacellular.",
            };

            val = GetTopKFrequent(k, keywords, reviews);
        }

        [TestMethod]
        public void TestMethod38()
        {
            char[,] grid =
            {
                {'1', '1', '1', '1', '0'},
                {'1', '1', '0', '1', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '0', '0', '0'}
            };

            var val = NumberOfIslands(grid);

            char[,] grid2 =
            {
                {'1', '1', '0', '0', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '1', '0', '0'},
                {'0', '0', '0', '1', '1'}
            };

            val = NumberOfIslands(grid2);
        }

        [TestMethod]
        public void TestMethod39()
        {
            var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            var banned = new[] {"hit"};

            var val = MostCommonWord(paragraph, banned); //Output: "ball"
        }

        [TestMethod]
        public void TestMethod40()
        {
            var ropes = new[] {8, 4, 6, 12};
            var val = MinCostToConnectRopes(ropes); //58

            ropes = new[] {20, 4, 8, 2};
            val = MinCostToConnectRopes(ropes); //54

            ropes = new[] {1, 2, 5, 10, 35, 89};
            val = MinCostToConnectRopes(ropes); //224

            ropes = new[] {2, 2, 3, 3};
            val = MinCostToConnectRopes(ropes); //20
        }

        [TestMethod]
        public void TestMethod41()
        {
            var days = 7;
            var cells = new[] {0, 1, 0, 1, 1, 0, 0, 1};

            var val = PrisonAfterNDays(cells, days); //output [0,0,1,1,0,0,0,0]
            /*
            Explanation:
            The following table summarizes the state of the prison on each day:
            Day 0: [0, 1, 0, 1, 1, 0, 0, 1]
            Day 1: [0, 1, 1, 0, 0, 0, 0, 0]
            Day 2: [0, 0, 0, 0, 1, 1, 1, 0]
            Day 3: [0, 1, 1, 0, 0, 1, 0, 0]
            Day 4: [0, 0, 0, 0, 0, 1, 0, 0]
            Day 5: [0, 1, 1, 1, 0, 1, 0, 0]
            Day 6: [0, 0, 1, 0, 1, 1, 0, 0]
            Day 7: [0, 0, 1, 1, 0, 0, 0, 0]
            */

            days = 1000000000;
            cells = new[] {1, 0, 0, 1, 0, 0, 1, 0};

            val = PrisonAfterNDays(cells, days); //output [0,0,1,1,1,1,1,0]
        }

        [TestMethod]
        public void TestMethod42()
        {
            CheckSameInOrderTraversal();
        }

        [TestMethod]
        public void TestMethod43()
        {
            // [3,9,20,null,null,15,7]
            /*
                     3
                    / \
                   9  20
                     /  \
                    15   7
             */

            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            var val = MaxDepthRecursion(tree); //3

            val = MaxDepthIteration(tree); //3

            //Time Complexity: O(n) for both
            //Space Complexity: O(n) for both
        }


        [TestMethod]
        public void TestMethod44()
        {
            // [3,9,20,null,null,15,7]
            /*
                     3
                    / \
                   9  20
                     /  \
                    15   7
             */

            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            var val = LevelOrderTraversal(tree);
        }

        [TestMethod]
        public void TestMethod45()
        {
            // [3,9,20,null,null,15,7]
            /*
                     3
                    / \
                   9  20
                     /  \
                    15   7
             */

            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            var val = MinDepthIteration(tree);
        }

        [TestMethod]
        public void TestMethod46()
        {
            // [3,9,20,null,null,15,7]
            /*
                     3
                    / \
                   9  20
                     /  \
                    15   7
             */

            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            var val = VerticalOrderTraversal(tree);
        }

        [TestMethod]
        public void TestMethod47()
        {
            // [5,1,4,null,null,3,6]
            /*
                     5
                    / \
                   1   4
                     /  \
                    3    6
             */

            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(1);
            tree.right = new TreeNode(4);
            tree.right.left = new TreeNode(3);
            tree.right.right = new TreeNode(6);

            // [2,1,3]
            /*
                     2
                    / \
                   1   3
             */

            tree = new TreeNode(2);
            tree.left = new TreeNode(1);
            tree.right = new TreeNode(3);

            var val = IsValidBST(tree);


            var root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.left.left = new TreeNode(2);
            root.left.left.left = new TreeNode(1);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(15);
            root.right.left = new TreeNode(13);
            root.right.left.right = new TreeNode(14);
            root.right.right = new TreeNode(22);

            val = IsValidBST(root);
        }

        [TestMethod]
        public void TestMethod48()
        {
            string beginWord = "hit";
            string endWord = "cog";
            List<string> wordList = new List<string>() {"hot", "dot", "dog", "lot", "log", "cog"};

            LadderLength(beginWord, endWord, wordList);
        }

        [TestMethod]
        public void TestMethod49()
        {
            string s = "leetcode";
            List<string> wordDict = new List<string> {"leet", "code"};
            bool val = wordBreak(s, wordDict);

            s = "applepenapple";
            wordDict = new List<string> {"apple", "pen"};
            val = wordBreak(s, wordDict);

            s = "catsandog";
            wordDict = new List<string> {"cats", "dog", "sand", "and", "cat"};
            val = wordBreak(s, wordDict);

            s = "aaaaaaa";
            wordDict = new List<string> {"aaaa", "aaa"};
            val = wordBreak(s, wordDict);
        }

        [TestMethod]
        public void TestMethod50()
        {
            char[,] board =
            {
                {'A', 'B', 'C', 'E'},
                {'S', 'F', 'C', 'S'},
                {'A', 'D', 'E', 'E'}
            };

            string word = "ABCCED"; // return true.
            bool val = WordSearch(board, word);

            word = "SEE"; // return true.
            val = WordSearch(board, word);

            word = "ABCB"; // return false.
            val = WordSearch(board, word);

        }

        [TestMethod]
        public void TestMethod51()
        {
            string digits = "23";
            LetterCombinations(digits);
        }

        [TestMethod]
        public void TestMethod52()
        {
            RotateString("", "");
        }

        [TestMethod]
        public void TestMethod53()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);
            root.right.right = new TreeNode(4);

            BoundaryOfBinaryTree(root);
        }

        [TestMethod]
        public void TestMethod54()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.left.left.left = new TreeNode(8);
            root.left.left.right = new TreeNode(9);
            root.left.right.left = new TreeNode(10);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            //BranchSums(root);
            hasPathSum2(root);

            root = new TreeNode(0);
            root.left = new TreeNode(9);
            root.right = new TreeNode(1);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(10);
            root.right.right.left = new TreeNode(100);
            root.right.right.right = new TreeNode(200);

            //BranchSums(root);
            hasPathSum2(root);
        }

        public int[] PrisonAfterNDays(int[] cells, int days)
        {
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

        public string MostCommonWord(string paragraph, string[] banned)
        {
            // paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            // banned = new[] { "hit" };
            // 1. convert banned words to lower case
            // 2. split paragraph by space delimiter and convert to array
            // 3. iterate over each word in paragraph
            // 4. inspect each character and verify that it only contains letters, then return word
            // 5. if word is not banned, add it to dictionary if count  = 1
            // 6. if not banned and word already exists in dictionary, update the count by 1
            // 7. return word with highest count by sorting dictionary of words and sort by count, then return key

            var results = new Dictionary<string, int>();
            banned = banned.Select(s => s.ToLowerInvariant()).ToArray();

            var words = paragraph.Split(" ");
            foreach (var word in words)
            {
                var updatedWord = containsLetters(word);
                if (!banned.Contains(updatedWord))
                {
                    if (!results.ContainsKey(updatedWord))
                    {
                        results.Add(updatedWord, 1);
                    }
                    else
                    {
                        results[updatedWord] += 1;
                    }
                }
            }

            return results.OrderByDescending(x => x.Value).First().Key;
        }


        private string containsLetters(string word)
        {
            word = word.ToLower();
            var sb = new StringBuilder();

            foreach (char a in word)
            {
                if ((a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z'))
                {
                    sb.Append(a);
                }
            }

            return sb.ToString();
        }

        private static TestNode NewNode(int key)
        {
            var ptr = new TestNode
            {
                key = key,
                left = null,
                right = null
            };

            return ptr;
        }

        // Standard BST insert function  
        private static TestNode Insert(TestNode root, int key)
        {
            if (root == null)
                root = NewNode(key);
            else if (root.key > key)
                root.left = Insert(root.left, key);
            else if (root.key < key)
                root.right = Insert(root.right, key);

            return root;
        }

        // This function returns distance of x from  
        // root. This function assumes that x exists  
        // in BST and BST is not NULL.  
        private static int DistanceFromRoot(TestNode root, int x)
        {
            if (root.key == x)
                return 0;
            if (root.key > x)
                return 1 + DistanceFromRoot(root.left, x);

            return 1 + DistanceFromRoot(root.right, x);
        }

        // Returns minimum distance beween a and b.  
        // This function assumes that a and b exist  
        // in BST.  
        private static int DistanceBetween2(TestNode root, int a, int b)
        {
            while (true)
            {
                if (root == null) return 0;

                // Both keys lie in left  
                if (root.key > a && root.key > b)
                {
                    root = root.left;
                    continue;
                }

                // Both keys lie in right  
                if (root.key < a && root.key < b) // same path  
                {
                    root = root.right;
                    continue;
                }

                // Lie in opposite directions (Root is  
                // LCA of two nodes)  
                if (root.key >= a && root.key <= b) return DistanceFromRoot(root, a) + DistanceFromRoot(root, b);

                return 0;
            }
        }

        // This function make sure that a is smaller  
        // than b before making a call to findDistWrapper()  
        private static int FindDistWrapper(TestNode root, int a, int b)
        {
            if (a > b)
            {
                var temp = a;
                a = b;
                b = temp;
            }

            return DistanceBetween2(root, a, b);
        }

        public int MaxOfMinAltitude(int[,] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            var row = grid.GetLength(0);
            var column = grid.GetLength(1);

            var dp = new int[grid.GetLength(0), grid.GetLength(1)];

            // First entry is not considered
            dp[0, 0] = int.MaxValue;
            dp[row - 1, column - 1] = int.MaxValue;

            // Access first column 
            for (var i = 1; i < dp.GetLength(0); i++)
            {
                if (dp[i, 0] != int.MaxValue)
                {
                    //For first column grid, compare value from one above 
                    dp[i, 0] = Math.Min(dp[i - 1, 0], grid[i, 0]);
                }

            }

            //Access first row
            for (int j = 1; j < dp.GetLength(1); j++)
            {
                if (dp[0, j] != int.MaxValue)
                {
                    //For first row, compare value from one left
                    dp[0, j] = Math.Min(dp[0, j - 1], grid[0, j]);
                }

            }

            //Access inner matrix
            for (var i = 1; i < row; i++)
            {
                for (var j = 1; j < column; j++)
                {
                    if (i == row - 1 && j == column - 1)
                    {
                        //For last entry in matrix, it won't compare with itself and take max value from
                        //above or left
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                    else
                    {
                        //Score 1 is min value from current grid and left
                        var score1 = Math.Min(dp[i, j - 1], grid[i, j]);
                        var score2 = Math.Min(dp[i - 1, j], grid[i, j]);
                        dp[i, j] = Math.Max(score1, score2);
                    }
                }
            }

            return dp[row - 1, column - 1] == int.MaxValue ? 0 : dp[row - 1, column - 1];
        }

        public int MaxAvailableDiskSpace(int numComputer, int[] hardDiskSpace, int segmentLength)
        {
            //https://leetcode.com/problems/sliding-window-maximum/solution/
            // In this array of computers, the subarrays of size 2 are [8,2] and [2,4].
            // Thus, the initial analysis returns 2 and 2 because those are the minimal for the segments.
            // Finally the maximum of these values is 2.
            // Therefore, the answer is 2.

            var n = hardDiskSpace.Length;
            var k = segmentLength;

            var left = new int[n];
            var right = new int[n];
            left[0] = hardDiskSpace[0];
            right[n - 1] = hardDiskSpace[n - 1];

            for (var i = 1; i < n; i++)
            {
                if (i % k == 0)
                    left[i] = hardDiskSpace[i];
                else
                    left[i] = Math.Min(left[i - 1], hardDiskSpace[i]);

                var j = n - i - 1;
                if ((j + 1) % k == 0)
                    right[j] = hardDiskSpace[j];
                else
                    right[j] = Math.Min(right[j + 1], hardDiskSpace[j]);
            }

            var answer = new List<int>();
            for (var i = 0; i + k - 1 < n; i++)
            {
                var currentVal = Math.Min(right[i], left[i + k - 1]);
                answer.Add(currentVal);
            }

            return answer.Concat(new[] {0}).Max();
        }

        public int BaseBallScoreKeeping(string[] ops)
        {
            // blocks = new[] {"10", "20", "X", "+"}";
            // 1. In case of an an integer that that value is added to the total
            // 2. if the value is "+", add the sum of the last two scores to top of stack, pop last one, peek previous then add values back
            // 3. if the value is "X", double the last value then add to stack
            // 4. if the value is "Z" pop the last one of stack
            // 5. return the sum of all values in stack

            var stack = new Stack<int>();

            foreach (var op in ops)
            {
                if (op.Equals("+"))
                {
                    var top = stack.Pop();
                    var newtop = top + stack.Peek();
                    stack.Push(top);
                    stack.Push(newtop);
                }
                else if (op.Equals("X"))
                {
                    stack.Push(2 * stack.Peek());
                }
                else if (op.Equals("Z"))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(int.Parse(op));
                }
            }

            return stack.Sum();
        }

        public int MaxProfit(List<int> inventory, int orders)
        {
            // input: inventory = new List<int> { 2, 8, 4, 10, 6 }, order = 20
            // 1. Iterate through inventory and and add price and increment count by 1 for each item that appears 1 or more times
            // 2. Get the current maximum price from that dictionary
            // 3. while the orders are greater than zero, get the minimum between orders and current max from dictionary 
            // 4. multiply current max by the minimum value above and add that to a result
            // 5. decrement orders by minimum value
            // 6. decrement currentMax from dictionary by min value
            // 7. if dictionary contains "current max - 1", update current value with min value. Otherwise, add it with min value
            // 8. if dictionary entry's value with current max equal to zero, then remove it and decrement current max by 1
            // 9. When all orders reach zero, return the result

            var profit = new Dictionary<int, int>();

            foreach (var price in inventory)
            {
                if (profit.ContainsKey(price))
                    profit[price] = profit[price] + 1;
                else
                    profit.Add(price, 1);
            }

            var currentMax = profit.Select(x => x).Max(x => x.Key);

            var result = 0;
            while (orders > 0)
            {
                var maxi = Math.Min(orders, profit[currentMax]);
                result += currentMax * maxi;
                orders -= maxi;

                profit[currentMax] -= maxi;

                if (profit.ContainsKey(currentMax - 1))
                    profit[currentMax - 1] = profit[currentMax - 1] + maxi;
                else
                    profit.Add(currentMax - 1, maxi);

                if (profit[currentMax] == 0)
                {
                    profit.Remove(currentMax);
                    currentMax -= 1;
                }
            }

            return result;
        }


        public static int maxTenureNode;
        public static Pair maxSum;


        public Pair FindHighestTenure(Dictionary<int, List<int>> hmap, int V)
        {
            if (hmap[V].Count == 0)
            {
                return new Pair(1, V);
            }

            var totalNodesCount = 1;
            var totalSum = V;
            for (var i = 0; i < hmap[V].Count; i++)
            {
                var temp = FindHighestTenure(hmap, hmap[V][i]);
                totalNodesCount += temp.totalNodes;
                totalSum += temp.totalSum;
            }

            if (totalSum * maxSum.totalNodes >= maxSum.totalSum * totalNodesCount)
            {
                // logic to avoid precision error
                maxSum.totalNodes = totalNodesCount;
                maxSum.totalSum = totalSum;
                maxTenureNode = V;
            }

            return new Pair(totalNodesCount, totalSum);
        }

        public List<string> NearestCities(int numOfCities, List<string> cities, List<int> xCoordinates,
            List<int> yCoordinates, int numOfQueries, List<string> queries)
        {
            var cityMap = new Dictionary<string, City>();
            var xMap = new Dictionary<int, HashSet<string>>();
            var yMap = new Dictionary<int, HashSet<string>>();

            for (var i = 0; i < numOfCities; i++)
            {
                var city = new City
                {
                    name = cities[i],
                    x = xCoordinates[i],
                    y = yCoordinates[i]
                };

                cityMap.Add(city.name, city);

                if (!xMap.ContainsKey(city.x))
                    xMap.Add(city.x, new HashSet<string> {city.name});
                else
                    xMap[city.x].Add(city.name);

                if (!yMap.ContainsKey(city.y))
                    yMap.Add(city.y, new HashSet<string> {city.name});
                else
                    yMap[city.y].Add(city.name);
            }

            var result = new List<string>();
            foreach (var query in queries)
            {
                var city = cityMap[query];

                var set = new HashSet<string>();
                set.UnionWith(xMap[city.x]);
                set.UnionWith(yMap[city.y]);

                var minDist = int.MaxValue;
                var str = "";
                foreach (var cityName in set)
                {
                    var c = cityMap[cityName];
                    var dist = Dist(city, c);
                    if (!cityName.Equals(query) && dist <= minDist)
                    {
                        if (dist < minDist)
                            str = c.name;
                        else if (dist == minDist && string.Compare(str, c.name, StringComparison.Ordinal) > 0)
                            str = c.name;

                        minDist = dist;
                    }
                }

                result.Add(str.Length > 0 ? str : "None");
            }

            return result;
        }

        private static int Dist(City c1, City c2)
        {
            return (c2.x - c1.x) * (c2.x - c1.x) + (c2.y - c1.y) * (c2.y - c1.y);
        }

        public int ZombieInaMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return -1;

            var queue = new Queue<int[]>();
            var target = matrix.GetLength(0) * matrix.GetLength(1);
            var humanCount = 0;
            var days = 0;

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        queue.Enqueue(new[] {i, j});
                        humanCount++;
                    }
                }
            }

            int[,] directions = {{0, 1}, {0, -1}, {1, 0}, {-1, 0}};
            while (queue.Any() && humanCount > 0)
            {
                var queueSize = queue.Count;

                if (humanCount == target)
                    return days;

                for (var i = 0; i < queueSize; i++)
                {
                    var current = queue.Dequeue();
                    for (var j = 0; j < directions.GetLength(0); j++)
                    {
                        var newX = current[0] + directions[j, 0];
                        var newY = current[1] + directions[j, 1];

                        if (newX >= 0 && newX < matrix.GetLength(0) && newY >= 0
                            && newY < matrix.GetLength(1) && matrix[newX, newY] == 0)
                            // when the new coordinates doesn't exceed the boundaries of the matrix or the new valid coordinate is a human, only then turn that to a zombie
                        {
                            humanCount++;
                            queue.Enqueue(new[]
                            {
                                newX, newY
                            }); // now that new coordinate is a zombie, add that to the queue so it can be processed in the next level
                            matrix[newX, newY] = 1;
                        }
                    }
                }

                days++;
            }

            return -1;
        }

        double max;
        Node maxNode;

        public Node GetMaximumAverage(Node root)
        {
            maxNode = null;
            max = double.MinValue;

            //Helper(root);
            ComputeAvg(root);
            return maxNode;
        }

        public int[] ComputeAvg(Node root)
        {
            if (root == null) return new int[] {0, 0};
            int val = root.val, count = 1;

            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    int[] arr = ComputeAvg(child);
                    val += arr[0];
                    count += arr[1];
                }
            }

            if (count > 1 && (maxNode == null || val / (0.0 + count) > max))
            {
                maxNode = root;
                max = val / (0.0 + count);
            }

            return new int[] {val, count};
        }

        public double[] Helper(Node root)
        {
            if (root == null) return new double[] {0, 0};
            double count = 1;
            double sum = root.val;

            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    var cur = Helper(child);
                    sum += cur[0];
                    count += cur[1];
                }
            }

            var average = sum / count;
            if (count > 1 && average > max)
            {
                max = average;
                maxNode = root;
            }

            return new[] {sum, count};
        }


        public int LoadBalancer(int[] array)
        {
            // 1. create two pointers (i, j) for array. One starting at second element and one starting at second to last element
            // 2. create a begin sub array with index 0 and first index i.
            // 3. pass both values into another method to get total of sub array or substring between both indexes
            // 4. create a middle sub array with index i + 1 and j - 1 to get elements in between current elements of array.
            // 5. pass both values into another method to get total of sub array or substring between both indexes
            // 6. create an end sub array with index j and length of array to get elements after current second element of array.
            // 7. pass both values into another method to get total of sub array or substring between both indexes
            // 8. check if all three total equal each other. If they do, then return total
            // 9. otherwise repeat process and increment i and decrement j until i = j

            var i = 1;
            var j = array.Length - 2;

            while (i < j)
            {
                var element1 = array[i];
                var element2 = array[j];

                var begin = new int[] {0, i};
                var total1 = GetTotal(array, begin[0], begin[1]);
                var middle = new int[] {i + 1, j - 1};
                var total2 = GetTotal(array, middle[0], middle[1]);
                var end = new int[] {j, array.Length};
                var total3 = GetTotal(array, end[0], end[1]);

                if (total1 == total2 && total2 == total3)
                {
                    return total3;
                }

                i++;
                j--;
            }

            return 0;
        }


        private int GetTotal(int[] array, int left, int right)
        {
            var count = 0;
            while (left < right || left == 0)
            {
                count += array[left];
                left++;
            }

            return count;
        }

        public Dictionary<string, IList<string>> FavoriteGenres(Dictionary<string, IList<string>> userMap,
            Dictionary<string, IList<string>> genreMap)
        {
            // name, genres
            var result = new Dictionary<string, IList<string>>();

            // songName, genres
            var songsToGenre = new Dictionary<string, IList<string>>();

            // Initialize songsToGenre
            foreach (var (genre, songs) in genreMap)
            {
                var songList = genreMap[genre];
                foreach (var song in songList)
                {
                    if (songsToGenre.ContainsKey(song))
                    {
                        songsToGenre[song].Add(genre); // add a new genre to the list.
                    }
                    else
                    {
                        var songGenres = new List<string>(); // initialize list of songs, and add to list
                        songGenres.Add(genre);
                        songsToGenre.Add(song, songGenres);
                    }
                }
            }

            // Iterate through userMap, lookup song, and keep a running count for each genre that appears for each song.
            foreach (var (user, songs) in userMap)
            {
                var favoriteSongs = userMap[user];

                // <Genre, Count>
                var genreCount = new Dictionary<string, int>();
                var maxCount = 0;
                var favoriteGenres = new List<string>();

                foreach (var song in favoriteSongs)
                {
                    if (songsToGenre.ContainsKey(song))
                    {
                        // Loop through every genre, iterate the count. While we iterate, we check if it's the max value.
                        var genresInSong = songsToGenre[song];
                        foreach (var genre in genresInSong)
                        {
                            if (genreCount.ContainsKey(genre))
                            {
                                genreCount[genre] = genreCount[genre] + 1; // just iterate by 1

                                // if the getCount is the same as the maxCount, go ahead and add it in to the list.
                                if (maxCount == genreCount[genre])
                                {
                                    favoriteGenres.Add(genre);
                                }
                                // otherwise, clear the favorite genre list, and update the list. 
                                else if (maxCount < genreCount[genre])
                                {
                                    favoriteGenres.Clear();
                                    maxCount = genreCount[genre];
                                    favoriteGenres.Add(genre);
                                }
                            }
                            else
                            {
                                genreCount.Add(genre, 1);
                            }
                        }
                    }
                }

                result.Add(user, favoriteGenres);
            }

            return result;
        }

        public int TreasureIsland(char[,] grid)
        {
            // Init the queue
            var answer = 1;
            var queue = new Queue<int[]>();
            queue.Enqueue(new[] {0, 0});

            // Traverse the grid using BFS and keep track of the level
            var visited = new bool[grid.GetLength(0), grid.GetLength(1)];
            visited[0, 0] = true;
            int[,] dirs = {{0, 1}, {1, 0}, {0, -1}, {-1, 0}};

            while (queue.Count > 0)
            {
                var size = queue.Count;
                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    for (var j = 0; j < dirs.GetLength(0); j++)
                    {
                        var row = current[0] + dirs[j, 0];
                        var column = current[1] + dirs[j, 1];
                        if (row >= grid.Length || row < 0 || column >= grid.GetLength(1) || column < 0 ||
                            grid[row, column] == 'D' || visited[row, column])
                            continue;

                        if (grid[row, column] == 'X') return answer;

                        queue.Enqueue(new[] {row, column});
                        visited[row, column] = true;
                    }
                }

                answer++;
            }

            return -1;
        }

        public int[] rotLeft(int[] a, int d)
        {

            var count = d;
            int temp = a[0];
            for (int i = 0; i < a.Length; i++)
            {

                if (count > 0)
                {
                    temp = a[i];
                    a[i] = a[i + 1];
                    a[a.Length - 1] = temp;
                }

                count--;
            }

            return a;
        }

        public int RollDice(int[] array)
        {
            var minFlipCount = 9999999;

            foreach (var value in array)
            {
                var flipCount = 0;
                foreach (var i in array)
                {
                    if (value == i)
                        flipCount += 0;

                    else if (value + i == 7)
                        flipCount += 2;

                    else
                        flipCount += 1;
                }

                if (flipCount < minFlipCount)
                    minFlipCount = flipCount;
            }

            return minFlipCount;
        }


        public int UniqueLetterString(string s)
        {
            var index = new Dictionary<char, List<int>>();
            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (!index.ContainsKey(ch))
                    index.Add(ch, new List<int> {i});
                else
                    index[ch].Add(i);
            }

            long answer = 0;
            foreach (var list in index.Values)
            {
                for (var i = 0; i < list.Count; i++)
                {
                    long prev = i > 0 ? list.ElementAt(i - 1) : -1;
                    long next = i < list.Count - 1 ? list.ElementAt(i + 1) : s.Length;
                    answer += (list.ElementAt(i) - prev) * (next - list.ElementAt(i));
                }
            }

            return (int) answer % 1_000_000_007;
        }

        public IList<int> FindAnagrams(string s, string p)
        {
            var ns = s.Length;
            var np = p.Length;

            var result = new List<int>();

            if (ns < np) return result;

            var pCount = new int[26];
            var sCount = new int[26];

            // build reference array using string p
            foreach (var ch in p.ToCharArray())
                pCount[ch - 'a']++;

            // sliding window on the string s
            for (var i = 0; i < ns; i++)
            {
                // add one more letter 
                // on the right side of the window
                sCount[s[i] - 'a']++;

                // remove one letter 
                // from the left side of the window
                if (i >= np)
                    sCount[s[i - np] - 'a']--;

                // compare array in the sliding window
                // with the reference array
                if (pCount.SequenceEqual(sCount))
                    result.Add(i - np + 1);
            }

            return result;

        }

        public IList<string> RemoveDuplicateIPv4Addresses(string[] ipv4AddressList)
        {
            if (ipv4AddressList.Length == 0)
                return ipv4AddressList;

            Array.Sort(ipv4AddressList);

            var i = 0;
            for (var j = 1; j < ipv4AddressList.Length; j++)
            {
                if (!ipv4AddressList[j].Equals(ipv4AddressList[i]))
                {
                    i++;
                    ipv4AddressList[i] = ipv4AddressList[j];
                }
            }

            return ipv4AddressList;
        }

        public int CountNumberInSortedArray(int[] array, int target)
        {
            var left = 0;
            var right = array.Length - 1;

            var result = 0;
            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else if (array[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    result = mid;
                    right = mid - 1;
                }
            }

            return CountNum(array, result, target);
        }

        private static int CountNum(int[] array, int mid, int target)
        {
            var count = 0;
            for (var i = mid; i < array.Length; i++)
            {
                if (array[i] == target)
                    count++;
                else
                    break;
            }

            return count;
        }


        public int ShortestWordDistance(List<string> words, string word1, string word2)
        {
            var m = -1;
            var n = -1;

            var minDifference = int.MaxValue;
            for (var i = 0; i < words.Count; i++)
            {
                var word = words[i];
                if (word1.Equals(word))
                {
                    m = i;
                    if (n != -1)
                        minDifference = Math.Min(minDifference, m - n);
                }
                else if (word2.Equals(word))
                {
                    n = i;
                    if (m != -1)
                        minDifference = Math.Min(minDifference, n - m);
                }
            }

            return minDifference;
        }

        public bool SecretFruitList(List<IList<string>> secretFruitLists, List<string> customerPurchasedList)
        {
            var i = 0;
            var j = 0;
            var fruitLen = secretFruitLists.Count;
            var purchaseLen = customerPurchasedList.Count;

            var result = new bool[fruitLen];

            while (i < purchaseLen)
            {
                while (j < fruitLen)
                {
                    var k = 0;
                    while (k < secretFruitLists[j].Count)
                    {
                        // end of shopping list, break out of both loops
                        if (i == purchaseLen)
                        {
                            j = fruitLen;
                            break;
                        }

                        // try to match item in shopping list to code list[j]
                        if (customerPurchasedList[i].Equals(secretFruitLists[j][k]) ||
                            secretFruitLists[j][k].Equals("anything"))
                            k++;
                        else
                            // match not found, reset k
                            k = 0;

                        i++;
                    }

                    // ensure order and mark visited
                    if (j < fruitLen && k == secretFruitLists[j].Count)
                    {
                        result[j] = true;
                        j++;
                    }
                }

                i++;
            }

            return result.All(x => x);
        }

        /*public bool SecretFruitList(List<IList<string>> secretFruitLists, List<string> customerPurchasedList)
        {
            var j = 0;
            var matchCounter = 0;
            foreach (var secretFruitList in secretFruitLists)
            {
                var i = 0;
                while(i < secretFruitList.Count)
                {
                    while (j < customerPurchasedList.Count)
                    {
                        if (i == secretFruitList.Count)
                            break;

                        if (secretFruitList[i].Equals("anything") ||
                            secretFruitList[i].Equals(customerPurchasedList[j]))
                        {
                            matchCounter++;
                            i++;
                        }
                        else
                            matchCounter--;
                        j++;
                    }
                }
            }

            return secretFruitLists.SelectMany(list => list).Count() == matchCounter;
        }*/

        public IList<string> PartitionLabelsReturnSubStrings(string S)
        {
            var last = new int[26];
            for (var i = 0; i < S.Length; i++)
                last[S[i] - 'a'] = i;

            var start = 0;
            var end = 0;
            var answer = new List<string>();

            long val = 2222;
            long result;
            long.TryParse(val.ToString(), out result);
            val = val++;

            for (var i = 0; i < S.Length; i++)
            {
                end = Math.Max(end, last[S[i] - 'a']);
                if (i == end)
                {
                    // partition found
                    answer.Add(S.Substring(start, end - start + 1)); // add + 1 to get length of substring
                    start = end + 1; // move onto new partition once we have added length to current partition
                }
            }

            return answer;
        }

        public IList<int> PartitionLabels(string S)
        {
            var last = new int[26];
            for (var i = 0; i < S.Length; i++)
            {
                last[S[i] - 'a'] = i;
            }

            var start = 0;
            var end = 0;
            var answer = new List<int>();

            for (var i = 0; i < S.Length; i++)
            {
                end = Math.Max(end, last[S[i] - 'a']);
                if (i == end)
                {
                    // partition found
                    answer.Add(end - start + 1); // add + 1 to get length of substring
                    start = end + 1; // move onto new partition once we have added length to current partition
                }
            }

            return answer;
        }

        public int NumberOfIslands(char[,] grid)
        {
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

        public List<string> TopNBuzzwords(int numToys, int topToys, List<string> toys, int numQuotes,
            List<string> quotes)
        {
            var toySet = new HashSet<string>(toys.ToList());

            var freqMap = new Dictionary<string, int>();
            var sentenceMap = new Dictionary<string, HashSet<int>>();

            foreach (var toy in toys)
            {
                freqMap.Add(toy, 0);
                sentenceMap.Add(toy, new HashSet<int>());
            }

            for (var i = 0; i < quotes.Count; i++)
            {
                var res = new string(quotes[i].Where(c => !char.IsPunctuation(c)).ToArray());
                var words = res.ToLower().Split(" ");
                foreach (var word in words)
                {
                    if (!toySet.Contains(word))
                        continue;

                    if (freqMap.ContainsKey(word))
                        freqMap[word] = freqMap[word] + 1;

                    if (sentenceMap.ContainsKey(word))
                        sentenceMap[word].Add(i);
                }
            }

            var toyList = toys.Select(toy => new Toy(toy, freqMap[toy], sentenceMap[toy].Count)).ToArray();

            Array.Sort(toyList,
                (p1, p2) => p1.freq != p2.freq ? p2.freq - p1.freq :
                    p2.sentenceCnt != p1.sentenceCnt ? p2.sentenceCnt - p1.sentenceCnt :
                    string.Compare(p1.name, p2.name, StringComparison.Ordinal));

            var result = new List<string>();
            var count = topToys;
            var idx = 0;

            while (count > 0 && idx < toyList.Length)
            {
                result.Add(toyList[idx].name);
                idx++;
                count--;
            }

            return result;
        }


        public int[] MoviesOnAFlight(int flightLength, int[] movieTimes)
        {
            var target = flightLength - 30;
            var indexMap = new Dictionary<int, int>(movieTimes.Length);

            for (var i = 0; i < movieTimes.Length; i++)
                indexMap.Add(movieTimes[i], i);

            Array.Sort(movieTimes);

            var max = 0;
            var pairIdx1 = 0;
            var pairIdx2 = 0;

            var left = 0;
            var right = movieTimes.Length - 1;

            while (left < right)
            {
                var sum = movieTimes[left] + movieTimes[right];

                if (sum <= target)
                {
                    if (sum == max)
                    {
                        // This is a check for which pair has the highest length. Since array is sorted, 
                        //movie length order is equivalent to index order and Since i<j && l<h
                        if (pairIdx2 < right)
                        {
                            pairIdx1 = left;
                            pairIdx2 = right;
                        }
                    }

                    if (sum > max)
                    {
                        max = sum;
                        pairIdx1 = left;
                        pairIdx2 = right;
                    }

                    left++;
                }
                else right--;
            }

            return new[] {indexMap[movieTimes[pairIdx1]], indexMap[movieTimes[pairIdx2]]};

        }
        /*public int[] MoviesOnAFlight(int flightLength, int[] movieLengths)
        {
            if (movieLengths.Length == 0)
                return new[] {-1, -1};

            var result = new List<int>();
            var currentMax = int.MinValue;

            var dictionary = movieLengths.ToDictionary(movieLength => movieLength,
                movieLength => Array.IndexOf(movieLengths, movieLength));

            for (var i = 0; i < movieLengths.Length; i++)
            {
                var matchingMovieLength = flightLength - 30 - movieLengths[i];
                //if (dictionary.Values(x => x <= matchingMovieLength))
                var value = 0;
                if(dictionary.Count > 0)
                    value = dictionary.Count > 0 ? dictionary.Keys.FirstOrDefault(key => key <= matchingMovieLength) : 0;
                
                if (value > 0)
                {
                    var max = Math.Max(matchingMovieLength, movieLengths[i]);
                    if (max > currentMax)
                    {
                        currentMax = max;
                        result = new List<int> {i, dictionary[matchingMovieLength]};
                    }
                }

                dictionary[movieLengths[i]] = i;
            }

            return result.ToArray();
        }*/

        private static List<string> GetTopKFrequent(int k, string[] keywords, string[] reviews)
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

        public string[] ReorderLogFiles2(string[] logs)
        {
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

        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            // keyword search
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

        public int FindTheLongestSubstring(string s)
        {
            var count = 0;
            var result = 0;

            var vowelList = new List<char>
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };

            char[] str = s.ToCharArray();
            foreach (var ch in s)
            {
                if (vowelList.Contains(ch))
                    count++;
                else
                {
                    result = Math.Max(result, count);
                    count = 0;
                }
            }

            return result;
        }

        public int FindTheLongestSubstringEventCountVowels(string s)
        {
            var vowelList = new Dictionary<char, int>
            {
                {'a', 1},
                {'e', 2},
                {'i', 4},
                {'o', 8},
                {'u', 16}
            };

            var seen = new Dictionary<int, int> {{0, -1}};
            int maxSubStrLen = 0, current = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (vowelList.ContainsKey(s[i]))
                    current ^= vowelList[s[i]];

                if (seen.ContainsKey(current))
                    maxSubStrLen = Math.Max(maxSubStrLen, i - seen[current]);
                else
                    seen.Add(current, i);

            }

            return maxSubStrLen;
        }

        public int MissingNumber(int[] nums)
        {
            var ddd = "2";
            int.Parse(ddd);
            Array.Sort(nums);

            var left = 0;
            var right = nums.Length;
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (nums[mid] > mid)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return right;
        }

        public bool WordBreak(string s, IList<string> wordDict)
        {
            var wordDictSet = new HashSet<string>(wordDict);
            var dp = new bool[s.Length + 1];
            dp[0] = true;

            for (var i = 1; i <= s.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    var subStr = s.Substring(j, i - j);
                    if (dp[j] && wordDictSet.Contains(subStr))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }

        public int ShortestDistance(string[] words, string word1, string word2)
        {
            HashSet<int> numSet = new HashSet<int>();

            var dictionary = new Dictionary<int, string>();

            for (var i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(word1) || words[i].Equals(word2))
                {
                    if (!dictionary.ContainsKey(i))
                    {
                        dictionary.Add(i, words[i]);
                    }
                }
            }

            var minDistance = int.MaxValue;

            var distance1 = int.MaxValue;
            var distance2 = int.MaxValue;
            foreach (var (key, value) in dictionary)
            {
                if (value == word1)
                {
                    distance1 = key;
                }

                if (value == word2)
                {
                    distance2 = key;
                }

                if (distance1 < int.MaxValue && distance2 < int.MaxValue)
                {
                    var absoluteVal = Math.Abs(distance1 - distance2);
                    if (absoluteVal < minDistance)
                    {
                        minDistance = absoluteVal;
                    }
                }

            }

            return minDistance;
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {

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

            var fff = answer.Values;

            var flattenList = answer.SelectMany(x => x.Value);
            var dddd = int.MaxValue.ToString();
            flattenList.ToList();
            //flattenList.ToList().
            result.Add(flattenList.ToList());

            return result;

        }

        public bool IsHappy(int n)
        {
            double total = 0;
            var result = BuildNumberList(n);
            foreach (var value in result)
            {
                var squared = Math.Pow(value, 2);
                total += squared;
            }

            if (total == 1)
                return true;

            if (total > 1)
                return IsHappy((int) total);

            return false;

        }

        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int reversed = 0, remainder, original = x;

            while (x != 0)
            {
                remainder = x % 10; // reversed integer is stored in variable
                reversed = reversed * 10 +
                           remainder; //multiply reversed by 10 then add the remainder so it gets stored at next             decimal place.
                x /= 10; //the last digit is removed from x after division by 10.
            }

            // palindrome if original and reversed are equal
            return original == reversed;
        }


        private int[] BuildNumberList(int n)
        {
            string temp = n.ToString();
            var newGuess = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                newGuess[i] = temp[i] - '0';
            }

            return newGuess;
        }


        public string[] ReorderLogFiles(string[] logs)
        {

            var numLogs = new List<string>();
            //var letterLogs = new List<string>();
            var letterLogs = new List<Log>();

            foreach (var logEntry in logs)
            {
                var space = logEntry.IndexOf(" ", StringComparison.Ordinal);
                var id = logEntry.Substring(0, space);
                var log = logEntry.Substring(space + 1);

                if (log[0] >= '0' && log[0] <= '9')
                {
                    numLogs.Add(logEntry);
                }
                else
                {
                    letterLogs.Add(new Log(id, log));
                }
            }

            letterLogs.Sort((a, b) => string.Compare(a.LogEntry, b.LogEntry, StringComparison.Ordinal));
            //var updatedletterlogs = from a in letterLogs.Skip(1) orderby a select a;
            //var updatedLetterLogs = letterLogs.Select(x => x)
            //    .OrderBy(x => x.Length).ThenBy(x => x.Split(" ").Skip(1).Take(x.Length - 1).FirstOrDefault());

            //Array.Sort(letterLogs.ToArray(), (s1, s2) => string.Compare(s1.Split()[1], s2.Split()[1], StringComparison.Ordinal));
            var answer = new string[logs.Length];

            var j = 0;
            foreach (var letterLog in letterLogs)
            {
                answer[j++] = letterLog.Id + " " + letterLog.LogEntry;
            }

            foreach (var digitLog in numLogs)
            {
                answer[j++] = digitLog;
            }

            return answer;

            //return letterLogs.Concat(numLogs).ToArray();
        }

        public void CheckSameInOrderTraversal()
        {
            /* Given two binary trees, determine whether
               they have the same in-order traversal

                 Tree 1                    Tree 2
                    5                         3      
                  /   \                     /   \                    
                 3     7                   1     6
                /     /                        /   \
               1     6                        5     7
                   
            Time Complexity: O(n + m)
            Space Complexity: O(n + m)
                                           
             */

            TreeNode tree1 = new TreeNode(5);
            tree1.left = new TreeNode(3);
            tree1.left.left = new TreeNode(1);
            tree1.right = new TreeNode(7);
            tree1.right.left = new TreeNode(6);

            TreeNode tree2 = new TreeNode(3);
            tree2.left = new TreeNode(1);
            tree2.right = new TreeNode(6);
            tree2.right.left = new TreeNode(5);
            tree2.right.right = new TreeNode(7);

            List<int> list = new List<int>();

            InOrder(tree1, list);
            var val = InOrderCheck(tree2, list);

            var isSameOrder = val && list.Count == 0;
        }

        private static bool InOrderCheck(TreeNode root, List<int> list)
        {
            if (root == null) return true;

            // if check is returning false, then entire method returns false
            if (!InOrderCheck(root.left, list))
                return false;

            // if list is empty of current element is not equal to first element in list return false
            if (list.Count == 0 || list.ElementAt(0) != root.val)
                return false;

            // remove from top of list
            list.RemoveAt(0);

            // recurse on right part of tree
            return InOrderCheck(root.right, list);
        }

        private static void InOrder(TreeNode root, List<int> list)
        {
            if (root == null) return;

            // recurse on left part of tree
            InOrder(root.left, list);

            // add current node value to list
            list.Add(root.val);

            // recurse on right part of tree
            InOrder(root.right, list);
        }

        public int MaxDepthRecursion(TreeNode root)
        {
            // Space and Time Complexity: O(n) | O(n)

            if (root == null)
                return 0;

            int leftHeight = MaxDepthRecursion(root.left);
            int rightHeight = MaxDepthRecursion(root.right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public int MinDepthIteration(TreeNode root)
        {
            // Space and Time Complexity: O(n) | O(n)

            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var currentDepth = 0;
            while (queue.Any())
            {
                // increment current depth
                currentDepth++;

                // get count of queue items
                int size = queue.Count();

                for (int i = 0; i < size; i++)
                {
                    // remove first item from queue
                    TreeNode current = queue.Dequeue();

                    // break from loop since we reached a leaf node, which will return min depth
                    if (current.left == null && current.right == null)
                        return currentDepth;

                    // otherwise, if there is a left child node, then add to queue
                    if (current.left != null)
                        queue.Enqueue(current.left);

                    // otherwise, if there is a right child node, then add to queue
                    if (current.right != null)
                        queue.Enqueue(current.right);
                }
            }

            return currentDepth;
        }

        public int MaxDepthIteration(TreeNode root)
        {
            // Space and Time Complexity: O(n) | O(n)

            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<int> depths = new Stack<int>();

            if (root == null)
                return 0;

            stack.Push(root);
            depths.Push(1);

            int depth = 0;
            int currentDepth = 0;

            while (stack.Any())
            {
                // get last item from TreeNode stack
                root = stack.Pop();

                // get last item from TreeNode Depth stack
                currentDepth = depths.Pop();

                if (root != null)
                {
                    // get the max depth from current and existing depth
                    depth = Math.Max(depth, currentDepth);

                    // add left and right tree nodes to stack
                    stack.Push(root.left);
                    stack.Push(root.right);

                    // add new depth to depth stack
                    depths.Push(currentDepth + 1);
                    depths.Push(currentDepth + 1);
                }
            }

            // return depth
            return depth;

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
            }

            return result;
        }

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {

            List<IList<int>> result = new List<IList<int>>();
            Dictionary<int, List<int>> items = new Dictionary<int, List<int>>();

            if (root == null)
                return result;

            int level = 0;
            Queue<KeyValuePair<int, TreeNode>> queue = new Queue<KeyValuePair<int, TreeNode>>();
            queue.Enqueue(KeyValuePair.Create(0, root));

            while (queue.Any())
            {

                var current = queue.Dequeue();
                root = current.Value;
                level = current.Key;

                if (root != null)
                {
                    if (!items.ContainsKey(level))
                    {
                        items.Add(level, new List<int>());
                    }

                    items[level].Add(root.val);

                    if (root.left != null)
                    {
                        queue.Enqueue(KeyValuePair.Create(level + 1, root.left));
                    }

                    if (root.right != null)
                    {
                        queue.Enqueue(KeyValuePair.Create(level + 1, root.right));
                    }
                }
            }

            LinkedList<List<int>> results = new LinkedList<List<int>>();
            //if (root == null)
            // {
            //     return results;
            // }

            var output = new List<IList<int>>();
            var list = results.Select(x => x);
            //output.Add(fff);


            for (int i = items.Count - 1; i >= 0; i--)
            {
                result.Add(items[i]);
            }

            return result;
        }

        public IList<IList<int>> LevelOrderBottom2(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();

            LinkedList<IList<int>> result = new LinkedList<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            Stack<TreeNode> stack = new Stack<TreeNode>();
            var ff = stack.Last().val;
            //if(stack.Last())

            while (queue.Any())
            {

                int size = queue.Count();
                List<int> level = new List<int>();

                for (int i = 0; i < size; i++)
                {

                    root = queue.Dequeue();
                    level.Add(root.val);

                    if (root.left != null)
                    {
                        queue.Enqueue(root.left);
                    }

                    if (root.right != null)
                    {
                        queue.Enqueue(root.right);
                    }
                }


                result.AddFirst(level);

            }

            return result.ToList();

        }


        public bool IsBalanced(TreeNode root)
        {
            return IsBalancedTreeHelper(root).balanced;
        }

        // Return whether or not the tree at root is balanced while also storing
        // the tree's height in a reference variable.
        private TreeInfo IsBalancedTreeHelper(TreeNode root)
        {
            // An empty tree is balanced and has height = -1
            if (root == null)
            {
                return new TreeInfo(-1, true);
            }

            // Check subtrees to see if they are balanced.
            TreeInfo left = IsBalancedTreeHelper(root.left);

            if (!left.balanced)
                return new TreeInfo(-1, false);

            TreeInfo right = IsBalancedTreeHelper(root.right);

            if (!right.balanced)
            {
                return new TreeInfo(-1, false);
            }

            // Use the height obtained from the recursive calls to
            // determine if the current node is also balanced.
            if (Math.Abs(left.height - right.height) < 2)
            {
                return new TreeInfo(Math.Max(left.height, right.height) + 1, true);
            }

            return new TreeInfo(-1, false);
        }

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();

            if (root == null)
                return paths;

            LinkedList<TreeNode> nodeStack = new LinkedList<TreeNode>();
            LinkedList<string> pathStack = new LinkedList<string>();
            TreeNode node;
            string path;

            while (nodeStack.Any())
            {
                // get the last node added
                node = nodeStack.Last();
                nodeStack.RemoveLast();

                // get the last path added
                path = pathStack.Last();
                pathStack.RemoveLast();

                // if leaf node, add the current path to list
                if (node.left == null && node.right == null)
                    paths.Add(path);

                if (node.left != null)
                {
                    // if left child node is not null, add to node stack and path stack
                    nodeStack.AddFirst(node.left);
                    pathStack.AddFirst(path + "->" + node.left.val.ToString());
                }

                if (node.right != null)
                {
                    // if right child node is not null, add to node stack and path stack
                    nodeStack.AddFirst(node.right);
                    pathStack.AddFirst(path + "->" + node.right.val.ToString());
                }
            }

            double fff = -double.MaxValue;

            return paths;
        }

        public bool IsValidBST(TreeNode root)
        {
            // in order traversal
            Stack<TreeNode> stack = new Stack<TreeNode>();
            double inOrder = -double.MaxValue; // set to a negative max value

            // iterate through stack if there are items or root is not null
            while (stack.Any() || root != null)
            {
                while (root != null)
                {
                    // add root and left child nodes to stack until there are no child nodes
                    stack.Push(root);
                    root = root.left;
                }

                // pop the last child node from stack (right or left)
                root = stack.Pop();

                // if node value is less than previous one, return false
                if (root.val <= inOrder)
                    return false;

                // set inOrder to node value
                inOrder = root.val;

                // set right child node to root so it can be added to stack on next iteration
                root = root.right;
            }

            return true;

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

        public List<int> FindDuplicates(int[] nums)
        {
            List<int> answer = new List<int>();

            foreach (int num in nums)
            {
                if (nums[Math.Abs(num) - 1] < 0)
                {
                    answer.Add(Math.Abs(num));
                }

                nums[Math.Abs(num) - 1] *= -1;
            }

            return answer;
        }

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
                        int[] sumList = new int[] {array[i], array[left], array[right]};
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

        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {

            // Time Complexity: O(n)
            // Space Complexity: O(1)

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            int i = 0;
            int j = 0;
            int minDifference = int.MaxValue;
            int current = int.MaxValue;
            var result = new int[2];

            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                int firstNum = arrayOne[i];
                int secondNum = arrayTwo[j];

                if (firstNum < secondNum)
                {
                    // take absolute difference if first num less than second, then increment first index
                    current = secondNum - firstNum;
                    i++;
                }
                else if (secondNum < firstNum)
                {
                    // take absolute difference if second num less than second, then increment second index
                    current = firstNum - secondNum;
                    j++;
                }
                else
                {
                    // if they are both equal, we know we reached zero, so return both element of array
                    return new int[] {firstNum, secondNum};
                }

                if (minDifference > current)
                {
                    // if the current difference is less than min difference, update and also reallocate array
                    minDifference = current;
                    result = new int[] {firstNum, secondNum};
                }
            }

            return result;
        }

        public TreeNode InvertTree(TreeNode root)
        {
            // Time Complexity: O(n)
            // Space Compexity: O(n)

            if (root == null)
                return null;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {

                // dequeue root node
                TreeNode current = queue.Dequeue();

                // swap right and left nodes
                TreeNode temp = current.left;
                current.left = current.right;
                current.right = temp;

                if (current.left != null)
                {
                    // enqueue left node
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    // enqueue right node
                    queue.Enqueue(current.right);
                }
            }

            return root;
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            if (root == null)
                return root;

            // Stack for tree traversal
            Stack<TreeNode> stack = new Stack<TreeNode>();

            // HashMap for parent pointers
            Dictionary<TreeNode, TreeNode> parent = new Dictionary<TreeNode, TreeNode>();

            parent.Add(root, null);
            stack.Push(root);

            // Iterate until we find both the nodes p and q
            while (!parent.ContainsKey(p) || !parent.ContainsKey(q))
            {

                TreeNode current = stack.Pop();

                // While traversing the tree, keep saving the parent pointers.
                if (current.left != null)
                {
                    parent.Add(current.left, current);
                    stack.Push(current.left);
                }

                if (current.right != null)
                {
                    parent.Add(current.right, current);
                    stack.Push(current.right);
                }

            }

            // Ancestors set() for node p.
            HashSet<TreeNode> ancestors = new HashSet<TreeNode>();

            // Process all ancestors for node p using parent pointers.
            while (p != null)
            {
                ancestors.Add(p);
                p = parent[p];
            }

            // The first ancestor of q which appears in
            // p's ancestor set() is their lowest common ancestor.
            while (!ancestors.Contains(q))
                q = parent[q];

            return q;

        }

        public int[] ProductExceptSelf(int[] nums)
        {

            // Time Complexity: O(n)
            // Space Compexity O(1)

            // Final answer array to be returned
            int[] answer = new int[nums.Length];

            // answer[i] contains the product of all the elements to the left
            // Note: for the element at index '0', there are no elements to the left,
            // so the answer[0] would be 1
            answer[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {

                // answer[i - 1] already contains the product of elements to the left of 'i - 1'
                // Simply multiplying it with nums[i - 1] would give the product of all 
                // elements to the left of index 'i'
                answer[i] = nums[i - 1] * answer[i - 1];
            }

            // R contains the product of all the elements to the right
            // Note: for the element at index 'length - 1', there are no elements to the right,
            // so the R would be 1
            int right = 1;
            for (var i = nums.Length - 1; i >= 0; i--)
            {

                // For the index 'i', R would contain the 
                // product of all elements to the right. We update R accordingly
                answer[i] = answer[i] * right;
                right *= nums[i];
            }

            return answer;

        }

        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {

            // Time Complexity: O(n)
            // Space Complexity: O(1)

            int left = 0;
            int right = array.Count - 1;

            while (left < right)
            {
                if (array[right] == toMove)
                {
                    right--;
                }
                else if (array[left] != toMove)
                {
                    left++;
                }
                else
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }

            }

            // Write your code here.
            return array;
        }

        public static bool IsPalindrome(string str)
        {
            // Time Complexity: O(n)
            // Space Complexity: O(1)

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (!(str[left] >= 'a' && str[left] <= 'z') && !(str[right] >= 'a' && str[right] <= 'z'))
                    continue;

                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        public static string CaesarCypherEncryptor(string str, int key)
        {
            // O(n) time | O(n) space
            char[] newLetters = new char[str.Length];
            int newKey = key % 26;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < str.Length; i++)
            {
                newLetters[i] = GetNewLetter(str[i], newKey, alphabet);
            }

            return new string(newLetters);
        }

        private static char GetNewLetter(char letter, int key, string alphabet)
        {
            int newLetterCode = alphabet.IndexOf(letter) + key;
            return alphabet[newLetterCode % 26];
        }

        public static List<List<string>> GroupAnagrams(List<string> words)
        {
            // O(w * n * log(n)) time | o(wn) space - where w is the number of words and n is the length
            //of the longest word
            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                var charArray = word.ToCharArray();
                Array.Sort(charArray);
                var newWord = new string(charArray);

                if (!anagrams.ContainsKey(newWord))
                {
                    anagrams.Add(newWord, new List<string> {word});
                }
                else
                {
                    anagrams[newWord].Add(word);
                }
            }

            return anagrams.Values.ToList();
        }

        // O(n) time | O(1) space
        public static bool IsMonotonic(int[] array)
        {

            if (array.Length == 0 || array.Length == 1)
                return true;

            bool isNonDecreasing = true;
            bool isNonIncreasing = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    isNonDecreasing = false;

                if (array[i] > array[i - 1])
                    isNonIncreasing = false;
            }

            return isNonDecreasing || isNonIncreasing;
        }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {

            // 1. iterate through list
            // 2. then iterate through each character of word
            // 3. if difference in count is greater than 1, then there is not transformation
            // 4. record length until end word is reached

            //Use Breadth first search (BFS)

            // Convert to hashSet for O(1) constant time lookup
            HashSet<string> hSet = wordList.ToHashSet();

            // if endWord is not in set, then return 0
            if (!hSet.Contains(endWord))
                return 0;

            // create a queue starting with begin word
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);

            // level is used for length in BFS
            int level = 1;

            while (queue.Any())
            {
                // while queue is not empty, iterate through queue
                int size = queue.Count();
                for (var i = 0; i < size; i++)
                {
                    // pop first word from queue
                    string currentWord = queue.Dequeue();

                    // then convert word to char array
                    char[] word_chars = currentWord.ToCharArray();

                    for (var j = 0; j < word_chars.Length; j++)
                    {
                        // iterate through characters and set current character to original_char
                        char original_char = word_chars[j];

                        // iterate through alphabet
                        for (char c = 'a'; c < 'z'; c++)
                        {
                            // check if current character is equal to letter in alpha, then continue
                            if (word_chars[j] == c)
                                continue;
                            // otherwise set the letter in alphabet to current character
                            word_chars[j] = c;

                            // create new string from characters
                            string new_word = new string(word_chars);

                            // if the word is equal to end word, exit and return new level + 1
                            if (new_word.Equals(endWord))
                                return level + 1;

                            // otherwise, if hashSet contains new word
                            // add to queue to be processed and remove from hashset to avoid duplicates
                            if (hSet.Contains(new_word))
                            {
                                queue.Enqueue(new_word);
                                hSet.Remove(new_word);
                            }
                        }

                        // set current character back to original character to avoid unnecessary issues going forward
                        word_chars[j] = original_char;
                    }
                }

                // increment level on each iteration
                level++;
            }

            return 0;
        }

        public bool wordBreak(string s, List<string> wordDict)
        {
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

        public bool WordSearch(char[,] board, string word)
        {
            // https://www.youtube.com/watch?v=vYYNp0Jrdv0
            // Complexity: O(n) time | O(n) space

            // iterate through rows
            for (int row = 0; row < board.GetLength(0); row++)
            {
                // at the same time, iterate through columns
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    // check first character of word, then use dfs to traverse through board by passing in:
                    // board, row, column, count of letters and word
                    if (board[row, col] == word[0] && Dfs(board, row, col, 0, word))
                    {
                        // return true if all letters found
                        return true;
                    }
                }
            }

            // no match
            return false;

        }

        private bool Dfs(char[,] board, int row, int column, int count, string word)
        {
            // if the count is equal to word length return true
            if (count == word.Length)
                return true;

            // check if row and columns are out of bounds and if current board value not equals to character of word to search
            if (row < 0 || row >= board.GetLength(0) || column < 0 || column >= board.GetLength(1) ||
                board[row, column] != word[count])
                return false;

            // temporarily mark character on board to space since we cannot use it more than once
            char temp = board[row, column];
            board[row, column] = ' ';

            // use dfs to traverse through all adjecent directions on board while adding count
            bool found = Dfs(board, row + 1, column, count + 1, word)
                         || Dfs(board, row - 1, column, count + 1, word)
                         || Dfs(board, row, column + 1, count + 1, word)
                         || Dfs(board, row, column - 1, count + 1, word);

            // add back character to position
            board[row, column] = temp;

            // return whether it was found
            return found;
        }

        Dictionary<string, string> phoneMap = new Dictionary<string, string>();

        List<string> result = new List<string>();

        public List<string> LetterCombinations(string digits)
        {
            // Space and Time Complexity: O(3^N × 4^M) | O(3^N × 4^M)

            phoneMap.Add("2", "abc");
            phoneMap.Add("3", "def");
            phoneMap.Add("4", "ghi");
            phoneMap.Add("5", "jkl");
            phoneMap.Add("6", "mno");
            phoneMap.Add("7", "pqrs");
            phoneMap.Add("8", "tuv");
            phoneMap.Add("9", "wxyz");


            if (digits.Length != 0)
                // call backtrack if there are digits
                BackTrack("", digits);

            return result;
        }

        private void BackTrack(string combination, string nextDigits)
        {
            if (nextDigits.Length == 0)
                // if there are no more next digits add letter combination to result
                result.Add(combination);
            else
            {
                // otherwise get current digit of next digits
                string digit = nextDigits.Substring(0, 1);
                // get letter values associated with digit from map
                string letters = phoneMap[digit];

                for (int i = 0; i < letters.Length; i++)
                {
                    // iterate through letters and get next letter from phone map
                    string currentLetter = phoneMap[digit].Substring(i, 1);
                    // recursively call method with current combination, append current letter and next digit
                    BackTrack(combination + currentLetter, nextDigits.Substring(1));
                }
            }
        }

        Dictionary<char, char> map;

        public bool IsValidParenthesis(string s)
        {
            map = new Dictionary<char, char>();
            map.Add(')', '(');
            map.Add('}', '{');
            map.Add(']', '[');

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];

                if (map.ContainsKey(ch))
                {
                    char topElement = !stack.Any() ? '#' : stack.Pop();

                    if (topElement != map[ch])
                        return false;
                }
                else
                {
                    stack.Push(ch);
                }
            }

            return !stack.Any();
        }

        public string ReorganizeString(string s)
        {
            // Space and Time Complexity: O(n) | O(n)

            if (s == null || s.Length < 2)
                return s;

            int n = s.Length;

            // Calculate and store frequencies in char-frequency map.
            // Find character and frequency with max frequency
            int freqChar = -1;
            int freqCharCount = -1;
            int[] freq = new int[26];
            for (int i = 0; i < n; i++)
            {
                freq[s[i] - 'a']++;
                if (freq[s[i] - 'a'] > freqCharCount)
                {
                    freqCharCount = freq[s[i] - 'a'];
                    freqChar = s[i] - 'a';
                }
            }

            // Required string is only possible when char with max frequency is less than equal to half of size of given string.
            if (freqCharCount > (n + 1) / 2)
                return "";

            StringBuilder str = new StringBuilder(s);
            int position = 0;
            // In case it is possible, arrange the most occuring character on even positions. 
            // Arrange the remaining characters on alternate remaining positions. 
            // This makes sure that no 2 same character occurs together.
            for (int i = -1; i < 26; i++)
            {
                int current = i == -1 ? freqChar : i;
                while (freq[current]-- > 0)
                {
                    str[position] = (char) ('a' + current);
                    position = position + 2 >= n ? 1 : position + 2;
                }
            }

            return str.ToString();
        }

        public bool RotateString(string A, string B)
        {

            if (A.Length == 0 && B.Length == 0)
                return true;

            int i = 0;
            string newStr = A;
            while (i < A.Length)
            {
                char[] charArray = newStr.ToCharArray();
                newStr = shiftArray(charArray);
                if (newStr.Equals(B))
                    return true;

                i++;
            }

            return false;

        }

        private string shiftArray(char[] array)
        {
            int i;
            char temp = array[0];
            for (i = 0; i < array.Length - 1; i++)
                array[i] = array[i + 1];

            array[i] = temp;

            return new string(array);
        }

        public bool rotateString(String a, String b)
        {
            // Space and Time Complexity: O(n) | O(n)
            foreach (char x in a.ToCharArray())
            {
                string firstLetter = a.Substring(0, 1);
                string otherLetters = a.Substring(1, a.Length);
                a = otherLetters + firstLetter;

                if (a.Equals(b))
                    return true;
            }

            return false;
        }


        private void LevelOrderTraversals(TreeNode node)
        {
            if (node == null)
                return;

            int level = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            //levels.Enqueue(1);

            while (queue.Any())
            {
                int size = queue.Count;
                List<int> levels = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    node = queue.Dequeue();

                    levels.Add(node.val);

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
        }

        private void IsValidBSTs(TreeNode node)
        {

            if (node == null)
                return;

            double inOrder = -double.MinValue;
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (stack.Any() || node != null)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }

                node = stack.Pop();

                if (node.val <= inOrder)
                    return;

                inOrder = node.val;

                node = node.right;
            }

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


        public int missingNumber(int[] nums)
        {
            // space time complexity O(n) | O(1)
            int expectedSum = nums.Length * (nums.Length + 1) / 2;
            int actualSum = 0;

            foreach (int num in nums)
                actualSum += num;

            return expectedSum - actualSum;
        }

        public int LengthOfLongestSubstring(string s)
        {

            // Space and Time Complexity: O(n) | O(min(m,n))

            int n = s.Length;
            int answer = 0;

            // map character to it's index
            Dictionary<char, int> map = new Dictionary<char, int>();

            // iterate over string with two indexes i and j
            for (int j = 0, i = 0; j < n; j++)
            {
                // if character repeats, get the max index between i and index stored in map
                if (map.ContainsKey(s[j]))
                {
                    // this will skip over characters after repeated char found
                    i = Math.Max(map[s[j]], i);
                }

                // get the max of current length and new length of sub string
                // skips over characters
                answer = Math.Max(answer, j - i + 1);

                // if character does not exist in map add with new start index + 1
                if (!map.ContainsKey(s[j]))
                    map.Add(s[j], j + 1);
                else
                    map[s[j]] = j + 1;
            }

            return answer;

        }

        public int Search(int[] nums, int target)
        {

            int start = 0;
            int end = nums.Length - 1;

            // Space and Time Complexity: O(LogN) | O(1)
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

        public int FindKthLargest(int[] nums, int k)
        {
            // [3,2,1,5,6,4] and k = 2
            // [1 , 2, 3, 4, 5, 6] and k = 2
            // [1, 2, 2, 3, 3, 4, 5, 5, 6]
            // [3,2,3,1,2,4,5,5,6] k = 4
            // 1, 2, 2, 3, 3, 4, 5, 5, 6
            // space and time complexity: O(n) | O(1)

            Array.Sort(nums);

            int n = k;
            int nLargest = int.MaxValue;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] <= nLargest && n > 0)
                {
                    nLargest = nums[i];
                    n--;
                }

                if (n == 0)
                    break;
            }

            return nLargest;

        }

        public IList<int> BoundaryOfBinaryTree(TreeNode root)
        {

            List<int> result = new List<int>();

            if (root == null)
                return result;

            result.Add(root.val);

            dfs(root.left, true, false, result);
            dfs(root.right, false, true, result);

            return result;

        }

        private void dfs(TreeNode root, bool leftMost, bool rightMost, List<int> result)
        {
            //return if leaf node is reached
            if (root == null)
                return;

            // pre order -> add root node if there are left and right nodes (ROOT -> LEFT -> RIGHT)
            if (leftMost || root.left == null && root.right == null)
                result.Add(root.val);

            dfs(root.left, leftMost, root.right == null && rightMost, result);

            dfs(root.right, root.left == null && leftMost, rightMost, result);

            // post order -> add root node if there are left and right nodes (LEFT -> RIGHT -> ROOT)
            if (rightMost && !leftMost && (root.left != null || root.right != null))
            {
                result.Add(root.val);
            }
        }

        public static List<int> BranchSums(TreeNode root)
        {
            List<int> sums = new List<int>();
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            Queue<int> values = new Queue<int>();

            nodes.Enqueue(root);
            values.Enqueue(root.val);

            while (nodes.Any())
            {
                root = nodes.Dequeue();
                int currentSum = values.Dequeue();

                if (root.left == null && root.right == null)
                {
                    //total += root.value;
                    sums.Add(currentSum);
                }

                if (root.right != null)
                {
                    nodes.Enqueue(root.right);
                    values.Enqueue(currentSum + root.right.val);
                }

                if (root.left != null)
                {
                    nodes.Enqueue(root.left);
                    values.Enqueue(currentSum + root.left.val);
                }
            }

            sums.Reverse();

            return sums;
        }

        public static List<int> hasPathSum2(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            Stack<int> sumStack = new Stack<int>();

            TreeNode current = root;
            int pathSum = 0;
            int runningSum = 0;
            nodes.Push(root);
            sumStack.Push(root.val);

            while (nodes.Any())
            {
                runningSum = sumStack.Pop();
                current = nodes.Pop();

                if (current.left == null && current.right == null)
                {
                    result.Add(pathSum + runningSum);
                    continue;
                }


                if (current.left != null)
                {
                    int newSum = runningSum + current.left.val;
                    nodes.Push(current.left);
                    sumStack.Push(newSum);
                }

                if (current.right != null)
                {
                    int newSum = runningSum + current.right.val;
                    nodes.Push(current.right);
                    sumStack.Push(newSum);
                }


                /*while (current != null)
                {
                    nodes.Push(current.right);
                    pathSum += current.val;
                    sumStack.Push(pathSum);
                    current = current.left;
                }
                pathSum = sumStack.Pop();
                current = nodes.Pop();

                if (current.left == null && current.right == null)
                    result.Add(pathSum);*/

            }

            result.Reverse();

            return result;
        }

        public static void IterativeInOrderTraversal(TreeNode tree, Action<TreeNode> callback)
        {

            if (tree == null)
                return;

            TreeNode previousNode = null;
            TreeNode currentNode = tree;

            while (currentNode != null)
            {
                TreeNode nextNode;

                // no previous node and top of the list
                if (previousNode == null || previousNode == currentNode.parent)
                {
                    // traverse left side first
                    if (currentNode.left != null)
                    {
                        // set next node to the current nodes left child
                        nextNode = currentNode.left;
                    }
                    else
                    {
                        // if no left node use callback on current node
                        callback(currentNode);
                        // set the next node to current nodes right child, otherwise use parent
                        nextNode = currentNode.right != null ? currentNode.right : currentNode.parent;
                    }
                }
                // if the previous node equal to current nodes left child
                else if (previousNode == currentNode.left)
                {
                    // use callback on current node
                    callback(currentNode);
                    // set next node to current node's right child, otherwise use parent
                    nextNode = currentNode.right != null ? currentNode.right : currentNode.parent;
                }
                else
                {
                    // otherwise just set the next node to parent node
                    nextNode = currentNode.parent;
                }

                // iterate by setting previous and current node to current and next
                previousNode = currentNode;
                currentNode = nextNode;

            }

        }

        public string ReverseWords(string s)
        {
            Dictionary<string, int> wordMap = new Dictionary<string, int>();

            var h = wordMap.Aggregate((x, y) => x.Value > y.Value ? y : x).Key;

            if (string.IsNullOrEmpty(s))
                return s;

            s = s.Trim();

            s = Regex.Replace(s, @"\s+", " ", RegexOptions.Multiline);

            string[] words = s.Split(" ");

            StringBuilder sb = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                if (i > 0)
                    sb.Append(" ");
            }

            return sb.ToString();

        }

        [TestMethod]
        public void TestMethod100()
        {
            var result = MostCommonWords("Bob hit a ball, the hit BALL flew far after it was hit.", new[] {"hit"});
        }

        public string MostCommonWords(string paragraph, string[] banned)
        {

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

        public int[][] Merge(int[][] intervals)
        {

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

        public bool CanAttendMeetings(int[][] intervals)
        {
            // Space and TIme Complexity: O(N Log(n)) | O(n)
            if (!intervals.Any())
            {
                return true;
            }

            int[][] sortedTimes = intervals.Select(x => x).OrderBy(x => x[0]).ToArray();

            for (int i = 0; i < sortedTimes.Length - 1; i++)
            {
                if (sortedTimes[i][1] > sortedTimes[i + 1][0])
                    return false;
            }

            return true;

        }

        [TestMethod]
        public void test1()
        {
            RemoveElements(new ListNode(), 1);
        }

        public ListNode RemoveElements(ListNode head, int val)
        {
            // space and time complexity: O(n) | O(1)

            LinkedList<List<int>> result = new LinkedList<List<int>>();
            result.AddFirst(new List<int>() {1, 2});

            var output = result.ToList();


            ListNode sentinal = new ListNode(0);
            sentinal.next = head;

            ListNode prev = sentinal;
            ListNode current = head;

            while (current != null)
            {

                if (current.val == val)
                {
                    prev.next = current.next;
                }
                else
                    prev = current;

                current = current.next;
            }

            return sentinal.next;
        }


        public int LongestSubstringWithRepeatingCharacters(string s, int k)
        {
            // Space Time Complexity: O(n^2) | O(n)

            return LongestSubstringUtil(s, 0, s.Length, k);

        }

        private int LongestSubstringUtil(string s, int start, int end, int k)
        {

            if (end < k)
                return 0;

            int[] countMap = new int[26];

            for (int i = start; i < end; i++)
                countMap[s[i] - 'a']++;

            for (int mid = start; mid < end; mid++)
            {
                if (countMap[s[mid] - 'a'] >= k) continue;

                int midNext = mid + 1;
                while (midNext < end && countMap[s[midNext] - 'a'] < k)
                    midNext++;

                return Math.Max(LongestSubstringUtil(s, start, mid, k), LongestSubstringUtil(s, midNext, end, k));
            }

            return (end - start);
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            //Space and Time complexity : O(n) | O(n)

            // construct hashmap mapping a value to its inorder index
            Dictionary<int, int> idxMap = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                idxMap.Add(inorder[i], i);
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode head = null;

            // Iterate over preorder and construct the tree 
            foreach (int val in preorder)
            {
                if (head == null)
                {
                    head = new TreeNode(val);
                    stack.Push(head);
                }
                else
                {
                    TreeNode node = new TreeNode(val);

                    if (idxMap[val] < idxMap[stack.Peek().val])
                        stack.Peek().left = node;
                    else
                    {
                        TreeNode item = null;
                        while (stack.Any() && idxMap[stack.Peek().val] < idxMap[val])
                            item = stack.Pop();
                        item.right = node;
                    }

                    stack.Push(node);
                }
            }

            return head;

        }

        public bool IsValidSequenceFromRootToLeaf(TreeNode root, int[] arr)
        {

            TreeNode node = root;
            if (arr[0] != node.val)
                return false;

            for (int i = 1; i < arr.Length; i++)
            {
                if (node.left != null && node.left.val == arr[i])
                    node = node.left;
                else if (node.right != null && node.right.val == arr[i])
                    node = node.right;
                else
                    return false;
            }

            return node.left == null && node.right == null;

        }

        [TestMethod]
        public void TestMethodc()
        {
            double[] result = FindAverages(5, new int[] {1, 3, 2, 6, -1, 4, 1, 8, 2});
            Console.Write("Averages of subarrays of size K: " + result.ToString());
        }

        public static double[] FindAverages(int K, int[] arr)
        {
            double[] result = new double[arr.Length - K + 1];
            double windowSum = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd]; // add the next element
                // slide the window, we don't need to slide if we've not hit the required window size of 'k'
                if (windowEnd >= K - 1)
                {
                    result[windowStart] = windowSum / K; // calculate the average
                    windowSum -= arr[windowStart]; // subtract the element going out
                    windowStart++; // slide the window ahead
                }
            }

            return result;
        }

        [TestMethod]
        public void TestMethodMerge()
        {
            int[] arr = {76, 89, 23, 1, 55, 78, 99, 12, 65, 100};
            mergeSort(arr, 0, arr.Length - 1);
        }

        public static void merges(int[] arr, int start, int mid, int end)
        {
            int i, j, k;
            int len1 = mid - start + 1;
            int len2 = end - mid;

            int[] leftArray = arr.Take(mid - start + 1).ToArray();
            //int[] rightArray = arr.Take(mid - end).ToArray();
            int[] rightArray = arr.Skip(mid - start + 1).Take(end - mid + 1).ToArray();

            i = 0;
            j = 0;
            k = start;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] < rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }

                k++;
            }

            while (i < leftArray.Length)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightArray.Length)
            {
                arr[j] = rightArray[j];
                j++;
                k++;
            }
        }





        public static void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }

            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public static void mergeSort(int[] arr, int p, int r)
        {
            if (p >= r)
                return;

            int q = (p + r) / 2;
            mergeSort(arr, p, q);
            mergeSort(arr, q + 1, r);
            //merge(arr, p, q, r);

            merges(arr, p, q, r);
        }

        [TestMethod]
        public void TestMethodMerge2()
        {
            //int[] arr1 = { 3, 1, 3, 5 };
            //int[] arr2 = { 6, 2, 4, 6, 0, 0, 0 };

            int[] arr1 = {2, 5, 10};
            int[] arr2 = {4, 8, 13, 0, 0};

            //int[] arr2 = {1, 2, 3, 0, 0, 0};
            //int[] arr1 = {2, 5, 6};

            //int[] arr1 = { 1, 3, 5 };
            //int[] arr2 = { 2, 4, 6, 0, 0, 0 };

            merger_first_into_second(arr1, arr2);
        }

        static void merger_first_into_second(int[] arr1, int[] arr2)
        {
            //int len1 = 3;
            //int len2 = 3;
            //int p1 = len1 - 1;
            //int p2 = len2 - 1;
            //int p3 = len1 + len2 - 1;

            int len1 = arr1[0];
            int len2 = arr2[0] - arr1[0];
            int p1 = len1 - 1;
            int p2 = len2 - 1;
            int p3 = len2 + len1 - 1;

            //int p1 = len1 - 1;
            //int p2 = len2 - len1;
            //int p3 = p1 + p2;
            //int p1 = arr1[0] - 1;
            //int p2 = arr2[0] - 1;
            // set pointer for nums1
            //int p3 = p1 + p2 - 2;

            //arr1 = arr1.Skip(1).ToArray();
            //arr2 = arr2.Skip(1).ToArray();

            while ((p1 >= 1) && (p2 >= 1))
            {
                if (arr1[p1] < arr2[p2])
                {
                    arr2[p3] = arr2[p2];
                    p2--;
                }
                else
                {
                    arr2[p3] = arr1[p1];
                    p1--;
                }

                p3--;
            }

            while (p1 >= 1)
            {
                arr2[p3] = arr1[p1];
                p1--;
                p3--;
            }

            while (p2 >= 1)
            {
                arr2[p3] = arr2[p2];
                p2--;
                p3--;
            }
        }

        [TestMethod]
        public void TestMethodGroup()
        {
            int[] arr = {8, 4, 9, 5, 2, 9, 5, 7, 10};
            solve(arr);
        }

        static int[] solve(int[] arr)
        {

            int left = 1;
            int right = arr.Length - 1;

            while (left < right)
            {

                if (arr[left] % 2 != 0 && arr[right] % 2 == 0)
                {
                    swap(arr, left, right);
                    left++;
                    right--;
                }
                else if (arr[left] % 2 != 0 && arr[left] % 2 != 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return arr;

        }

        static void swap(int[] arr, int left, int right)
        {

            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }

        [TestMethod]
        public void TestGenerateExpressions()
        {
            string s = "222";
            long target = 24;
            generate_all_expressions(s, target);
        }

        public static int n;
        public static string[] generate_all_expressions(string s, long target)
        {
            n = s.Length;
            List<string> collection = new List<string>();
            collection.Skip(1);
            helper(s, 0, "", target, 0L, 0L, collection);
            return collection.ToArray();
        }


        // using mutable data structure
        public static void helper(string input, int idx, string current_express, long target, long curr_express_val, long curr_express_val_after_right_sign, List<string> coll)
        {
            if (idx == n)
            {
                if (curr_express_val == target)
                {
                    coll.Add(current_express);
                }

                return;
            }

            for (int i = idx; i < n; i++)
            {
                var str_number_add_as_str = input.Substring(idx, i - idx + 1);
                var number_to_add = str_to_long(str_number_add_as_str);

                if (idx == 0)
                {
                    helper(input, i + 1, str_number_add_as_str, target, number_to_add, number_to_add, coll);
                }
                else
                {
                    helper(input, i + 1, current_express + "+" + str_number_add_as_str, target,
                        curr_express_val + number_to_add, number_to_add, coll);

                    helper(input, i + 1, current_express + "*" + str_number_add_as_str, target,
                        curr_express_val - curr_express_val_after_right_sign + (curr_express_val_after_right_sign * number_to_add), curr_express_val_after_right_sign * number_to_add, coll);
                }

            }
            
            
            
            
            /*else
            {
                soFar.Append(input[idx]);
                int sumSoFar1 = int.Parse(sumSoFar.ToString() + input[idx]);
                helper2(input, idx + 1, soFar, sumSoFar1, target, coll);
                soFar.Length--;


                //if(soFar.Length > 0)
                //    soFar.Append("+").Append(input[idx]);
                //else
                //    soFar.Append(input[idx]);

                soFar.Append("+").Append(input[idx]);
                int sumSoFar2 = int.Parse(sumSoFar.ToString()) + (input[idx] - '0');
                helper2(input, idx + 1, soFar, sumSoFar2, target, coll);
                soFar.Length -= 2;

                soFar.Append("*").Append(input[idx]);
                int sumSoFar3 = int.Parse(sumSoFar.ToString()) * (input[idx] - '0');
                helper2(input, idx + 1, soFar, sumSoFar3, target, coll);
                soFar.Length -= 2;
            }*/
        }

        /*private static long str_to_long(string str_number)
        {
            long val = 0;
            foreach (var num in str_number)
            {
                val *= 10L + (num - '0');
            }

            return val;
        }*/

        private static long str_to_long(string str_number)
        {
            long val = 0;
            int len = str_number.Length;
            for (int i = 0; i < len; i++)
            {
                val = val * 10L + (str_number[i] - '0');
            }
            return val;
        }

        [TestMethod]
        public void TestPalindrome()
        {
            string s = "abracadabra";
            //string s = "aab";
            generate_palindromic_decompositions(s);
        }

        //public static string[] generate_palindromic_decompositions(string s)
        public static List<string> generate_palindromic_decompositions(string s)
        {
            //List<string> collection = new List<string>();
            //palindromeHelper(s, 0, new StringBuilder(), collection);
            List<string> collection = new List<string>();
            palindromeHelper(s, 0, new StringBuilder(), collection);
            return collection;
        }

        public static void palindromeHelper(string s, int start, StringBuilder soFar, List<string> collection)
        {

            if (start >= s.Length)
            {
                //soFar.Length--;
                collection.Add(soFar.ToString());
                //collection.Add(current.ToList());
                //collection.Add(new List<string>(current));
            }
            else
            {
                //soFar.Append(s[idx]);
                //if(idx + 1 < s.Length) soFar.Append("|"); 
                //palindromeHelper(s, idx + 1, soFar, collection);
                //soFar.Length -= 2;

                //var substr = getPalindromeAroundCenter(s, i, i);

                //var substr = getPalindromeAroundCenter(s, start, end);
                //soFar.Append(substr);
                //if (start + 1 < s.Length) soFar.Append("|");
                //palindromeHelper(s, start + 1, end + 1, soFar, collection);


                for (int end = start; end < s.Length; end++)
                {
                    if(IsPalindrome(s, start, end))
                    {
                        string currentSubstr = s.Substring(start, end - start + 1);
                        soFar.Append(currentSubstr).Append("|");

                        palindromeHelper(s, end + 1, soFar, collection);
                        //soFar.RemoveAt(current.Count - 1);
                        soFar.Length -= currentSubstr.Length + 1;
                    }
                    
                    //if (substri.Length == end)
                    //    start = end + 1;
                    
                    //soFar.Append(candidates[i]);
                    //Helper(remain - candidates[i], soFar, i, candidates, collection);
                    //soFar.RemoveAt(soFar.Count - 1);
                }
                //palindromeHelper(s, idx + 1, soFar, collection);
                //soFar.Length -= substr.Length + 1;
                //soFar.Length--;

                /*for (int i = 0; i < s.Length; i++)
                {

                    //odd length
                    var substr = getPalindromeAroundCenter(s, i, i);

                    soFar.Append(s[idx]);
                    palindromeHelper(s, idx + 1, soFar, collection);
                    soFar.Length - 2;

                    //even length
                    substr = getPalindromeAroundCenter(s, i, i + 1);

                    soFar.Append(s[idx]);
                    palindromeHelper(s, idx + 1, soFar, collection);
                    soFar.Length - 2;
                }*/
            }
        }


        private static bool IsPalindrome(string ss, int lo, int hi)
        { 
            while (lo < hi)
            {
                if (ss[lo] != ss[hi])
                    return false;

                lo++;
                hi--;
            }

            return true;
        }

        /*while (lo >= 0 && hi<ss.length()) {
            if (ss.charAt(lo) != ss.charAt(hi))
                break;      // the first and last characters don't match!

            // expand around the center
            lo--;
            hi++;

            ans++;
        }*/

    [TestMethod]
        public void TestPermeate()
        {
            int[] nums = {1, 1, 2};
            PermuteUnique(nums);
        }

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> collection = new List<IList<int>>();
            helper(nums, 0, new List<int>(), collection);
            return collection;
        }

        public void helper(int[] nums, int idx, IList<int> soFar, List<IList<int>> collection)
        {

            if (idx == nums.Length)
            {
                collection.Add(soFar);
            }
            else
            {
                HashSet<int> cache = new HashSet<int>();

                for (int i = idx; i < nums.Length; i++)
                {
                    if (cache.Contains(nums[i]))
                        continue;

                    cache.Add(nums[i]);
                    // add
                    swaps(nums, idx, i);
                    soFar.Add(nums[i]);
                    helper(nums, i + 1, soFar, collection);
                    soFar.RemoveAt(soFar.Count - 1);
                    swaps(nums, idx, i);
                    // remove
                }
            }
        }

        public void swaps(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }


        [TestMethod]
        public void TestPalindromes()
        {
            string s = "abracadabra";
            //string s = "aab";
            partition(s);
        }

        public List<IList<string>> partition(string s)
        {
            List<IList<string>> result = new List<IList<string>>();
            dfs(0, result, new List<string>(), s);
            return result;
        }

        void dfs(int start, List<IList<string>> result, List<string> currentList, string s)
        {
            if (start >= s.Length) result.Add(new List<string>(currentList));
            for (int end = start; end < s.Length; end++)
            {
                if (isPalindrome(s, start, end))
                {
                    // add current substring in the currentList
                    currentList.Add(s.Substring(start, end - start + 1));
                    dfs(end + 1, result, currentList, s);
                    // backtrack and remove the current substring from currentList
                    currentList.RemoveAt(currentList.Count - 1);
                }
            }
        }

        public bool isPalindrome(string s, int low, int high)
        {
            while (low < high)
            {
                if (s[low++] != s[high--]) return false;
            }
            return true;
        }

        [TestMethod]
        public void TestBsts()
        {
            int n = 3;
            //string s = "aab";
            how_many_BSTs(n);
        }

        //private static long bst_count;

        public static long how_many_BSTs(int n)
        {
            //BST_Helper(arr, 1, soFar);
            if (n == 0) return 0;
            return BST_Helper(1, n);
        }

        public static long BST_Helper(int start, int end)
        {
            long bst_count = 0;
            //if(n == idx) {
            if (start >= end)
            {
                return 1;
            }

            for (int i = start; i <= end; i++)
            {
                // left side of tree
                long left = BST_Helper(start,  i - 1);
                //n += 1;

                // right side of tree
                long right = BST_Helper(i + 1, end);

                bst_count += left * right;
                //n -= 1;
            }

            return bst_count;

            /*for (int i = n; i >= 0; i--)
                {
                    // left side of tree
                    BST_Helper(n, idx + 1, soFar);

                    // right side of tree
                    BST_Helper(n, idx + 1, soFar);
                }
                */
        }

        /*public static void BST_Helper(int[] arr, int idx, List<long> soFar)
        {

            //if(n == idx) {
            if (idx == arr.Length)
            {
                bst_count += 1;
            }
            else
            {

                for (int i = idx; i < arr.Length; i++)
                {

                    swaps2(arr, idx, i);

                    soFar.Add(arr[i]);
                    BST_Helper(arr, i + 1, soFar);
                    soFar.RemoveAt(soFar.Count - 1);
                    swaps2(arr, idx, i);
                }
            }
        }*/

        private static void swaps2(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }

        [TestMethod]
        public void TestStrs()
        {

            string[] strArray = {"abc", "bcd", "acef", "xyz", "az", "ba", "a", "z"};

            GroupStrings(strArray);
        }

        public IList<IList<string>> GroupStrings(string[] strings)
        {

            List<IList<string>> result = new List<IList<string>>();
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            foreach (string str in strings)
            {

                string distanceString = helper(str);
                if (!map.ContainsKey(distanceString))
                {
                    map.Add(distanceString, new List<string>());
                }
                map[distanceString].Add(str);
            }

            foreach (var strs in map.Values)
            {
                result.Add(strs);
            }

            return result;

        }


        public string helper(string s)
        {
            char[] arr = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                if (diff < 0)
                {
                    diff += 26;
                }
                sb.Append(diff);
            }

            return sb.ToString();
        }
    }
}
