using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)

		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			double lengthAB = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
			double lenghtAM = Math.Sqrt(Math.Pow(x - ax, 2) + Math.Pow(y - ay, 2));
			double lengthBM = Math.Sqrt(Math.Pow(x - bx, 2) + Math.Pow(y - by, 2));

			double cosABandAM = ((bx - ax)*(x - ax) + (by - ay)*(y - ay)) / (lengthAB * lenghtAM);
			double cosBAandBM = ((ax - bx) * (x - bx) + (ay - by) * (y - by)) / (lengthAB * lengthBM);
			
			if (cosABandAM >= 0 && cosBAandBM >= 0)
			{
				if (cosABandAM == 1 && cosBAandBM == 1)
				{
					return 0;
				}
				else
				{
					double halfPerimeter = (lenghtAM + lengthAB + lengthBM) / 2;

					return ((2 * Math.Sqrt((halfPerimeter * (halfPerimeter - lenghtAM) * (halfPerimeter - lengthAB) * (halfPerimeter - lengthBM)))) / lengthAB);
				}
			}
			else
			{
				if (lengthBM < lenghtAM)
				{
					return lengthBM;
				}
				else
				{
					return lenghtAM;
				}
			}
		}
	}
}