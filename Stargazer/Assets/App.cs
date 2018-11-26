using System.Collections.Generic;
using Stargazer.Data;
using UnityEngine;

public class App : MonoBehaviour
{
	public GameObject SpherePrefab;

	private async void Start()
	{
		var reader = new JSONReader();
		var json = await reader.GetJSON();
		var stars = Serializer.Deserialize(json);
		DrawBodies(stars.hipstars);
	}

	private void DrawBodies(List<Hipstar> bodies)
	{
		foreach (var item in bodies)
		{
			CreateBody(item);
		}
	}

	private void CreateBody(Hipstar body)
	{
		var go = Instantiate(SpherePrefab);
		go.transform.position = Coor.GetPosition(body);
		var radius = (float)body.radius * 2;
		go.transform.localScale = new Vector3(radius, radius, radius);
		var text = go.GetComponentsInChildren<TextMesh>();
		text[0].text = body.name;
		text[1].text = body.desig;
	}
}