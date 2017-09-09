using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {

	public static BlockManager mBlockManager;

	[SerializeField] private enum BlockFlow { Xaxis=0,Yaxis=1,Zaxis=3};
	[SerializeField] private BlockFlow mBlockFlow;
	private Vector3 BlockFlowPosition;

	[SerializeField] private GameObject[] Blocks;
	[SerializeField] private GameObject CurrentBlock;
	[SerializeField] private float BlockOffset;
	private GameObject tempBlock;

	void Awake(){
		mBlockManager = this;
	}
	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;

		CurrentBlock= Blocks[0];
		SetBlockOffsetAxis ();
	}

	public void Instantiate(){
		int rand = Random.Range (0,3);

		if (Blocks [rand] == CurrentBlock) {
			Instantiate ();
			return;
		}
		Blocks [rand].transform.position = CurrentBlock.transform.position + BlockFlowPosition;
		CurrentBlock = Blocks [rand];
	}

	private void SetBlockOffsetAxis(){
		if (mBlockFlow == BlockFlow.Xaxis)
			BlockFlowPosition = new Vector3 (BlockOffset, 0, 0);
		else if (mBlockFlow == BlockFlow.Yaxis)
			BlockFlowPosition = new Vector3 (0, BlockOffset, 0);
		else if (mBlockFlow == BlockFlow.Zaxis)
			BlockFlowPosition = new Vector3 (0, 0, BlockOffset);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
