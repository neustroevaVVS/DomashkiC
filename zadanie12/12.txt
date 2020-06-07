package com.example.zadanie12;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

import java.util.HashMap;
import java.util.Scanner;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void onClick (View view)
    {
        double a= 0;
        String b="";
        if (!"".equals(b))
        {
            try
            {
                a = Double.parseDouble(b);
            }
            catch (NumberFormatException e)
            {
                HashMap<String,Integer> map = new HashMap<>();
                map.put("I",1);
                map.put("V",5);
                map.put("X",10);
                map.put("L",50);
                map.put("C",100);
                map.put("D",500);
                map.put("M",100);
                a = Double.parseDouble(String.valueOf(map.get(b)));
            }
        }

    }
    public void onClick2(View view)
    {
        int[] a = new int[1000];
        boolean is_Polindrom = true;
        for(int i=0; i < a.length;i++) {
            if (a[i] != a[a.length - i - 1]) {
                is_Polindrom = false;
                break;
            }
        }
    }
}