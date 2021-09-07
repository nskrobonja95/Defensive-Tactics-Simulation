using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts.Movements.Formation_433
{
    class RightAttackingPlayer_433 : PlayerMovement
    {
        protected override void CalculateBestPosition(Vector3 homePosition, Vector3 ballPosition, FootballField field)
        {
            if (ballPosition.z <= field.Height / 3)
                return;

            if (0f <= ballPosition.x && ballPosition.x <= field.Width / 3)
            {
                //region 1
                if (field.Height / 2 <= ballPosition.z && ballPosition.z <= (field.Height * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z - 3);
                }
                //region 2
                else
                {
                    newPosition = new Vector3(HomePosition.x - 7, HomePosition.y,
                                                HomePosition.z - 4);
                }
            }
            else if (field.Width / 3 <= ballPosition.x && ballPosition.x <= (field.Width * 2) / 3)
            {
                //region 3
                if (field.Height / 2 <= ballPosition.z && ballPosition.z <= (field.Height * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z);
                }
                //region 4
                else
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z);
                }
            }
            else
            {
                //region 5
                if (field.Height / 2 <= ballPosition.z && ballPosition.z <= (field.Height * 3) / 4)
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                HomePosition.z);
                }
                //region 6
                else
                {
                    newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                                   HomePosition.z);
                }
            }
        }
    }
}
