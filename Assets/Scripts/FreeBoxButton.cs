using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FreeBoxButton : MonoBehaviour {

	public enum State {Active , Ready, Changing};

	public Image MBox;
	public Button Mbtn;

	public gameMaster gm;

	public float activeTime;
	//public float chargingTime =5f;
	float counter;

	public State status;

	void Start () 
	{
		status = State.Ready;
		//MBox.color = Color.white;
		//if (PlayerPrefs.GetFloat ("UpgrateCounter") != 0) 
		//{
			//status = State.Changing;
			//counter = PlayerPrefs.GetFloat("UpgrateCounter");
		//}
	}
	

	void Update () 
	{
		if (status == State.Active) 
		{
			counter += Time.deltaTime;
			MBox.fillAmount = counter / activeTime;


			if (counter >=activeTime)
			{
				status = State.Ready;
			}

			//PlayerPrefs.SetFloat ("UpgrateCounter", -counter);

		//	if (counter > activeTime) 
		//	{
		//		status = State.Changing;
		//		counter = 0;
		//	}


			if (status == State.Ready) 
			{
				counter = 0;
				MBox.fillAmount = 1;
				Mbtn.interactable = true;
			}
			//if (status == State.Changing) 
			//{
			//	counter += Time.deltaTime;

			//	PlayerPrefs.SetFloat ("UpgrateCounter", counter);

			//	MBox.fillAmount = counter / chargingTime;

				//if (counter >= chargingTime) 
				//{
				//	PlayerPrefs.SetFloat ("UpgrateCounter", 0);
				//	status = State.Ready;
				//}

			//}
		}
	}

	public void Pressed()
	{
		if (status == State.Ready) 
		{
			status = State.Active;
			//function
			gm.mbCount ++;
			Mbtn.interactable = false;

		}
	}
}
