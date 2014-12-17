using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemID : MonoBehaviour
{
		//1=rupe 2=emerald 3=shaguruma 4=barl 5=bluegem
		//6=milk 7=clank 8=rgem 9dia 10=hude 11key 12gahagu 13machi
		//Listにアイテムを入れ、状態を管理する
		public List<int> itemList;
		//以下Gameobjectの宣言が続く、もっといい方法がありそう、
		public int barlstate;
		public GameObject f218;
		public GameObject barlget;
		public GameObject menubarl;
		public bool StateChanged = false;
		//emerald
		public GameObject f229;
		public GameObject utibuta;
		public GameObject f72152;
		public GameObject f142;
		public GameObject f141;
		public GameObject f143;
		public GameObject emetoruyokun;
		public GameObject hutatoru;
		public GameObject menuemerald;
		public menuitemkanrikun barlfragkanrikun;
		//rupe
		public GameObject menurupe;
		public GameObject f228;
		public GameObject f225;
		public GameObject f224;
		//shaguruma
		public GameObject menuShaguruma;
		public GameObject f219;
		public GameObject f219kesuyo;
		public GameObject f136;
		public GameObject f214;
		public GameObject f216;
		public menuitemkanrikun itaNEOkun;
		//shagurma2
		public GameObject menushaguruma;
		public GameObject a175;
		public menuitemkanrikun icondel;
		public GameObject shagurumaokuyo;
		//eme2
		public GameObject b135b;
		public menuitemkanrikun menuitem;
		public GameObject b2tobn1;
		public GameObject emeoitakun;
		public clankkanrikun flag;
		public GameObject pakokun;
		public GameObject sitaikuyokun;
		//milk
		public GameObject menumilk;
		public GameObject a237;
		public GameObject a189;
		public GameObject milktoruyo;
		//milk2
		public GameObject a239;
		public menuitemkanrikun flag2;
		public GameObject clank;
		public GameObject f46;
		public GameObject milkireru;
		public GameObject pako;
		public GameObject butoby;
		public GameObject cat;
		public GameObject akaritukeru;
		public menuitemkanrikun milkNEO;
		//clank
		public GameObject a233;
		//public GameObject clank;
		public GameObject menuclank;
		//clank 2
		public menuitemkanrikun clankflag2;
		public GameObject f175;
		public clankkanrikun clank1;
		public GameObject emeokuyo;
		public GameObject clankokuyo;
		//bluegem
		public GameObject bluegemA;
		public GameObject menubluegem;
		public GameObject f195;
		public GameObject a170;
		public GameObject bluegemget;
		public GameObject redhutatoru;
		//bluegem2
		public GameObject a135;
		public menuitemkanrikun bluegemflag;
		public GameObject atoax;
		public GameObject atoaz;
		//ghagu
		public GameObject a284;
		public GameObject menuhGhaguruma;
		public GameObject a184;
		public GameObject hagurumatoruyo;
		public GameObject menuGhaguruma;
		public menuitemkanrikun ghaguflagg;
		public GameObject b175;
		public clankuenisuru ghaguF;
		//machi
		public GameObject a303;
		public GameObject a304;
		public GameObject menumachi;
		public menuitemkanrikun akarin;
		public GameObject f29;
		public GameObject nakamiruyo;
		//rgem
		public GameObject a255;
		public GameObject a164;
		public GameObject menurgem;
		public GameObject passparent;
		public GameObject az4toaz5;
		public GameObject rgemtoruyo;
		public menuitemkanrikun rgemflag;
		public GameObject catocc;
		public GameObject a268;
		public GameObject rgemokuyo;
		//dia
		public GameObject diatoruyo;
		public GameObject a208;
		public GameObject menudia;
		public GameObject hutaakeru;
		public GameObject marks;
		public GameObject c135;
		public GameObject AAtoJ;
		public menuitemkanrikun diaflag;
		//hude
		public GameObject menuhude;
		public GameObject a279;
		public GameObject hudetoruyo;
		public GameObject a278;
		public menuitemkanrikun picff;
		public menuitemkanrikun hudeic;
		//key
		public GameObject menukey;
		public GameObject a292;
		public menuitemkanrikun picfoff;
		public menuitemkanrikun flag3;
		// Use this for initialization
		void Start ()
		{
				//最初からゲームを始める用にListに0を入れ初期化する
				itemList.Clear ();
				//何のアイテムが入っているか確認している
				foreach (string i in System.Enum.GetNames(typeof(Itemnum)))
						Debug.Log (i);
				//最初からゲームを始める用にListに0を入れ初期化する
				for (int i = 0; i <System.Enum.GetNames(typeof(Itemnum)).Length; i++) {
						itemList.Add (0);
				}
		}

	
		// Update is called once per frame
		void Update ()
		{
				if (StateChanged) {
						//Itemload関数でここをtrueするのでfalseに戻す
						StateChanged = false;
						//Loadした時にそれぞれの変数に入っている値それぞれの関数の引数に渡し、switchで現在の状態をloadする
						GetStateBarl (itemList [3]);
						GetStateEme (itemList [1]);
						GetStateRupe (itemList [0]);
						GetStateShaguruma (itemList [2]);
						GetStateMilk (itemList [5]);
						GetStateClank (itemList [6]);
						GetStateBluegem (itemList [4]);
						GetStateGhagu (itemList [11]);
						GetStateMachi (itemList [12]);
						GetStateRgem (itemList [7]);
						GetStateDia (itemList [8]);
						GetStateHude (itemList [9]);
						GetStateKey (itemList [10]);
				}
		}
		//ItemをEnumで宣言する、これの使い方がよくわからない（謎）
		public enum Itemnum : int
		{
				rupe = 0,
				emerald = 1,
				shaguruma = 2,
				barl = 3,
				bluegem =4,
				milk =5,
				clank =6,
				rgem =7,
				dia =8,
				hude =9,
				key =10,
				ghagu =11,
				machi = 12
		}

		//以下引数のint型変数別にアイテムの状態を指定する関数が続く、これは上記のupdateでflgが起こされると呼び出される

		public void GetStateKey (int key)
		{
				switch (key) {
				case 0:
						break;
				case 1:
						menukey.SetActive (true);
						a292.SetActive (false);
			//gameObject.SetActive (false);
						picfoff.picfinishflag = false;
						break;
				}
		}

		public void GetStateHude (int hude)
		{
				switch (hude) {
				case 0:
						menuhude.SetActive (false);
						a278.SetActive (true);
						hudetoruyo.SetActive (true);
						break;
				case 1:
						menuhude.SetActive (true);
						a278.SetActive (false);
						hudetoruyo.SetActive (false);
						break;
				case 2:
						a278.SetActive (false);
						hudetoruyo.SetActive (false);
						picff.picfinishflag = true;
						menuhude.SetActive (false);
						hudeic.itemflag = 0;
						break;
				}
		}

		public void GetStateDia (int sdia)
		{
				switch (sdia) {
				case 0:
						menudia.SetActive (false);
						a208.SetActive (true);
						diatoruyo.SetActive (true);
						hutaakeru.SetActive (false);
						marks.SetActive (true);
						break;
				case 1:
						menudia.SetActive (true);
						a208.SetActive (false);
						diatoruyo.SetActive (false);
						hutaakeru.SetActive (true);
						marks.SetActive (false);
						break;
				case 2:
						a208.SetActive (false);
						diatoruyo.SetActive (false);
						hutaakeru.SetActive (true);
						marks.SetActive (false);
						c135.SetActive (true);
						AAtoJ.SetActive (true);
						diaflag.itemflag = 0;
						menudia.SetActive (false);
						break;
				}
		}

		public void GetStateRgem (int rgem)
		{
				switch (rgem) {
				case 0:
						a255.SetActive (false);
						menurgem.SetActive (false);
						a164.SetActive (true);
						passparent.SetActive (true);
						az4toaz5.SetActive (false);
						rgemtoruyo.SetActive (true);
						rgemokuyo.SetActive (false);
						catocc.SetActive (false);
						a268.SetActive (false);
						break;
				case 1:
						a255.SetActive (false);
						menurgem.SetActive (true);
						a164.SetActive (false);
						passparent.SetActive (false);
						az4toaz5.SetActive (true);
						rgemtoruyo.SetActive (false);
						rgemokuyo.SetActive (false);
						break;
				case 2:
						a255.SetActive (false);
			//menurgem.SetActive (true);
						a164.SetActive (false);
						passparent.SetActive (false);
						az4toaz5.SetActive (true);
						rgemtoruyo.SetActive (false);
						rgemflag.itemflag = 0;
						menurgem.SetActive (false);
						catocc.SetActive (true);
						a268.SetActive (true);
						rgemokuyo.SetActive (false);
						break;
				}
		}

		public void GetStateMachi (int smachi)
		{
				switch (smachi) {
				case 0:
						a304.SetActive (false);
						menumachi.SetActive (false);
						a303.SetActive (true);
						f29.SetActive (false);
						nakamiruyo.SetActive (false);
						break;
				case 1:
						a304.SetActive (false);
						menumachi.SetActive (true);
						a303.SetActive (false);
						f29.SetActive (false);
						nakamiruyo.SetActive (false);
			//az3toaz4.SetActive (true);
						break;
				case 2:
						a304.SetActive (false);
						menumachi.SetActive (false);
						a303.SetActive (false);
						akarin.itemflag = 0;
						f29.SetActive (true);
						nakamiruyo.SetActive (true);
						akaritukeru.SetActive (false);
						break;
				}
		}

		public void GetStateGhagu (int sghagu)
		{
				switch (sghagu) {
				case 0:
			//a284.SetActive (true);
						a184.SetActive (true);
						hagurumatoruyo.SetActive (true);
						menuhGhaguruma.SetActive (false);
						ghaguflagg.itemflag = 0;
						break;
				case 1:
						a284.SetActive (false);
						a184.SetActive (false);
						hagurumatoruyo.SetActive (false);
						menuhGhaguruma.SetActive (true);
						ghaguflagg.itemflag = 0;
						break;
				case 2:
						a284.SetActive (false);
						a184.SetActive (false);
						hagurumatoruyo.SetActive (false);
						menuGhaguruma.SetActive (false);
						ghaguflagg.itemflag = 0;
						b175.SetActive (true);
			//gameObject.SetActive (false);
						ghaguF.Gflag = true;
						break;
				}
		}

		public void GetStateBluegem (int sblueneo)
		{
				switch (sblueneo) {
				case 0:
			//bluegemA.SetActive (true);
						menubluegem.SetActive (false);
						f195.SetActive (true);
						bluegemget.SetActive (true);
						a170.SetActive (true);
						redhutatoru.SetActive (false);
						break;
				case 1:
						bluegemA.SetActive (false);
						menubluegem.SetActive (true);
						f195.SetActive (false);
						bluegemget.SetActive (false);
						a170.SetActive (false);
						redhutatoru.SetActive (true);
						break;
				case 2:
						bluegemA.SetActive (false);
						f195.SetActive (false);
						bluegemget.SetActive (false);
						a170.SetActive (false);
						redhutatoru.SetActive (true);
						a135.SetActive (true);
						menubluegem.SetActive (false);
						atoax.SetActive (false);
						atoaz.SetActive (true);
						bluegemflag.itemflag = 0;
						break;
				}
		}

		public void GetStateClank (int sclank)
		{
				switch (sclank) {
				case 0:
						menuclank.SetActive (false);
						a233.SetActive (false);
			//a233.SetActive (true);
						clank.SetActive (true);
						f175.SetActive (true);
						clank1.clankkanri = 0;
						break;
				case 1:
						menuclank.SetActive (true);
						a233.SetActive (false);
			//a233.SetActive (true);
						clank.SetActive (false);
						f175.SetActive (true);
						clank1.clankkanri = 0;
						break;
				case 2:
						clankflag2.itemflag = 0;
						menuclank.SetActive (false);
						clankokuyo.SetActive (false);
						f175.SetActive (false);
						clank1.clankkanri = 1;
						emeokuyo.SetActive (false);
						clank.SetActive (false);
						break;
				}
		}

		public void GetStateMilk (int smilk)
		{
				switch (smilk) {
				case 0:
						menumilk.SetActive (false);
						a189.SetActive (true);
						milktoruyo.SetActive (true);
						break;
				case 1:
						menumilk.SetActive (true);
			//a237.SetActive (true);
						a189.SetActive (false);
						milktoruyo.SetActive (false);
			//a237.SetActive (false);
						break;
				case 2:
						milkireru.SetActive (false);
						menumilk.SetActive (true);
						a239.SetActive (true);
						flag2.milkflag = false;
			//gameObject.SetActive (false);
						clank.SetActive (true);
						f46.SetActive (false);
						a189.SetActive (false);
						milktoruyo.SetActive (false);
			//iconmilk.SetActive(true);
						pako.SetActive (false);
						butoby.SetActive (true);
						akaritukeru.SetActive (true);
						cat.SetActive (false);
						milkNEO.milkflagNEO = true;
						break;
				case 3:
						milkireru.SetActive (false);
						menumilk.SetActive (false);
						flag3.itemflag = 0;
						a239.SetActive (true);
						flag2.milkflag = false;
			//gameObject.SetActive (false);
						clank.SetActive (true);
						f46.SetActive (false);
						a189.SetActive (false);
						milktoruyo.SetActive (false);
			//iconmilk.SetActive(true);
						pako.SetActive (false);
						butoby.SetActive (true);
						akaritukeru.SetActive (true);
						cat.SetActive (false);
						milkNEO.milkflagNEO = true;
						break;
				}
		}

		public void GetStateShaguruma (int shagu)
		{
				switch (shagu) {
				case 0:
						a175.SetActive (false);
						menuShaguruma.SetActive (false);
						f136.SetActive (true);
						f214.SetActive (true);
						f216.SetActive (true);
						itaNEOkun.itatoruyoNEOflag = false;
						break;
				case 1:
						menuShaguruma.SetActive (true);
						f219.SetActive (false);
						f219kesuyo.SetActive (false);
						f136.SetActive (false);
						f214.SetActive (false);
						f216.SetActive (false);
						itaNEOkun.itatoruyoNEOflag = true;
						break;
				case 2:
						a175.SetActive (true);
						menushaguruma.SetActive (false);
						shagurumaokuyo.SetActive (false);
						icondel.itemflag = 0;
						f219.SetActive (false);
						f219kesuyo.SetActive (false);
						f136.SetActive (false);
						f214.SetActive (false);
						f216.SetActive (false);
						itaNEOkun.itatoruyoNEOflag = true;
						break;
				}
		}

		public void GetStateRupe (int srupe)
		{
				switch (srupe) {
				case 0:
						f225.SetActive (true);
						f228.SetActive (false);
						f224.SetActive (true);
						menurupe.SetActive (false);
						break;
				case 1:
						menurupe.SetActive (true);
						f225.SetActive (false);
						f228.SetActive (false);	
						utibuta.SetActive (false);
						f224.SetActive (false);
						break;
				}
		}

		public void GetStateBarl (int sbarl)
		{
				switch (sbarl) {
				case 0:
			//savebarl = 0;
						f218.SetActive (false);
						menubarl.SetActive (false);
						barlget.SetActive (true);
			//PlayerPrefs.SetInt ("savebarl",savebarl);
						break;
				case 1:
			//savebarl = 1;
						f218.SetActive (true);
						menubarl.SetActive (true);
						barlget.SetActive (false);
			//PlayerPrefs.SetInt ("savebarl",savebarl);
						break;
				}
		}

		public void GetStateEme (int seme)
		{
				switch (seme) {
				case 0:
						menuemerald.SetActive (false);
						f72152.SetActive (true);
						f142.SetActive (true);
						f141.SetActive (true);
						f143.SetActive (true);
						barlfragkanrikun.barlfragkun = 0;
						break;
				case 1:
						barlfragkanrikun.barlfragkun = 1;
						menuemerald.SetActive (true);
						f229.SetActive (false);
						utibuta.SetActive (true);
						f72152.SetActive (false);
						f142.SetActive (false);
						f141.SetActive (false);
						emetoruyokun.SetActive (false);
						hutatoru.SetActive (false);
						f143.SetActive (false);
						break;
				case 2:
						barlfragkanrikun.barlfragkun = 1;
						menuemerald.SetActive (true);
						f229.SetActive (false);
						utibuta.SetActive (true);
						f72152.SetActive (false);
						f142.SetActive (false);
						f141.SetActive (false);
						emetoruyokun.SetActive (false);
						hutatoru.SetActive (false);
						f143.SetActive (false);
						b135b.SetActive (true);
						emeoitakun.SetActive (false);
						menuitem.itemflag = 0;
						menuemerald.SetActive (false);
						b2tobn1.SetActive (true);
						emeoitakun.SetActive (true);
			//flag.clankkanri = 0;
						pakokun.SetActive (false);
						sitaikuyokun.SetActive (true);
						break;
				}
		}
	/*Itemを取得したとき等、セーブを行う度に呼び出す関数。
	  *使う時はまずitemnumの指定した配列に値を入れ、その後これを呼ぶ、いちいち全部のアイテムを記録している（汗）*/
		public void ItemSave ()
		{
				for (int i = 0; i <System.Enum.GetNames(typeof(Itemnum)).Length; i++) {
						//itemList.Add(0);
						PlayerPrefs.SetInt (System.Enum.GetName (typeof(Itemnum), i), itemList [i]);
				}
		}
	/*itemListのi番目にそれぞれの状態を入れてあるItemnumの変数をいれる。
引数はGetIntで保存してある。
StateChangedフラグを起こし、全ての関数を呼びアイテムの状態を再現する。
Loadボタンにつけて使う。*/
		public void ItemLoad ()
		{
				for (int i = 0; i <System.Enum.GetNames(typeof(Itemnum)).Length; i++) {
						itemList [i] = PlayerPrefs.GetInt (System.Enum.GetName (typeof(Itemnum), i));
				}
				StateChanged = true;


		}
}