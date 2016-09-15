﻿using System;
using System.Collections.Generic;

namespace monosnake
{
	public class VerticalLine : Figure
	{
		public VerticalLine(int yUp, int yDown, int x, char sym)
		{
			pList = new List<Point>();
			for (int y = yUp; y <= yDown; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}
	}
}
