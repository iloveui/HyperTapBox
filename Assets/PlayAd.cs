using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class PlayAd : MonoBehaviour {

	public void ShowAd (){
		if (Advertisement.IsReady ()) {
			Advertisement.Show("rewardedVideo", new ShowOptions() {resultCallback = HandleAdResult});
		}
	}

	private void HandleAdResult (ShowResult results){
	
		switch (results) {
		case ShowResult.Finished:
			Debug.Log ("le dimos las lucas");
			break;
		case ShowResult.Skipped:
			Debug.Log ("se hace el rata");
			break;
		case ShowResult.Failed:
			Debug.Log ("se le cayo el internet");
			break;
		}
	}

}
