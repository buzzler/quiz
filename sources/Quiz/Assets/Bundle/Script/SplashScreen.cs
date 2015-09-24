using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour, IFageUIComponent {
	public	void OnUIInstantiate(FageUIMem mem, params object[] param) {}
	public	void OnUIInstantiated(FageUIMem mem) {
		Invoke("OnTime", 3f);
	}

	public	void OnUIDestroy(FageUIMem mem) {}
	public	void OnSwitchOut(FageUIMem mem) {}
	public	void OnSwitchIn(FageUIMem mem) {}
	public	void OnUIPause(FageUIMem mem) {}
	public	void OnUIResume(FageUIMem mem, params object[] param) {}
	public	void OnUIResumed(FageUIMem mem) {}

	public	GameObject	GetGameObject() {
		return gameObject;
	}

	private	void OnTime() {
		FageUIManager.Instance.Change(FageUIRoot.Instance.FindUISet("ui_title"));
	}
}
