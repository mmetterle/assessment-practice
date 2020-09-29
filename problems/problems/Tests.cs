using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            //Math.Sqrt()

            //value = int.Parse(sb.ToString());

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

            ropes = new[] { 20, 4, 8, 2 };
            val = MinCostToConnectRopes(ropes); //54

            ropes = new[] { 1, 2, 5, 10, 35, 89 };
            val = MinCostToConnectRopes(ropes); //224

            ropes = new[] { 2, 2, 3, 3 };
            val = MinCostToConnectRopes(ropes); //20
        }

        [TestMethod]
        public void TestMethod41()
        {
            var days = 7;
            var cells = new[] { 0, 1, 0, 1, 1, 0, 0, 1 };

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
            cells = new[] { 1, 0, 0, 1, 0, 0, 1, 0 };

            val = PrisonAfterNDays(cells, days); //output [0,0,1,1,1,1,1,0]
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

            //First entry is not considered
            dp[0, 0] = int.MaxValue;
            dp[row - 1, column - 1] = int.MaxValue;

            //Access first column 
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
                
                if(profit.ContainsKey(currentMax - 1))
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
            { // logic to avoid precision error
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
                    xMap.Add(city.x, new HashSet<string> { city.name });
                else
                    xMap[city.x].Add(city.name);

                if (!yMap.ContainsKey(city.y))
                    yMap.Add(city.y, new HashSet<string> { city.name });
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
                        queue.Enqueue(new[] { i, j });
                        humanCount++;
                    }
                }
            }

            int[,] directions = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
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
                            queue.Enqueue(new[] { newX, newY }); // now that new coordinate is a zombie, add that to the queue so it can be processed in the next level
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
            if (root == null) return new int[] { 0, 0 };
            int val = root.val, count = 1;

            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    int[] arr = ComputeAvg(child);
                    val += arr[0]; count += arr[1];
                }
            }

            if (count > 1 && (maxNode == null || val / (0.0 + count) > max))
            {
                maxNode = root;
                max = val / (0.0 + count);
            }
            return new int[] { val, count };
        }

        public double[] Helper(Node root)
        {
            if (root == null) return new double[] { 0, 0 };
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
            return new[] { sum, count };
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

                var begin = new int[] { 0, i };
                var total1 = GetTotal(array, begin[0], begin[1]);
                var middle = new int[] { i + 1, j - 1 };
                var total2 = GetTotal(array, middle[0], middle[1]);
                var end = new int[] { j, array.Length };
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
                        songsToGenre[song].Add(genre);   // add a new genre to the list.
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
            queue.Enqueue(new[] { 0, 0 });

            // Traverse the grid using BFS and keep track of the level
            var visited = new bool[grid.GetLength(0), grid.GetLength(1)];
            visited[0, 0] = true;
            int[,] dirs = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

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
                        if (row >= grid.Length || row < 0 || column >= grid.GetLength(1) || column < 0 || grid[row, column] == 'D' || visited[row, column])
                            continue;

                        if (grid[row, column] == 'X') return answer;

                        queue.Enqueue(new[] { row, column });
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
                    index.Add(ch, new List<int> { i });
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

            return (int)answer % 1_000_000_007;
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
            var dictionary = new Dictionary<int, int>();

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
            if (i < 0 || i >= grid.GetLength(0)|| j < 0 || j >= grid.GetLength(1) || grid[i, j] == '0')
                return;

            grid[i, j] = '0';
            GetBFS(grid, i + 1, j); // up
            GetBFS(grid, i - 1, j); // down
            GetBFS(grid, i, j + 1); // left
            GetBFS(grid, i, j - 1); // right
        }

        public List<string> TopNBuzzwords(int numToys, int topToys, List<string> toys, int numQuotes, List<string> quotes)
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
                    p2.sentenceCnt != p1.sentenceCnt ? p2.sentenceCnt - p1.sentenceCnt : string.Compare(p1.name, p2.name, StringComparison.Ordinal));

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
            return new[] { indexMap[movieTimes[pairIdx1]], indexMap[movieTimes[pairIdx2]] };

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
                        if(count.ContainsKey(word))
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

            var seen = new Dictionary<int, int> { { 0, -1 } };
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
                return IsHappy((int)total);

            return false;

        }

        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int reversed = 0, remainder, original = x;

            while (x != 0)
            {
                remainder = x % 10; // reversed integer is stored in variable
                reversed = reversed * 10 + remainder; //multiply reversed by 10 then add the remainder so it gets stored at next             decimal place.
                x /= 10;  //the last digit is removed from x after division by 10.
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
    }
}
