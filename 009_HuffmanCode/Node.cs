﻿using System;
using System.Collections.Generic;

namespace _009_HuffmanCode
{
  public class Node
  {
    public char Symbol { get; set; }
    public int Frequency { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    internal List<bool> Traverse(char symbol, List<bool> data)
    {
      // Leaf
      if(Left == null && Right == null)
      {
        if (symbol == this.Symbol)
          return data;
        else
          return null;
      }
      else
      {
        List<bool> left = null;
        List<bool> right = null;

        if(Left != null)
        {
          List<bool> leftPath = new List<bool>();
          leftPath.AddRange(data);
          leftPath.Add(false);
          left = Left.Traverse(symbol, leftPath);
        }
        if(Right != null)
        {
          List<bool> rightPath = new List<bool>();
          rightPath.AddRange(data);
          rightPath.Add(true);
          right = Right.Traverse(symbol, rightPath);
        }
        if (left != null)
          return left;
        else
          return right;

      }
    }
  }
}