using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Assets.Custom.Scripts.FootballLogic;

public class LeftBackMovement : PlayerMovement
{

    protected override void CalculateBestPosition(Vector3 homePosition, Vector3 ballPosition, FootballField field)
    {
        if (ballPosition.z <= field.Height / 3)
            return;

        if (0f <= ballPosition.x && ballPosition.x <= field.Width / 3)
        {
            //region 1
            if (field.Height / 3 <= ballPosition.z && ballPosition.z <= (field.Height * 2) / 3)
            {
                newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                            HomePosition.z + 4);
            }
            //region 2
            else
            {
                newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                            HomePosition.z + 9);
            }
        }
        else if (field.Width / 3 <= ballPosition.x && ballPosition.x <= (field.Width * 2) / 3)
        {
            //region 3
            if (field.Height / 3 <= ballPosition.z && ballPosition.z <= (field.Height * 2) / 3)
            {
                newPosition = new Vector3(HomePosition.x + 3, HomePosition.y,
                                            HomePosition.z);
            }
            //region 4
            else
            {
                newPosition = new Vector3(HomePosition.x, HomePosition.y,
                                            HomePosition.z + 10);
            }
        }
        else
        {
            //region 5
            if (field.Height / 3 <= ballPosition.z && ballPosition.z <= (field.Height * 2) / 3)
            {
                newPosition = new Vector3(HomePosition.x + 10, HomePosition.y,
                                            HomePosition.z - 15);
            }
            //region 6
            else
            {
                newPosition = new Vector3(HomePosition.x + 10, HomePosition.y,
                                               HomePosition.z - 10);
            }
        }
    }
}
