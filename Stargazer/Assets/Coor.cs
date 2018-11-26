using System;
using Stargazer.Data;
using UnityEngine;

public class Coor
{
	public static Vector3 GetPosition(Hipstar body)
	{
		var a = body.ra;
		var b = body.de;
		var c = body.dist;
		var x = (c * Math.Cos(b)) * Math.Cos(a);
		var y = (c * Math.Cos(b)) * Math.Sin(a);
		var z = c * Math.Sin(b);
		return new Vector3((float)x, (float)y, (float)z);
	}
}
