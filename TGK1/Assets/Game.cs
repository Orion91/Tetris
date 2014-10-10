using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {


	public GameObject L,LRev,T,Cube,Z,ZRev,I;
	GameObject block;

	private int counter;
	// Use this for initialization
	void Start()
	{
		counter = 0;
	}
	void Update () {

		counter++;
		if(counter ==200)
		{
			Shape();
		}

		if(Input.GetKeyDown (KeyCode.LeftArrow) == true)
		{
			block.transform.position = block.transform.position + new Vector3(-0.4f,0,0);
		}
		if(Input.GetKeyDown (KeyCode.RightArrow) == true)
		{
			block.transform.position = block.transform.position + new Vector3(0.4f,0,0);
		}
		if(Input.GetKeyDown(KeyCode.Space) == true)
		{
			block.transform.rotation = Quaternion.AngleAxis(90, new Vector3(0,0,1));

		}
	}
	
	// Update is called once per frame

	void Shape()
	{
		int whichShape = Random.Range (0, 7);

		switch(whichShape)
		{
		case 0: 
		{
			block = (GameObject) Instantiate(L,new Vector3(2,5,0),Quaternion.identity);
			print("L");
		}break;
		case 1: 
		{
			block = (GameObject) Instantiate(LRev,new Vector3(2,5,0),Quaternion.identity);
			print("LRev");
		}break;
		case 2: 
		{
			block = (GameObject) Instantiate(T,new Vector3(2,5,0),Quaternion.identity);
			print("T");
		}break;
		case 3:
		{
			block = (GameObject) Instantiate(Cube,new Vector3(2,5,0),Quaternion.identity);
			print("Cube");
		}break;
		case 4: 
		{
			block = (GameObject) Instantiate(Z,new Vector3(2,5,0),Quaternion.identity);
			print("Z");
		}break;
		case 5: 
		{
			block = (GameObject) Instantiate(ZRev,new Vector3(2,5,0),Quaternion.identity);
			print("ZRev");
		}break;
		case 6: 
		{
			block = (GameObject) Instantiate(I,new Vector3(2,5,0),Quaternion.identity);
			print("I");
		}break;
		}

		counter = 0;
	}
}
