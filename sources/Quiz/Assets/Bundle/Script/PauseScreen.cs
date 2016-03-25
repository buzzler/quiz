using UnityEngine;
using System.Collections;

public class PauseScreen : MonoBehaviour, IFageUIComponent {
	public	void OnUIInstantiate(FageUIMem mem, params object[] param) {}
	public	void OnUIInstantiated(FageUIMem mem) {}
	public	void OnUIDestroy(FageUIMem mem) {}
	public	void OnSwitchOut(FageUIMem mem) {}
	public	void OnSwitchIn(FageUIMem mem) {}
	public	void OnUIPause(FageUIMem mem) {}
	public	void OnUIResume(FageUIMem mem, params object[] param) {}
	public	void OnUIResumed(FageUIMem mem) {}
	
	public	GameObject	GetGameObject() {
		return gameObject;
	}
	
	public	void OnClickQuit() {
		FageUIManager.Instance.Change(FageUIRoot.Instance.FindUISet("ui_vssubject"));
	}

	public void OnClickPlay() {
		FageUIManager.Instance.Pop();
	}

	public	void OnClickRestart() {
		FageUIManager.Instance.Flush();
		FageUIManager.Instance.Change(FageUIRoot.Instance.FindUISet("ui_vs"));
	}
}
