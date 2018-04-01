using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelEnemyDefenitions : MonoBehaviour {

    public static Vector3[] pawnsPosLvl0 =
    {
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (2.2f, 0.0f, 14.8f)
    };

    public static Vector3[] bishopsPosLvl0 =
    {
        new Vector3 (0.1f, 0.0f, 14.8f),
    };

    public static Vector3[] rooksPosLvl0 =
    {
        new Vector3 (2.2f, 0.0f, 17.1f)
    };


    public static Vector3[] pawnsPosLvl1 =
    {
        new Vector3 (-2.0f, 0.0f, 10.2f),
        new Vector3 (-2.0f, 0.0f, 12.5f),
        new Vector3 (2.2f, 0.0f, 12.5f),
        new Vector3 (0.1f, 0.0f, 10.2f)
    };

    public static Vector3[] pawnsPosLvl2 =
{
        new Vector3 ( 0.1f, 0.0f, 12.5f ),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3(2.2f, 0.0f, 19.3f),
        new Vector3(-2.0f, 0.0f, 19.3f)
    };

    // no lvl 3 yet

    public static Vector3[] pawnsPosLvl4 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-4.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (-4.1f, 0.0f, 17.0f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (4.2f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (-2.0f, 0.0f, 32.7f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (0.1f, 0.0f, 35.0f),
        new Vector3 (2.2f, 0.0f, 35.0f),
        new Vector3 (2.2f, 0.0f, 39.6f),
        new Vector3 (0.1f, 0.0f, 41.7f),
        new Vector3 (-4.1f, 0.0f, 39.7f),
        new Vector3 (-4.1f, 0.0f, 41.8f),
        new Vector3 (2.2f, 0.0f, 46.3f),
    };


    public static Vector3[] pawnsPosLvl5 =
{
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (0.1f, 0.0f, 14.8f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (2.2f, 0.0f, 16.9f),
        new Vector3 (4.2f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (4.2f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 28.3f),
        new Vector3(2.2f, 0.0f, 26.0f),
    };

    public static Vector3[] pawnsPosLvl6 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (-4.1f, 0.0f, 28.2f),
        new Vector3 (-2.0f, 0.0f, 30.5f),
        new Vector3 (4.2f, 0.0f, 28.3f),
        new Vector3 (-2.0f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 28.3f)
    };



    public static Vector3[] pawnsPosLvl7 =
{
        new Vector3 (0.1f, 0.0f, 8.0f),
        new Vector3 (-2.0f, 0.0f, 10.2f),
        new Vector3 (2.2f, 0.0f, 12.4f),
        new Vector3 (-2.0f, 0.0f, 14.8f),
        new Vector3 (0.1f, 0.0f, 12.4f),
        new Vector3 (2.2f, 0.0f, 10.3f),
        new Vector3 (2.2f, 0.0f, 17.0f),
        new Vector3 (0.1f, 0.0f, 19.2f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 23.8f),
        new Vector3 (-2.0f, 0.0f, 23.8f),
        new Vector3 (-2.0f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 28.2f),
    };



    public static Vector3[] pawnsPosLvl8 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (-2.0f, 0.0f, 16.9f),
        new Vector3 (4.2f, 0.0f, 16.9f),
        new Vector3 (2.2f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (2.2f, 0.0f, 26.0f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (4.2f, 0.0f, 30.5f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (2.2f, 0.0f, 37.2f),
        new Vector3 (4.2f, 0.0f, 32.6f),
        new Vector3 (-2.0f, 0.0f, 39.6f),
        new Vector3 (-4.1f, 0.0f, 41.8f),
        new Vector3 (0.1f, 0.0f, 46.3f),
        new Vector3 (2.2f, 0.0f, 46.3f),
    };


    public static Vector3[] pawnsPosLvl9 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (0.1f, 0.0f, 14.8f),
        new Vector3 (2.2f, 0.0f, 14.8f),
        new Vector3 (-2.0f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (4.2f, 0.0f, 19.3f),
        new Vector3 (-4.1f, 0.0f, 19.4f),
        new Vector3 (0.1f, 0.0f, 23.7f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 26.0f),
        new Vector3 (4.2f, 0.0f, 26.0f),
        new Vector3 (4.2f, 0.0f, 28.3f),
        new Vector3 (-2.0f, 0.0f, 30.5f),
        new Vector3 (0.1f, 0.0f, 30.5f),
    };

    public static Vector3[] pawnsPosLvl10 =
{
        new Vector3(0.1f, 0.0f, 12.5f),
        new Vector3(0.1f, 0.0f, 14.8f),
        new Vector3(2.2f, 0.0f, 14.8f),
        new Vector3(-2.0f, 0.0f, 16.9f),
        new Vector3(0.1f, 0.0f, 19.3f),
        new Vector3(-2.0f, 0.0f, 21.5f),
        new Vector3(4.2f, 0.0f, 19.3f),
        new Vector3(-4.1f, 0.0f, 19.4f),
        new Vector3(0.1f, 0.0f, 23.7f),
        new Vector3(-2.0f, 0.0f, 23.7f),
        new Vector3(-4.1f, 0.0f, 23.7f),
        new Vector3(2.2f, 0.0f, 26.0f),
        new Vector3(4.2f, 0.0f, 26.0f),
        new Vector3(4.2f, 0.0f, 28.3f),
        new Vector3(-2.0f, 0.0f, 30.5f),
        new Vector3(0.1f, 0.0f, 30.5f),
    };


    public static Vector3[] pawnsPosLvl11 =
    {
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (-2.0f, 0.0f, 12.5f),
        new Vector3 (-4.1f, 0.0f, 17.0f),
        new Vector3 (-4.1f, 0.0f, 14.9f),
        new Vector3 (0.1f, 0.0f, 19.3f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (4.2f, 0.0f, 26.0f),
        new Vector3 (2.2f, 0.0f, 26.0f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (-2.0f, 0.0f, 28.3f),
        new Vector3 (4.2f, 0.0f, 30.5f),
        new Vector3 (2.2f, 0.0f, 30.5f),
        new Vector3 (4.2f, 0.0f, 32.6f),
        new Vector3 (-4.1f, 0.0f, 35.2f),
        new Vector3 (-4.1f, 0.0f, 32.8f),
        new Vector3 (0.1f, 0.0f, 35.0f),
        new Vector3 (4.2f, 0.0f, 14.8f),
        new Vector3(4.2f, 0.0f, 39.6f),
    };

    public static Vector3[] pawnsPosLvl12 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-4.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (-4.1f, 0.0f, 17.0f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (4.2f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (-2.0f, 0.0f, 32.7f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (0.1f, 0.0f, 35.0f),
        new Vector3 (2.2f, 0.0f, 35.0f),
        new Vector3 (2.2f, 0.0f, 39.6f),
        new Vector3 (0.1f, 0.0f, 41.7f),
        new Vector3 (-4.1f, 0.0f, 39.7f),
        new Vector3 (-4.1f, 0.0f, 41.8f),
        new Vector3 (2.2f, 0.0f, 46.3f),
    };


    public static Vector3[] pawnsPosLvl13  =
 {
        new Vector3 (2.2f, 0.0f, 14.8f),
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 19.3f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 26.0f),
        new Vector3 (4.2f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 28.3f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (0.1f, 0.0f, 30.5f),
        new Vector3 (-2.0f, 0.0f, 35.0f),
        new Vector3 (-2.0f, 0.0f, 37.2f),
        new Vector3 (-4.1f, 0.0f, 39.7f),
        new Vector3 (2.2f, 0.0f, 41.7f),
        new Vector3 (4.2f, 0.0f, 41.7f),
        new Vector3 (-4.1f, 0.0f, 44.0f),
        new Vector3 (-2.0f, 0.0f, 44.0f),
    };


    public static Vector3[] pawnsPosLvl14 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (-2.0f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (4.2f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (4.2f, 0.0f, 26.0f),
        new Vector3 (-2.0f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 28.3f),
        new Vector3 (0.1f, 0.0f, 30.5f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
    };


    public static Vector3[] pawnsPosLvl15 =
{
        new Vector3 (-4.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (0.1f, 0.0f, 26.0f),
        new Vector3 (2.2f, 0.0f, 28.3f),
    };

    public static Vector3[] pawnsPosLvl16 =
{
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (0.1f, 0.0f, 14.8f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (4.2f, 0.0f, 19.3f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (0.1f, 0.0f, 26.0f),
        new Vector3 (-2.0f, 0.0f, 26.0f), 
    };

    public static Vector3[] pawnsPosLvl17 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3 (2.2f, 0.0f, 16.9f),
        new Vector3 (4.2f, 0.0f, 14.8f),
        new Vector3 (-4.1f, 0.0f, 17.0f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (0.1f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 21.5f),
        new Vector3 (2.2f, 0.0f, 26.0f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (-2.0f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 30.5f),
        new Vector3 (4.2f, 0.0f, 30.5f),
        new Vector3 (-4.1f, 0.0f, 32.8f),
        new Vector3 (-2.0f, 0.0f, 35.0f),
        new Vector3 (2.2f, 0.0f, 35.0f),
        new Vector3 (4.2f, 0.0f, 35.0f),
        new Vector3 (0.1f, 0.0f, 39.6f),
    };

    //7
    public static Vector3[] pawnsPosLvl18 =
{
        new Vector3 (2.2f, 0.0f, 12.4f),
        new Vector3 (0.1f, 0.0f, 14.8f),
        new Vector3 (4.2f, 0.0f, 14.8f),
        new Vector3 (0.1f, 0.0f, 19.3f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3 (-4.1f, 0.0f, 17.0f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (-4.1f, 0.0f, 12.5f),
        new Vector3 (2.2f, 0.0f, 21.5f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (0.1f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 28.2f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (-2.0f, 0.0f, 30.5f),
        new Vector3 (2.2f, 0.0f, 30.5f),
        new Vector3 (4.2f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 35.0f),
        new Vector3 (-2.0f, 0.0f, 37.2f),
    };

    // 7
    public static Vector3[] pawnsPosLvl19 =
{
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (-2.0f, 0.0f, 12.5f),
        new Vector3 (0.1f, 0.0f, 14.8f),
        new Vector3 (-4.1f, 0.0f, 19.4f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 23.7f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (4.2f, 0.0f, 19.3f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 30.5f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (-2.0f, 0.0f, 28.3f),
        new Vector3 (4.2f, 0.0f, 14.8f),
        new Vector3 (2.2f, 0.0f, 12.4f),
        new Vector3 (4.2f, 0.0f, 28.3f),
        new Vector3 (0.1f, 0.0f, 35.0f),
        new Vector3 (-2.0f, 0.0f, 35.0f),
        new Vector3 (2.2f, 0.0f, 37.2f),
    };

    public static Vector3[] pawnsPosLvl20 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (2.2f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (-4.1f, 0.0f, 21.6f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 23.7f),
        new Vector3 (-2.0f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 26.0f),
        new Vector3 (4.2f, 0.0f, 26.0f),
        new Vector3 (-2.0f, 0.0f, 30.5f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (0.1f, 0.0f, 35.0f),
        new Vector3 (2.2f, 0.0f, 37.2f),
        new Vector3 (-4.1f, 0.0f, 39.7f),
    };

    // 1 opit
    public static Vector3[] pawnsPosLvl21 =
{
        new Vector3 (-2.0f, 0.0f, 16.9f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (2.2f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (4.2f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (4.2f, 0.0f, 30.5f),
        new Vector3 (2.2f, 0.0f, 32.6f),
        new Vector3 (-2.0f, 0.0f, 32.7f),
        new Vector3 (-2.0f, 0.0f, 37.2f),
        new Vector3 (2.2f, 0.0f, 37.2f),
    };

    // 10 
    public static Vector3[] pawnsPosLvl22 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (2.2f, 0.0f, 14.8f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (4.2f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 23.7f),
        new Vector3 (0.1f, 0.0f, 26.0f),
        new Vector3 (-2.0f, 0.0f, 28.3f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 30.5f),
    };

    public static Vector3[] pawnsPosLvl23 =
{
        new Vector3 (-2.0f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (0.1f, 0.0f, 16.9f),
        new Vector3 (-2.0f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 19.3f),
        new Vector3 (4.2f, 0.0f, 21.5f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (0.1f, 0.0f, 26.0f),
        new Vector3 (4.2f, 0.0f, 26.0f),
        new Vector3 (2.2f, 0.0f, 28.3f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (0.1f, 0.0f, 30.5f),
    };

    public static Vector3[] pawnsPosLvl24 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (2.2f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 19.3f),
        new Vector3 (-4.1f, 0.0f, 19.4f),
        new Vector3 (-2.0f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 28.3f),
        new Vector3 (-2.0f, 0.0f, 26.0f),
        new Vector3 (-2.0f, 0.0f, 35.0f),
        new Vector3 (0.1f, 0.0f, 30.5f),
        new Vector3 (2.2f, 0.0f, 23.7f),
        new Vector3 (4.2f, 0.0f, 16.9f),
        new Vector3 (-2.0f, 0.0f, 21.5f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (4.2f, 0.0f, 26.0f),
        new Vector3 (-2.0f, 0.0f, 32.7f),
        new Vector3 (-2.0f, 0.0f, 37.2f)
    };

    public static Vector3[] pawnsPosLvl25 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (-2.0f, 0.0f, 16.9f),
        new Vector3 (2.2f, 0.0f, 16.9f),
        new Vector3 (4.2f, 0.0f, 14.8f),
        new Vector3 (4.2f, 0.0f, 16.9f),
        new Vector3 (2.2f, 0.0f, 21.5f),
        new Vector3 (0.1f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 21.6f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (2.2f, 0.0f, 28.3f),
        new Vector3 (4.2f, 0.0f, 26.0f),
        new Vector3 (-2.0f, 0.0f, 28.3f),
        new Vector3 (-4.1f, 0.0f, 30.7f),
        new Vector3 (2.2f, 0.0f, 30.5f),
        new Vector3 (-4.1f, 0.0f, 35.2f),
        new Vector3 (-2.0f, 0.0f, 37.2f),
        new Vector3 (0.1f, 0.0f, 37.2f),
        new Vector3 (2.2f, 0.0f, 39.6f),
        new Vector3 (-2.0f, 0.0f, 41.7f),
    };

    // 10+
    public static Vector3[] pawnsPosLvl26 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-4.1f, 0.0f, 17.0f),
        new Vector3 (4.2f, 0.0f, 19.3f),
        new Vector3 (-2.0f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (2.2f, 0.0f, 16.9f),
        new Vector3 (-2.0f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 14.8f),
        new Vector3 (-4.1f, 0.0f, 21.6f),
        new Vector3 (4.2f, 0.0f, 23.7f),
        new Vector3 (0.1f, 0.0f, 26.0f),
        new Vector3 (0.1f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 30.5f),
        new Vector3 (4.2f, 0.0f, 28.3f),
        new Vector3 (2.2f, 0.0f, 21.5f),
        new Vector3 (-4.1f, 0.0f, 28.2f),
        new Vector3 (0.1f, 0.0f, 32.7f),
        new Vector3 (-2.0f, 0.0f, 37.2f),
        new Vector3 (-2.0f, 0.0f, 39.6f),
        new Vector3 (0.1f, 0.0f, 39.6f),
    };

    public static Vector3[] pawnsPosLvl27 =
{
        new Vector3 (0.1f, 0.0f, 12.5f),
        new Vector3 (-2.0f, 0.0f, 14.7f),
        new Vector3 (4.2f, 0.0f, 16.9f),
        new Vector3 (2.2f, 0.0f, 14.8f),
        new Vector3 (2.2f, 0.0f, 16.9f),
        new Vector3 (0.1f, 0.0f, 21.5f),
        new Vector3 (-2.0f, 0.0f, 16.9f),
        new Vector3 (-4.1f, 0.0f, 14.9f),
        new Vector3 (4.2f, 0.0f, 19.3f),
        new Vector3 (2.2f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 23.7f),
        new Vector3 (-4.1f, 0.0f, 21.6f),
        new Vector3 (0.1f, 0.0f, 19.3f),
        new Vector3 (4.2f, 0.0f, 28.3f),
        new Vector3 (-4.1f, 0.0f, 28.2f),
        new Vector3 (-4.1f, 0.0f, 26.1f),
        new Vector3 (2.2f, 0.0f, 26.0f),
        new Vector3 (-4.1f, 0.0f, 32.8f),
        new Vector3 (0.1f, 0.0f, 28.3f),
    };

    public static Vector3[] bishopsPosLvlEmpty = { };
    public static Vector3[] rooksPosLvlEmpty = { };

}
