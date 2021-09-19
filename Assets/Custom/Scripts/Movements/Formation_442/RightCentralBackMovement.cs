using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Movements
{
    class RightCentralBackMovement : PlayerMovement
    {
        protected override void CalculateBestPosition(Vector3 homePosition, Vector3 ballPosition, int fieldWidth, int fieldLength)
        {
            if (ballPosition.z <= fieldLength / 3)
                return;

            if (0f <= ballPosition.x && ballPosition.x <= fieldWidth / 3)
            {
                //region 1
                if (fieldLength / 2 <= ballPosition.z && ballPosition.z <= (fieldLength * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x - 9, HomePosition.y,
                                                HomePosition.z);
                }
                //region 2
                else
                {
                    newPosition = new Vector3(HomePosition.x - 9, HomePosition.y,
                                                HomePosition.z + 5);
                }
            }
            else if (fieldWidth / 3 <= ballPosition.x && ballPosition.x <= (fieldWidth * 2) / 3)
            {
                //region 3
                if (fieldLength / 2 <= ballPosition.z && ballPosition.z <= (fieldLength * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z);
                }
                //region 4
                else
                {
                    newPosition = newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                            HomePosition.z + 10);
                }
            }
            else
            {
                //region 5
                if (fieldLength / 2 <= ballPosition.z && ballPosition.z <= (fieldLength * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x + 5, HomePosition.y,
                                                HomePosition.z + 7);
                }
                //region 6
                else
                {
                    newPosition = new Vector3(HomePosition.x + 5, HomePosition.y,
                                                   HomePosition.z + 12);
                }
            }
        }
    }
}
