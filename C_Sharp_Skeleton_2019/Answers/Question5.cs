using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] input)
        {
            SortedDictionary<int, HashSet<int>> Attacks = new SortedDictionary<int, HashSet<int>>();

            for (int i = 1; i < input.Length; i += 2)
            {
                if (Attacks.ContainsKey(input[i]))
                {
                    Attacks[input[i]].Add(input[i + 1]);
                }
                else
                {
                    Attacks[input[i]] = new HashSet<int>() { input[i + 1] };
                }
            }
            int maxdef = 0;

            foreach (var keyval in Attacks) //foreach time slot
            {
                List<KeyValuePair<int, int>> cones = new List<KeyValuePair<int, int>>();
                foreach (var after in Attacks) //for every point after
                {
                    if (after.Key > keyval.Key) //^
                    {

                        foreach (int f in after.Value) //for every time value
                        {

                            foreach (int def in keyval.Value) //for every defender a.k.a point on current time slot
                            {
                                if (Math.Abs(f - def) <= after.Key - keyval.Key) //check if target is in cone
                                {
                                    goto nextfreq;
                                }
                            }
                            foreach (var cone in cones)
                            {
                                if (Math.Abs(f - cone.Value) <= after.Key - cone.Key)
                                {
                                    goto nextfreq;
                                }
                            }
                            cones.Add(new KeyValuePair<int, int>(after.Key, f));
                        nextfreq: { }

                        }
                    }
                }
                maxdef = maxdef < keyval.Value.Count + cones.Count ? keyval.Value.Count + cones.Count : maxdef;

            }
            /*foreach (var keyval in Attacks) //foreach time slot
            {
                List<KeyValuePair<int, int>> cones = new List<KeyValuePair<int, int>>();
                foreach (var before in Attacks) //for every point
                {
                    if (before.Key < keyval.Key) //before
                    {

                        foreach (int f in before.Value) //for every time value
                        {

                            foreach (int def in keyval.Value) //for every defender a.k.a point on current time slot
                            {
                                if (Math.Abs(f - def) <= Math.Abs(keyval.Key - before.Key)) //check if target is in cone
                                {
                                    goto nextfreq;
                                }
                            }
                            foreach (var cone in cones)
                            {
                                if (Math.Abs(f - cone.Value) <= Math.Abs(cone.Key - before.Key))
                                {
                                    goto nextfreq;
                                }
                            }
                            cones.Add(new KeyValuePair<int, int>(before.Key, f));
                        nextfreq: { }

                        }
                    }
                }
                maxdef = maxdef < keyval.Value.Count + cones.Count ? keyval.Value.Count + cones.Count : maxdef;

            }*/

            return maxdef;
        }
    }
}