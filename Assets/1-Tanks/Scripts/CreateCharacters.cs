using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tanks.Custom
{

    public class CreateCharacters : MonoBehaviour
    {
        public int[] partIndexPlayer1 = new int[3];
        public int[] partIndexPlayer2 = new int[3];
        public int[] partIndexMax = new int[3];

        public List<Sprite> body;
        public List<Sprite> turret;
        public List<Sprite> tracks;

        private void Start()
        {
            for (int i = 0; i < partIndexMax[0]; i++)
            {
                GameObject temp = Resources.Load("Tank_Parts/Body_" + partIndexPlayer1[0]) as GameObject;
                body.Add(temp.GetComponent<Image>().sprite);
            }
            for (int i = 0; i < partIndexMax[1]; i++)
            {
                GameObject temp = Resources.Load("Tank_Parts/Turret_" + partIndexPlayer1[0]) as GameObject;
                turret.Add(temp.GetComponent<Image>().sprite);
            }
            for (int i = 0; i < partIndexMax[2]; i++)
            {
                GameObject temp = Resources.Load("Tank_Parts/Tracks_" + partIndexPlayer1[0]) as GameObject;
                tracks.Add(temp.GetComponent<Image>().sprite);
            }
        }
        #region Change
        public void ChangeBodyPlayer1(int direction)
        {
            partIndexPlayer1[0] += direction;
            if(partIndexPlayer1[0] < 0)
            {
                partIndexPlayer1[0] = partIndexMax[0] - 1;
            }
            if (partIndexPlayer1[0] > partIndexMax[0] - 1)
            {
                partIndexPlayer1[0] = 0;
            }
        }
        public void ChangeTurretPlayer1(int direction)
        {
            partIndexPlayer1[1] += direction;
            if (partIndexPlayer1[1] < 0)
            {
                partIndexPlayer1[1] = partIndexMax[1] - 1;
            }
            if (partIndexPlayer1[1] > partIndexMax[1] - 1)
            {
                partIndexPlayer1[1] = 0;
            }
        }
        public void ChangeTracksPlayer1(int direction)
        {
            partIndexPlayer1[2] += direction;
            if (partIndexPlayer1[2] < 0)
            {
                partIndexPlayer1[2] = partIndexMax[2] - 1;
            }
            if (partIndexPlayer1[2] > partIndexMax[2] - 1)
            {
                partIndexPlayer1[2] = 0;
            }
        }
        #endregion
    }
}
