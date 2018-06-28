using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class simpannama : MonoBehaviour {

	public InputField inputField;
	public Text textOutput;

	public void TombolSave(int yangdituju){
		string nama = inputField.text;

		PlayerPrefs.SetString("Name", nama);
		Application.LoadLevel (yangdituju);
	}

	public void TombolLoad(){
		string loadNama = PlayerPrefs.GetString("Name");

		textOutput.text = "" + loadNama;
	}

}
