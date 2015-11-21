using UnityEngine;
using System.Collections;

public class GraphicsSetup : MonoBehaviour 
{
	void Awake()
	{
		//Make iOS run smooth :)
		Application.targetFrameRate = 60;
	}
}
