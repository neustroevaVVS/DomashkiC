package com.example.zadanie10;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

import java.util.Arrays;
import java.util.OptionalInt;
import java.util.Random;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void onClick(View view)
    {
        int[][] mass =new int[10][10];
        for (int i = 0; i < mass.length; i++)
        {
            for (int j = 0; j < mass[i].length; j++)
            {
                mass [i][j] = j + 1;
            }
        }
        for (int[] an : mass)
        {
            for (int anAn : an) {
                System.out.print(anAn + " ");
            }
            System.out.println();
        }
        int max = mass[0][0];
        for (int i = 1; i < mass.length; i++)
        {
            max = Math.max(max, mass[i].length);
        }
        int x = mass.length;
        int a1 = 0;
        int a2 = 0;
        int a3 = 0;
        int a4 = 0;
        int a5 = 0;
        int a6 = 0;
        int a7 = 0;
        int a8 = 0;
        int a9 = 0;
        int a10 = 0;
        for (int i=0;i<x;i++)
        {
            a1+=i+mass[i][0];
        }
        System.out.println(a1);
        for (int i=0;i<x;i++)
        {
            a2+=i+mass[i][1];
        }
        System.out.println(a2);
        for (int i=0;i<x;i++)
        {
            a3+=i+mass[i][2];
        }
        System.out.println(a3);
        for (int i=0;i<x;i++)
        {
            a4+=i+mass[i][3];
        }
        System.out.println(a4);
        for (int i=0;i<x;i++)
        {
            a5+=i+mass[i][4];
        }
        System.out.println(a5);
        for (int i=0;i<x;i++)
        {
            a6+=i+mass[i][5];
        }
        System.out.println(a6);
        for (int i=0;i<x;i++)
        {
            a7+=i+mass[i][0];
        }
        System.out.println(a7);
        for (int i=0;i<x;i++)
        {
            a8+=i+mass[i][0];
        }
        System.out.println(a8);
        for (int i=0;i<x;i++)
        {
            a9+=i+mass[i][0];
        }
        System.out.println(a9);
        for (int i=0;i<x;i++)
        {
            a10+=i+mass[i][0];
        }
        System.out.println(a10);
    }
}