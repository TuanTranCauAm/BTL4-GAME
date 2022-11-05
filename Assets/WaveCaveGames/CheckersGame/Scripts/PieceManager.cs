using UnityEngine;

namespace WaveCaveGames.CheckersGame{

	public enum PieceType{
		Normal, King
	}
	public enum PieceColor{
		White, Black
	}
	public class PieceManager : MonoBehaviour
	{
		public PieceType pieceType;
		public PieceColor color;

		void OnMouseDown(){
			ClickThis();
		}
		public void ClickThis(){
			GameManager gm = FindObjectOfType<GameManager>();
			gm.ClickPiece(this);
		}
	}
}
