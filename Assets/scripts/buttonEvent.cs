using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonEvent : MonoBehaviour {

	public void keluar(){
		Application.Quit ();
	}

	public void ketujuan(int yangdituju){
		Application.LoadLevel (yangdituju);
	}
}
