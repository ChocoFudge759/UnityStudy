using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // 페이즈 1
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        for (int i = 0; i < 5; i++)
        {
            for (int j = 4; j > i; j--)
            {
                star += "　";
            }

            for (int j = 0; j <= i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        for (int i = 4;i >= 0;i--)
        {
            for (int j = 0;j <= i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4
        for (int i = 0; i < 5; i++)
        {
            for (int j = 4; j > i; j--)
            {
                star += "　";
            }

            for (int j = 0; j <= i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        for (int i = 4; i >= 0; i--)
        {

            for (int j = 5; j > i; j--)
            {
                star += "　";
            }

            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5
        for (int i = 0; i < 5; i++)
        {
            for (int j = 4; j > i; j--)
            {
                star += "　";
            }

            for (int j = 0; j < (2 * i) + 1; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        for (int i = 4; i >= 0; i--)
        {

            for (int j = 5; j > i; j--)
            {
                star += "　";
            }

            for (int j = 0; j < (2 * i) - 1; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

}
