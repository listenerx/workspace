using UnityEngine;
using System.Collections;

public class markspade : MonoBehaviour {	
	// スペード、ハート、クローバーのマークそれぞれで押した順番を記録し、
	// その順番がbuttonkanrikunクラスのmarkpassと合っていたら鍵を開ける。
	// markpassは配列で7つはいっており、ハートやスペードのマークを押すたびに
	// 配列の[6]番目にそれぞれの数を代入するとともに、i番目の数をi+1番目の数で代入し、ひとつずつ前にずらしている

	public buttonkanrikun spade;
	
	// Use this for initialization
	void Start () {
		// やりまぁす
	}

	// Update is called once per frame
	void Update () {
		// やりまぁす
	}
	
	// 関数OnClickはNGUIの関数
	void OnClick () {
		for (int i=0; i<6; i++) {
			spade.markpass[i] = spade.markpass [i+1];
		}
		spade.markpass[6] = 7;
	}
}
