using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class distanceController : MonoBehaviour {

	private float distTraveled; //counter up on how far player has traveled
	private float fuelDeduct = 20; //amount deducted from money after certain distance
	private float fuelDistance = 3; //distance traveled when fuel is deducted
	public float money;

	public Text fuelText;
	public Text moneyText;

	void Start () {
			distTraveled = 0.0f;
			money = 500;
	} 

	void Update(){
		distTraveled += Time.deltaTime;

		fuelText.text = "" + distTraveled;
		moneyText.text = "" + money;

		if(distTraveled > fuelDistance){
				money -= fuelDeduct;
				fuelText.text = "You paid for fuel!";
				distTraveled = 0;
			}
	}
}